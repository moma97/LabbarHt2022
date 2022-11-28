using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace godiskalkylatorn
{
    class CandyCalculator
    {
        public List<Person> personList { get; set; } = new List<Person>();

    
        public void DistributeCandy(int candies)
        {


            int rest = candies % personList.Count;
            int total = candies / personList.Count;



            foreach (Person person in personList)  
            {
                person.Candies = total;

            }

            foreach (Person person in personList)
            {
                if (rest != 0)
                {
                    rest--;
                    person.Candies++;

                }    
            }

        }
        
        



    }
}
