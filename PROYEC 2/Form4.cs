using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYEC_2
{
    public partial class iniciarsessionlong1 : Form
    {
        public iniciarsessionlong1()
        {
            InitializeComponent();

            // Opcional: ocultar caracteres de la contraseña si el control existe
            try
            {
                if (this.Contralog != null)
                    this.Contralog.UseSystemPasswordChar = true;
            }
            catch
            {
                // No bloquear si por alguna razón el control no está disponible en este momento
            }
        }
        // Esto de aqui es para conectar a la biblioteca de sql no borres ninguna linea  porfa :)

        SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
    
        

        private void Iniciarsesión1_Click(object sender, EventArgs e)
        //Esto conecta al servidor y verifica si el usuario y la contraseña son correctos no vaya a borrar ninguna linea  :
        {
            // Validación básica de entrada
            if (string.IsNullOrWhiteSpace(Usuariolong.Text) || string.IsNullOrWhiteSpace(Contralog.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Abrir conexión si no está abierta
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                // Consulta parametrizada (mejor seguridad) y uso de ExecuteScalar para comprobar existencia
                using (SqlCommand comando = new SqlCommand("SELECT FROM USUARIOS WHERE NOMBREUSUARIO = @user AND [CONTRASEÑA] = @pass", conexion))
                {
                    comando.Parameters.AddWithValue("@user", Usuariolong.Text.Trim());
                    comando.Parameters.AddWithValue("@pass", Contralog.Text);

                    object result = comando.ExecuteScalar();
                    int count = 0;
                    if (result != null && int.TryParse(result.ToString(), out count) && count > 0)
                    {
                        // Usuario correcto: abrir Form1
                        Form1 ventna = new Form1();
                        ventna.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Usuario o contraseña incorrecta
                        MessageBox.Show("Usuario o contraseña incorrecta", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores de conexión/consulta
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurar cierre de conexión
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}
