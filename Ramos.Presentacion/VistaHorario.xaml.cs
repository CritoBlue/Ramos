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
using System.Windows.Shapes;
using Ramos.Negocios;

namespace Ramos.Presentacion
{
    public partial class VistaHorario : Window
    {
        Manejadora mane = new Manejadora();
        public VistaHorario(String alumno, String username)
        {
            InitializeComponent();
            lbHorario.Content = "Horario - " + alumno;
            DataTable dt = mane.TablitaInscripcion(username);
            dtgHorario.ItemsSource = dt.DefaultView;
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
