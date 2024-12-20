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

namespace Pract_2_Tatymov
{

    public partial class Okno : Window
    {
        public Okno()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window MainWindow = new MainWindow();
            MainWindow.Closed += (s, args) => this.Close();
            MainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RED.Fill = Brushes.Red;
            YELLOW.Fill = Brushes.White;
            GREEN.Fill = Brushes.White;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            YELLOW.Fill = Brushes.Yellow;
            RED.Fill = Brushes.White;
            GREEN.Fill = Brushes.White;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GREEN.Fill = Brushes.Green;
            RED.Fill = Brushes.White;
            YELLOW.Fill = Brushes.White;
        }
    }
}
