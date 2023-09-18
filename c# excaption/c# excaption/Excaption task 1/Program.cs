using static System.Collections.Specialized.BitVector32;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Security.Cryptography;
using System;
using c__excaption.Excaption_task_1;

namespace c__excaption
{
    public class Program
    {
        static void Main()
        {

            ////task 1
            //try
            //{
            //    BankCard bankCard = new BankCard("Rubail", "Rubail bank", "1233 1234 1234 1234", "1470", "844", "08/25", 1200000000);
            //    Client clientt = new Client(12, "Mehemmed", "Hemzeyev", 2008, 1000000, bankCard);
            //    clientt.showCardBalance(bankCard);
            //}
            //catch (pinExcaption ex)
            //{
            //
            //    Console.WriteLine(ex.Message);
            //}

            ////task 2
            
            List<string> userrr = new();
            Card card1 = new Card("1233 1234 1234 1234", "1470", "844", "08/25", 1200, userrr);
            Card card2 = new Card("1235 1264 1734 1234", "1570", "845", "09/27", 1204, userrr);
            Card card3 = new Card("1233 1334 1234 1234", "1575", "848", "05/26", 120400, userrr);
            Card card4 = new Card("1233 1734 1238 1239", "1888", "843", "03/25", 1220000, userrr);
            Card card5 = new Card("1234 1234 1234 1234", "1555", "877", "02/23", 120322, userrr);
            User user1 = new User("Haci", "Hacili", card1);
            User user2 = new User("Qaqas", "Ibrahimli", card2);
            User user3 = new User("Qacay", "Haciyev", card3);
            User user4 = new User("Eli", "Elili", card4);
            User user5 = new User("Gunduz", "Gunduzlu", card5);
            List<User> users = new List<User> { user1, user2, user3, user4, user5 };
            bool start = true;
            while (start)
            {
                Console.Clear();
                string? pinn;
                Console.WriteLine("Pini daxil edin ");
                pinn = Console.ReadLine();

                foreach (var item in users)
                {

                    
                    Console.Clear();
                    if (pinn == item.CreditCard.Pin)
                    {
                        string? secim;
                        Console.WriteLine(item.Name + "   " + item.Surname + "\nXos gelmisiniz \n1 Balans \n2 Negd pul\n" +
                            "3 Sonuncu edilen emeliyyatlar \n4 Kartdan karta kocurme\n5 Exit \nSecim edin : ");
                        secim = Console.ReadLine();
                        if (secim == "1")
                        {

                            Console.Clear();
                            item.CreditCard.showBalance();
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else if (secim == "2")
                        {

                            Console.Clear();
                            item.CreditCard.excance();
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else if (secim == "3")
                        {

                            Console.Clear();
                            item.CreditCard.endl();
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else if (secim == "4")
                        {
                            Console.Clear();
                            item.CreditCard.kartToKart(users);
                            Thread.Sleep(3000);
                            Console.Clear();

                        }
                        else if (secim == "5")
                        {
                            Console.WriteLine("Bizi secdiyiniz ucun tesekkurler");
                            start = false;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine("Ele secim yoxdur");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }

                    }
                    else
                    {
                        try
                        {
                            throw new pinExcaption();
                        }
                   
                        catch (pinExcaption ex)
                        {
                            Console.Clear();
                            Console.WriteLine(ex.Message);
                           
                        }
                    }



                }
               
            }
        }
    }
}