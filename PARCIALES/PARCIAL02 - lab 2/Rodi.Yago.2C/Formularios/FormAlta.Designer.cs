﻿namespace Formularios
{
    partial class FormAlta
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
            this.lblAlta = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtBoxEdad = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtBoxDni = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbObraCampo = new System.Windows.Forms.ComboBox();
            this.lblObraCampo = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.panelSuperior.Controls.Add(this.lblAlta);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(245, 40);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.ForeColor = System.Drawing.Color.White;
            this.lblAlta.Location = new System.Drawing.Point(17, 12);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(104, 18);
            this.lblAlta.TabIndex = 2;
            this.lblAlta.Text = "Alta paciente";
            this.lblAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(20, 67);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(206, 20);
            this.txtBoxNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(17, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre*";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(17, 91);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 16);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido*";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(20, 110);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(206, 20);
            this.txtBoxApellido.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(17, 179);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(44, 16);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo*";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.Black;
            this.lblEdad.Location = new System.Drawing.Point(17, 134);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(46, 16);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad*";
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
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(17, 225);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(70, 16);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Dirección*";
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(20, 244);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(206, 20);
            this.txtBoxDireccion.TabIndex = 11;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.Black;
            this.lblDni.Location = new System.Drawing.Point(17, 268);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(185, 16);
            this.lblDni.TabIndex = 14;
            this.lblDni.Text = "Dni* (8 caracteres obligatorio)";
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
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbObraCampo
            // 
            this.cmbObraCampo.FormattingEnabled = true;
            this.cmbObraCampo.Location = new System.Drawing.Point(20, 329);
            this.cmbObraCampo.Name = "cmbObraCampo";
            this.cmbObraCampo.Size = new System.Drawing.Size(206, 21);
            this.cmbObraCampo.TabIndex = 18;
            // 
            // lblObraCampo
            // 
            this.lblObraCampo.AutoSize = true;
            this.lblObraCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraCampo.ForeColor = System.Drawing.Color.Black;
            this.lblObraCampo.Location = new System.Drawing.Point(17, 310);
            this.lblObraCampo.Name = "lblObraCampo";
            this.lblObraCampo.Size = new System.Drawing.Size(82, 16);
            this.lblObraCampo.TabIndex = 17;
            this.lblObraCampo.Text = "Obra social*";
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(245, 421);
            this.Controls.Add(this.cmbObraCampo);
            this.Controls.Add(this.lblObraCampo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtBoxDni);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtBoxEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta paciente";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtBoxEdad;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtBoxDni;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbObraCampo;
        private System.Windows.Forms.Label lblObraCampo;
    }
}
