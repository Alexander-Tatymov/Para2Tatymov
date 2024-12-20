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

namespace Pract_2_Iwanov
{
    /// <summary>
    /// Логика взаимодействия для Okno2.xaml
    /// </summary>
    public partial class Okno2 : Window
    {
        public Okno2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window MainWindow = new MainWindow();
            MainWindow.Closed += (s, args) => this.Close();
            MainWindow.Show();
        }

        private void AlarmButton_Click(object sender, RoutedEventArgs e)
        {
            AlarmButton.Content = "Текст";
            AlarmButton.Visibility = Visibility.Hidden;
            TextTest.Text = "Написано же - не нажимать!";
            TextTest.Background = Brushes.Red;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window MainWindow = new MainWindow();
            MainWindow.Closed += (s, args) => this.Close();
            MainWindow.Show();
        }
    }
}
