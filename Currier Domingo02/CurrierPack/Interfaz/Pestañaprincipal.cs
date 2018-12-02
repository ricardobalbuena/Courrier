﻿using System;
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
using System.Data;
using System.Data.SqlClient;

namespace Interfaz
{
    public partial class Pestañaprincipal : MaterialSkin.Controls.MaterialForm
    {
        public Pestañaprincipal()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;
            M.AddFormToManage(this);
            M.Theme = MaterialSkinManager.Themes.LIGHT;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
            
        }

        
        
        private void privilegiosUser()
        {
            if(Program.TipoUsuario != "admi      ")
            {
                AgregarC.Enabled = false;
                AgregarP.Enabled = false;
                Info.Enabled = false;
                
            }


        }

        private void Pestañaprincipal_Load(object sender, EventArgs e)
        {
            privilegiosUser();
        }

        private void ilustrarotroform(object formhijo)
        {
            if (this.Panelcontenido.Controls.Count > 0)
                this.Panelcontenido.Controls.RemoveAt(0);
             Agregar ag = formhijo as Agregar;
            ag.TopLevel = false;
            ag.Dock = DockStyle.Fill;
            this.Panelcontenido.Controls.Add(ag);
            this.Panelcontenido.Tag = ag;
            
            ag.Show();

            

        }

        private void CerrarS_Click(object sender, EventArgs e)
        {
            Form1 peslogin = new Form1();
            this.Hide();
            peslogin.ShowDialog();
        }

        private void AgregarC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helooo");
            Agregar _ag = new Agregar();
            _ag.ShowDialog();
            ilustrarotroform(new Agregar());
        }

        private void AgregarP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("prueva");
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("prueva");
        }

        private void Panelcontenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("prueva");
        }

        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Agregar add = new Agregar();
            this.Hide();
            add.ShowDialog();
           
        }
    }
}
