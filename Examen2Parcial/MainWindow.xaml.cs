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
using System.Data;
using System.Data.SqlClient;

namespace Examen2Parcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-H5OOPDVV\\SQLEXPRESS;Initial Catalog=ERP;Integrated Security=True");

        private void nuevoUsuario(object sender, RoutedEventArgs e)
        {
            NuevoUsuari nuevo = new NuevoUsuari();
                this.Hide();
                nuevo.Show();
        }

        private void Iniciar(object sender, RoutedEventArgs e)
        {
            try
            {
                cn.Open();
                string query = "Select nombreUsuario, contraseña FROM Usuario.usuario where nombreUsuario = @Usuario AND contraseña= @contra ";
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.AddWithValue("@Usuario", txtUser.Text);
                comando.Parameters.AddWithValue("@contra", txtContra.Password);
                comando.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" Se a iniciado sesion");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }

        private void editar(object sender, RoutedEventArgs e)
        {
            NuevoUsuari nuevo = new NuevoUsuari();
            this.Hide();
            nuevo.Show();
        }
    }
}
