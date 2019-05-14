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

namespace Ramos.Presentacion
{
    public partial class Login : Window
    {
        String username;
        String password;

        public Login()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            username = txtUsername.Text;
            password = pwdPassword.Password;
            MainWindow w1 = new MainWindow(username, password);
            w1.Show();
            this.Close();
        }
    }
}