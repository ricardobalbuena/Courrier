namespace Interfaz
{
    partial class Pestañaprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pestañaprincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Inicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CerrarS = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Info = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AgregarC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AgregarP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Panelcontenido = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAgregarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Panelcontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.Inicio);
            this.panel1.Controls.Add(this.CerrarS);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.AgregarC);
            this.panel1.Controls.Add(this.AgregarP);
            this.panel1.Location = new System.Drawing.Point(-2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 424);
            this.panel1.TabIndex = 1;
            // 
            // Inicio
            // 
            this.Inicio.Depth = 0;
            this.Inicio.Location = new System.Drawing.Point(0, 88);
            this.Inicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.Inicio.Name = "Inicio";
            this.Inicio.Primary = true;
            this.Inicio.Size = new System.Drawing.Size(113, 45);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Modificar paquete";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // CerrarS
            // 
            this.CerrarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarS.Depth = 0;
            this.CerrarS.Location = new System.Drawing.Point(0, 355);
            this.CerrarS.MouseState = MaterialSkin.MouseState.HOVER;
            this.CerrarS.Name = "CerrarS";
            this.CerrarS.Primary = true;
            this.CerrarS.Size = new System.Drawing.Size(116, 54);
            this.CerrarS.TabIndex = 0;
            this.CerrarS.Text = "Cerrar sesión";
            this.CerrarS.UseVisualStyleBackColor = true;
            this.CerrarS.Click += new System.EventHandler(this.CerrarS_Click);
            // 
            // Info
            // 
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Depth = 0;
            this.Info.Location = new System.Drawing.Point(-3, 247);
            this.Info.MouseState = MaterialSkin.MouseState.HOVER;
            this.Info.Name = "Info";
            this.Info.Primary = true;
            this.Info.Size = new System.Drawing.Size(116, 49);
            this.Info.TabIndex = 5;
            this.Info.Text = "Informes ";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // AgregarC
            // 
            this.AgregarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarC.Depth = 0;
            this.AgregarC.Location = new System.Drawing.Point(-3, 139);
            this.AgregarC.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarC.Name = "AgregarC";
            this.AgregarC.Primary = true;
            this.AgregarC.Size = new System.Drawing.Size(116, 47);
            this.AgregarC.TabIndex = 3;
            this.AgregarC.Text = "Agregar cliente";
            this.AgregarC.UseVisualStyleBackColor = true;
            this.AgregarC.Click += new System.EventHandler(this.AgregarC_Click);
            // 
            // AgregarP
            // 
            this.AgregarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarP.Depth = 0;
            this.AgregarP.Location = new System.Drawing.Point(-3, 192);
            this.AgregarP.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarP.Name = "AgregarP";
            this.AgregarP.Primary = true;
            this.AgregarP.Size = new System.Drawing.Size(116, 49);
            this.AgregarP.TabIndex = 4;
            this.AgregarP.Text = "Agregar paquete";
            this.AgregarP.UseVisualStyleBackColor = true;
            this.AgregarP.Click += new System.EventHandler(this.AgregarP_Click);
            // 
            // Panelcontenido
            // 
            this.Panelcontenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panelcontenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.Panelcontenido.Controls.Add(this.btnAgregarCliente);
            this.Panelcontenido.Controls.Add(this.pictureBox2);
            this.Panelcontenido.Location = new System.Drawing.Point(119, 63);
            this.Panelcontenido.Margin = new System.Windows.Forms.Padding(2);
            this.Panelcontenido.Name = "Panelcontenido";
            this.Panelcontenido.Size = new System.Drawing.Size(666, 410);
            this.Panelcontenido.TabIndex = 2;
            this.Panelcontenido.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelcontenido_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-43, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(665, 407);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Depth = 0;
            this.btnAgregarCliente.Location = new System.Drawing.Point(43, 10);
            this.btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Primary = true;
            this.btnAgregarCliente.Size = new System.Drawing.Size(113, 45);
            this.btnAgregarCliente.TabIndex = 2;
            this.btnAgregarCliente.Text = "Aggregar Cliente ";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // Pestañaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 484);
            this.Controls.Add(this.Panelcontenido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Pestañaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Pestañaprincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Panelcontenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarC;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarP;
        private MaterialSkin.Controls.MaterialRaisedButton Info;
        private MaterialSkin.Controls.MaterialRaisedButton CerrarS;
        private System.Windows.Forms.Panel Panelcontenido;
        private MaterialSkin.Controls.MaterialRaisedButton Inicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarCliente;
    }
}