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
            
            int whatBlood = random.Next(1, 101);

            if (whatBlood > 40 && whatBlood <= 100)
            {
                BloodStatus = "Halvblod";
                
            }

            if (whatBlood > 15 && whatBlood <= 40)
            {

                BloodStatus = "Mugglarfödd";
                
            }
            if (whatBlood > 5 && whatBlood <= 15)
            {

                BloodStatus = "Fullblod";
                

            }

            if (whatBlood <= 5)
            {

                BloodStatus = "Okänt";
                
            }



        }

        public void WizzyDeathEater() 
        {
            int randomHalfblood = random.Next(1, 101);

            if (BloodStatus == "Halvblod" || BloodStatus == "Okänt" && randomHalfblood <= 25)
            {                                                                                                                         
                    DeathEater = true;
                      
            }


            if (BloodStatus == "Mugglarfödd" && randomHalfblood <= 15)
            {                                                          
                    DeathEater = true;
            
            }


            if (BloodStatus == "Fullblod" && randomHalfblood <= 60)
            {
                DeathEater = true;

            }
            
       
        }
       
        public void DumbledoresArmy()
        {
            int randomDE = random.Next(1, 101);

            if (!DeathEater && randomDE <= 45)
            {                                            
                    DumbledoorsArmy = true;                         
            }
           
            if (DeathEater && randomDE <= 25)
            {                                          
                    DumbledoorsArmy = true;               
            }
        }
            
           



        


    }
}
