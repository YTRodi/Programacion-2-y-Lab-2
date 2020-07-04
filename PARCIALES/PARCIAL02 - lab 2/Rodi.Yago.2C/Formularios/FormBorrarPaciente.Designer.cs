namespace Formularios
{
    partial class FormBorrarPaciente
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
            this.lblAltaPaciente = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstBoxPacientesEliminar = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.panelSuperior.Controls.Add(this.lblAltaPaciente);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(504, 40);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblAltaPaciente
            // 
            this.lblAltaPaciente.AutoSize = true;
            this.lblAltaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaPaciente.ForeColor = System.Drawing.Color.White;
            this.lblAltaPaciente.Location = new System.Drawing.Point(17, 12);
            this.lblAltaPaciente.Name = "lblAltaPaciente";
            this.lblAltaPaciente.Size = new System.Drawing.Size(137, 18);
            this.lblAltaPaciente.TabIndex = 2;
            this.lblAltaPaciente.Text = "Eliminar paciente";
            this.lblAltaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(12, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(239, 41);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(257, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(235, 41);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstBoxPacientesEliminar
            // 
            this.lstBoxPacientesEliminar.FormattingEnabled = true;
            this.lstBoxPacientesEliminar.Location = new System.Drawing.Point(12, 73);
            this.lstBoxPacientesEliminar.Name = "lstBoxPacientesEliminar";
            this.lstBoxPacientesEliminar.Size = new System.Drawing.Size(480, 290);
            this.lstBoxPacientesEliminar.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Seleccione el paciente a eliminar";
            // 
            // FormBorrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(504, 421);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstBoxPacientesEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBorrarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta paciente";
            this.Load += new System.EventHandler(this.FormEditarPaciente_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblAltaPaciente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstBoxPacientesEliminar;
        private System.Windows.Forms.Label label8;
    }
}

