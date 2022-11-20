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

            if (OnlyLettersInBirthyear(text))
            {
                int age = CalcAge(int.Parse(text));
                MessageBox.Show($"Du är {age} år gammal");

            }
            else if (OnlyLettersInBirthyear(text) == false)
            {

                MessageBox.Show("Du måste mata in enbart siffror");
            }




        }







        private bool OnlyLettersInBirthyear(string myText)
        {

            string input = txtinput.Text;

            char[] array = input.ToCharArray();

            bool result;

            for (int i = 0; i < array.Length; i++)

            {
                array[i] = myText[i];

            }


                foreach (char c in myText)
            {


                if (char.IsLetter(c))
                {
                    return false;

                    //MessageBox.Show("enbart siffror");


                }

            }
           
            
            
            
            return true;

            //MessageBox.Show("beräkna år");




            //MessageBox.Show(result.ToString());
                             
            //return result;

           


        }


        private int CalcAge(int birthYear)

        {


            int yearNow = DateTime.Now.Year;

            int age = yearNow - birthYear;

            return age;

        }
    }



}
