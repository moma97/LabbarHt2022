﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace Uppgift_3
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

        private void Knapp1_Click(object sender, RoutedEventArgs e)
        {
            Knapp1.Content = "klickad";
            Knapp2.Content = "Oklickad";
        }

        private void Knapp2_Click(object sender, RoutedEventArgs e)
        {
            Knapp2.Content = "Klickad";
            Knapp1.Content = "Oklickad";
        }
    }
}
