using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Races
{
   public class Person
    {
        public string Name;
        public Gamble MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Person(string name, int Cash, Label MyLabel, RadioButton guyButton)
        {
            Name = name;
            this.Cash = Cash;
            this.MyLabel = MyLabel;
            MyRadioButton = guyButton;
            MyBet = null;

        }
        public void UpdateLabels()
        {
            if(MyLabel != null && MyRadioButton!=null) { 
            MyRadioButton.Text = Name + " has $" + Cash + " bucks!";
            if (MyBet == null)
            {
                MyLabel.Text = Name;
            }
            else
            {
                MyLabel.Text = Name + " has bet $" + MyBet.Amount + " bucks on horse number " + (MyBet.horse+1);
            }
            }

        }

        public void UnSetBet()
        {
            MyBet = null;
        }

        public bool SetBet(int Amount, int horse)
        {
            MyBet = new Gamble(Amount, horse, this);
            UpdateLabels();
            if (MyBet.Amount == 0)
            {
                MyRadioButton.Enabled = false;
            }
            return false;
        }

        public void PickCash(int Winner)
        {
            Cash += MyBet.GiveCash(Winner);
        }


    }
}
