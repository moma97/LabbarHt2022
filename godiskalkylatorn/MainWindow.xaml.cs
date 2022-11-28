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
          CandyCalculator candycalculator = new CandyCalculator();
        

        private void btnadd_Click(object sender, RoutedEventArgs e)
            {
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            int personAge = int.Parse(txtAge.Text);

            AddPerson(firstName, lastName,personAge);

                      
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = candycalculator.personList;

            Clear();

        }

        private void btnsplit_Click(object sender, RoutedEventArgs e)
        {
           
            int amountCandies = int.Parse(txtCandies.Text);
                   

            candycalculator.DistributeCandy(amountCandies);

            listbox1.ItemsSource = null;
            listbox1.ItemsSource = candycalculator.personList;

           


        }

        public void AddPerson(string inputFirst, string inputLast, int inputAge)  // denna metod är bättre för det blir inkapsling, mindre kod i main
        {

            Person person = new Person();
            person.Firstname = inputFirst;
            person.Lastname = inputLast;
            person.Age = inputAge;

            candycalculator.personList.Add(person);


        }

        public void Clear()
        {

            txtFirstname.Clear();
            txtLastname.Clear();
            txtAge.Clear();

        }

       
    }
}
