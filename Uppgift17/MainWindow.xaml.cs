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

namespace Uppgift17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] vowels = new char[] { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Räknar ut hur många vokaler som finns i texten
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private int NumberOfVowels(string text)
        {
            char[] bigVowels = new char[] { 'A', 'O', 'U', 'Å', 'E', 'I', 'Y', 'Ä', 'Ö' };

            int count = 0;
            foreach (char c in text) 
            {
                if (IsVowels(c) || bigVowels.Contains(c))

                    count++;
            }
            return count;
        }

        /// <summary>
        /// inkluderar stora bokstäver, introducerar ny variabel och använder tidigare metod IsVowels för att byta ut bokstäverna
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string Jibberish(string text)
        {
            char[] bigVowels = new char[] {'A', 'O', 'U', 'Å', 'E', 'I', 'Y', 'Ä', 'Ö'};

            string a = "";

            foreach (char c in text)
            {

                if (IsVowels(c))
                {

                    a += 'ö';


                }
                else if (bigVowels.Contains(c))
                {
                    a += 'Ö';
                }
                else
                {

                    a += c;
                }
            }
            return a;
        }


        /// <summary>
        /// bestämmer vilka bokstäver i strängen som är vokaler, går igenom bokstäverna i arrayen 
        /// </summary>
        /// <param name="asdText"></param>
        /// <returns></returns>
        private bool IsVowels(char asdText)
        {
            for (int i = 0; i < vowels.Length; i++)
            {
                if (asdText == vowels[i])
                {
                    return true;
                }
            }

           return false;

        }
        /// <summary>
        /// skriver ut resultaten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnconvert_Click(object sender, RoutedEventArgs e)
        {
            string myText = txtboxinput.Text;

            lblvowels.Content = ($"Antal vokaler {NumberOfVowels(myText)}");

            txtblockjibberish.Text = Jibberish(myText);
        }
    }
}
