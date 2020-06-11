namespace WindowsFormsApp1
{
    partial class Form03
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.btnEntrarHiloP = new System.Windows.Forms.Button();
            this.btnSalirHiloP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha y hora en tiempo real:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl01
            // 
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(0, 60);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(239, 113);
            this.lbl01.TabIndex = 4;
            this.lbl01.Text = "Label por defecto";
            this.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrarHiloP
            // 
            this.btnEntrarHiloP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarHiloP.Location = new System.Drawing.Point(245, 64);
            this.btnEntrarHiloP.Name = "btnEntrarHiloP";
            this.btnEntrarHiloP.Size = new System.Drawing.Size(130, 53);
            this.btnEntrarHiloP.TabIndex = 5;
            this.btnEntrarHiloP.Text = "Entrar al hilo principal";
            this.btnEntrarHiloP.UseVisualStyleBackColor = true;
            this.btnEntrarHiloP.Click += new System.EventHandler(this.btnEntrarHiloP_Click);
            // 
            // btnSalirHiloP
            // 
            this.btnSalirHiloP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirHiloP.Location = new System.Drawing.Point(245, 123);
            this.btnSalirHiloP.Name = "btnSalirHiloP";
            this.btnSalirHiloP.Size = new System.Drawing.Size(130, 53);
            this.btnSalirHiloP.TabIndex = 6;
            this.btnSalirHiloP.Text = "Salir del hilo";
            this.btnSalirHiloP.UseVisualStyleBackColor = true;
            this.btnSalirHiloP.Click += new System.EventHandler(this.btnSalirHiloP_Click);
            // 
            // Form03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 186);
            this.Controls.Add(this.btnSalirHiloP);
            this.Controls.Add(this.btnEntrarHiloP);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.label1);
            this.Name = "Form03";
            this.Text = "Form03";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form03_FormClosing);
            this.Load += new System.EventHandler(this.Form03_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Button btnEntrarHiloP;
        private System.Windows.Forms.Button btnSalirHiloP;
    }
}