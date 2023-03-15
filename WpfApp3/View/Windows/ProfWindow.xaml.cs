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

namespace WpfApp3.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProfWindow.xaml
    /// </summary>
    public partial class ProfWindow : Window
    {
        public ProfWindow()
        {
            InitializeComponent();
            this.DataContext = Helpers.ClassConnect.auth;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AuthRegWindow window = new AuthRegWindow();
            window.Show();
            Close();
        }
    }
}
