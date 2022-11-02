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

namespace Uppgift5
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

       
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // int är data typ number1 variabelnamn, efter = har vi tilldelat värde 

          
            
            int number1 = int.Parse(txtnumber1.Text);
            int number2 = int.Parse(txtnumber2.Text);

            int result = number1 + number2;
           
            
            
            txtresult.Text = result.ToString(); 
                   
            
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtnumber1.Clear();
            txtnumber2.Clear();
            txtresult.Clear();
        }
    }
}
