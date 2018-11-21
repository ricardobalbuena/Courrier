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

namespace Currier
{
    public partial class Pestañapacks : MaterialSkin.Controls.MaterialForm
    {
        public Pestañapacks()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;
            M.AddFormToManage(this);
            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red800, Primary.Red500, Accent.Red700, TextShade.WHITE);
        }

        private void Pestañapacks_Load(object sender, EventArgs e)
        {


        }

        private void CerrarUser_Click(object sender, EventArgs e)
        {
            Login pestaña1 = new Login();
            this.Hide();
            pestaña1.ShowDialog();
            this.Close();
        }
    }
}
