using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnInThree
{
    public class Author
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Author (string name, string country)
        {

            ID++;
            Name = name;
            Country = country;

        }


    }

}
