using ChatWpf.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace ChatWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public List<User> Users { get; set; } = new List<User>
        {
            new User
            {
                Name = "Bağırlı Arif",
                Number="+994708397309",
                ImagePath="bagirliarif.jpg",
                LatestMessage = "dərs təxirə salınıb?"
            },
            new User
            {
                Name = "Zaur Step",
                Number="+99412345687",
                ImagePath="zaurstep.jpg",
                LatestMessage = "Gürcü Xəngəli"
            },
            new User
            {
                Name = "Ayxan Step",
                Number="+99412345687",
                ImagePath="ayxanstep.png",
                LatestMessage = "Axşam vaxtın var?"
            },
            new User
            {
                Name = "Sənan Step",
                Number="+99412345687",
                ImagePath="senanstep.png",
                LatestMessage = @"Özüm öyrənəcəm Phytonu,
çox vaxtım gedir"
            },
            new User
            {
                Name = "Amin Step",
                Number="+99412345687",
                ImagePath="aminstep.png",
                LatestMessage = "sen Abdülhamiti savundun"
            },
        };
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ContactsListBox.Visibility = Visibility.Collapsed;
            MessagesListBox.ItemsSource = Users;
            MessagesListBox.Visibility = Visibility.Visible;
        }

        private void ContactBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ContactsListBox.ItemsSource = Users;
            MessagesListBox.Visibility = Visibility.Collapsed;
            ContactsListBox.Visibility = Visibility.Visible;
        }

        private void SettingsBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessagesListBox.Visibility = Visibility.Collapsed;
        }
    }
}
