namespace PruebaEnWinForms
{
    partial class FrmDatosAlumno
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
            this.pBoxAlumno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxAlumno
            // 
            this.pBoxAlumno.Location = new System.Drawing.Point(16, 189);
            this.pBoxAlumno.Name = "pBoxAlumno";
            this.pBoxAlumno.Size = new System.Drawing.Size(219, 250);
            this.pBoxAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAlumno.TabIndex = 11;
            this.pBoxAlumno.TabStop = false;
            // 
            // FrmDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 520);
            this.Controls.Add(this.pBoxAlumno);
            this.Name = "FrmDatosAlumno";
            this.Controls.SetChildIndex(this.txtBoxNombre, 0);
            this.Controls.SetChildIndex(this.txtBoxApellido, 0);
            this.Controls.SetChildIndex(this.txtBoxDni, 0);
            this.Controls.SetChildIndex(this.txtBoxFoto, 0);
            this.Controls.SetChildIndex(this.pBoxAlumno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxAlumno;
    }
}