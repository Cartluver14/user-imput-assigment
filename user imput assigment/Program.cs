using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_imput_assigment
{
    internal class Program
    {
        //part 1 
        static void Main(string[] args)
        {
            //Part1();
            //North
            //Part2();
            //Part3();
            //Part4();
            Part5();
        }

        public static void Part1()
        {
            string name;
            int age;
            double wage;

            Console.WriteLine(" Hi what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + " How old are you");
            //Console.ReadLine();
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine(" Your still pretty young, Wow");
            Console.WriteLine(" So your " + age + " Thats good how, much do you make," + name + "?");
            Double.TryParse(Console.ReadLine(), out wage);
            Console.WriteLine(wage + " Jeez I hope thats per hour not per year");
        }


        public static void Part2()
        {
            string firstName;
            string lastName;
            string loginname;
            int grade;
            int studentid;
            double average;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What grade are you in?");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.WriteLine("What is your login name?");
            loginname = Console.ReadLine();
            Console.WriteLine("What is your student ID? ");
            int.TryParse(Console.ReadLine(), out studentid);
            Console.WriteLine("What is your average?");
            double.TryParse(Console.ReadLine(), out average);


        }

        public static void Part3()
        {
            string name;
            int age;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hey " + name + " how old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Did you know that in 5 years you will be " + (age + 5));
            Console.WriteLine(" and did you know that 5 years ago you were " + (age - 5));




        }
        public static void Part4()
        {
            double num1;
            double num2;
            double num3;

            Console.WriteLine(" please enter your numbers");
            double.TryParse(Console.ReadLine(), out num1);
            double.TryParse(Console.ReadLine(), out num2);
            double.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine("=" + (num1 + num2 + num3) / 2);





















        }
        public static void Part5()
        {
            string item1;
            string item2;
            double price1;
            double price2;
            double subtotal;


            Console.WriteLine("what two items whould you like?");
            Console.WriteLine("item 1");
            item1 = Console.ReadLine();
            Console.WriteLine("item 2");
            item2 = Console.ReadLine();

            Console.WriteLine(" What is the price of item 1");
            double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine(" What is the price of item 2");
            double.TryParse(Console.ReadLine(), out price2);
            subtotal = price1 + price2;
            Console.WriteLine(" The total of the two will be " + subtotal.ToString("C"));















        }
    }
    









}
