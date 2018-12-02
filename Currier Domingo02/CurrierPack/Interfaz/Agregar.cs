using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;
            
            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=currier;Integrated Security=True");
            
            int condicion_logear = 0;
            SqlDataReader logear;
            
            conexion.Open();

            SqlDataReader myReader = null;
            
            string nombre = "";
            string direccion = "";
            string apellido = "";
            string codigoUsuario = "";
            string correo = "";

             nombre = txtnombre.Text;
            direccion = txtDireccion.Text;
             apellido = txtapellido.Text;
             codigoUsuario = txtcodigo.Text;
           correo = txtCorreo.Text;
            string addClient = "";

            if (nombre != "")
            {
                if (direccion != "")
                {
                    if (apellido != "")
                    {
                        if (codigoUsuario != "")
                        {
                            if (correo != "")
                            {

                                addClient = "INSERT into Cliente (Nombre,Apellido,Direccion,CodigoUsuario,Correo) " + " VALUES ('" + nombre + "', '" + apellido + "', '" + direccion + "', '" + codigoUsuario + "', '" + correo + "');";


                                SqlCommand myCommand = new SqlCommand(addClient, conexion);
                                myCommand.ExecuteNonQuery();
                                conexion.Close();
                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show("El campo correo no puede ser nulo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo codigoUsuario no puede ser nulo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo apellido no puede ser nulo");
                    }
                }
                else
                {
                    MessageBox.Show("El campo direccion no puede ser nulo");
                }

            }
            else
            {
                MessageBox.Show("El campo Nombre no puede ser nulo");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
