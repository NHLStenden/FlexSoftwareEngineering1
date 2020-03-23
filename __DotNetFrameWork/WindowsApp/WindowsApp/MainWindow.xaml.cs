using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WindowsApp
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

        private void MenuItem_Login(object sender, RoutedEventArgs e)
        {
            Window dlg = new dlgLogin();
            dlg.ShowDialog();
            if (helpers.GlobalSettings.Instance.LoggedIn)
            {
                this.lbl_Name.Content = "Welkom " + helpers.GlobalSettings.Instance.Username;
            }
        }

        private void MenuItem_Logout(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Quit(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }

    public class Counter : INotifyPropertyChanged
    {
        public int Count { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
