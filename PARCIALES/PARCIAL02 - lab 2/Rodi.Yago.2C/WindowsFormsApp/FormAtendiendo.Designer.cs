namespace WindowsFormsApp
{
    partial class FormAtendiendo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtendiendo));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblAtendiendo = new System.Windows.Forms.Label();
            this.lsbBoxAtendiendo = new System.Windows.Forms.ListBox();
            this.btnMostrarAtendidos = new System.Windows.Forms.Button();
            this.btnTurnoEspecifico = new System.Windows.Forms.Button();
            this.pBoxCruz = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCruz)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.panelSuperior.Controls.Add(this.lblAtendiendo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(562, 40);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblAtendiendo
            // 
            this.lblAtendiendo.AutoSize = true;
            this.lblAtendiendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendiendo.ForeColor = System.Drawing.Color.White;
            this.lblAtendiendo.Location = new System.Drawing.Point(230, 9);
            this.lblAtendiendo.Name = "lblAtendiendo";
            this.lblAtendiendo.Size = new System.Drawing.Size(106, 18);
            this.lblAtendiendo.TabIndex = 2;
            this.lblAtendiendo.Text = "Atendiendo...";
            this.lblAtendiendo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsbBoxAtendiendo
            // 
            this.lsbBoxAtendiendo.Enabled = false;
            this.lsbBoxAtendiendo.FormattingEnabled = true;
            this.lsbBoxAtendiendo.Location = new System.Drawing.Point(12, 54);
            this.lsbBoxAtendiendo.Name = "lsbBoxAtendiendo";
            this.lsbBoxAtendiendo.Size = new System.Drawing.Size(422, 212);
            this.lsbBoxAtendiendo.TabIndex = 2;
            // 
            // btnMostrarAtendidos
            // 
            this.btnMostrarAtendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnMostrarAtendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAtendidos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarAtendidos.Location = new System.Drawing.Point(438, 54);
            this.btnMostrarAtendidos.Name = "btnMostrarAtendidos";
            this.btnMostrarAtendidos.Size = new System.Drawing.Size(117, 45);
            this.btnMostrarAtendidos.TabIndex = 16;
            this.btnMostrarAtendidos.Text = "&Mostrar atendidos";
            this.btnMostrarAtendidos.UseVisualStyleBackColor = false;
            // 
            // btnTurnoEspecifico
            // 
            this.btnTurnoEspecifico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnTurnoEspecifico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnoEspecifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnoEspecifico.ForeColor = System.Drawing.Color.White;
            this.btnTurnoEspecifico.Location = new System.Drawing.Point(438, 106);
            this.btnTurnoEspecifico.Name = "btnTurnoEspecifico";
            this.btnTurnoEspecifico.Size = new System.Drawing.Size(117, 45);
            this.btnTurnoEspecifico.TabIndex = 17;
            this.btnTurnoEspecifico.Text = "&Mostrar turno específico";
            this.btnTurnoEspecifico.UseVisualStyleBackColor = false;
            // 
            // pBoxCruz
            // 
            this.pBoxCruz.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCruz.Image")));
            this.pBoxCruz.Location = new System.Drawing.Point(438, 157);
            this.pBoxCruz.Name = "pBoxCruz";
            this.pBoxCruz.Size = new System.Drawing.Size(117, 109);
            this.pBoxCruz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCruz.TabIndex = 18;
            this.pBoxCruz.TabStop = false;
            // 
            // FormAtendiendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(562, 283);
            this.Controls.Add(this.pBoxCruz);
            this.Controls.Add(this.btnTurnoEspecifico);
            this.Controls.Add(this.btnMostrarAtendidos);
            this.Controls.Add(this.lsbBoxAtendiendo);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAtendiendo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta paciente";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCruz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblAtendiendo;
        private System.Windows.Forms.ListBox lsbBoxAtendiendo;
        private System.Windows.Forms.Button btnMostrarAtendidos;
        private System.Windows.Forms.Button btnTurnoEspecifico;
        private System.Windows.Forms.PictureBox pBoxCruz;
    }
}

