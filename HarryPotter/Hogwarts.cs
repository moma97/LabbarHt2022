using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Hogwarts
    {
        public Gryffindor Gryffindor { get; set; }
        
        public Hufflepuff Hufflepuff { get; set; }

        public Ravenclaw Ravenclaw { get; set; }

        public Slytherin Slytherin { get; set; }


        public Hogwarts() //nyar upp egenskaperna //fråga till imorgon varför man måste göra såhär // 
        {
            Gryffindor= new Gryffindor();
            Hufflepuff= new Hufflepuff();
            Ravenclaw= new Ravenclaw();
            Slytherin= new Slytherin();

        }

    




    }
}                        
    

