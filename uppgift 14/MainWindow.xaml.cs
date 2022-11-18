﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace uppgift_14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] values = new double[5]; //clean code, global 
        

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnok_Click(object sender, RoutedEventArgs e)
        {                  

            double input = double.Parse(txtnumber.Text);
            listBoxValues.Items.Add(input);    //förstod mig inte på itemsSource så jag plockade bort det och använde mig av dessa istället

            if (listBoxValues.Items.Count == 5 )  // count är en inbyggd funktion som räknar 
            
            {

                for (int i = 0; i < listBoxValues.Items.Count; i++)
                {

                    values[i] = double.Parse(listBoxValues.Items[i].ToString());

                }


            }

            if (listBoxValues.Items.Count >= 5 ) 
            
            { 
                btnok.IsEnabled= false;
                btnreset.Visibility = Visibility.Visible;

            }


            double mean = values.Sum();
            txtmedel.Text = (mean / 5).ToString();
                     
        }

        private void btnreset_Click(object sender, RoutedEventArgs e)
        {
            listBoxValues.Items.Clear();
            txtnumber.Text = string.Empty;
            txtmedel.Text = string.Empty;
            txtnumber.Focus();
            btnok.IsEnabled= true;
            btnreset.Visibility= Visibility.Hidden;
        }
    }

}