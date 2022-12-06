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

        

        int count = 0;


        //för egenskapen tilldelar vi värden av gryff
        public Hogwarts() //nyar upp egenskaperna gör att du får tillgång till klassernas properties 
        {
            Gryffindor = new Gryffindor();
            Hufflepuff = new Hufflepuff();
            Ravenclaw = new Ravenclaw();
            Slytherin = new Slytherin();
            
            //när man skapar ett objekt av klassen kommer dessa upp direkt. 
        }

       
        //för att kunna returnera ett house i main window skriver vi house innan sortinghat. vi stoppar in wizard wizar för att kunna använda det i main. 
        public House SortingHat(Wizard wizard)  //Indata är alltså en trollkarl och utdatat blir vilket elevhem som man hamnar i. "House" "Wizard",//använder klassen som datatyp
        {
                   
            if (count == 0)
            {
                Hufflepuff.Members.Add(wizard);
                count++;
                return Hufflepuff;
            }
            else  if (count == 1)
            {
                Ravenclaw.Members.Add(wizard);
                count++;
                return Ravenclaw;
            }

            else if (count == 2)
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
    

