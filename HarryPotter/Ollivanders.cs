using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;

namespace HarryPotter
{
    internal class Ollivanders
    {
        private List<string> Woods = new List<string>
        {
         "Akacia",
         "Al",
         "Ask",
         "Asp",
         "Björk",
         "Slånbärträd",
         "Körsbär",
         "Ebenholt"
        };

        public Ollivanders()
        {
            Wand wand = new Wand();

            //Wizard wizard= new Wizard();
        }  
      
        


        
        public string WhatWood(Wizard wizard) //ge ut trä från lista till den trollkarl med lika många bokstäver i blodstatus
        {
            //Wand wand = new Wand();
            int ltrsInWood;
            

           string bloodstatus = wizard.BloodStatus;
           int ltrsInBlood = bloodstatus.Count();

          
            foreach (string wood in Woods) 
            {
               
                ltrsInWood = wood.Count();
                if (ltrsInWood == ltrsInBlood)
                {
                    wizard.Wand = wood;
                }
            }

            return wizard.Wand;

        }


        


        public int LettersInName(Wizard wizard) // flera namn, undvika whitespace, ta reda på namnet med längst bokstäver
        {
            string wName = wizard.Name;
            string[] names = wName.Split(' ');

            // inspo https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-24.php
            string name = "";
            int ctr = 0;
            foreach (string s in names)
            {
                if (s.Length > ctr) 
                {
                    name = s;
                    ctr = s.Length;
                }

            }          
            return ctr;

            

        }

        public int EvenOrOdd(int testing)
        {
            
            if (testing % 2 == 0)
            {

                return 8;

            }
            else
                return 7;

        }

        public int WizardWholeName(Wizard wizard) //https://stackoverflow.com/questions/16608691/length-of-string-without-spaces-c
        {
                       
            string name = wizard.Name;

            //int koko = name.Count(c => !char.IsWhiteSpace(c)); utan whitespace

            int koko = name.Count();

            return koko;
        }
      

        private static int SumDigits(int number)
        {
            
            
            int sum;
            do
            {
                sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum;
            } while (sum >= 10);
            return sum;
        }

        public int Core(Wizard wizard)
        {
         
            int lettersInName = LettersInName(wizard);

            int evenOrOdd = EvenOrOdd(lettersInName);

            int magicNumber = lettersInName * evenOrOdd;

            int coreNumber = SumDigits(magicNumber);

            return coreNumber;

        }

        public double WandLenght(Wizard wizard)
        {
            int lettersInName = LettersInName(wizard);
            int evenOrOdd = EvenOrOdd(lettersInName);

            int magicNumber = lettersInName * evenOrOdd;
            double magicNumberseven = magicNumber * 0.7;
       
            int wholeName = WizardWholeName(wizard);

            double lenght = (magicNumberseven / lettersInName) + wholeName;

            return lenght;


        }

    }
}
