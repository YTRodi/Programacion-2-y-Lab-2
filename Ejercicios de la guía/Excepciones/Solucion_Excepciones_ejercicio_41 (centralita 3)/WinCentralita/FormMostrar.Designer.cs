namespace WinCentralita
{
    partial class FormMostrar
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
            this.richTxtBoxMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTxtBoxMostrar
            // 
            this.richTxtBoxMostrar.Location = new System.Drawing.Point(0, 0);
            this.richTxtBoxMostrar.Name = "richTxtBoxMostrar";
            this.richTxtBoxMostrar.ReadOnly = true;
            this.richTxtBoxMostrar.Size = new System.Drawing.Size(410, 406);
            this.richTxtBoxMostrar.TabIndex = 0;
            this.richTxtBoxMostrar.Text = "";
            // 
            // FormMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 418);
            this.Controls.Add(this.richTxtBoxMostrar);
            this.Name = "FormMostrar";
            this.Text = "FormMostrar";
            this.Load += new System.EventHandler(this.FormMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBoxMostrar;
    }
}