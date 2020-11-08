using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Vacation Budget Planner");

            Console.WriteLine("Please enter your name");

            string name = Console.ReadLine();


            Console.WriteLine("Welcome " + name + " where would you like to travel today, Jamaica or Mexico?");

            string travel = Console.ReadLine();


            Console.WriteLine("You have chosen " + travel + " as your destination.");

            Console.WriteLine("How many days will you spend on your trip?");

            int days = Convert.ToInt32(Console.ReadLine());
            
           
            Console.WriteLine("How much spending money would you like to bring on your trip?");

            int money = Convert.ToInt32(Console.ReadLine());

            string m = money.ToString("C");
            
            int sum = (money / days);

            string s = sum.ToString("C");


            Console.WriteLine("Hey " + name + " you are going to " + travel + " for " + days + " days with " +
                m + " for spending money. You can spend " + s + " per day.");

            Console.ReadLine();








        }
    }
}
