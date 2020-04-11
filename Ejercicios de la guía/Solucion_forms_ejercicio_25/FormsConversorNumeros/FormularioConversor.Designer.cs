namespace FormsConversorNumeros
{
    partial class FormularioConversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConversor));
            this.lblBinADec = new System.Windows.Forms.Label();
            this.lblDecABin = new System.Windows.Forms.Label();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinADec
            // 
            this.lblBinADec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinADec.Location = new System.Drawing.Point(12, 9);
            this.lblBinADec.Name = "lblBinADec";
            this.lblBinADec.Size = new System.Drawing.Size(144, 36);
            this.lblBinADec.TabIndex = 0;
            this.lblBinADec.Text = "Binario a Decimal";
            this.lblBinADec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDecABin
            // 
            this.lblDecABin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecABin.Location = new System.Drawing.Point(12, 54);
            this.lblDecABin.Name = "lblDecABin";
            this.lblDecABin.Size = new System.Drawing.Size(144, 36);
            this.lblDecABin.TabIndex = 1;
            this.lblDecABin.Text = "Decimal a Binario";
            this.lblDecABin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(298, 9);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(104, 36);
            this.btnBinToDec.TabIndex = 4;
            this.btnBinToDec.Text = "-->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(298, 55);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(104, 36);
            this.btnDecToBin.TabIndex = 5;
            this.btnDecToBin.Text = "-->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(162, 54);
            this.txtDecimal.Multiline = true;
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(130, 36);
            this.txtDecimal.TabIndex = 9;
            // 
            // txtBinario
            // 
            this.txtBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinario.Location = new System.Drawing.Point(162, 9);
            this.txtBinario.Multiline = true;
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(130, 36);
            this.txtBinario.TabIndex = 12;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoDec.Location = new System.Drawing.Point(408, 10);
            this.txtResultadoDec.Multiline = true;
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(130, 36);
            this.txtResultadoDec.TabIndex = 14;
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoBin.Location = new System.Drawing.Point(408, 55);
            this.txtResultadoBin.Multiline = true;
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(130, 36);
            this.txtResultadoBin.TabIndex = 13;
            // 
            // FormularioConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 100);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.lblDecABin);
            this.Controls.Add(this.lblBinADec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinADec;
        private System.Windows.Forms.Label lblDecABin;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtResultadoBin;
    }
}

