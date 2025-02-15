using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TurnInThree
{
    public class MyDataBase
    {
        [JsonPropertyName("books")]
        public List<Book> AllBooks { get; set; }

        [JsonPropertyName("Authors")]
        public List<Author> AllAuthor { get; set; }
    }
}
