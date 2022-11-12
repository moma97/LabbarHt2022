using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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

namespace Uppgift10a
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

        private void btncontroll_Click(object sender, RoutedEventArgs e)
        {
            //deklarera variabler ge värde

            int age;    
            
            age = int.Parse(txtage.Text);

            //mindre än sju och radioknappen är i klickad

            if (age < 7 && rdmedvuxen.IsChecked == true)
            
                txtblock.Text = ($"Hej {txtname.Text}. Du är {txtage.Text} år gammal och får se filmer med åldersgräns upp till 7 år eftersom du har en vuxen med dig");

             else

                   txtblock.Text = ($"Hej {txtname.Text}. Du är {txtage.Text} år gammal och du får se barntillåtna filmer men du måste ha med en vuxen för att få se filmer med 7 års åldersgräns");





            // större än 7 och mindre än 10
            
            

            if (age >= 7 && age <= 10 && rdmedvuxen.IsChecked == true)

            

                txtblock.Text = ($"Hej {txtname.Text}. Du är {txtage.Text} år gammal och får se filmer med åldersgräns upp till 11 år eftersom du har en vuxen med dig");

            

            if (age >= 7 && age <= 10 && rdmedvuxen.IsChecked == false)

            
                txtblock.Text = ($"Hej {txtname.Text}. Du är {txtage.Text} år gammal och får se filmer med åldersgräns upp till 7 år");






            // större än eller lika med 11 och mindre än eller lika med 14

            if (age >= 11 && age <= 14 && rdmedvuxen.IsChecked == true) 

            
                txtblock.Text = ($"Hej {txtname.Text}. Du är {txtage.Text} år gammal och får se filmer med åldersgräns upp till 11 år oavsett om du går tillsammans med en vuxen eller inte");

            
              
            if (age >= 11 && age <= 14 && rdmedvuxen.IsChecked == false)


                txtblock.Text = ($"Hej {txtname.Text}. Du är {txtage.Text} år gammal och får se filmer med åldersgräns upp till 11 år.");




            if (age >= 15)

            
                txtblock.Text = ($"Hej {txtname.Text}. Du är {txtage.Text} år gammal och får se alla filmer");

        }
            

            


                      
                  
        


    }
}
