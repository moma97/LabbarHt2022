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

namespace IndexTest
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
        int antalklickat = 0;

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            //int[] antalklickat = new int[5];

            //antalklickat[]




            

            antalklickat++; //öka med 1 steg

            MessageBox.Show(antalklickat.ToString()); ;



        }
    }
}
