using System;
using System.Collections.Generic;
using System.Linq;
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
            
        }  
      
        


        
        public void WhatWood(Wizard wizard) //ge ut trä från lista till den trollkarl med lika många bokstäver i blodstatus
        {
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


        }





        public string LettersInName(Wizard wizard) // flera namn, undvika whitespace, ta reda på namnet med längst bokstäver
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
          
            return name;
        }

        
    }
}
