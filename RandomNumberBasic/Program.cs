using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberBasic
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("******************************");
            Console.WriteLine("* Random Numbers Generator   *");
            Console.WriteLine("* created by : Mohamed Sabry *");
            Console.WriteLine("*     Date : 5/6/2023        *");
            Console.WriteLine("******************************");
            Console.WriteLine("     ");

            // Generate X random numbers
            // stored in array & printed
            // --------------------------

            string YN;
            do
            {

                Console.WriteLine("    ");
                // Ask user enter count of random numbers
                Console.Write("Enter Count of Random Numbers: ");
                int X = int.Parse(Console.ReadLine());

                // create array to assign random numbers
                int[] rndNums = new int[X];
                Random rnd = new Random();

                // Ask user to enter min & max value
                Console.Write("Enter Minimum Value: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Enter Maximum Value: ");
                int m = int.Parse(Console.ReadLine());

                // loop to assign each number to array
                // print all random numbers
                for (int i=0; i<X; i++)
                {
                    rndNums[i] = rnd.Next(n,m);
                    Console.WriteLine(rndNums[i]);
                
                }
                

                // Ask user to make another trial
                Console.Write("do you want another trial? (y/n): ");
                YN = Console.ReadLine();

                // when enter n/N exit the program
                if(YN == "n" || YN == "N")
                {
                    Environment.Exit(0);
                }

                // whn enter anything else y and n
                else if(YN != "y" && YN != "Y" && YN != "n" && YN != "N")
                {
                    Console.WriteLine("this value is not valid, try again");
                }
            // run the program again when enter y/Y
            } while (YN == "y" || YN == "Y");




        }
    }
}
