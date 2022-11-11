using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
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

namespace Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Trainingsplan
    {
        string name;

        public Trainingsplan(string _name)
        {
            name = _name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Trainingsplan> trainingsplans = new List<Trainingsplan>();

        SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\Christopher\\OneDrive\\Desktop\\Hear Me Tonight.wav");
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState |= WindowState.Maximized;
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            soundPlayer.Play();
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            soundPlayer.Stop();
        }

        private void HoverButton_Click(object sender, RoutedEventArgs e)
        {
            Trainingsplan plan = new Trainingsplan("Neuer Plan " + (trainingsplans.Count + 1));
            trainingsplans.Add(plan);   

            TrainingsplanListView.Items.Add(plan.Name);
        }
    }
}
