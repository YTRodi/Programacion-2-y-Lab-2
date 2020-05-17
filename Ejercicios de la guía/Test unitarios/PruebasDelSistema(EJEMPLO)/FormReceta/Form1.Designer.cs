namespace FormReceta
{
    partial class Form1
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
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.btnImprimirReceta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(0, 0);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(546, 289);
            this.rtbSalidaDeTest.TabIndex = 0;
            this.rtbSalidaDeTest.Text = "";
            // 
            // btnImprimirReceta
            // 
            this.btnImprimirReceta.Location = new System.Drawing.Point(12, 295);
            this.btnImprimirReceta.Name = "btnImprimirReceta";
            this.btnImprimirReceta.Size = new System.Drawing.Size(521, 44);
            this.btnImprimirReceta.TabIndex = 1;
            this.btnImprimirReceta.Text = "Imprimr receta";
            this.btnImprimirReceta.UseVisualStyleBackColor = true;
            this.btnImprimirReceta.Click += new System.EventHandler(this.btnImprimirReceta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(545, 351);
            this.Controls.Add(this.btnImprimirReceta);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
        private System.Windows.Forms.Button btnImprimirReceta;
    }
}

