using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__excaption.Excaption_task_1
{
    public class Card
    {
       
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }

        public string ExpireDate { get; set; }

        public decimal Balans { get; set; }

        public List<string> Userrr { get; set; }
        public Card( string pan, string pin, string cvc, string expireDate, decimal balans, List<string> userrr)
        {

            Pan = pan;
            if (pin.Length != 4)
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
            Userrr = userrr;
        }
        public void showBalance()
        {

            Console.WriteLine("Balans : "+Balans);
        }
        public void excance()
        {
            DateTime dateTime = DateTime.Now;
            string? balanceee;
            string? sec;
            Console.WriteLine("Balance : "+ Balans+ "\nBalansdan cekeceyin pulu daxil edin \n1 10 azn\n2 20 azn\n3 50 azn\n4 100 azn\n5 Diger mebleg");
            sec = Console.ReadLine();

            
            try
            {
                if (sec == "1")
                {
                    if ((Balans-10)>=0)
                    {
                        
                        Balans -= 10;
                        Userrr.Add(dateTime + "  10 azn");
                        Console.WriteLine("Balans : " + Balans);
                        foreach (var item in Userrr)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        throw new balansExcaption();
                    }
                   
                }
                else if (sec == "2")
                {

                    if ((Balans - 20) >= 0)
                    {
                        Balans -= 20;
                        Userrr.Add(dateTime +"  20 azn");
                        Console.WriteLine("Balans : " + Balans);
                    }
                    else
                    {
                        throw new balansExcaption();
                    }
                }
                else if (sec == "3")
                {
                    if ((Balans - 50) >= 0)
                    {
                        Balans -= 50;
                        Userrr.Add(dateTime + "  50 azn");
                        Console.WriteLine("Balans : " + Balans);
                    }
                    else
                    {
                        throw new balansExcaption();
                    }
                }
                else if (sec == "4")
                {
                    if ((Balans - 100) >= 0)
                    {
                        Balans -= 100;
                        Userrr.Add(dateTime + "  100 azn");
                        Console.WriteLine("Balans : " + Balans);
                    }
                    else
                    {
                        throw new balansExcaption();
                    }
                }
                else if (sec=="5")
                {
                    Console.WriteLine("Balance : "+ Balans+ "\nBalansdan cekeceyin pulu daxil edin");
                    balanceee = Console.ReadLine();
                    if (Balans >= int.Parse(balanceee))
                    {
                        Balans -= int.Parse(balanceee);
                        Userrr.Add(dateTime +"  "+ balanceee+" azn");
                        Console.WriteLine("Balans : " + Balans);
                    }
                    else
                    {
                        throw new balansExcaption();
                    }
                }
                
            }
            catch (balansExcaption ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
        }

        public void endl()
        {
            Console.WriteLine("Sonuncu edilen emeliyyatlar");
            foreach (var item in Userrr)
            {
                Console.WriteLine(item);
            }
        }
        public void kartToKart(List<User>users)
        {
            string? kart;
            Console.WriteLine("Kocurme etmek isdediyin kartin nomresini yaz");
            kart = Console.ReadLine();
            bool start = true;
            while (start)
            {
                foreach (var item1 in users)
                {

                    if (item1.CreditCard.Pan == kart)
                    {
                        string? bal;
                        Console.WriteLine(item1.Name + "  " + item1.Surname + "  Balansina gondereceyin meblegi qeyd edin ");
                        bal = Console.ReadLine();
                        try
                        {
                            if (Balans >= int.Parse(bal))
                            {
                                Balans -= int.Parse(bal);
                                item1.CreditCard.Balans += int.Parse(bal);
                                Console.WriteLine("Balans : " + Balans);
                                start=false;

                            }
                            else
                            {
                                throw new balansExcaption();
                                
                            }
                            
                        }
                        catch (balansExcaption ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        start = false;

                    }
                }
            }
        }
    }
}
