using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Uppgift9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // deklaraera datatyp, variebel namn samt värden 

        double exchangerategall = 0.01612383102225;
        double exchangeratesikel = 0.274105127378265;
        double exchangerateknut = 7.949048693969687;


        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // ta värde från text ruta, geonomför uträkning, se till att svaret blir i hela kronor

            double Galleoner = double.Parse(txtGalleoner.Text);

            double ResultGalleoner = Galleoner / exchangerategall;


            ResultGalleoner = Math.Round(ResultGalleoner, 0);




            double Sikel = double.Parse(txtSiklar.Text);

            double ResultSikel = Sikel / exchangeratesikel;

            ResultSikel = Math.Round(ResultSikel, 0);




            double Knuting = double.Parse(txtKnutar.Text);

            double ResultKnutingar = Knuting / exchangerateknut;

            ResultKnutingar = Math.Round(ResultKnutingar, 0);


            lblsumma.Content = ResultSikel + ResultGalleoner + ResultKnutingar + " SEK";



            //Smidigare lösning efter studiegrupp 

            //  double sek = (Galleoner / exchangerategall) + (Sikel / exchangeratesikel) + (Knuting / exchangerateknut);

            //  sek = Math.Round(sek, 0);

            //  lblsumma.Content = sek + "SEK"; 


        }
    }
}
