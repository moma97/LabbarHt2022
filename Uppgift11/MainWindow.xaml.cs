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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int antalklickar = 0;
        

        public MainWindow()
        {
            InitializeComponent();


            btnguess.IsEnabled = false;





        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random slump = new Random();
            

            int slumptal=slump.Next(1000);

            lbltemp.Content = slumptal.ToString();

            

            btnguess.IsEnabled = true;

            btnslumpa.IsEnabled = false; 

        }

        private void btnguess_Click(object sender, RoutedEventArgs e)
        {




            // datatyper variabler 

            int slumptal = int.Parse((string)lbltemp.Content);

            lbltemp.Content = slumptal.ToString();


            //Från FL 2

            antalklickar += 1;



            int guess = int.Parse(txtguess.Text);

            bool GuessIsWithinOneHundred = slumptal - guess > 0 && slumptal - guess < 100;

            // det ska bli negativt tal om gissningen är större än slumptalet 

            bool GuessIsWithinOneHundredSmaller = slumptal - guess < 0 && slumptal - guess > (-100);


            // if satser beroende på vad man gissar

            if (!GuessIsWithinOneHundred && !GuessIsWithinOneHundredSmaller && guess > slumptal)

                txtblock.Text = ("Oh, du är inte ens nära. Du gissade alldeles för stort");

            if (GuessIsWithinOneHundredSmaller)


                txtblock.Text = ("Du är nära men gissade för stort");



            if (!GuessIsWithinOneHundred && guess < slumptal)

                txtblock.Text = ("Oh, du är inte ens nära. Du gissade alldeles för litet");

            if (GuessIsWithinOneHundred)


                txtblock.Text = ("Du är nära men gissade för litet");


            if (guess == slumptal)

            { 
                txtblock.Text = ($"Din gissning är korrekt! Du gissade rätt efter {antalklickar} antal gissningar :)");

                btnslumpa.IsEnabled = true;
                btnguess.IsEnabled = false;

            }
           


        }


      

    }
}
