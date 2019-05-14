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

namespace Ramos.Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(String user, String pass)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void BtnGrid_Click(object sender, RoutedEventArgs e)
        {
            //No sé qué vaya a hacer esto, pero luego veremos
            //DataRowView dtrv = (DataRowView)((Button)e.Source).DataContext;
            //String idSeccion = dtrv[0].ToString();
            //String idRamo = dtrv[1].ToString();
            //String idCarrera = dtrv[2].ToString();
            //String idSede = dtrv[3].ToString();
        }

        private void BtnFin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("uwu", "Advertencia");
            this.Close();
        }
    }
}
