using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProblem_Book_Square
{
    class Book
    {
        //Fields
        private string title;
        private string author;

        //Properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        //Constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public Book()
        {
            title = "Unknown Title";
            author = "Unknown Author";
        }

        //Method to display book info
        public void DisplayInfo()
        {
            Console.WriteLine($"Title = {Title}, Author = {Author}");
        }

        //Deconstructor
        ~Book()
        {
            Console.WriteLine("Book object is destroyed.");
        }


    }
}
