using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person ada = new Person("Ada");
            //Person mike = new Person("Mike");
            //Person alexia = new Person("Alexia");
            //Person mikey = new Person("Mikey");
            //Person ally = new Person("Ally");

            //mikey.height = 183;
            //mikey.weight = 75;

            //ally.height = 170;
            //ally.weight = 52;

            //Console.WriteLine(mikey.name + ", body mass index is " + mikey.BodyMassIndex());
            //Console.WriteLine(ally.name +  ", body mass index is " + ally.BodyMassIndex());

            //ada.PrintPerson();
            //mike.PrintPerson();
            //alexia.PrintPerson();

            //int i = 0;
            //while (i < 27)
            //{
            //    alexia.GrowOlder();
            //    i = i + 1;
            //}

            //mike.GrowOlder();

            //Console.WriteLine(mike);
            //Console.WriteLine(alexia);

            //if (mike.IsOfLegalAge())
            //{
            //    Console.WriteLine("of legal age: ");
            //    mike.PrintPerson();
            //}
            //else
            //{
            //    Console.WriteLine("underage: ");
            //    mike.PrintPerson();
            //}

            //if (alexia.IsOfLegalAge())
            //{
            //    Console.WriteLine("of legal age: ");
            //    alexia.PrintPerson();
            //}
            //else
            //{
            //    Console.WriteLine("underage: ");
            //    alexia.PrintPerson();
            //}

            //ada.GrowOlder();
            //mike.GrowOlder();
            //alexia.GrowOlder();
            //alexia.GrowOlder();

            //ada.PrintPerson();
            //mike.PrintPerson();
            //alexia.PrintPerson();
            //int combined = alexia.ReturnAge() + mike.ReturnAge();

            //Console.WriteLine("Alexia and Mike's combined age " + combined + " years");


            //Teacher teacher = new Teacher();
            //int grading = teacher.Grade();
            //Console.WriteLine("The grade received is " + grading);

            //Teacher first = new Teacher();
            //Teacher second = new Teacher();
            //Teacher third= new Teacher();

            //double average = (first.Grade() + second.Grade() + third.Grade() ) / 3.0;
            //Console.WriteLine("Grading average" + average);

            Account mikesAccount = new Account("Mike's account", 100.00);
            Account mikeSwissAccount = new Account("Mike's account in Swiss ", 1000000.00);

            mikesAccount.Deposit(20);
            Console.WriteLine("The balance of mike's account is $" + mikesAccount.accountBalance);

            Account heikkisAccount = new Account("Heikki's account", 1000);
            Account personalAccount = new Account("Personal account", 0);

            Console.WriteLine("Initial Values");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);

            heikkisAccount.Withdrawal(100);
            personalAccount.Deposit(100);

            Console.WriteLine("end values");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);
        }
    }
}
