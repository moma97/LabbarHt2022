using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace godiskalkylatorn
{
    class CandyCalculator
    {
        public List<Person> personList { get; set; } 


        public CandyCalculator()
        {
            personList= new List<Person>();
        }

        public void AddPerson(string inputFirst, string inputLast, int inputAge)
        {
            Person person = new Person();
            {
                person.Firstname = inputFirst;
                person.Lastname = inputLast;
                person.Age = inputAge;
                person.Candies = 0;
            };

            personList.Add(person);                 

        }



    }
}
