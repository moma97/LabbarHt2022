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

        double Galleoner = 1;
        double Sikel = 17;
        double Knuting = 493;
        double SvenskaKronor = 62.02;
        double exchangerategall = 0.0161;


        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Galleoner = double.Parse(txtGalleoner.Text);

            lblsumma.Content = Galleoner / exchangerategall;

            

                 //double Sikel = double.Parse(txtSiklar.Text.ToString);
           // double Knuting = double.Parse(txtKnutar.Text);
        }
    }
}
