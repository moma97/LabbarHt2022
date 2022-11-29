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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            House hufflepuff = new Hufflepuff();

            bool successh =hufflepuff.HasCorrectPasswordFormat("en ensam trollkarl"); //true
                
            successh =hufflepuff.HasCorrectPasswordFormat("en ensam trollkvinna");  //false

            //SetPassword(string currentPassword, string newPassword)
            bool successf = hufflepuff.SetPassword("en ensam trollkarl", "alla får vara mea");   //false
            successf = hufflepuff.SetPassword("en ensam trollkarl", "alla får vara med"); //true //den byter faktiskt lösenordet, men endast i knappklicket.
            




            House gryffindor = new Gryffindor();

            bool successg = gryffindor.HasCorrectPasswordFormat("en hårig älg"); //true
            successg = gryffindor.HasCorrectPasswordFormat("boken av häxkonst"); //false

            gryffindor.SetPassword("en gullig gris", "en rolig räv"); //den byter lösenord



            House ravenclaw = new Ravenclaw();

            ravenclaw.HasCorrectPasswordFormat("en snäll kanin");  //true
            ravenclaw.HasCorrectPasswordFormat("en taskig pojke"); //false

            ravenclaw.SetPassword("öron vax", "en ful hörlur"); //byter lösen

            
            
            House slytherin = new Slytherin();

            bool success = slytherin.HasCorrectPasswordFormat("baaaaaaab"); // true
            success = slytherin.HasCorrectPasswordFormat("eaaaaaae");  //false

            bool ksuccess = slytherin.SetPassword("cenblodig", "caaaaaac"); //true
            //ksuccess = slytherin.SetPassword("cenblodiiiig", "cbbbbbbbc");  //false



        }

        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cboHouses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboHouses.Items.Add(hogwarts.Gryffindor);
            cboHouses.Items.Add(hogwarts.Hufflepuff);
            cboHouses.Items.Add(hogwarts.Slytherin);
            cboHouses.Items.Add(hogwarts.Ravenclaw);

        }
    }
}
