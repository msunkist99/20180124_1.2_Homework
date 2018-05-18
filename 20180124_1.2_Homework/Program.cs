using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180124_1._2_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first string - ");
            string firstString;
            firstString = Console.ReadLine();

            Console.Write("Enter your second string - ");
            string secondString = Console.ReadLine();

            Console.WriteLine(firstString + " " + secondString + "!");
            Console.ReadLine();

            Console.WriteLine($"{firstString} {secondString} - using string interpolation!");
            Console.ReadLine();

            Console.WriteLine($"{firstString.ToUpper()} {secondString.ToUpper()} - all UPPER case this time!");
            Console.ReadLine();

            Console.Write("Enter a complete sentence - ");
            string sentence = Console.ReadLine();

            Console.WriteLine(sentence.ToUpper());
            Console.ReadLine();

            Console.Write("enter your first date as mm/dd/yyyy - ");
            DateTime dateOne = DateTime.Parse( Console.ReadLine());

            Console.Write("enter your second date as mm/dd/yyyy - ");
            DateTime dateTwo = DateTime.Parse(Console.ReadLine());

            TimeSpan dateDifference = dateTwo - dateOne;
            Console.WriteLine($"Difference between {dateOne} and {dateTwo} is {dateDifference.Days} days");
            Console.WriteLine();
            Console.WriteLine($"Difference between {dateOne.ToShortDateString()} and {dateTwo.ToShortDateString()} is {dateDifference.Days} days");

            Console.ReadLine();
        }
    }
}
