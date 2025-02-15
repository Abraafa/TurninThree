using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace TurnInThree
{
    public class Program
    {
        Library library = new Library();

        static void Main(string[] args)
        {
            
        }

        public void SaveData()
        {
            string dataJSONfilePath = "LibraryData.json";
            string allDataSomJSONType = File.ReadAllText(dataJSONfilePath);
            MyDataBase DataBase = JsonSerializer.Deserialize<MyDataBase>(allDataSomJSONType);
            List<Book> AllBooks = DataBase.AllBooks;
            List<Author> AllAuthors = DataBase.AllAuthor;
            string updateBooks = JsonSerializer.Serialize(DataBase, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataJSONfilePath, updateBooks);
        }
        public void DisplayMenu()
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Add author");
            Console.WriteLine("3. Update book or author");
            Console.WriteLine("4. Remove book");
            Console.WriteLine("5. Remove author");
            Console.WriteLine("6. List all books and authors");
            Console.WriteLine("7. Add rating to a book");
            Console.WriteLine("8. See average rating on each book");
            Console.WriteLine("9. Detailed information regarding authors");
            Console.WriteLine("10. Exit and save!");
        }

        public void RunMenu()
        {
            bool running = true;
            while (running)
            {
                DisplayMenu();
                string userInput = Console.ReadLine();
                int userInputInt = int.Parse(userInput);

                switch (userInputInt)
                {
                    case 1:
                        library.AddBook();
                        SaveData();
                        break;
                    
                    case 2:
                        library.AddAuthor();
                        SaveData();
                        break;
                    
                    case 3:
                        library.UpdateInformation(); 
                        SaveData();
                        break;
                    
                    case 4:
                        library.RemoveBook();
                        SaveData();
                        break;
                    
                    case 5:
                        library.RemoveAuthor();
                        SaveData();
                        break;
                    
                    case 6:
                        library.ListAllBooksWithAuthor();
                        break;

                    case 7:
                        library.AddRating();
                        SaveData();
                        break;

                    case 8:
                        library.GetAverageRating();
                        break;

                    case 9:
                        library.DisplayAuthorDetails();
                        break;
                    
                    case 10:
                        SaveData();
                        running = false;
                        break;
                        
                }
            }
        }
    }
}