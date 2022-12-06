using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HarryPotter
{
    internal class Wizard
    {
        public string BloodStatus { get; set; } 

        public bool DeathEater { get; set; } 

        public bool DumbledoorsArmy { get; set; } 

        public string Name { get; set; }

        public string Wand { get; set; }



        Random random = new Random();

        public Wizard(string name) //när det skapas ett nytt objekt körs dessa, när man skapar en klass körs alltid denna konstuktor 
        {
            Name = name;
            WizzyBloodStatus();
            WizzyDeathEater();
            DumbledoresArmy();              

        }

        public override string ToString()
        {
            return Name;
        }

      

        public void WizzyBloodStatus() 
        {
            int control = random.Next(100);
         

            //int whatBlood = bloodStatus.Next(1, 101);

            if (control >= 40 && control <= 100)
            {
                BloodStatus = "Halvblod";
                
            }

            if (control >= 15 && control <= 40)
            {

                BloodStatus = "Mugglarfödd";
                
            }
            if (control >= 5 && control <= 15)
            {

                BloodStatus = "Fullblod";
                

            }

            if (control > 0 && control <= 5)
            {

                BloodStatus = "Okänt";
                
            }



        }

        public void WizzyDeathEater() 
        {

          
            if (BloodStatus == "Halvblod" || BloodStatus == "Okänt")
            {
               
               int randomHalfblood = random.Next(100);
                
                                
                if (randomHalfblood > 0 && randomHalfblood <= 25) 
                {
                    
                    DeathEater = true;

                }       

            }


            if (BloodStatus == "Mugglarfödd")
            {
                
                int randomMuggle = random.Next(100);

                if (randomMuggle >= 25 && randomMuggle <= 40)
                {

                    DeathEater = true;

                }

            }


            if (BloodStatus == "Fullblod")
            {
               
                int randomFullblood = random.Next(100);
                if (randomFullblood > 40 && randomFullblood <= 100)
                {

                    DeathEater = true;

                }

            }
                   

        
        }
       
        public void DumbledoresArmy()
        {

            if (!DeathEater)
            {
                
                int randomDE = random.Next(100);
                if (randomDE > 0 && randomDE <= 45) 
                { 
                    DumbledoorsArmy = true;
                
                }

            }
            if (DeathEater)
            {
                
                int randomDE = random.Next(100);
                if (randomDE > 0 && randomDE <= 25)
                {
                    DumbledoorsArmy = true;

                }

            }

            
        }
            
           



        


    }
}
