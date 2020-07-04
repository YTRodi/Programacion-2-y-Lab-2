namespace Formularios
{
    partial class FormMenuClinica
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.lstBoxPacientes = new System.Windows.Forms.ListBox();
            this.lstBoxEspecialistas = new System.Windows.Forms.ListBox();
            this.btnABMPaciente = new System.Windows.Forms.Button();
            this.btnABMEspecialista = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panelSuperior.Size = new System.Drawing.Size(1008, 40);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblAltaPaciente
            // 
            this.lblAltaPaciente.AutoSize = true;
            this.lblAltaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaPaciente.ForeColor = System.Drawing.Color.White;
            this.lblAltaPaciente.Location = new System.Drawing.Point(451, 12);
            this.lblAltaPaciente.Name = "lblAltaPaciente";
            this.lblAltaPaciente.Size = new System.Drawing.Size(59, 18);
            this.lblAltaPaciente.TabIndex = 2;
            this.lblAltaPaciente.Text = "Clínica";
            this.lblAltaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(884, 65);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(117, 45);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "&Asignar turno";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lstBoxPacientes
            // 
            this.lstBoxPacientes.FormattingEnabled = true;
            this.lstBoxPacientes.Location = new System.Drawing.Point(12, 67);
            this.lstBoxPacientes.Name = "lstBoxPacientes";
            this.lstBoxPacientes.Size = new System.Drawing.Size(480, 199);
            this.lstBoxPacientes.TabIndex = 16;
            // 
            // lstBoxEspecialistas
            // 
            this.lstBoxEspecialistas.FormattingEnabled = true;
            this.lstBoxEspecialistas.Location = new System.Drawing.Point(508, 68);
            this.lstBoxEspecialistas.Name = "lstBoxEspecialistas";
            this.lstBoxEspecialistas.Size = new System.Drawing.Size(365, 199);
            this.lstBoxEspecialistas.TabIndex = 17;
            // 
            // btnABMPaciente
            // 
            this.btnABMPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnABMPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMPaciente.ForeColor = System.Drawing.Color.White;
            this.btnABMPaciente.Location = new System.Drawing.Point(884, 116);
            this.btnABMPaciente.Name = "btnABMPaciente";
            this.btnABMPaciente.Size = new System.Drawing.Size(117, 45);
            this.btnABMPaciente.TabIndex = 18;
            this.btnABMPaciente.Text = "&Paciente (ABM)";
            this.btnABMPaciente.UseVisualStyleBackColor = false;
            this.btnABMPaciente.Click += new System.EventHandler(this.btnABMPaciente_Click);
            // 
            // btnABMEspecialista
            // 
            this.btnABMEspecialista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnABMEspecialista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMEspecialista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMEspecialista.ForeColor = System.Drawing.Color.White;
            this.btnABMEspecialista.Location = new System.Drawing.Point(884, 167);
            this.btnABMEspecialista.Name = "btnABMEspecialista";
            this.btnABMEspecialista.Size = new System.Drawing.Size(117, 45);
            this.btnABMEspecialista.TabIndex = 19;
            this.btnABMEspecialista.Text = "&Especialista (ABM)";
            this.btnABMEspecialista.UseVisualStyleBackColor = false;
            this.btnABMEspecialista.Click += new System.EventHandler(this.btnABMEspecialista_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(884, 218);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(117, 45);
            this.btnLog.TabIndex = 20;
            this.btnLog.Text = "&Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Especialistas";
            // 
            // FormMenuClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1008, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnABMEspecialista);
            this.Controls.Add(this.btnABMPaciente);
            this.Controls.Add(this.lstBoxEspecialistas);
            this.Controls.Add(this.lstBoxPacientes);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta paciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuClinica_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuClinica_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblAltaPaciente;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ListBox lstBoxPacientes;
        private System.Windows.Forms.ListBox lstBoxEspecialistas;
        private System.Windows.Forms.Button btnABMPaciente;
        private System.Windows.Forms.Button btnABMEspecialista;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

