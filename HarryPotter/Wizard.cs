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


        public void WizzyBloodStatus()
        {
            Random bloodStatus = new Random();
            string halvBlod;
            string mugglarfödd;
            string fullblod;
            string okänt;

            int whatBlood = bloodStatus.Next(1, 101);

            if (whatBlood >= 40 && whatBlood <= 100)
            {
                BloodStatus = "Halvblod";
                //whatBlood = halvBlod;
                MessageBox.Show(BloodStatus);
            }

            if (whatBlood >= 15 && whatBlood <= 40)
            {

                BloodStatus = "Mugglarfödd";
                MessageBox.Show(BloodStatus);
            }
            if (whatBlood >= 5 && whatBlood <= 15)
            {

                BloodStatus = "Fullblod";
                MessageBox.Show(BloodStatus);

            }


            if (whatBlood > 0 && whatBlood <= 5)
            {

                BloodStatus = "Okänt";
                MessageBox.Show(BloodStatus);
            }



        }

        public bool WizzyDeathEater() 
        {

          Random deathEater = new Random();
            int isDeathEater = deathEater.Next(1, 101);

            if (BloodStatus == "Halvblod")
            {
                if (isDeathEater > 0 && isDeathEater <= 25) 
                {
                    
                    DeathEater= true;

                }       

            }


            if (BloodStatus == "Mugglarfödd")
            {
                if (isDeathEater >= 25 && isDeathEater <= 40)
                {

                    DeathEater = true;

                }

            }


            if (BloodStatus == "Fullblod")
            {
                if (isDeathEater > 40 && isDeathEater <= 100)
                {

                    DeathEater = true;

                }

            }

            if (BloodStatus == "Okänt")
            {
                if (isDeathEater > 0 && isDeathEater <= 25)
                {

                    DeathEater = true;

                }

            }

            return false;
        }
       
        
            
           



        


    }
}
