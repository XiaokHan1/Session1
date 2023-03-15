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
    /// Логика взаимодействия для AuthRegWindow.xaml
    /// </summary>
    public partial class AuthRegWindow : Window
    {
        public AuthRegWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var q = Helpers.ClassConnect.user.Auth.FirstOrDefault(i => i.Login == LogTb.Text && i.Password == PassTb.Password);
            if(q == null)
            {
                Tb1.Text = "Проверьте данные";
            }
            else
            {
                Helpers.ClassConnect.auth = q;
                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            Close();
        }
    }
}
