using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading;
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
using static System.Net.Mime.MediaTypeNames;

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
            CheckJSON();
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

            SaveJson();
            
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            candycalculator.DistributeCandyByAge();

            listbox1.ItemsSource = null;
            listbox1.ItemsSource = candycalculator.personList;

        }

        private void rdbtnfirstname_Checked(object sender, RoutedEventArgs e)
        {
            candycalculator.DistributeCandybyFirstName();
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = candycalculator.personList;

        }

        private void rdbtnlastname_Checked(object sender, RoutedEventArgs e)
        {
            candycalculator.DistributeCandyByLastName();
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = candycalculator.personList;

        }

       

        private void CheckJSON()
        {
            string fileName = "Candy.json";
            if (File.Exists(fileName))
            {
                candycalculator = FileHandler.Open<CandyCalculator>(fileName);

                listbox1.ItemsSource = null;
                listbox1.ItemsSource = candycalculator.personList;
            }
            else
            {
                listbox1.ItemsSource = null;
                listbox1.ItemsSource = candycalculator.personList;

            }

        }

        private void SaveJson()
        {

            string filename = "Candy.json";
            FileHandler.Save(candycalculator, filename);

        }


    }
}
