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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            this.DataContext = Helpers.ClassConnect.auth;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProfWindow profWindow = new ProfWindow();
            profWindow.Show();
            Close();
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VipVisitingWindow vipVisitingWindow = new VipVisitingWindow();
            vipVisitingWindow.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GroupVisitingWindow groupVisitingWindow = new GroupVisitingWindow();
            groupVisitingWindow.Show();
            Close();
        }
    }
}
