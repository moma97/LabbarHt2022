using Accessibility;
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

namespace uppgift_15
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

        private void btncalc_Click(object sender, RoutedEventArgs e)
        {
            char letter = char.Parse(txtletter.Text);
            string textinput = txtinput.Text; //en array i sig själv
            int count = 0;
                       
          
            for (int i = 0; i < textinput.Length; i++)
            {
                if (textinput[i] == letter)

                    count++;

            }


            lblresult.Content = ($"Hittade bokstaven {letter} {count} gånger");

        }
    }
}
