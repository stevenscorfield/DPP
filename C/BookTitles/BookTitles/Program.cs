using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>();
            books.Add("The Hunger Games");
            books.Add("Mockingjay");
            books.Add("Catching Fire");
            books.Add("The Hitchikers Guide to the Galaxy");
            //creates 2 empty user input variable strigns
            string user = "";
            string booksColl = "";

            Console.WriteLine("Welcome to the book list depository. Please select the following options: ");
            //Empty console to create a line break
            Console.WriteLine();
           

            do
            {
                Console.WriteLine("Enter A to add a new book, enter D to delete a book, enter L to list the books and enter S to sort the books. Enter X to stop.");
                Console.WriteLine();

                //reads the initial user input and then acts accordingly
                user = Console.ReadLine();

                switch (user)
                {
                    case "A":
                        Console.WriteLine("Please enter the book title you would like to add.");
                        booksColl = Console.ReadLine();
                        books.Add(booksColl);
                        Console.WriteLine();
                        Console.WriteLine("You have added " + booksColl + " to the collection.");
                        Console.WriteLine();
                        break;
                    case "D":
                        Console.WriteLine("Please enter the book title you would like to delete.");
                        booksColl = Console.ReadLine();
                        books.Remove(booksColl);
                        Console.WriteLine();
                        Console.WriteLine("You have deleted " + booksColl + " from the collection.");
                        Console.WriteLine();
                        break;
                    case "L":
                        foreach (string i in books)                           
                        {
                            Console.WriteLine();
                            Console.WriteLine("The following books are in the collection:" + i);
                            Console.WriteLine();
                        }
                        break;
                    case "S":
                        Console.WriteLine("The books have been sorted alphabetically");
                        booksColl = Console.ReadLine();
                        books.Sort();
                        Console.WriteLine();
                        Console.WriteLine("You have sorted the collection.");
                        Console.WriteLine();
                        break;

                    default:
                        break;
                }
            }
            //continues the loop until x is entered
            while (user != "X");
            Console.WriteLine("Good Bye!");
        }
    }
}
