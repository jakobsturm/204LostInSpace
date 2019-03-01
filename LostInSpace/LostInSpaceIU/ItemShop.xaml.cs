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
using System.Windows.Shapes;

namespace LostInSpaceUI
{
    /// <summary>
    /// Interaktionslogik für ItemShop.xaml
    /// </summary>
    public partial class ItemShop : Window
    {
        public ItemShop()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string current = button_caption.Text;
            int cur = Convert.ToInt32(current.Substring(0, 1));
            cur++;
            button_caption.Text = cur + "x";
        }
        
    }
}
