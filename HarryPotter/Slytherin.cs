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
        /// kollar att lösenordet har rätt format
        /// </summary>
        /// <param name="newpassword"></param>
        /// <returns></returns>
        //public bool HasCorrectPasswordFormatSlyth(string newpassword)
        //{
           
        //        if (newpassword.Length >= 8)
        //        {
        //            if (FirstAndLast(newpassword) == true)

        //            {
        //                return true;
        //            }
        //        }

            

        //    return false;
            
        //}

        /// <summary>
        /// sätter nytt lösenord om man inmatat rätt nuvrande och fyller kriterierna för nya
        /// </summary>
        /// <param name="currentPswds"></param>
        /// <param name="newPswds"></param>
        /// <returns></returns>
        public override bool SetPassword(string currentPswds, string newPswds)
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


        /// <summary>
        /// kollar att första och sista bokstaven är konsonant
        /// </summary>
        /// <param name="pswdSlyth"></param>
        /// <returns></returns>
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




        /// <summary>
        /// kollar att lösenord är samma som det förbestämda
        /// </summary>
        /// <param name="currentPasswords"></param>
        /// <returns></returns>
        public bool CurrentPasswords(string currentPasswords)
        {

            if (currentPasswords == Password)
            {
                return true;
            }

            return false;
        }

        //gjort fel, gör om enligt fl


        public override bool HasCorrectPasswordFormat(string lösen)
        {


            if (lösen.Length >= 8)
            {
                if (FirstAndLast(lösen) == true)

                {
                    return true;
                }
            }



            return false;

        }






    }
      


}
