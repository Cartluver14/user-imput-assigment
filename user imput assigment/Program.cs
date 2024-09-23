using System;
using System.Collections.Generic;
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
            Part2()
            

            
            

            

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
            loginname














        }
    }



}
