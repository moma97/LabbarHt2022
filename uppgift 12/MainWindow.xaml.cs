using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace uppgift_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      

        public MainWindow()
        {
            InitializeComponent();

            lblvalue.Content = pBar.Value + "%";

        }

        

        private void btnstart_Click(object sender, RoutedEventArgs e)
        {
                                 
            int antaltries = int.Parse(txttries.Text);
           

            // måste skapa en head/tails för att avgöra om en macka hamnar uppåt eller neråt, 50%

            int up = 0;
            int down = 0;

            int probability;
            probability = (int)pBar.Value;

            
            


            Random upOrDown = new Random();

            for (int i = 0; i < antaltries; i++)
            {
                int resultat = upOrDown.Next(1, 101); //1, 3
               
                //om resultatet (det randomiserade numret) är större än pBar värdet 

                if (resultat > probability)  //1  51-100
                {

                    up++;

                }

                else

                {
                    down++;
                }

                //få ut resultat i programmet

                lblup.Content = "Antal med smör upp " + up.ToString();

                lbldown.Content = "Antal med smör ner " + down.ToString();


            }


        }

        private void btnlessunlucky_Click(object sender, RoutedEventArgs e)
        {
            pBar.Value -= 5;
            lblvalue.Content = pBar.Value + "%";
        }

        private void btnmoreunlucky_Click(object sender, RoutedEventArgs e)
        {
            pBar.Value += 5;
            lblvalue.Content = pBar.Value + "%";
        }
    }

        

    }

   

