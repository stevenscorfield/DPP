using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPresidents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********------------------                         ------------------------");
            Console.WriteLine("**********------------------                         | x  x  || || || x  x  |");
            Console.WriteLine("**********------------------                         |       || || ||       |");
            Console.WriteLine("**********------------------                         | x  x  || || || x  x  |");
            Console.WriteLine("**********------------------                         ------------------------");
            Console.WriteLine("**********------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Console.WriteLine("Out of the following candidates (Trump, Cruz, Clinton, Sanders or Bloomberg), who will win the US Presidential Elections?");
            String presidents = Console.ReadLine();

            switch (presidents)
            {
                case "Trump":
                    Console.WriteLine("We are all doomed!");
                    break;
                case "Cruz":
                    Console.WriteLine("Not as bad as Trump but still bad!");
                    break;
                case "Clinton":
                    Console.WriteLine("Probably won't cause WW3.");
                    break;
                case "Sanders":
                    Console.WriteLine("Not sure if the US is ready for a socialist president.");
                    break;
                case "Bloomberg":
                    Console.WriteLine("An independent candidate winning. Don't be silly!");
                    break;
                default:
                    Console.WriteLine("Not sure who will win then?");
                    break;               
            }
        }
    }
}
