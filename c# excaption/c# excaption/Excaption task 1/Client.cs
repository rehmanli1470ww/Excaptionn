using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__excaption
{
    public class Client
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public BankCard bankAccount { get; set; }

        public Client(int id, string name, string surname, int age, int salary, BankCard bankAccount)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salary = salary;
            this.bankAccount = bankAccount;
        }
        public void showCardBalance(BankCard b)
        {
            Console.WriteLine(b.Balans);
        }

    }
}
