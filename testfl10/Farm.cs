using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace testfl10
{
    internal class Farm
    { //farmen har djur

        public List<Chicken> Chickens { get; set; } = new List<Chicken>();

        public List<Cow> Cows { get; set; } = new List<Cow>();

        public List<Pig> Pigs { get; set; } = new List<Pig>();







        public int GetAnimalLegCount(int chickens, int cows, int pigs) //metod för att räkna djurben 
        { //hur många ben varje djur har
          //metoden flyttades från mainwindow för att kunna anv den där
            int legsChicken = 2, legsCows = 4, legsPigs = 4;


            return chickens * legsChicken + cows * legsCows + pigs * legsPigs;



        }

        public int GetAnimalLegCount()  //ny metod 
        {
            int countPigs, countCows, countchickens;

            countCows = Cows.Count;
            return countCows;

        }










    }




}

   
