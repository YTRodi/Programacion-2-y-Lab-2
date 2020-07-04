namespace WindowsFormsApp
{
    partial class FormAltaPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaPaciente));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblAltaPaciente = new System.Windows.Forms.Label();
            this.pBoxCerrar = new System.Windows.Forms.PictureBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEdad = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDni = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbObraCampo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.panelSuperior.Controls.Add(this.lblAltaPaciente);
            this.panelSuperior.Controls.Add(this.pBoxCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(245, 40);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblAltaPaciente
            // 
            this.lblAltaPaciente.AutoSize = true;
            this.lblAltaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaPaciente.ForeColor = System.Drawing.Color.White;
            this.lblAltaPaciente.Location = new System.Drawing.Point(17, 12);
            this.lblAltaPaciente.Name = "lblAltaPaciente";
            this.lblAltaPaciente.Size = new System.Drawing.Size(104, 18);
            this.lblAltaPaciente.TabIndex = 2;
            this.lblAltaPaciente.Text = "Alta paciente";
            this.lblAltaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxCerrar
            // 
            this.pBoxCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.pBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCerrar.Image")));
            this.pBoxCerrar.Location = new System.Drawing.Point(213, 12);
            this.pBoxCerrar.Name = "pBoxCerrar";
            this.pBoxCerrar.Size = new System.Drawing.Size(29, 18);
            this.pBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCerrar.TabIndex = 1;
            this.pBoxCerrar.TabStop = false;
            this.pBoxCerrar.Click += new System.EventHandler(this.pBoxCerrar_Click);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(20, 67);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(206, 20);
            this.txtBoxNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido*";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(20, 110);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(206, 20);
            this.txtBoxApellido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sexo*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad*";
            // 
            // txtBoxEdad
            // 
            this.txtBoxEdad.Location = new System.Drawing.Point(20, 153);
            this.txtBoxEdad.Name = "txtBoxEdad";
            this.txtBoxEdad.Size = new System.Drawing.Size(206, 20);
            this.txtBoxEdad.TabIndex = 6;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(20, 198);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(206, 21);
            this.cmbSexo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dirección*";
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(20, 244);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(206, 20);
            this.txtBoxDireccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dni*";
            // 
            // txtBoxDni
            // 
            this.txtBoxDni.Location = new System.Drawing.Point(20, 287);
            this.txtBoxDni.Name = "txtBoxDni";
            this.txtBoxDni.Size = new System.Drawing.Size(206, 20);
            this.txtBoxDni.TabIndex = 13;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(20, 365);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(96, 41);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "&Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(130, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 41);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cmbObraCampo
            // 
            this.cmbObraCampo.FormattingEnabled = true;
            this.cmbObraCampo.Location = new System.Drawing.Point(20, 329);
            this.cmbObraCampo.Name = "cmbObraCampo";
            this.cmbObraCampo.Size = new System.Drawing.Size(206, 21);
            this.cmbObraCampo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Obra social*";
            // 
            // FormAltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(245, 421);
            this.Controls.Add(this.cmbObraCampo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxDni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAltaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta paciente";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pBoxCerrar;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEdad;
        private System.Windows.Forms.Label lblAltaPaciente;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxDni;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbObraCampo;
        private System.Windows.Forms.Label label5;
    }
}

