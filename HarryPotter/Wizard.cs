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
        public string BloodStatus { get; set; } //renblod, halvblod, mugglarfödd, okänt 

        public bool DeathEater { get; set; } //bool ja/nej

        public bool DumbledoorsArmy { get; set; } //bool ja/nej

        public string Name { get; set; } //trollkarens namn

        public Wizard(string name) //Varför deklarera i konstruktor??
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
            Random bloodStatus = new Random();
         

            int whatBlood = bloodStatus.Next(1, 101);

            if (whatBlood >= 40 && whatBlood <= 100)
            {
                BloodStatus = "Halvblod";
                
            }

            if (whatBlood >= 15 && whatBlood <= 40)
            {

                BloodStatus = "Mugglarfödd";
                
            }
            if (whatBlood >= 5 && whatBlood <= 15)
            {

                BloodStatus = "Fullblod";
                

            }

            if (whatBlood > 0 && whatBlood <= 5)
            {

                BloodStatus = "Okänt";
                
            }



        }

        public bool WizzyDeathEater() 
        {

          
            if (BloodStatus == "Halvblod" || BloodStatus == "Okänt")
            {
               Random random= new Random();
               int randomHalfblood = random.Next(1,101);
                
                                
                if (randomHalfblood > 0 && randomHalfblood <= 25) 
                {
                    
                    DeathEater = true;

                }       

            }


            if (BloodStatus == "Mugglarfödd")
            {
                Random random= new Random();
                int randomMuggle = random.Next(1, 101);

                if (randomMuggle >= 25 && randomMuggle <= 40)
                {

                    DeathEater = true;

                }

            }


            if (BloodStatus == "Fullblod")
            {
                Random random= new Random();
                int randomFullblood = random.Next(1, 101);
                if (randomFullblood > 40 && randomFullblood <= 100)
                {

                    DeathEater = true;

                }

            }
                   

            return false;
        }
       
        public bool DumbledoresArmy()
        {

            if (!DeathEater)
            {
                Random random= new Random();
                int randomDE = random.Next(1, 101);
                if (randomDE > 0 && randomDE <= 45) 
                { 
                    DumbledoorsArmy = true;
                
                }

            }
            if (DeathEater)
            {
                Random random = new Random();
                int randomDE = random.Next(1, 101);
                if (randomDE > 0 && randomDE <= 25)
                {
                    DumbledoorsArmy = true;

                }

            }

            return false;
        }
            
           



        


    }
}
