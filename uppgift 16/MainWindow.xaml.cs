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

namespace uppgift_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        int age;
        int birthYear;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, RoutedEventArgs e)
        {
            
            string text = txtinput.Text;

            OnlyLettersInBirthyear(text);

            if (OnlyLettersInBirthyear(text) == true)
            {
                int age = CalcAge(int.Parse(text));
                MessageBox.Show($"Du är {age} år gammal");

            }
            else if (OnlyLettersInBirthyear(text) == false)
            {

                MessageBox.Show("Du måste mata in enbart siffror");
            }

        }

        /// <summary>
        /// går igenom texten, returnerar olika värden baserat på om det finns bokstav eller inte
        /// </summary>
        /// <param name="myText"></param>
        /// <returns></returns>
        private bool OnlyLettersInBirthyear(string myText)
        {
            foreach (char c in myText)
            {

                if (char.IsLetter(c))
                {
                    return false;
                                   
                }

            }
                   
            return true;
                      
        }

        /// <summary>
        /// Genomför beräkningen för din ålder
        /// </summary>
        /// <param name="birthYear"></param>
        /// <returns></returns>
        private int CalcAge(int birthYear)

        {
            int yearNow = DateTime.Now.Year;

            int age = yearNow - birthYear;

            return age;

        }
    }



}
