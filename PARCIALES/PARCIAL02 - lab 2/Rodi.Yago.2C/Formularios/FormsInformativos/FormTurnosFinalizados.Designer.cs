namespace WindowsFormsApp.FormsInformativos
{
    partial class FormTurnosFinalizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTurnosFinalizados));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pBoxCerrar = new System.Windows.Forms.PictureBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lstTurnosFinalizados = new System.Windows.Forms.ListBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.panelSuperior.Controls.Add(this.lblTotal);
            this.panelSuperior.Controls.Add(this.pBoxCerrar);
            this.panelSuperior.Controls.Add(this.lblEliminar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(537, 40);
            this.panelSuperior.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(386, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 18);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxCerrar
            // 
            this.pBoxCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.pBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCerrar.Image")));
            this.pBoxCerrar.Location = new System.Drawing.Point(508, 12);
            this.pBoxCerrar.Name = "pBoxCerrar";
            this.pBoxCerrar.Size = new System.Drawing.Size(29, 18);
            this.pBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCerrar.TabIndex = 21;
            this.pBoxCerrar.TabStop = false;
            this.pBoxCerrar.Click += new System.EventHandler(this.pBoxCerrar_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.White;
            this.lblEliminar.Location = new System.Drawing.Point(161, 12);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(147, 18);
            this.lblEliminar.TabIndex = 2;
            this.lblEliminar.Text = "Turnos finalizados";
            this.lblEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstTurnosFinalizados
            // 
            this.lstTurnosFinalizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTurnosFinalizados.FormattingEnabled = true;
            this.lstTurnosFinalizados.Location = new System.Drawing.Point(0, 40);
            this.lstTurnosFinalizados.Name = "lstTurnosFinalizados";
            this.lstTurnosFinalizados.Size = new System.Drawing.Size(537, 410);
            this.lstTurnosFinalizados.TabIndex = 20;
            // 
            // FormTurnosFinalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.lstTurnosFinalizados);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTurnosFinalizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAtendidos";
            this.Load += new System.EventHandler(this.FormTurnosFinalizados_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.ListBox lstTurnosFinalizados;
        private System.Windows.Forms.PictureBox pBoxCerrar;
        private System.Windows.Forms.Label lblTotal;
    }
}