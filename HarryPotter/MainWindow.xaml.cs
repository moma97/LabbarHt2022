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

namespace HarryPotter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hogwarts hogwarts = new Hogwarts();


        //House house= new House(); ///tog bort abstract ,vet ej om det blir kaos då? 

        House hufflepuff = new Hufflepuff();
        House gryffindor = new Gryffindor();
        House ravenclaw = new Ravenclaw();
        House slytherin = new Slytherin();
        int count = 0;

        public MainWindow()
        {

            InitializeComponent();
            CmbBoxDisplay();
        }



        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {
            Wizard wizard= new Wizard();
            hogwarts.SortingHat(wizard);

            House house = hogwarts.SortingHat(wizard);


        }

        private void cboHouses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }



        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            string currentPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;

          

            Object selectedItem = cboHouses.SelectedItem;
            if (selectedItem == hogwarts.Gryffindor) 
            
            {
                if (gryffindor.SetPassword(currentPassword, newPassword) && gryffindor.HasCorrectPasswordFormat(newPassword))
                {
                   
                   MessageBox.Show("Ditt lösenord har nu ändrats!");
                }
                else
                {
                  MessageBox.Show("Antingen matchar inte lösenorden med varandra, eller så har det nya lösenordet felaktigt format");
                }


            }

            if (selectedItem == hogwarts.Hufflepuff)
            
            {

                if (hufflepuff.SetPassword(currentPassword, newPassword) && hufflepuff.HasCorrectPasswordFormat(newPassword))
                {
                    
                    MessageBox.Show("Ditt lösenord har nu ändrats!");
                }
                else
                {
                    MessageBox.Show("Antingen matchar inte lösenorden med varandra, eller så har det nya lösenordet felaktigt format");
                }


            }

            if (selectedItem == hogwarts.Ravenclaw)

            {
                if (ravenclaw.SetPassword(currentPassword, newPassword) && ravenclaw.HasCorrectPasswordFormat(newPassword))
                {
                   
                    MessageBox.Show("Ditt lösenord har nu ändrats!");
                }
                else
                {
                    MessageBox.Show("Antingen matchar inte lösenorden med varandra, eller så har det nya lösenordet felaktigt format");
                }


            }

            if (selectedItem == hogwarts.Slytherin)

            {
                if (slytherin.SetPassword(currentPassword, newPassword) && slytherin.HasCorrectPasswordFormat(newPassword))
                {
                   
                    MessageBox.Show("Ditt lösenord har nu ändrats!");
                }
                else
                {
                    MessageBox.Show("Antingen matchar inte lösenorden med varandra, eller så har det nya lösenordet felaktigt format");
                }


            }




        }

















        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    House hufflepuff = new Hufflepuff();

        //    bool successh =hufflepuff.HasCorrectPasswordFormat("en ensam trollkarl"); //true

        //    successh =hufflepuff.HasCorrectPasswordFormat("en ensam trollkvinna");  //false

        //    //SetPassword(string currentPassword, string newPassword)
        //    bool successf = hufflepuff.SetPassword("en ensam trollkarl", "alla får vara mea");   //false
        //    successf = hufflepuff.SetPassword("en ensam trollkarl", "alla får vara med"); //true //den byter faktiskt lösenordet, men endast i knappklicket.





        //    House gryffindor = new Gryffindor();

        //    bool successg = gryffindor.HasCorrectPasswordFormat("en hårig älg"); //true
        //    successg = gryffindor.HasCorrectPasswordFormat("boken av häxkonst"); //false

        //    gryffindor.SetPassword("en gullig gris", "en rolig räv"); //den byter lösenord



        //    House ravenclaw = new Ravenclaw();

        //    ravenclaw.HasCorrectPasswordFormat("en snäll kanin");  //true
        //    ravenclaw.HasCorrectPasswordFormat("en taskig pojke"); //false

        //    ravenclaw.SetPassword("öron vax", "en ful hörlur"); //byter lösen



        //    House slytherin = new Slytherin();

        //    bool success = slytherin.HasCorrectPasswordFormat("baaaaaaab"); // true
        //    success = slytherin.HasCorrectPasswordFormat("eaaaaaae");  //false

        //    bool ksuccess = slytherin.SetPassword("cenblodig", "caaaaaac"); //true
        //    //ksuccess = slytherin.SetPassword("cenblodiiiig", "cbbbbbbbc");  //false



        //}


        public void CmbBoxDisplay()
        {
            cboHouses.Items.Add(hogwarts.Gryffindor);
            cboHouses.Items.Add(hogwarts.Hufflepuff);
            cboHouses.Items.Add(hogwarts.Slytherin);
            cboHouses.Items.Add(hogwarts.Ravenclaw);

        }

        private void btntesta_Click(object sender, RoutedEventArgs e)
        {
            Wizard wizard = new Wizard();


            wizard.Name = txtNewWizardName.Text;

            wizard.WizzyBloodStatus();
            wizard.WizzyDeathEater();
            wizard.DumbledoresArmy();

            txtName.Text = wizard.Name;

          
            if (wizard.DeathEater)
            {
                chkDeatheater.IsChecked = true;

            }
            if (wizard.DumbledoorsArmy)
            {

                chkArmy.IsChecked = true;
            }


            
          



                            txtName.Clear();
            chkArmy.IsChecked = false;
            chkDeatheater.IsChecked = false;

        } 

      
        


    }
}
