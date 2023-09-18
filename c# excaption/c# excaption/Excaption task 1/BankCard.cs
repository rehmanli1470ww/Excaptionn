using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__excaption
{
    public class BankCard
    {
        public string Bankname { get; set; }

        public string Fullname { get; set; }
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }

        public string ExpireDate { get; set; }

        public int Balans { get; set; }

        public BankCard(string bankname, string fullname, string pan, string pin, string cvc, string expireDate, int balans)
        {
            Bankname = bankname;
            Fullname = fullname;
            Pan = pan;
            if (pin.Length !=4)
            {
                throw new pinExcaption();
            }
            else
            {
                Pin = pin;
            }   
            Cvc = cvc;
            ExpireDate = expireDate;
            Balans = balans;

        }


    }
}
