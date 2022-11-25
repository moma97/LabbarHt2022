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


        public bool HasCorrectPasswordFormatSlyth(string newpassword)
        {
           
                if (newpassword.Length >= 8)
                {
                    if (FirstAndLast(newpassword) == true)

                    {
                        return true;
                    }
                }

            

            return false;
            
        }

   
        public bool SetPasswordSlyth(string currentPswds, string newPswds)
        {
            if (newPswds.Length >= 8)
            {

                if (FirstAndLast(newPswds) == true)
                {
                        if (CurrentPasswords(currentPswds) == true)
                        {
                            Password = newPswds;
                            return true;

                        }
                    
                }
            }
            return false;
        }



        public bool FirstAndLast(string pswdSlyth)
        {
            char[] consonant = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'z', 'x' };

            foreach (char c in consonant)
            {
                if (pswdSlyth.StartsWith(c) && pswdSlyth.EndsWith(c))
                {
                     return true;
                }

            }

            return false;


        }





        public bool CurrentPasswords(string currentPasswords)
          {

            if (currentPasswords == Password)
            {
                return true;
            }

            return false;
          }
    }




}
