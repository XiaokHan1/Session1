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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(logtb.Text))
                mes += "Введите логин\n";
            if (string.IsNullOrWhiteSpace(logtb.Text))
                mes += "Введите пароль\n";
            if (string.IsNullOrWhiteSpace(logtb.Text))
                mes += "Введите номер телефона\n";
            if(mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Models.Auth auth = new Models.Auth
            {
                Login = logtb.Text,
                Password = passtb.Password,
                Phone = phonetb.Text
            };
            Helpers.ClassConnect.user.Auth.Add(auth);
            Helpers.ClassConnect.user.SaveChanges();
            MessageBox.Show("Пользователь добавлен");
            AuthRegWindow authWindow = new AuthRegWindow();
            authWindow.Show();
            Close();

        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            AuthRegWindow authRegWindow = new AuthRegWindow();
            authRegWindow.Show();
            Close();
        }
    }
}
