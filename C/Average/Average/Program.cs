using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers to calculate their average.");
            Console.WriteLine();
            //Creates a decimal variable used to store user input
            decimal input = 0;
            //for loop counter - 5 is the total times the for loop should loop till
            for (int i = 0; i < 5; i++)
            {
                //Console command increases the enter number value by 1 (i + 1)
                Console.WriteLine("Enter number " + (i + 1) + ":");
                //Reads users input and converts into a decimal
                input += Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine("The total of your numbers was " + input + " and your average is " + input / 5);
        }
    }
}