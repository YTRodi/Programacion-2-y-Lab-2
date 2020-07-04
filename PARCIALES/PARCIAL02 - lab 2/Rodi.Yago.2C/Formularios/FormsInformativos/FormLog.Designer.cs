namespace Formularios.FormsInformativos
{
    partial class FormLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            this.lblLog = new System.Windows.Forms.Label();
            this.pBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.rtbMostrarLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.White;
            this.lblLog.Location = new System.Drawing.Point(193, 12);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(36, 18);
            this.lblLog.TabIndex = 2;
            this.lblLog.Text = "Log";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxCerrar
            // 
            this.pBoxCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.pBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCerrar.Image")));
            this.pBoxCerrar.Location = new System.Drawing.Point(377, 12);
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
            this.panelSuperior.Controls.Add(this.lblLog);
            this.panelSuperior.Controls.Add(this.pBoxCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(418, 40);
            this.panelSuperior.TabIndex = 1;
            // 
            // rtbMostrarLog
            // 
            this.rtbMostrarLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMostrarLog.Location = new System.Drawing.Point(0, 40);
            this.rtbMostrarLog.Name = "rtbMostrarLog";
            this.rtbMostrarLog.Size = new System.Drawing.Size(418, 309);
            this.rtbMostrarLog.TabIndex = 2;
            this.rtbMostrarLog.Text = "";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 349);
            this.Controls.Add(this.rtbMostrarLog);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLog";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.PictureBox pBoxCerrar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.RichTextBox rtbMostrarLog;
    }
}