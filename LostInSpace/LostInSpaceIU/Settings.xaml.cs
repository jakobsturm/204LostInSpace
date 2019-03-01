using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaktionslogik für Settings.xaml
    /// </summary>
    public partial class Settings : Window, INotifyPropertyChanged
    {
         private double volume;
        private string imageSource;

        public Settings()
        {
            InitializeComponent();
            Volume = 50;
            ImageSource = "Images/volume_medium";
            DataContext = this;
        }


        public string ImageSource
        {
            get { return imageSource; }
            set
            {
                imageSource = value;
                OnPropertyChanged("ImageSource");
            }
        }


        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                OnPropertyChanged("Volume");


                if (volume <= 10)
                {
                    ImageSource = "Images/volume_mute";
                }
                else if (volume < 80 && volume > 10)
                {
                    ImageSource = "Images/volume_medium";
                }
                else if (volume <= 80)
                {
                    ImageSource = "Images/volume_loud";
                }
            }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
