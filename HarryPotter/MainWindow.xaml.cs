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
        
        int count = 0;

        public MainWindow()
        {

            InitializeComponent();
            CmbBoxDisplay();
            MascotLabels();
        }

        
        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {
        
            
            Wizard wizard = new Wizard(txtNewWizardName.Text); //skapar ett object av klassen wizard med namnet som indata 
            House house = hogwarts.SortingHat(wizard); //house är en bas klass, metoden returnerar ett objekt av klassen house och det går därför att göra så

            if (wizard.DeathEater)
            {
                chkDeatheater.IsChecked = true;

            }

            if (wizard.DumbledoorsArmy)
            {

                chkArmy.IsChecked = true;
            }
            if (wizard.DeathEater == false)
            {

                chkDeatheater.IsChecked = false;
            }
            if (wizard.DumbledoorsArmy == false)
            {
                chkArmy.IsChecked = false;
            }

            DisplayListgryff();
            DisplayListHuffle();
            DisplayListRaven();
            DisplayListSlyth();                              

            MessageBox.Show($"{wizard} är numera medlem nr {house.Members.Count} i {house}. {house.HouseGhost} kommer ta väl hand om dig.");
        }

         


        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            string currentPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;

            House house = (House)cboHouses.SelectedItem;
            house.SetPassword(currentPassword, newPassword);
           
        }

    




        public void CmbBoxDisplay()
        {
            cboHouses.Items.Add(hogwarts.Gryffindor);
            cboHouses.Items.Add(hogwarts.Hufflepuff);
            cboHouses.Items.Add(hogwarts.Slytherin);
            cboHouses.Items.Add(hogwarts.Ravenclaw);

        }




        public void DisplayListgryff()
        {
            lstGryffindor.ItemsSource = null;
            lstGryffindor.ItemsSource = hogwarts.Gryffindor.Members;

        }

        public void DisplayListHuffle()
        {

            lstHufflepuff.ItemsSource = null;
            lstHufflepuff.ItemsSource = hogwarts.Hufflepuff.Members;
        }

        public void DisplayListRaven()
        {

            lstRavenclaw.ItemsSource = null;
            lstRavenclaw.ItemsSource = hogwarts.Ravenclaw.Members;

        }

        public void DisplayListSlyth()
        {
            lstSlytherin.ItemsSource = null;
            lstSlytherin.ItemsSource = hogwarts.Slytherin.Members;

        }



        

        private void MascotLabels()
        {

            lblGryffindorMascot.Content = hogwarts.Gryffindor.Mascot;
            lblHufflepuffMascot.Content = hogwarts.Hufflepuff.Mascot;
            lblRavenclawMascot.Content = hogwarts.Ravenclaw.Mascot;
            lblSlytherinMascot.Content = hogwarts.Slytherin.Mascot;

        }




        //https://www.codeproject.com/Questions/311720/Access-listbox-item-by-double-click 
        private void lstHufflepuff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Wizard wizard = (Wizard)lstHufflepuff.SelectedItem;
            chkDeatheater.IsChecked = wizard.DeathEater;
            chkArmy.IsChecked = wizard.DumbledoorsArmy;
            txtName.Text = wizard.Name;
            txtNewWizardName.Clear();
        }

        private void lstRavenclaw_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Wizard wizard = (Wizard)lstRavenclaw.SelectedItem;
            chkDeatheater.IsChecked = wizard.DeathEater;
            chkArmy.IsChecked = wizard.DumbledoorsArmy;
            txtName.Text = wizard.Name;
            txtNewWizardName.Clear();
        }

        private void lstGryffindor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Wizard wizard = (Wizard)lstGryffindor.SelectedItem;
            chkDeatheater.IsChecked = wizard.DeathEater;
            chkArmy.IsChecked = wizard.DumbledoorsArmy;
            txtName.Text = wizard.Name;
            txtNewWizardName.Clear();
        }

        private void lstSlytherin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Wizard wizard = (Wizard)lstSlytherin.SelectedItem;
            chkDeatheater.IsChecked = wizard.DeathEater;
            chkArmy.IsChecked = wizard.DumbledoorsArmy;
            txtName.Text = wizard.Name;
            txtNewWizardName.Clear();
        }

   


    }
}
