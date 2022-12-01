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

        public List<Wizard> Members { get; set; } //= new List<Wizard>();

        public string Password { get; protected set; } //vrf är den protected set?

      


        public override string ToString()
        {
            return this.GetType().Name;
        }

        /// <summary>
        /// om nuvarande lösenord är samma och framtida lösnord fyller kritierier byt lösenord
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public virtual bool SetPassword(string currentPassword, string newPassword)
        {
            
                if (CurrentPassword(currentPassword) && HasCorrectPasswordFormat(newPassword))
                {
                    Password = newPassword;
                    return true;

                }
                
            return false;
        }

        /// <summary>
        /// kontrollerar att lösenordet har rätt format, //lade till virtual efter inlämning//här kollar vi om plats 1 och sista är vokal/consonant
        /// </summary>
        /// <param name="passwordatm"></param>
        /// <returns></returns>
        public virtual bool HasCorrectPasswordFormat(string passwordatm)
        {
            if (passwordatm.Length >= 5)
            {

                if (FirstLetterVowel(passwordatm[0]))
                {

                    if (IsConsonant(passwordatm[passwordatm.Length -1]))
                    {                                                                
                            return true;
                        
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Kollar om första bokstaven är en vokal//loopar igenom 
        /// </summary>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool FirstLetterVowel(char letter)
        {
            char[] vowels = new char[] { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };

            foreach (char c in vowels)
            {

                if (c == letter)
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
        public bool IsConsonant(char newpassword)
        {
            char[] consonant = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'z', 'x' };

            foreach (char c in consonant)
            {
                if (c == newpassword)
                {
                    
                    return true;
                }
                
            }
            
            return false;

        }

        /// <summary>
        /// kontrollerar så att lösnordet är likadant som det nuvarande
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <returns></returns>
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
