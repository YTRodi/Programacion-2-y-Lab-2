namespace Formularios.FormsInformativos
{
    partial class FormPreABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreABM));
            this.lblOpcion = new System.Windows.Forms.Label();
            this.pBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.ForeColor = System.Drawing.Color.White;
            this.lblOpcion.Location = new System.Drawing.Point(81, 12);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(239, 18);
            this.lblOpcion.TabIndex = 2;
            this.lblOpcion.Text = "Elija que opción desea realizar";
            this.lblOpcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxCerrar
            // 
            this.pBoxCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.pBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCerrar.Image")));
            this.pBoxCerrar.Location = new System.Drawing.Point(354, 12);
            this.pBoxCerrar.Name = "pBoxCerrar";
            this.pBoxCerrar.Size = new System.Drawing.Size(29, 18);
            this.pBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCerrar.TabIndex = 1;
            this.pBoxCerrar.TabStop = false;
            this.pBoxCerrar.Click += new System.EventHandler(this.pBoxCerrar_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.panelSuperior.Controls.Add(this.lblOpcion);
            this.panelSuperior.Controls.Add(this.pBoxCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(388, 40);
            this.panelSuperior.TabIndex = 1;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(12, 59);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(117, 45);
            this.btnAlta.TabIndex = 16;
            this.btnAlta.Text = "&Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(135, 59);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 45);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(258, 59);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 45);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormPreABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 118);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPreABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLog";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.PictureBox pBoxCerrar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}