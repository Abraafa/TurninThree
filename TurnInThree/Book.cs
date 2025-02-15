using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TurnInThree
{
    public class Book
    {
        public int ID {  get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PubYear { get; set; }
        public int ISBN { get; set; }
        public List<int> Ratings { get; set; }

        public Book (string title, string author, string genre, int pubyear, int isbn)
        {
            ID++;
            Title = title;
            Author = author;
            Genre = genre;
            PubYear = pubyear;
            ISBN = isbn;
            Ratings = new List<int>();

        }
    }
}
