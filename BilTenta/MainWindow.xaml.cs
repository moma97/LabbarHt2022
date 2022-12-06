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

namespace BilTenta
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

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            int totalVikt = int.Parse(txtTotalWeight.Text);

            int släpBWeight = CalcB(totalVikt);
            lblsläpb.Content = släpBWeight;


            int släpUB = CalcUB(totalVikt);
            lblsläpub.Content = släpUB;
            
            

        }

        private int CalcB(int totWeight)
        {
            int allowedWeight = 3500 - totWeight;
            return allowedWeight;
        }

        private int CalcUB(int totalWeight)
        {
            int allowedWeight = 4250 - totalWeight;
            return allowedWeight;


        }


    }
}
