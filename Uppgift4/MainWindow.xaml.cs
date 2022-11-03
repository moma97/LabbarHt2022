using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Uppgift_4
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

        private void knapp_Click(object sender, RoutedEventArgs e)
        {
            label.Visibility = Visibility.Visible;

            //btn.Content = "Visa lösenord";

            if (btn.Content == "Visa lösenord")
            {


                btn.Content = "Dölj lösenord";
                

            }


            else 
            {
                btn.Content = "Visa lösenord";

                label.Visibility = Visibility.Collapsed;


            }




        }
    }
}
