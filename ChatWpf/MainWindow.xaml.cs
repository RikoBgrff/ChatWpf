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
            ContactsListBox.ItemsSource = Users;
        }
        public List<User> Users { get; set; } = new List<User>
        {
            new User
            {
                Name = "Bagirli Arif",
                Number="+994708397309",
                ImagePath="bagirliarif.jpg",
                LatestMessage = "i will be there for 5 min"
            },
            new User
            {
                Name = "Jafarov Zaur",
                Number="+99412345687",
                ImagePath="zaurstep.jpg",
                LatestMessage = "i will be there for 5 min"
            }

        };
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Yes");
        }
    }
}
