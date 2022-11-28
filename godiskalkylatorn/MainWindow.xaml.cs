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

namespace godiskalkylatorn
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
    

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
        

            
            Person person1= new Person();
            CandyCalculator person2= new CandyCalculator();
            
            int personAge = int.Parse(txtAge.Text);


            person2.AddPerson(txtFirstname.Text, txtLastname.Text, personAge);


          
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = person2.personList;

            ////6 clear text rutorna

            //txtFirstname.Clear();
            //txtLastname.Clear();
            //txtAge.Clear();
        }
    }
}
