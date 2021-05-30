using System.Windows;
using System.Windows.Controls;
using System.ServiceModel;
using ChatClient.ServiceChat;
using System.Windows.Input;
using System.Drawing;
using Tulpep.NotificationWindow;

namespace ChatClient
{

    public partial class MainWindow : Window, ChatClient.ServiceChat.IService1Callback
    {
        private bool isConnected = false;
        private int ID;
        private PopupNotifier popup = null;
        Service1Client client = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadPopup()
        {
            popup = new PopupNotifier();
            popup.Image = Properties.Resources.have_a_nice_day_logo;
            popup.ImageSize = new System.Drawing.Size(96, 96);
            popup.TitleText = "Error";
            popup.TitleColor = Color.Red;
            popup.ContentText = "Host is not connected!";
        }

        private void ConnectUser()
        {
            try
            {
                if (!isConnected)
                client = new Service1Client(new InstanceContext(this));
                ID = client.Connect(tbUserName.Text);
                tbUserName.IsEnabled = false;
                isConnected = true;
                Button.Content = "Disconnected";
            }
            catch
            {
                popup.Popup();
            }
        }

        private void DisconnectUser()
        {
            if (isConnected)
            client.Disconnect(ID);
            client = null;
            tbUserName.IsEnabled = true;
            isConnected = false;
            Button.Content = "Connected";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
                DisconnectUser();
            else
                ConnectUser();
        }

        public void MsgCallBack(string mesg)
        {
            lbChat.Items.Add(mesg);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DisconnectUser();
        }

        private void tbMessage_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter && client != null)
            {
                client.Send_Msg(tbMessage.Text, ID);
                tbMessage.Text = string.Empty;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPopup();
        }
    }
}
