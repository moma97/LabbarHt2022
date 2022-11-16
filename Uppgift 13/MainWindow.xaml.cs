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

namespace Uppgift_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // datatyp, array, skriver i denna del så jag slipper upprepa mig 
        string[] fruits = { "äpple", "päron", "banan", "ananas", "melon", "kiwi" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnfirst_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Första frukten i listan är: " + fruits[0]);

        }

        private void btnmiddle_Click(object sender, RoutedEventArgs e)
        {

            //skapa två olika if satser, ena där antalet frukter är jämnt delbart med två och en där den inte är det. Vid jämnt delbart med två, visa två mitten värden, om inte delbart, visa endast 1


            // om fruits[fruit.Lenght -1] är sista rutan så borde jag kunna använda samma koncept att få fram mitten värden oavsett hur många som finns. 

            int middlefruit = fruits.Length;

            string middfruit = fruits[middlefruit / 2];

            string middfruit2 = fruits[middlefruit / 2 - 1];

            if (middlefruit % 2 == 0)
                MessageBox.Show("Frukterna i mitten är: " + middfruit + " och " + middfruit2);

            else
                MessageBox.Show("frukten i mitten är: " + middfruit);

            

        }

        private void btnlast_Click(object sender, RoutedEventArgs e)
        {      
            //skapa en variabel för den sista frukten i arrayen

            string lastFruit = fruits[fruits.Length - 1];

            MessageBox.Show("Sista frukten i listan är: " + lastFruit);
        }
    }
}
