using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Slytherin : House
    {
       
        internal Slytherin()
        {
            HouseGhost = "Den Blodiga Baronen";
            Mascot = "Ormen";
            
            Password = "cenblodig";
        }
     

       
        public override bool HasCorrectPasswordFormat(string lösen)
        {


            if (lösen.Length >= 8)
            {
                if (IsConsonant(lösen[0]) && IsConsonant(lösen[lösen.Length-1])) 
                {
                    return true;
                }
            }



            return false;

        }








    }



}
