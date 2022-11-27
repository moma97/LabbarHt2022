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
            //Members = null;
            Password = "cenblodig";
        }

      
        /// <summary>
        /// sätter nytt lösenord om man inmatat rätt nuvrande och fyller kriterierna för nya
        /// </summary>
        /// <param name="currentPswds"></param>
        /// <param name="newPswds"></param>
        /// <returns></returns>
        public override bool SetPassword(string currentPswds, string newPswds)
        {
            if (HasCorrectPasswordFormat(newPswds) == true && CurrentPassword(currentPswds) == true)
            {
                Password = newPswds;
                return true;
                
            }

            
            return false;
        }
        public override bool HasCorrectPasswordFormat(string lösen)
        {


            if (lösen.Length >= 8)
            {
                if (IsConsonant(lösen[0]) == true && IsConsonant(lösen[lösen.Length-1]) == true) 
                {
                    return true;
                }
            }



            return false;

        }








    }



}
