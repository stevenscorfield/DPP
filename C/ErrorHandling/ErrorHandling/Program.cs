using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            try
            {
                int mynumbers = numbers[7];
            }

            catch (Exception)
            {
                Console.WriteLine("Out of index range!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
                
                 
        }
    }
}
