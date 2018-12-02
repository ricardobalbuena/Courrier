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
using MaterialSkin.Controls;
using Codigo;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;
            M.AddFormToManage(this);
            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=currier;Integrated Security=True");
            CEmpleado objempleado = new CEmpleado();
            int condicion_logear = 0;
            SqlDataReader logear;
            objempleado.Usuario = txtusuario.Text;
            objempleado.Password = txtcontraseña.Text;
            conexion.Open();
            
                SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT * FROM Empleado", conexion);
           
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Console.WriteLine(myReader["usuario"].ToString());
                    Console.WriteLine(myReader["contrasena"].ToString());
                    if(myReader["usuario"].ToString() == objempleado.Usuario && myReader["contrasena"].ToString() == objempleado.Password)
                    {
                        condicion_logear = 1;
                        break;
                    }
                     //MessageBox.Show(myReader["contrasena"].ToString());
                    // MessageBox.Show(myReader["usuario"].ToString());
                }


            //MessageBox.Show(condicion_logear.ToString());
            
            




            

            //MessageBox.Show(objempleado.Usuario);
           // MessageBox.Show(objempleado.Password);

            //logear = objempleado.Iniciarsesion();

            try
            {
               // if (logear.Read() == true)
               if(condicion_logear==1)
                {
                    this.Hide();
                    Pestañaprincipal abrir = new Pestañaprincipal();
                    //Program.TipoUsuario = logear["TipoUsuario"].ToString();
                    Program.Usuario = objempleado.Usuario;
                    abrir.ShowDialog();
                    this.Close();
                }
                else

                    MessageBox.Show("Usuario o contraseña son invalidos");


            }

            catch(Exception)
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            Pestañaprincipal pesprinci = new Pestañaprincipal();
            this.Hide();
            pesprinci.ShowDialog();
            this.Close();
        }
    }
}
