using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace uppgift_14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] values = new double[5]; //clean code, global 
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnok_Click(object sender, RoutedEventArgs e)
        {                  

           

            double value = double.Parse(txtnumber.Text);
            values[counter] = value;
            counter++;
            
            listBoxValues.ItemsSource = null;
            listBoxValues.ItemsSource = values;

            txtnumber.Clear();


            double mean = values.Sum();

           

            if (counter >= 5) 

            {
                btnok.IsEnabled = false;
                btnreset.Visibility = Visibility.Visible;
                txtmedel.Text = (mean / 5).ToString();
            }
                                                                  

        }


        private void btnreset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            txtnumber.Focus();
            btnok.IsEnabled= true;
            btnreset.Visibility= Visibility.Hidden;
        }

        private void Reset()
        {
            listBoxValues.ItemsSource = null;
            txtnumber.Clear();
            txtmedel.Clear();

        }



    }

}
