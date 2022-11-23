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

namespace testfl10
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
            //genom att skiva såhär når vi koden i klassen farm


            //2 3 5 = 36
            //int totalLegsCount = farm.GetAnimalLegCount(chickens: 2, cows: 3, pigs: 5); //när den körts klart blir den slutligen 10
            //                                                                            //flytta metod till klass
            //totalLegsCount = farm.GetAnimalLegCount(1, 2, 3); //mer otydligt


            //låt djuren flytta in på farmen

            FirstLetterVowel("andra katter");


        }


        public bool FirstLetterVowel(string newPassword)
        {
            char[] vowels = new char[] { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };

            foreach (char c in vowels)
            {

                if (newPassword.StartsWith(c))
                {
                    MessageBox.Show("Första bokstaven är en vokal");
                    return true;
                   
                }
            }
            MessageBox.Show("Första bokstaven är INTE en vokal");
            return false;

        }





    }
}   
