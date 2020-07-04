namespace Formularios
{
    partial class FormMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblAltaPaciente = new System.Windows.Forms.Label();
            this.pBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Controls.Add(this.lblHora);
            this.panelSuperior.Controls.Add(this.lblAltaPaciente);
            this.panelSuperior.Controls.Add(this.pBoxCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1013, 40);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(705, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 18);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora:";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAltaPaciente
            // 
            this.lblAltaPaciente.AutoSize = true;
            this.lblAltaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaPaciente.ForeColor = System.Drawing.Color.White;
            this.lblAltaPaciente.Location = new System.Drawing.Point(49, 12);
            this.lblAltaPaciente.Name = "lblAltaPaciente";
            this.lblAltaPaciente.Size = new System.Drawing.Size(112, 18);
            this.lblAltaPaciente.TabIndex = 2;
            this.lblAltaPaciente.Text = "Rodi.Yago.2C";
            this.lblAltaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxCerrar
            // 
            this.pBoxCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.pBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCerrar.Image")));
            this.pBoxCerrar.Location = new System.Drawing.Point(981, 12);
            this.pBoxCerrar.Name = "pBoxCerrar";
            this.pBoxCerrar.Size = new System.Drawing.Size(29, 18);
            this.pBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCerrar.TabIndex = 1;
            this.pBoxCerrar.TabStop = false;
            this.pBoxCerrar.Click += new System.EventHandler(this.pBoxCerrar_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1013, 606);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta paciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMDI_FormClosing);
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pBoxCerrar;
        private System.Windows.Forms.Label lblAltaPaciente;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

