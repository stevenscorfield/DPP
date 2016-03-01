using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer this following riddle. 'Why did the chicken cross the road?'");
            string answer = (Console.ReadLine()).ToLower();
            string chickenAnswer = "To get to the other side";
            string stickAnswer = "A stick";

            while (answer != chickenAnswer)
            {
                Console.WriteLine("That's not right");
                answer = Console.ReadLine();
            }
            Console.WriteLine("What is brown and sticky?");
            answer = (Console.ReadLine()).ToLower();

            while (answer != stickAnswer)
            {
                Console.WriteLine("That's not right");
                answer = Console.ReadLine();
            }
            Console.WriteLine("Congratulations!");
        }
    }
}
