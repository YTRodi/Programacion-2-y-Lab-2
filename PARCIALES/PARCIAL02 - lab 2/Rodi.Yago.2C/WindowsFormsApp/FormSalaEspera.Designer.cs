namespace WindowsFormsApp
{
    partial class FormSalaEspera
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblSalaDeEspera = new System.Windows.Forms.Label();
            this.lstBoxEspera = new System.Windows.Forms.ListBox();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.panelSuperior.Controls.Add(this.lblSalaDeEspera);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(446, 40);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblSalaDeEspera
            // 
            this.lblSalaDeEspera.AutoSize = true;
            this.lblSalaDeEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaDeEspera.ForeColor = System.Drawing.Color.White;
            this.lblSalaDeEspera.Location = new System.Drawing.Point(156, 9);
            this.lblSalaDeEspera.Name = "lblSalaDeEspera";
            this.lblSalaDeEspera.Size = new System.Drawing.Size(120, 18);
            this.lblSalaDeEspera.TabIndex = 2;
            this.lblSalaDeEspera.Text = "Sala de espera";
            this.lblSalaDeEspera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxEspera
            // 
            this.lstBoxEspera.Enabled = false;
            this.lstBoxEspera.FormattingEnabled = true;
            this.lstBoxEspera.Location = new System.Drawing.Point(12, 54);
            this.lstBoxEspera.Name = "lstBoxEspera";
            this.lstBoxEspera.Size = new System.Drawing.Size(422, 212);
            this.lstBoxEspera.TabIndex = 22;
            // 
            // FormSalaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(446, 283);
            this.Controls.Add(this.lstBoxEspera);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalaEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta paciente";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblSalaDeEspera;
        private System.Windows.Forms.ListBox lstBoxEspera;
    }
}

