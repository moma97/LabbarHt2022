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

namespace Uppgift6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnrensa_Click(object sender, RoutedEventArgs e)
        {
            txttal1.Clear();
            txttal2.Clear();
            txtresultat.Clear();

            lblresultat.Content = "Resultat"; 



        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            

            //Datatyp variabelnamn värde konverterat

            double tal1 = double.Parse(txttal1.Text);


            double tal2 = double.Parse(txttal2.Text);

        
            double resultat = tal1 + tal2;
         

            // tostring i slutet för att konvertera heltalet till sträng

            txtresultat.Text = resultat.ToString();


            lblresultat.Content = "Summa";

        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {

            double tal1 = double.Parse(txttal1.Text);
            double tal2 = double.Parse(txttal2.Text);
            double diff = tal1 - tal2;

            txtresultat.Text = diff.ToString();


            lblresultat.Content = "Differens";




        }

        private void btngånger_Click(object sender, RoutedEventArgs e)
        {

            double tal1 = double.Parse(txttal1.Text);
            double tal2 = double.Parse(txttal2.Text);
            double product = tal1 * tal2;

            txtresultat.Text = product.ToString();


            lblresultat.Content = "Produkt";
        }

        private void btndivision_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = double.Parse(txttal1.Text);
            double tal2 = double.Parse(txttal2.Text);
            double division = tal1 / tal2;

            txtresultat.Text = division.ToString();


            lblresultat.Content = "Kvot";

                 
            double add = tal1 / tal2;

            add = Math.Round(add, 2);
            txtresultat.Text = add.ToString();
            
        }
    }
}
