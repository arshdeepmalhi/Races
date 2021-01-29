using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Races
{
    public class Gamble
    {
        public int Amount;
        public int horse;
        public Person Bettor;

        public Gamble(int Amount, int horse, Person which)
        {
            this.Amount = Amount;
            this.horse = horse;
            Bettor = which;
        }

        public string GetDescription()
        {
            string txt = "";
            if(Amount!=0 && horse!=0 && Bettor.Name !=null)
                txt = Bettor.Name + " has placed bet of amount " + Amount + " on horse " + horse;
            return txt;
        }

        public int GiveCash(int Winner)
        {
            if (horse == Winner)
            {
                return 2 * Amount;
            }
            else
            {
                return -Amount;
            }
        }



    }
}
