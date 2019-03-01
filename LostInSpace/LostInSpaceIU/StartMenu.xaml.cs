﻿using System;
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

namespace LostInSpaceUI
{
    /// <summary>
    /// Interaktionslogik für StartMenu.xaml
    /// </summary>
    public partial class StartMenu: Window
    {
        public StartMenu()
        {
            InitializeComponent();
            StartUp startUp = new StartUp();
            startUp.ShowDialog();
        }

        private void Button_StartGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ItemShop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}