 //6.	Create a structure Book which contains the following members: bookId, title, price, bookType
//Type of the book should an enumerated data type with values as Magazine, Novel, ReferenceBook, Miscellaneous.
//Write a console based application to do the following tasks.
//a.	Accept the details of the book
//b.	Display the details of the book. The type of book should be displayed as a string e.g.: Magazine
using System;
class Program
{
    struct Book
    {
        public int bookId;
        public string title;
        public double price;
        BookType booktype;
        enum BookType
        {
            Magazine,
            Novel,
            ReferenceBook,
            Miscellaneous
        }

        public void EnterDetails()
        {
            Console.WriteLine("Enter BookId:");
            this.bookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title:");
            this.title = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            this.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book Type");
            Console.WriteLine("Press 1 for Magazine \n" + "Press 2 for Novel\n" + "Press 3 for Referenece Book\n" + "Press 4 for Miscellaneous");
            int TypeNo = int.Parse(Console.ReadLine());
            switch (TypeNo)
            {
                case 1: this.booktype = BookType.Magazine; break;
                case 2: this.booktype = BookType.Novel; break;
                case 3: this.booktype = BookType.ReferenceBook; break;
                case 4: this.booktype = BookType.Miscellaneous; break;
                default: Console.WriteLine("Invalid Book type number"); break;
            }

        }
        public void DisplayDetails()
        {
            Console.WriteLine("The details about the book are as follows");
            Console.WriteLine("BookId: {0}", this.bookId);
            Console.WriteLine("Book Title: {0}", this.title);
            Console.WriteLine("Book Price: {0}", this.price);
            Console.WriteLine("Book Type: {0}", this.booktype);
        }
    }
    public static void Main()
    {
        Book b = new Book();
        b.EnterDetails();
        b.DisplayDetails();
    }
}