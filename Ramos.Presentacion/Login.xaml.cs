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
using Ramos.Negocios;

namespace Ramos.Presentacion
{
    public partial class Login : Window
    {
        String username = "alumno";
        String password = "alumno";

        public Login()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            txtUsername.Focus();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text != "")
            {
                username = txtUsername.Text;
            }
            else
            {
                MessageBox.Show("Ingrese su nombre de usuario", "Alerta");
                txtUsername.Focus();
                return;
            }

            if (pwdPassword.Password != "")
            {
                password = pwdPassword.Password;
            }
            else
            {
                MessageBox.Show("Ingrese su contraseña", "Alerta");
                pwdPassword.Focus();
                return;
            }

            Manejadora alu = new Manejadora();
            try
            {
                if (alu.Login(username, password) == true)
                {
                    MainWindow w1 = new MainWindow(username, password);
                    w1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión" +
                        "\rIntente de nuevo o registrese.", "Alerta");
                }
            }
            catch (Exception zz)
            {
                throw new Exception(zz.Message);
            }
        }
    }
}