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
using System.Data;
using System.Data.SqlClient;

namespace Examen2Parcial
{
    /// <summary>
    /// Lógica de interacción para NuevoUsuari.xaml
    /// </summary>
    public partial class NuevoUsuari : Window
    {
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-H5OOPDVV\\SQLEXPRESS;Initial Catalog=ERP;Integrated Security=True");
        public NuevoUsuari()
        {
            InitializeComponent();
        }

        private void Guardar(object sender, RoutedEventArgs e)
        {
            try
            {
                cn.Open();
                string query = "INSERT INTO Usuario.usuario VALUES (@nombre,@apellido,@usuario,@contraseña,@corre,GETDATE(),GETDATE(),@tipo,@estado)";
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.AddWithValue(" @nombre", txtNombre.Text);
                comando.Parameters.AddWithValue(" @apellido", txtApellido.Text);
                comando.Parameters.AddWithValue(" @usuario", txtUser.Text);
                comando.Parameters.AddWithValue(" @contraseña", txtContrasena.Text);
                comando.Parameters.AddWithValue(" @correo", txtCorreo.Text);
                comando.Parameters.AddWithValue(" @tipo", txtTipoUser.Text);
                comando.Parameters.AddWithValue(" @estado", txtEstado.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show(" Se a agregado un nuevo usuario");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
