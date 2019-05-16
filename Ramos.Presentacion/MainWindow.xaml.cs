using System;
using System.Collections.Generic;
using System.Data;
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
using Ramos.Negocios;

namespace Ramos.Presentacion
{
    public partial class MainWindow : Window
    {
        Manejadora mane = new Manejadora();
        DataTable secciones;
        DataTable ramos;
        DataTable dt;
        string username;
        string idRamo;
        string idCarrera;
        string idSede;

        public MainWindow(string user, string pass)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            username = user;
            dt = mane.Datitos(user);
            ramos = mane.TablitaRamos(user);
            idSede = (dt.Rows[0][0]).ToString();
            txtSede.Content = (dt.Rows[0][1]).ToString();
            idCarrera = (dt.Rows[0][2]).ToString();
            txtCarrera.Content = (dt.Rows[0][3]).ToString();
            txtRut.Content = (dt.Rows[0][4]).ToString();
            txtSemestre.Content = (dt.Rows[0][5]).ToString() + "° Semestre";
            txtNombre.Content = (dt.Rows[0][6]).ToString();
            dtgRamo.ItemsSource = ramos.DefaultView;
        }

        private void BtnGrid_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dtrv = (DataRowView)((Button)e.Source).DataContext;
            idRamo = dtrv[0].ToString();

            secciones = mane.TablitaSecciones(idRamo, idCarrera, idSede);
            dtgSeccion.ItemsSource = secciones.DefaultView;
        }

        private void BtnFin_Click(object sender, RoutedEventArgs e)
        {
            VistaHorario vih = new VistaHorario(txtNombre.Content.ToString(), username);
            vih.Show();
            this.Close();
        }

        private void BtnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            int indexS = dtgSeccion.SelectedIndex;
            String idSecc = secciones.Rows[indexS][0].ToString();
            DateTime fechaIns = DateTime.Now;

            if (MessageBox.Show("¿Quiere la sección " + secciones.Rows[indexS][0].ToString() + "?", "Confirmación", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                if (mane.CreateInscripcion(idSecc, idRamo, idCarrera, int.Parse(idSede), username, fechaIns) == true)
                {
                    MessageBox.Show("¡Sección agregada!", "Mensaje");
                }
                else
                {
                    MessageBox.Show("No pasó na' uwu");
                }
            }
        }
    }
}
