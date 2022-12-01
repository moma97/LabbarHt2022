using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HarryPotter
{
    internal class Hogwarts
    {
        public Gryffindor Gryffindor { get; set; }
        
        public Hufflepuff Hufflepuff { get; set; }

        public Ravenclaw Ravenclaw { get; set; }

        public Slytherin Slytherin { get; set; }

        //Wizard wizard = new Wizard();
        
        int count = 0;



        public Hogwarts() //nyar upp egenskaperna gör att du får tillgång till klassernas properties //fråga till imorgon varför man måste göra såhär // 
        {
            Gryffindor = new Gryffindor();
            Hufflepuff = new Hufflepuff();
            Ravenclaw = new Ravenclaw();
            Slytherin = new Slytherin();
            
            
        }


        public House SortingHat(Wizard wizard)  //Indata är alltså en trollkarl och utdatat blir vilket elevhem som man hamnar i.
        {
                   

            if (count == 0)
            {
                Hufflepuff.Members.Add(wizard);
                count++;
                return Hufflepuff;
            }
            if (count == 1)
            {
                Ravenclaw.Members.Add(wizard);
                count++;
                return Ravenclaw;
            }

            if (count == 2)
            {
                count++;    
                Gryffindor.Members.Add(wizard);
                return Gryffindor;
            }

            else 
            {
                count = 0;
                Slytherin.Members.Add(wizard);
                return Slytherin;
            }
           
            

        }




    }
}                        
    

