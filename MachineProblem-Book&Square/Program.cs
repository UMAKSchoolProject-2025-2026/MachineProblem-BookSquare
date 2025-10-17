using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProblem_Book_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creative Liberty, wanted to try something I saw in youtube
            List<Book> books = new List<Book>();
            bool continueAdding = true;

            Console.WriteLine("----Machine Problem 1 - Book----");
            Console.WriteLine();
            Console.WriteLine();


            while (continueAdding)
            {
                Console.WriteLine("Insert the information of a book :");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Information of book {books.Count + 1} :");
                Console.Write("Input name of the book : ");
                string title = Console.ReadLine();

                Console.Write("Input the author : ");
                string author = Console.ReadLine();

                books.Add(new Book(title, author));

                Console.WriteLine();
                Console.WriteLine("Current List of books :");
                Console.WriteLine("----------------------------");
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Title = {books[i].Title}, Author = {books[i].Author}");
                }

                Console.WriteLine();

                string choice;
                while (true)
                {
                    Console.Write("Do you want to add this book? (y/n) : ");
                    choice = Console.ReadLine().Trim().ToLower();

                    if (choice == "y" || choice == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }

                    if (choice == "n")
                    {
                        continueAdding = false;
                    }
                }



                Console.WriteLine("----Machine Problem 2 - Square----");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Method that returns a Class:");
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Input the dimensions of the Square (equal length and Width) :");
                Console.Write("Length: ");
                int length = int.Parse(Console.ReadLine());
                Console.Write("Width: ");
                int width = int.Parse(Console.ReadLine());


                Square mySquare = new Square(length, width);

                Console.WriteLine();
                Console.WriteLine("Perimeter and Area of the square:");
                mySquare.Display();

                Console.ReadLine();
            }
        }

    }
}
