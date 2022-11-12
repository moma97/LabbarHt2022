using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Uppgift11
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random slump = new Random();
            

            int slumptal=slump.Next(1000);

            lbltemp.Content = slumptal.ToString();
              

        }

        private void btnguess_Click(object sender, RoutedEventArgs e)
        {

            int slumptal = int.Parse((string)lbltemp.Content);

            lbltemp.Content = slumptal.ToString();


            int guess = int.Parse(txtguess.Text);


            if (guess > slumptal)

                txtblock.Text = ("Oh, du är inte ens nära. Du gissade alldeles för stort");

            if (guess < slumptal)

                txtblock.Text = ("Oh, du är inte ens nära. Du gissade alldeles för litet");


            if (guess == slumptal)


                txtblock.Text = ("Din gissning är korrekt! :)");



        }


      

    }
}
