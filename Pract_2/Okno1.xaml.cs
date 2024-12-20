using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pract_2_Iwanov
{
    /// <summary>
    /// Логика взаимодействия для Okno1.xaml
    /// </summary>
    public partial class Okno1 : Window
    {
        public Okno1()
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
    
        private void Knopka_Click(object sender, RoutedEventArgs e)
        {
            int maxLeft = Convert.ToInt32(Grid1.ActualWidth - Knopka.Width);
            int maxTop = Convert.ToInt32(Grid1.ActualHeight - Knopka.Height);
            Random rand = new Random();
            Knopka.Margin = new Thickness(rand.Next(maxLeft), rand.Next(maxTop), 0, 0);
        }
    }
}
