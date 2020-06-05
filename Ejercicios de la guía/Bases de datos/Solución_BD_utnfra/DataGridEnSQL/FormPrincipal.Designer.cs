namespace DataGridEnSQL
{
    partial class FormPrincipal
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
            this.dGridAlumnos = new System.Windows.Forms.DataGridView();
            this.lbCurso = new System.Windows.Forms.Label();
            this.txtBoxCurso = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridAlumnos
            // 
            this.dGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAlumnos.Location = new System.Drawing.Point(12, 106);
            this.dGridAlumnos.Name = "dGridAlumnos";
            this.dGridAlumnos.Size = new System.Drawing.Size(776, 519);
            this.dGridAlumnos.TabIndex = 0;
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurso.Location = new System.Drawing.Point(12, 27);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(118, 24);
            this.lbCurso.TabIndex = 1;
            this.lbCurso.Text = "Curso a filtrar";
            // 
            // txtBoxCurso
            // 
            this.txtBoxCurso.Location = new System.Drawing.Point(151, 32);
            this.txtBoxCurso.Name = "txtBoxCurso";
            this.txtBoxCurso.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCurso.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(280, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertarDatos
            // 
            this.btnInsertarDatos.Location = new System.Drawing.Point(412, 25);
            this.btnInsertarDatos.Name = "btnInsertarDatos";
            this.btnInsertarDatos.Size = new System.Drawing.Size(114, 32);
            this.btnInsertarDatos.TabIndex = 4;
            this.btnInsertarDatos.Text = "Insertar datos";
            this.btnInsertarDatos.UseVisualStyleBackColor = true;
            this.btnInsertarDatos.Click += new System.EventHandler(this.btnInsertarDatos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 637);
            this.Controls.Add(this.btnInsertarDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxCurso);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.dGridAlumnos);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridAlumnos;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.TextBox txtBoxCurso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertarDatos;
    }
}

