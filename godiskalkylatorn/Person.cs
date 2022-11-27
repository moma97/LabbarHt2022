using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace godiskalkylatorn
{
    class Person
    {
        public string Age { get; set; }

        public int Candies { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public List<Person> Persons  { get;set; } = new List<Person>();

      

        public override string ToString()
        {
            return Firstname + " " + Lastname + " (" + Age +" år): " + Candies + " st";
                 
        }

      
      
    }
}
