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
        char birthYear;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, RoutedEventArgs e)
        {
            // när knappen klickas på vill jag beräkna åldern utifrån födelseåret





            OnlyLettersInBirthyear();



        }







        private void OnlyLettersInBirthyear()
        {

            //bool isItALetter;
            char input = char.Parse(txtinput.Text);

            MessageBox.Show(char.IsLetter(input).ToString());

            char.IsLetter(input);

            //string textinput = txtinput.Text;
            //bool isaLetter(char c);

            
            //isItALetter = 

            //Char.IsLetter(input);
            // tror även det endast är första bokstaven den går utifrån                  



            //for (int i = 0; i < textinput.Length; i++)
            //{
            //    Char.IsLetter(textinput);

            //    if (true)

            //    {
            //        MessageBox.Show("Du måste mata in enbart siffror");
            //    }

            //    else
            //        MessageBox.Show("Du har enbart matat in siffror");









            }



        }



    }
