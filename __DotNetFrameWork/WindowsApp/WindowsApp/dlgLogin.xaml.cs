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
using WindowsApp.helpers;

namespace WindowsApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class dlgLogin : Window
    {
        public dlgLogin()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            string username, password;
            username = this.txt_username.Text;
            password = this.txt_password.Password;

            if (LoginHelper.isUsernamePasswordValid(username,password))
            {
                this.Close();
            }
            else
            {
                this.lbl_LoginError.Content = "Inloggen niet gelukt";
                this.lbl_LoginError.Visibility = Visibility.Visible;
            }
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
