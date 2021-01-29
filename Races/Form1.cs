using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Races
{
    public partial class Form1 : Form
    {
        Person[] persons = new Person[3];
        RaceHorses[] horses = new RaceHorses[4];
        Boolean winner = false;
        int Win = -1;
        public Form1()
        {
            InitializeComponent();
         
        }
        String[] names = {"Pari","Sahil","Sukhman" };
        private void Form1_OnLoad(object sender, EventArgs e)
        {
            persons[0] = new Person(names[0], 50, PariLabel, PariRadio);
            persons[1] = new Person(names[1], 75, SahilLabel, SahilRadio);
            persons[2] = new Person(names[2], 45, SukhmanLabel, SukhmanRadio);

            persons[0].UpdateLabels();
            persons[1].UpdateLabels();
            persons[2].UpdateLabels();
            Random random = new Random();
            horses[0] = new RaceHorses(horse1, random);
            horses[1] = new RaceHorses(horse2, random);
            horses[2] = new RaceHorses(horse3, random);
            horses[3] = new RaceHorses(horse4, random);
            this.horse1.Parent = this;
            this.horse1.BackColor = Color.Transparent;
            
        }
        private void RadioClicked(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 3; i++)
            {
                if (persons[i].MyRadioButton.Checked)
                {
                    betNumeric.Value = 5;
                    betNumeric.Maximum = persons[i].Cash;
                    horseNumberNumeric.Value = 1;
                    NameOfBettorLabel.Text = persons[i].Name;
                }
            }

            MinimumBetLabel.Text = "Bet Setting: " + betNumeric.Value + " bucks.";
            
        }
        private void BetsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (persons[i].MyRadioButton.Checked)
                {
                    persons[i].MyLabel.Text = persons[i].Name + " has bet $" + betNumeric.Value;
                    int para1, para2;
                    para1 = Convert.ToInt16(betNumeric.Value);
                    para2 = Convert.ToInt16(horseNumberNumeric.Value)-1;
                    persons[i].SetBet(para1, para2);
                }
            }

        }
        private bool IsBetPlaced(){
            for (int i = 0; i < 3; i++)
            {
                if(persons[i].MyBet == null){
                    return false;
                }
            }
            return true;
        }

        private void Race_Click(object sender, EventArgs e)
        {
            if (IsBetPlaced())
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("All Betters must bet on any of four horses!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4 && winner == false; i++)
            {
                winner = horses[i].Run();
                if (winner)
                {

                    
                    timer1.Stop();
                    timer1.Enabled = false;
                   
                    Win = i;
                    int dnumber = Win + 1;
                    for (int j = 0; j < 3; j++)
                    {
                        persons[j].PickCash(Win);
                        persons[j].UnSetBet();
                        persons[j].UpdateLabels();

                    }


                    for (int ii = 0; ii < persons.Length; ii++)
                    {

                        if (persons[ii].Cash < 1)
                        {
                            persons[ii].MyRadioButton.Enabled = false;
                            persons[ii].MyLabel.Text = "Busted!";

                        }
                    }
                    MessageBox.Show("Horse No " + dnumber + " has won the race!!","Winner",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                }
            }

            

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
           
        }



    }
}
