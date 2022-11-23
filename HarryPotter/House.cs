using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;

namespace HarryPotter
{
    internal abstract class House
    {
        public string HouseGhost { get; set; }

        public string Mascot { get; set; }

        public string Members { get; set; }

        public string Password { get; protected set; }

      
        public bool SetPassword(string currentPassword, string newPassword)
        {

            if (newPassword.Length >= 5)
            {
                


                if (FirstLetterVowel(newPassword) == true)
                {
                   


                    if (LastLetterEndWithK(newPassword) == true)
                    {
                        


                        if (CurrentPassword(currentPassword) == true)
                        {
                            Password = newPassword;
                            return true;
                           
                        }
                    }
                }
            }
            return false;
        }

        public bool HasCorrectPasswordFormat(string passwordatm)
        {
            if (passwordatm.Length >= 5)
            {

                if (FirstLetterVowel(passwordatm) == true)
                {

                    if (LastLetterEndWithK(passwordatm) == true)
                    {


                        //if (CurrentPassword(passwordatm) == true)
                        
                            return true;
                        
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Kollar om första bokstaven är en vokal
        /// </summary>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool FirstLetterVowel(string newPassword)
        {
            char[] vowels = new char[] { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };

            foreach (char c in vowels)
            {

                if (newPassword.StartsWith(c))
                {
                    
                    return true;

                }
            }
          
            return false;

        }
        /// <summary>
        /// kollar om sista bokstaven är en konsonant
        /// </summary>
        /// <param name="newpassword"></param>
        /// <returns></returns>
        public bool LastLetterEndWithK(string newpassword)
        {
            char[] consonant = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'z', 'x' };

            foreach (char c in consonant)
            {
                if (newpassword.EndsWith(c))
                {
                    
                    return true;
                }
                
            }
            
            return false;

        }

        public bool CurrentPassword(string currentPassword)
        {

            if (currentPassword == Password)
            {
                return true;
            }

            return false;
        }

      




    }
}
