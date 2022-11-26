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
        //1. skapar lista,av datatypen person som kan innehålla personobjekt
        List<Person> Persons = new List<Person>();

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            //2 när jag trycker på knappen vill vi skapa ett objekt av klassen person
            //för att skapa ett obj för den klassen så måste man först ange namnet på klassen (Person)
            // sen en objekt referens, kalla den vad som helst 
            //via den kan jag komma åt alla klassmedlemmar, som ligger i klassen person,property, metod, variabler 
            Person person = new Person();

            //3 det som matas in lagras till egenskapen, skriver på såsätt för att komma åt den  
            person.Firstname = txtFirstname.Text;
            person.Lastname = txtLastname.Text;
            person.Age= txtAge.Text;

            //4 nästa steg är att lägga till personen(objeketet) i vår lista , skriv namnet på listan +add();

            Persons.Add(person);


            //5 för att visa personen på listan och knyta den till en data källa gör vi såhär
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = Persons;

            //6 clear text rutorna

            //txtFirstname.Clear();
            //txtLastname.Clear();
            //txtAge.Clear();
        }
    }
}
