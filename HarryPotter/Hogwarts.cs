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

        public Hogwarts() //nyar upp egenskaperna gör att du får tillgång till klassernas properties //fråga till imorgon varför man måste göra såhär // 
        {
            Gryffindor = new Gryffindor();
            Hufflepuff = new Hufflepuff();
            Ravenclaw = new Ravenclaw();
            Slytherin = new Slytherin();

        }


        //public House SortingHat(string wizard)  //Indata är alltså en trollkarl och utdatat blir vilket elevhem som man hamnar i.
        //{


        //}


        

    }
}                        
    

