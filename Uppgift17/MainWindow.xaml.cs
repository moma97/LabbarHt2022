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

        private void btnconvert_Click(object sender, RoutedEventArgs e)
        {
            string myText = txtboxinput.Text;

            lblvowels.Content = ($"Antal vokaler {NumberOfVowels(myText)}");

            txtblockjibberish.Text = Jibberish(myText);
        }
    }
}
