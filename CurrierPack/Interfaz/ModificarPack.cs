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
using Codigo;
using Datos;
using System.Data.SqlClient;



namespace Interfaz
{
    public partial class brpaquete : Form
    {
        CPaquetes paquetes = new CPaquetes();
        DataView dv = new DataView();


        public brpaquete()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;

            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
        }

        public void actualizarPaquetes()
        {
            CPaquetes paquetes = new CPaquetes();
            tablapaquetes.DataSource = paquetes.mostrarpaquetes();

        }

        private void ModificarPack_Load(object sender, EventArgs e)
        {
            actualizarPaquetes();
        }


        private void filtrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (brnombre.Checked == true)
            {
                try
                {
                    CPaquetes paquete = new CPaquetes();
                    tablapaquetes.DataSource = paquete.buscarpaquetes(txtfiltrar.Text,"Nombre");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error  " + ex);
                }
            }

            if(brestado.Checked == true)
            {
                try
                {
                    CPaquetes paquete = new CPaquetes();
                    tablapaquetes.DataSource = paquete.buscarpaquetes(txtfiltrar.Text,"Estado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error  " + ex);
                }

            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            if (tablapaquetes.SelectedRows.Count > 0)
            {
                cbestado.Text = tablapaquetes.CurrentRow.Cells["Estado"].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la lista");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            paquetes.editarstate(cbestado.Text, tablapaquetes.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
            cbestado.Text = " ";
            MessageBox.Show("Datos actualizados");
            actualizarPaquetes();


        }

        private void txtfiltrar_Click(object sender, EventArgs e)
        {


        }
        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
