namespace FormsConversorDeTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConvertirFahrenheit = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvertirCelsius = new System.Windows.Forms.Button();
            this.btnConvertirKelvin = new System.Windows.Forms.Button();
            this.lblFahrenheitCentro = new System.Windows.Forms.Label();
            this.lblCelsiusCentro = new System.Windows.Forms.Label();
            this.lblKelvinCentro = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvinAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsiusAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtFahrenheitAFahrenhei = new System.Windows.Forms.TextBox();
            this.txtKelvinACelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitACelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrenheiAKelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvertirFahrenheit
            // 
            this.btnConvertirFahrenheit.Location = new System.Drawing.Point(202, 47);
            this.btnConvertirFahrenheit.Name = "btnConvertirFahrenheit";
            this.btnConvertirFahrenheit.Size = new System.Drawing.Size(90, 35);
            this.btnConvertirFahrenheit.TabIndex = 0;
            this.btnConvertirFahrenheit.Text = "--->";
            this.btnConvertirFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertirFahrenheit.Click += new System.EventHandler(this.btnConvertirFahrenheit_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(12, 47);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(88, 35);
            this.lblFahrenheit.TabIndex = 3;
            this.lblFahrenheit.Text = "Fahrenheit";
            this.lblFahrenheit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCelsius
            // 
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(12, 88);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(88, 35);
            this.lblCelsius.TabIndex = 4;
            this.lblCelsius.Text = "Celsius";
            this.lblCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKelvin
            // 
            this.lblKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin.Location = new System.Drawing.Point(12, 130);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(88, 35);
            this.lblKelvin.TabIndex = 5;
            this.lblKelvin.Text = "Kelvin";
            this.lblKelvin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheit.Location = new System.Drawing.Point(106, 47);
            this.txtFahrenheit.Multiline = true;
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(90, 35);
            this.txtFahrenheit.TabIndex = 8;
            this.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertirCelsius
            // 
            this.btnConvertirCelsius.Location = new System.Drawing.Point(202, 88);
            this.btnConvertirCelsius.Name = "btnConvertirCelsius";
            this.btnConvertirCelsius.Size = new System.Drawing.Size(90, 35);
            this.btnConvertirCelsius.TabIndex = 9;
            this.btnConvertirCelsius.Text = "--->";
            this.btnConvertirCelsius.UseVisualStyleBackColor = true;
            this.btnConvertirCelsius.Click += new System.EventHandler(this.btnConvertirCelsius_Click);
            // 
            // btnConvertirKelvin
            // 
            this.btnConvertirKelvin.Location = new System.Drawing.Point(202, 130);
            this.btnConvertirKelvin.Name = "btnConvertirKelvin";
            this.btnConvertirKelvin.Size = new System.Drawing.Size(90, 35);
            this.btnConvertirKelvin.TabIndex = 11;
            this.btnConvertirKelvin.Text = "--->";
            this.btnConvertirKelvin.UseVisualStyleBackColor = true;
            this.btnConvertirKelvin.Click += new System.EventHandler(this.btnConvertirKelvin_Click);
            // 
            // lblFahrenheitCentro
            // 
            this.lblFahrenheitCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheitCentro.Location = new System.Drawing.Point(298, 9);
            this.lblFahrenheitCentro.Name = "lblFahrenheitCentro";
            this.lblFahrenheitCentro.Size = new System.Drawing.Size(90, 35);
            this.lblFahrenheitCentro.TabIndex = 13;
            this.lblFahrenheitCentro.Text = "Fahrenheit";
            this.lblFahrenheitCentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCelsiusCentro
            // 
            this.lblCelsiusCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsiusCentro.Location = new System.Drawing.Point(394, 9);
            this.lblCelsiusCentro.Name = "lblCelsiusCentro";
            this.lblCelsiusCentro.Size = new System.Drawing.Size(90, 35);
            this.lblCelsiusCentro.TabIndex = 14;
            this.lblCelsiusCentro.Text = "Celsius";
            this.lblCelsiusCentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKelvinCentro
            // 
            this.lblKelvinCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvinCentro.Location = new System.Drawing.Point(490, 9);
            this.lblKelvinCentro.Name = "lblKelvinCentro";
            this.lblKelvinCentro.Size = new System.Drawing.Size(90, 35);
            this.lblKelvinCentro.TabIndex = 15;
            this.lblKelvinCentro.Text = "Kelvin";
            this.lblKelvinCentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsius.Location = new System.Drawing.Point(106, 88);
            this.txtCelsius.Multiline = true;
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(90, 35);
            this.txtCelsius.TabIndex = 25;
            this.txtCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvin.Location = new System.Drawing.Point(106, 129);
            this.txtKelvin.Multiline = true;
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(90, 35);
            this.txtKelvin.TabIndex = 26;
            this.txtKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinAFahrenheit
            // 
            this.txtKelvinAFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvinAFahrenheit.Location = new System.Drawing.Point(298, 129);
            this.txtKelvinAFahrenheit.Multiline = true;
            this.txtKelvinAFahrenheit.Name = "txtKelvinAFahrenheit";
            this.txtKelvinAFahrenheit.Size = new System.Drawing.Size(90, 35);
            this.txtKelvinAFahrenheit.TabIndex = 29;
            this.txtKelvinAFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusAFahrenheit
            // 
            this.txtCelsiusAFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsiusAFahrenheit.Location = new System.Drawing.Point(298, 88);
            this.txtCelsiusAFahrenheit.Multiline = true;
            this.txtCelsiusAFahrenheit.Name = "txtCelsiusAFahrenheit";
            this.txtCelsiusAFahrenheit.Size = new System.Drawing.Size(90, 35);
            this.txtCelsiusAFahrenheit.TabIndex = 28;
            this.txtCelsiusAFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheitAFahrenhei
            // 
            this.txtFahrenheitAFahrenhei.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheitAFahrenhei.Location = new System.Drawing.Point(298, 47);
            this.txtFahrenheitAFahrenhei.Multiline = true;
            this.txtFahrenheitAFahrenhei.Name = "txtFahrenheitAFahrenhei";
            this.txtFahrenheitAFahrenhei.Size = new System.Drawing.Size(90, 35);
            this.txtFahrenheitAFahrenhei.TabIndex = 27;
            this.txtFahrenheitAFahrenhei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinACelsius
            // 
            this.txtKelvinACelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvinACelsius.Location = new System.Drawing.Point(394, 128);
            this.txtKelvinACelsius.Multiline = true;
            this.txtKelvinACelsius.Name = "txtKelvinACelsius";
            this.txtKelvinACelsius.Size = new System.Drawing.Size(90, 35);
            this.txtKelvinACelsius.TabIndex = 32;
            this.txtKelvinACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusACelsius
            // 
            this.txtCelsiusACelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsiusACelsius.Location = new System.Drawing.Point(394, 87);
            this.txtCelsiusACelsius.Multiline = true;
            this.txtCelsiusACelsius.Name = "txtCelsiusACelsius";
            this.txtCelsiusACelsius.Size = new System.Drawing.Size(90, 35);
            this.txtCelsiusACelsius.TabIndex = 31;
            this.txtCelsiusACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheitACelsius
            // 
            this.txtFahrenheitACelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheitACelsius.Location = new System.Drawing.Point(394, 46);
            this.txtFahrenheitACelsius.Multiline = true;
            this.txtFahrenheitACelsius.Name = "txtFahrenheitACelsius";
            this.txtFahrenheitACelsius.Size = new System.Drawing.Size(90, 35);
            this.txtFahrenheitACelsius.TabIndex = 30;
            this.txtFahrenheitACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinAKelvin
            // 
            this.txtKelvinAKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvinAKelvin.Location = new System.Drawing.Point(490, 129);
            this.txtKelvinAKelvin.Multiline = true;
            this.txtKelvinAKelvin.Name = "txtKelvinAKelvin";
            this.txtKelvinAKelvin.Size = new System.Drawing.Size(90, 35);
            this.txtKelvinAKelvin.TabIndex = 35;
            this.txtKelvinAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusAKelvin
            // 
            this.txtCelsiusAKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsiusAKelvin.Location = new System.Drawing.Point(490, 88);
            this.txtCelsiusAKelvin.Multiline = true;
            this.txtCelsiusAKelvin.Name = "txtCelsiusAKelvin";
            this.txtCelsiusAKelvin.Size = new System.Drawing.Size(90, 35);
            this.txtCelsiusAKelvin.TabIndex = 34;
            this.txtCelsiusAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheiAKelvin
            // 
            this.txtFahrenheiAKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheiAKelvin.Location = new System.Drawing.Point(490, 47);
            this.txtFahrenheiAKelvin.Multiline = true;
            this.txtFahrenheiAKelvin.Name = "txtFahrenheiAKelvin";
            this.txtFahrenheiAKelvin.Size = new System.Drawing.Size(90, 35);
            this.txtFahrenheiAKelvin.TabIndex = 33;
            this.txtFahrenheiAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 175);
            this.Controls.Add(this.txtKelvinAKelvin);
            this.Controls.Add(this.txtCelsiusAKelvin);
            this.Controls.Add(this.txtFahrenheiAKelvin);
            this.Controls.Add(this.txtKelvinACelsius);
            this.Controls.Add(this.txtCelsiusACelsius);
            this.Controls.Add(this.txtFahrenheitACelsius);
            this.Controls.Add(this.txtKelvinAFahrenheit);
            this.Controls.Add(this.txtCelsiusAFahrenheit);
            this.Controls.Add(this.txtFahrenheitAFahrenhei);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblKelvinCentro);
            this.Controls.Add(this.lblCelsiusCentro);
            this.Controls.Add(this.lblFahrenheitCentro);
            this.Controls.Add(this.btnConvertirKelvin);
            this.Controls.Add(this.btnConvertirCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnConvertirFahrenheit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirFahrenheit;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnConvertirCelsius;
        private System.Windows.Forms.Button btnConvertirKelvin;
        private System.Windows.Forms.Label lblFahrenheitCentro;
        private System.Windows.Forms.Label lblCelsiusCentro;
        private System.Windows.Forms.Label lblKelvinCentro;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtKelvinAFahrenheit;
        private System.Windows.Forms.TextBox txtCelsiusAFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheitAFahrenhei;
        private System.Windows.Forms.TextBox txtKelvinACelsius;
        private System.Windows.Forms.TextBox txtCelsiusACelsius;
        private System.Windows.Forms.TextBox txtFahrenheitACelsius;
        private System.Windows.Forms.TextBox txtKelvinAKelvin;
        private System.Windows.Forms.TextBox txtCelsiusAKelvin;
        private System.Windows.Forms.TextBox txtFahrenheiAKelvin;
    }
}

