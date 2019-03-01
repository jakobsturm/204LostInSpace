using LostInSpace;
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

namespace LostInSpaceUI
{
    /// <summary>
    /// Interaktionslogik für StartMenu.xaml
    /// </summary>
    public partial class StartMenu: Window
    {
        Game1 game;
        public StartMenu()
        {
            InitializeComponent();
            StartUp startUp = new StartUp();
            startUp.ShowDialog();
        }

        private void Button_StartGame_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            using(var game = new Game1(100f))
            game.Run();
        }

        private void Button_ItemShop_Click(object sender, RoutedEventArgs e)
        {
            ItemShop itemShop = new ItemShop();
            itemShop.ShowDialog();
        }

        private void Button_Settings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
