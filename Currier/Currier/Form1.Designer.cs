namespace Currier
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btniniciar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtuser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcontraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chrecordar = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.Depth = 0;
            this.btniniciar.Location = new System.Drawing.Point(60, 313);
            this.btniniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btniniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Primary = true;
            this.btniniciar.Size = new System.Drawing.Size(76, 36);
            this.btniniciar.TabIndex = 0;
            this.btniniciar.Text = "Inicial";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtuser
            // 
            this.txtuser.AllowDrop = true;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.Depth = 0;
            this.txtuser.Hint = "Insertar User";
            this.txtuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtuser.Location = new System.Drawing.Point(60, 167);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtuser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtuser.SelectedText = "";
            this.txtuser.SelectionLength = 0;
            this.txtuser.SelectionStart = 0;
            this.txtuser.Size = new System.Drawing.Size(147, 23);
            this.txtuser.TabIndex = 0;
            this.txtuser.TabStop = false;
            this.txtuser.UseSystemPasswordChar = false;
            this.txtuser.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontraseña.Depth = 0;
            this.txtcontraseña.Hint = "Insertar contraseña";
            this.txtcontraseña.Location = new System.Drawing.Point(60, 214);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcontraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.SelectedText = "";
            this.txtcontraseña.SelectionLength = 0;
            this.txtcontraseña.SelectionStart = 0;
            this.txtcontraseña.Size = new System.Drawing.Size(147, 23);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // chrecordar
            // 
            this.chrecordar.AutoSize = true;
            this.chrecordar.Depth = 0;
            this.chrecordar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chrecordar.Location = new System.Drawing.Point(86, 254);
            this.chrecordar.Margin = new System.Windows.Forms.Padding(0);
            this.chrecordar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chrecordar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chrecordar.Name = "chrecordar";
            this.chrecordar.Ripple = true;
            this.chrecordar.Size = new System.Drawing.Size(86, 30);
            this.chrecordar.TabIndex = 4;
            this.chrecordar.Text = "Recordar";
            this.chrecordar.UseVisualStyleBackColor = true;
            this.chrecordar.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(141, 313);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Entrada de prueva";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(279, 360);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.chrecordar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btniniciar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtuser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcontraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckBox chrecordar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

