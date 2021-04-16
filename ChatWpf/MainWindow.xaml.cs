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
        public List<User> Users { get; set; } = new List<User> { };
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            MessagesListBox.ItemsSource = JsonHelper.JsonDeserialize("users.json");
            ContactsListBox.Visibility = Visibility.Collapsed;
            MessagesListBox.Visibility = Visibility.Visible;
        }

        private void ContactBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var list = JsonHelper.JsonDeserialize("users.json").OrderBy(x => x.Name).ToList();
            ContactsListBox.ItemsSource = list;
            MessagesListBox.Visibility = Visibility.Collapsed;
            ContactsListBox.Visibility = Visibility.Visible;
        }

        private void SettingsBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessagesListBox.Visibility = Visibility.Collapsed;
        }
        private void MessagesListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            sendMessageTxtBx.Visibility = Visibility.Visible;
            sendButton.Visibility = Visibility.Visible;
            var user = MessagesListBox.SelectedItem as User;
            latestMessage.Text = user.LatestMessage;
            senderName.Text = user.Name;
            senderImage.Source = new BitmapImage(new Uri(user.ImagePath, UriKind.RelativeOrAbsolute));
        }


        private void PowerOffBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void PowerOffBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var image = sender as Image;
            image.Height += 20;
        }

        private void PowerOffBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var image = sender as Image;
            image.Height = 50;
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            sentMessage.Text = sendMessageTxtBx.Text;
        }

        private void ContactsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            sendMessageTxtBx.Visibility = Visibility.Visible;
            sendButton.Visibility = Visibility.Visible;
            var user = ContactsListBox.SelectedItem as User;
            latestMessage.Text = user.LatestMessage;
            senderName.Text = user.Name;
            senderImage.Source = new BitmapImage(new Uri(user.ImagePath, UriKind.RelativeOrAbsolute));

        }
    }
}
