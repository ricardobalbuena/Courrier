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

namespace Interfaz
{
    public partial class Pestañaprincipal : MaterialSkin.Controls.MaterialForm
    {
        public Pestañaprincipal()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;
            M.AddFormToManage(this);
            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
        }

        private void Pestañaprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
