using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для GroupVisitingWindow.xaml
    /// </summary>
    public partial class GroupVisitingWindow : Window
    {
        public GroupVisitingWindow()
        {
            InitializeComponent();
            this.DataContext = Helpers.ClassConnect.client;

            Cmb1.SelectedValuePath = "Id";
            Cmb1.DisplayMemberPath = "Visiting1";
            Cmb1.ItemsSource = Helpers.ClassConnect.user.Visiting.ToList();

            Cmb2.SelectedValuePath = "Id";
            Cmb2.DisplayMemberPath = "DivisionName";
            Cmb2.ItemsSource = Helpers.ClassConnect.user.Divisions.ToList();

            OrgTb.SelectedValuePath = "Id";
            OrgTb.DisplayMemberPath = "Name";
            OrgTb.ItemsSource = Helpers.ClassConnect.user.Organization.ToList();

            q.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();
            w.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();
            e.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();
            r.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();
            t.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();

            y.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();
            u.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();
            i.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();
            o.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();
            p.DataContext = Helpers.ClassConnect.user.InfoClient.ToList();

        }

        private void dobBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(FamTb.Text))
                mes += "Введите номер телефона\n";
            if (string.IsNullOrWhiteSpace(NameTb.Text))
                mes += "Введите номер телефона\n";
            if (string.IsNullOrWhiteSpace(OtchTb.Text))
                mes += "Введите номер телефона\n";
            if (string.IsNullOrWhiteSpace(OrgTb.Text))
                mes += "Введите номер телефона\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Models.InfoClient infoClient = new Models.InfoClient
            {
                Surname = FamTb.Text,
                Name = NameTb.Text,
                MiddleName = OtchTb.Text,
                Organization = OrgTb.SelectedItem as Models.Organization,
                //Phone = PhoneTb.Text,
                //Email = EmailTb.Text,
                //Comment = CommentTb.Text,
                //DataBirthday = (DateTime)DatePc.SelectedDate,
                //SeriyaPasport = int.Parse(SeriyaTb.Text),
                //numberPasport = int.Parse(NumberTb.Text)
            };
            Helpers.ClassConnect.user.InfoClient.Add(infoClient);
            Helpers.ClassConnect.user.SaveChanges();
            MessageBox.Show("Данные добавлены");
        }
            
        public byte[] file;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            var qwe = openFile.FileName;
            file = File.ReadAllBytes(qwe);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextTb1.Clear();
            FamTb.Clear();
            NameTb.Clear();
            OtchTb.Clear();
            PhoneTb.Clear();
            Cmb1.SelectedItem = null;
            Cmb2.SelectedItem = null;
            OrgTb.SelectedItem = null;
            EmailTb.Clear();
            CommentTb.Clear();
            SeriyaTb.Clear();
            NumberTb.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //string mes = "";
            //if (string.IsNullOrWhiteSpace(Dt1.Text))
            //    mes += "Введите логин\n";
            //if (string.IsNullOrWhiteSpace(Dt2.Text))
            //    mes += "Введите пароль\n";
            //if (string.IsNullOrWhiteSpace(Cmb1.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(Cmb2.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(TextTb1.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(FamTb.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(NameTb.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(OtchTb.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(PhoneTb.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(EmailTb.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(OrgTb.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(DatePc.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(SeriyaTb.Text))
            //    mes += "Введите номер телефона\n";
            //if (string.IsNullOrWhiteSpace(NumberTb.Text))
            //    mes += "Введите номер телефона\n";
            //if (mes != "")
            //{
            //    MessageBox.Show(mes);
            //    mes = "";
            //    return;
            //}
            //Models.InfoPropusk infoPropusk = new Models.InfoPropusk
            //{
            //    DateS = (DateTime)Dt1.SelectedDate,
            //    DatePo = (DateTime)Dt2.SelectedDate,
            //    Visiting = Cmb1.SelectedItem as Models.Visiting
            //};
            //Helpers.ClassConnect.user.InfoPropusk.Add(infoPropusk);
            //Helpers.ClassConnect.user.SaveChanges();

            //Models.ReceivingParty receivingParty = new Models.ReceivingParty
            //{
            //    Divisions = Cmb2.SelectedItem as Models.Divisions,
            //    Fcs = TextTb1.Text
            //};
            //Helpers.ClassConnect.user.ReceivingParty.Add(receivingParty);
            //Helpers.ClassConnect.user.SaveChanges();

            //Models.InfoClient infoClient = new Models.InfoClient
            //{
            //    Surname = FamTb.Text,
            //    Name = NameTb.Text,
            //    MiddleName = OtchTb.Text,
            //    Phone = PhoneTb.Text,
            //    Email = EmailTb.Text,
            //    Organization = OrgTb.SelectedItem as Models.Organization,
            //    Comment = CommentTb.Text,
            //    DataBirthday = (DateTime)DatePc.SelectedDate,
            //    SeriyaPasport = int.Parse(SeriyaTb.Text),
            //    numberPasport = int.Parse(NumberTb.Text)
            //};
            //Helpers.ClassConnect.user.InfoClient.Add(infoClient);
            //Helpers.ClassConnect.user.SaveChanges();

            //Models.Docs docs = new Models.Docs
            //{
            //    FileDoc = file
            //};
            //Helpers.ClassConnect.user.Docs.Add(docs);
            //Helpers.ClassConnect.user.SaveChanges();
            //MessageBox.Show("Данные добавлены");

            AuthWindow authWindow = new AuthWindow();authWindow.Show();Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Models.InfoClient infoClient = new Models.InfoClient
            {
                
            };
        }
    }
}
