using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to check what data type it is:");
            string response = Console.ReadLine();
            Decimal myNumber = 0M;
            myNumber = Convert.ToDecimal(response);

            if (myNumber < -127 || myNumber > 128)
            {
                Console.WriteLine("That is the wrong type of data type");
            }

            else
            {
                Console.WriteLine("The number you have entered is the correct data type");
            }
            
        }
    }
}
