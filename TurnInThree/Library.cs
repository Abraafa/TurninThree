using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace TurnInThree
{
    public class Library
    {
        Book book { get; set; }
        Author author { get; set; }
        MyDataBase dataBase { get; set; }

        public void AddBook()
        {
            dataBase.AllBooks.Add(new Book(book.Title, book.Author, book.Genre, book.PubYear, book.ISBN));
            
            Console.WriteLine("Type the name of the book you want to add!");    
            book.Title = Console.ReadLine();

            Console.WriteLine("Which author has made this book?");
            book.Author = Console.ReadLine();

            Console.WriteLine("Which genre is this book?");
            book.Genre = Console.ReadLine();

            Console.WriteLine("Which year was this booke made?");
            try
            {
                book.PubYear = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That sure is a wierd year");
            }
            
            Console.WriteLine("What is the isbn of this book? (you can check it at the back of the book!");
            try
            {
                book.ISBN = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Are you sure that is correct?");
            }
        }

        public void AddAuthor()
        {
            dataBase.AllAuthor.Add(new Author(author.Name, author.Country));

            Console.WriteLine("Type the name of the author you want to add!");
            author.Name = Console.ReadLine();

            Console.WriteLine("What country is said author from?");
            author.Country = Console.ReadLine();
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter the name of the book you wish to remove!");
            string bookDelete = Console.ReadLine();
            if (bookDelete == book.Title)
            {
                dataBase.AllBooks.Remove(book);
                Console.WriteLine(bookDelete + " has been removed");
            }
            else
            {
                Console.WriteLine(bookDelete + " didn't exist, try again");
            }

        }

        public void RemoveAuthor()
        {
            Console.WriteLine("Enter the name of the author you wish to remove!");
            string authorDelete = Console.ReadLine();
            if (authorDelete == author.Name)
            {
                dataBase.AllAuthor.Remove(author);
                Console.WriteLine(authorDelete + " has been removed!");
            }
            else
            {
                Console.WriteLine(authorDelete + " didn't exist, try again!");
            }
        }

        public void UpdateInformation()
        {
            Console.WriteLine("Please enter the name of the book or author which information you wish to update!");
            string updateNow = Console.ReadLine();

            if (updateNow == book.Title)
            {
                Console.WriteLine("Please enter the changed title of this book which is currently " + book.Title);
                string newTitle = Console.ReadLine();

                Console.WriteLine("Please enter the changed author of this book which is currently " + book.Author);
                string newAuthor = Console.ReadLine();

                Console.WriteLine("Please enter the changed genre of this book which is currently " + book.Genre);
                string newGenre = Console.ReadLine();

                Console.WriteLine("Please enter the changed publishing year of this book which is currently " + book.PubYear);
                string newPubYear = Console.ReadLine();

                Console.WriteLine("Please enter the changed ISBN of  this book which is currently " + book.ISBN);
                string newISBN = Console.ReadLine();

            }
            else if (updateNow == author.Name)
            {
                Console.WriteLine("Please enter the changes you wish to do with the name which is currently " + author.Name);
                string newAuthor = Console.ReadLine();

                Console.WriteLine("Please enter the changes of country you wish to do with the name which is currently " + author.Country);
            }
            else
            {

            }
        }

        public void AddRating()
        {
            Console.WriteLine("Please enter the book title here!");
            string userInput = Console.ReadLine();
            if (userInput == book.Title)
            {
                Console.WriteLine("Please enter the rating between 1 to 5 you would like to add to this book");
                int rating = int.Parse(Console.ReadLine());
                if (rating < 1 || rating > 5)
                {
                    Console.WriteLine("The rating has to be between 1 and 5!");
                }
                else
                {
                    book.Ratings.Add(rating);
                }
            }
            else
            {
                Console.WriteLine("Please try again!");
            }
        }

        public double GetAverageRating()
        {
            if (book.Ratings.Count == 0)
            {
                return 0;
            }

            return book.Ratings.Average();
        }

        public void DisplayAuthorDetails()
        {
            Console.WriteLine($"Author: {author.Name}");
            Console.WriteLine("Böcker:");
            foreach (var book in dataBase.AllBooks)
            {
                Console.WriteLine($"- {book.Title} (Average Rating: {GetAverageRating():0.0})");
            }
        }

        public void ListAllBooksWithAuthor()
        {
            foreach (Book book in dataBase.AllBooks) 
            { 
                Console.WriteLine(book.Title + " " + book.Author); 
            }
        }
    }
}
