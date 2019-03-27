using System;
using System.Collections.Generic;
using System.Text;
namespace BankAccount.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Samina";
            p1.Age = 17;


            Person p2 = new Person();
            p2.Name = "Mariam";
            p2.Age = 17;


            Person p3 = new Person();
            p3.Name = "Selest";
            p3.Age = 17;


            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.ID = 123;
            bankAccount1.Balance = 200.01;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.ID = 124;
            bankAccount2.Balance = 300.01;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.ID = 125;
            bankAccount3.Balance = 400.01;

            p1.Accounts.Add(bankAccount1);
            p2.Accounts.Add(bankAccount2);
            p3.Accounts.Add(bankAccount3);

            BankAccount bankAccount4 = new BankAccount();
            bankAccount4.ID = 126;
            bankAccount4.Balance = 100;

            BankAccount bankAccount5 = new BankAccount();
            bankAccount5.ID = 127;
            bankAccount5.Balance = 50;

            BankAccount bankAccount6 = new BankAccount();
            bankAccount6.ID = 128;
            bankAccount6.Balance = 20;


            p3.Accounts.Add(bankAccount4);
            p3.Accounts.Add(bankAccount5);
            p3.Accounts.Add(bankAccount6);

            Console.WriteLine($"Name: {p1.Name}, {p1.Age}-years old. Have{p1.GetBalance()}");
            Console.WriteLine($"Name: {p2.Name}, {p2.Age}-years old. Have{p2.GetBalance()}");
            Console.WriteLine($"Name: {p3.Name}, {p3.Age}-years old. Have{p3.GetBalance()}");

        }
    }
}




BankAccount.cs



using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.cs
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
           set { balance = value; }
        }


    }
}



 Person.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount.cs
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public double GetBalance()
        {
            return accounts.Sum(element => element.Balance);
        }


    }
}














using System;
using System.Collections.Generic;
using System.Text;
namespace BankAccount.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Samina";
            p1.Age = 17;


            Person p2 = new Person();
            p2.Name = "Mariam";
            p2.Age = 17;


            Person p3 = new Person();
            p3.Name = "Selest";
            p3.Age = 17;


            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.ID = 123;
            bankAccount1.Balance = 200.01;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.ID = 124;
            bankAccount2.Balance = 300.01;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.ID = 125;
            bankAccount3.Balance = 400.01;

            p1.Accounts.Add(bankAccount1);
            p2.Accounts.Add(bankAccount2);
            p3.Accounts.Add(bankAccount3);

            BankAccount bankAccount4 = new BankAccount();
            bankAccount4.ID = 126;
            bankAccount4.Balance = 100;

            BankAccount bankAccount5 = new BankAccount();
            bankAccount5.ID = 127;
            bankAccount5.Balance = 50;

            BankAccount bankAccount6 = new BankAccount();
            bankAccount6.ID = 128;
            bankAccount6.Balance = 20;

            p1.Accounts.Add(bankAccount1);
            p2.Accounts.Add(bankAccount2);
            p2.Accounts.Add(bankAccount3);
            p3.Accounts.Add(bankAccount4);
            p3.Accounts.Add(bankAccount5);
            p3.Accounts.Add(bankAccount6);

            /* Console.WriteLine($"Name: {p1.Name}, {p1.Age}-years old. Have{p1.GetBalance()}");
             Console.WriteLine($"Name: {p2.Name}, {p2.Age}-years old. Have{p2.GetBalance()}");
             Console.WriteLine($"Name: {p3.Name}, {p3.Age}-years old. Have{p3.GetBalance()}");*/

            List<int> accs = new List<int>();
            List<double> money = new List<double>();
            foreach (var item in p3.Accounts)
            {
                accs.Add(item.ID);
                money.Add(item.Balance);
            }
            Console.WriteLine( $"Name: { p3.Name}, { p3.Age} years old. {string.Join(",", accs)}." + $"money {string.Join(",", money)}");
            
        }
    }
}






















