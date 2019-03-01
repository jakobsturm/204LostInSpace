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
using System.Windows.Threading;

namespace LostInSpaceUI
{
    /// <summary>
    /// Interaktionslogik für StartUp.xaml
    /// </summary>
    public partial class ProgressWindow : Window, INotifyPropertyChanged 
    {
        DispatcherTimer timer;
        private double progress;

        public ProgressWindow()
        {
            InitializeComponent();
            DataContext = this;

            this.Focus();
            Progress = 0;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,0,0,50);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Progress < 100)
            {
                Progress++;
            }
            else
            {
                timer.Stop();
                Application.Current.Dispatcher.Invoke(new Action(() => this.Close()));
            }
        }

        public double Progress
        {
            get { return progress; }
            set
            {
                progress = value;
                Application.Current.Dispatcher.Invoke(new Action (()=> OnPropertyChanged("Progress")));
            }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
