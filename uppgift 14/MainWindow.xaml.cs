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


        public MainWindow()
        {
            InitializeComponent();
        }

        //new int[4];

        private void btnok_Click(object sender, RoutedEventArgs e)
        {

            int[] values = { 0, 1, 2, 3, 4 };

            int input = int.Parse(txtnumber.Text);

            

            listBoxValues.ItemsSource = null;
            listBoxValues.ItemsSource = values;

          
            
                values[0] = input;
            

                


         
            
                //MessageBox.Show(values.ToString());


            //  antalggrklickat++; //öka med 1 steg

            //MessageBox.Show(antalggrklickat.ToString()); ;



        }
    }

}
