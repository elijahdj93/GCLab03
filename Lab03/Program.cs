using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing == true)
            {
                int num;
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer:");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");

                for (int i = 1; i<=num; i++)
                {
                    Console.WriteLine(i + "\t" + Math.Pow(i,2) + "\t" + Math.Pow(i,3));
                }
                string userChoice;
                Console.WriteLine("Continue? (y/n)");
                userChoice = Console.ReadLine();
                if (userChoice == "n" || userChoice == "N")
                {
                    keepGoing = false;
                }

            } 
        }
    }
}