namespace FormsConversor
{
    partial class FormMonedas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonedas));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblPesoCentro = new System.Windows.Forms.Label();
            this.lblDolarCentro = new System.Windows.Forms.Label();
            this.lblEuroCentro = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.LblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.btnConvertirPeso = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.btnConvertirEuro = new System.Windows.Forms.Button();
            this.btnConvertirDolar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "iconfinder_icon-114-lock_314692(1).png");
            this.imageList.Images.SetKeyName(1, "iconfinder_icon-115-lock-open_314693.png");
            // 
            // lblPesoCentro
            // 
            this.lblPesoCentro.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoCentro.Location = new System.Drawing.Point(542, 41);
            this.lblPesoCentro.Name = "lblPesoCentro";
            this.lblPesoCentro.Size = new System.Drawing.Size(94, 28);
            this.lblPesoCentro.TabIndex = 63;
            this.lblPesoCentro.Text = "Peso";
            this.lblPesoCentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolarCentro
            // 
            this.lblDolarCentro.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarCentro.Location = new System.Drawing.Point(430, 41);
            this.lblDolarCentro.Name = "lblDolarCentro";
            this.lblDolarCentro.Size = new System.Drawing.Size(94, 28);
            this.lblDolarCentro.TabIndex = 62;
            this.lblDolarCentro.Text = "Dolar";
            this.lblDolarCentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEuroCentro
            // 
            this.lblEuroCentro.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroCentro.Location = new System.Drawing.Point(319, 41);
            this.lblEuroCentro.Name = "lblEuroCentro";
            this.lblEuroCentro.Size = new System.Drawing.Size(94, 28);
            this.lblEuroCentro.TabIndex = 61;
            this.lblEuroCentro.Text = "Euro";
            this.lblEuroCentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(12, 143);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(90, 27);
            this.lblPeso.TabIndex = 60;
            this.lblPeso.Text = "Peso";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDolar
            // 
            this.LblDolar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDolar.Location = new System.Drawing.Point(12, 109);
            this.LblDolar.Name = "LblDolar";
            this.LblDolar.Size = new System.Drawing.Size(90, 27);
            this.LblDolar.TabIndex = 59;
            this.LblDolar.Text = "Dolar";
            this.LblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEuro
            // 
            this.lblEuro.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(12, 74);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(90, 28);
            this.lblEuro.TabIndex = 58;
            this.lblEuro.Text = "Euro";
            this.lblEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(116, 13);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(98, 28);
            this.lblCotizacion.TabIndex = 54;
            this.lblCotizacion.Text = "Cotización";
            this.lblCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageIndex = 1;
            this.btnLockCotizacion.ImageList = this.imageList;
            this.btnLockCotizacion.Location = new System.Drawing.Point(233, 12);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(70, 29);
            this.btnLockCotizacion.TabIndex = 53;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionEuro.Location = new System.Drawing.Point(319, 13);
            this.txtCotizacionEuro.Multiline = true;
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(94, 28);
            this.txtCotizacionEuro.TabIndex = 80;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroAEuro.Location = new System.Drawing.Point(319, 75);
            this.txtEuroAEuro.Multiline = true;
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(94, 28);
            this.txtEuroAEuro.TabIndex = 81;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarAEuro.Location = new System.Drawing.Point(319, 108);
            this.txtDolarAEuro.Multiline = true;
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(94, 28);
            this.txtDolarAEuro.TabIndex = 82;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoAEuro.Location = new System.Drawing.Point(319, 143);
            this.txtPesoAEuro.Multiline = true;
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(94, 27);
            this.txtPesoAEuro.TabIndex = 86;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoADolar.Location = new System.Drawing.Point(430, 143);
            this.txtPesoADolar.Multiline = true;
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(94, 27);
            this.txtPesoADolar.TabIndex = 89;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarADolar.Location = new System.Drawing.Point(430, 109);
            this.txtDolarADolar.Multiline = true;
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(94, 28);
            this.txtDolarADolar.TabIndex = 88;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroADolar.Location = new System.Drawing.Point(430, 75);
            this.txtEuroADolar.Multiline = true;
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(94, 28);
            this.txtEuroADolar.TabIndex = 87;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoAPeso.Location = new System.Drawing.Point(542, 143);
            this.txtPesoAPeso.Multiline = true;
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(94, 27);
            this.txtPesoAPeso.TabIndex = 92;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarAPeso.Location = new System.Drawing.Point(542, 109);
            this.txtDolarAPeso.Multiline = true;
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(94, 28);
            this.txtDolarAPeso.TabIndex = 91;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroAPeso.Location = new System.Drawing.Point(542, 75);
            this.txtEuroAPeso.Multiline = true;
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(94, 28);
            this.txtEuroAPeso.TabIndex = 90;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionDolar.Location = new System.Drawing.Point(430, 12);
            this.txtCotizacionDolar.Multiline = true;
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(94, 28);
            this.txtCotizacionDolar.TabIndex = 93;
            this.txtCotizacionDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionPeso.Location = new System.Drawing.Point(542, 10);
            this.txtCotizacionPeso.Multiline = true;
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(94, 28);
            this.txtCotizacionPeso.TabIndex = 94;
            this.txtCotizacionPeso.Leave += new System.EventHandler(this.txtCotizacionPeso_Leave);
            // 
            // btnConvertirPeso
            // 
            this.btnConvertirPeso.ImageIndex = 1;
            this.btnConvertirPeso.Location = new System.Drawing.Point(233, 142);
            this.btnConvertirPeso.Name = "btnConvertirPeso";
            this.btnConvertirPeso.Size = new System.Drawing.Size(70, 28);
            this.btnConvertirPeso.TabIndex = 100;
            this.btnConvertirPeso.Text = "-->";
            this.btnConvertirPeso.UseVisualStyleBackColor = true;
            this.btnConvertirPeso.Click += new System.EventHandler(this.btnConvertirPeso_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(120, 142);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(94, 28);
            this.txtPeso.TabIndex = 103;
            // 
            // txtDolar
            // 
            this.txtDolar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.Location = new System.Drawing.Point(120, 108);
            this.txtDolar.Multiline = true;
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(94, 28);
            this.txtDolar.TabIndex = 102;
            // 
            // txtEuro
            // 
            this.txtEuro.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuro.Location = new System.Drawing.Point(120, 74);
            this.txtEuro.Multiline = true;
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(94, 28);
            this.txtEuro.TabIndex = 101;
            // 
            // btnConvertirEuro
            // 
            this.btnConvertirEuro.ImageIndex = 1;
            this.btnConvertirEuro.Location = new System.Drawing.Point(233, 74);
            this.btnConvertirEuro.Name = "btnConvertirEuro";
            this.btnConvertirEuro.Size = new System.Drawing.Size(70, 28);
            this.btnConvertirEuro.TabIndex = 98;
            this.btnConvertirEuro.Text = "-->";
            this.btnConvertirEuro.UseVisualStyleBackColor = true;
            this.btnConvertirEuro.Click += new System.EventHandler(this.btnConvertirEuro_Click);
            // 
            // btnConvertirDolar
            // 
            this.btnConvertirDolar.ImageIndex = 1;
            this.btnConvertirDolar.Location = new System.Drawing.Point(233, 108);
            this.btnConvertirDolar.Name = "btnConvertirDolar";
            this.btnConvertirDolar.Size = new System.Drawing.Size(70, 28);
            this.btnConvertirDolar.TabIndex = 99;
            this.btnConvertirDolar.Text = "-->";
            this.btnConvertirDolar.UseVisualStyleBackColor = true;
            this.btnConvertirDolar.Click += new System.EventHandler(this.btnConvertirDolar_Click);
            // 
            // FormMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 180);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.btnConvertirPeso);
            this.Controls.Add(this.btnConvertirDolar);
            this.Controls.Add(this.btnConvertirEuro);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPesoCentro);
            this.Controls.Add(this.lblDolarCentro);
            this.Controls.Add(this.lblEuroCentro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.LblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.btnLockCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lblPesoCentro;
        private System.Windows.Forms.Label lblDolarCentro;
        private System.Windows.Forms.Label lblEuroCentro;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label LblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.Button btnConvertirPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Button btnConvertirEuro;
        private System.Windows.Forms.Button btnConvertirDolar;
    }
}

