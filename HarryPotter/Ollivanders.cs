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
      
        


        
        public void WhatWood(Wizard wizard)
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





        public string LettersInName(Wizard wizard)
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

            //int longestword = 0;

            //for (int i = 0; i < names.Length; i++)
            //{



            //}

            // ta reda på hur man genom en for loop hittar längsta namnet  

            //string longWord = "";

            //foreach (string name in names) 
            //{ 
            //    //name.Count();

            //    int longestName = name.Length;  // visar alla namn i arrayen och hur lång alla namn är


            //    for (int i = 0; i < name.Length ; i++)
            //    {


            //    }

            //    //if (name.Length > wordCount) 
            //    //{ 
            //    //    wordCount= name.Length;
            //    //    longWord= name;

            //    //}
            //    return name.Length;
            //}

            //int count = wizard.Name.Split(' ').Count();


            //for (int i = 0; i < wizard.Name.Length; i++)
            //{
            //    count++;
            //}


            return name;
        }

        
    }
}
