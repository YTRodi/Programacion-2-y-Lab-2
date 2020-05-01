namespace FormCantina
{
    partial class FormCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCantina));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnAgua = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnCerveza = new System.Windows.Forms.RadioButton();
            this.numUDCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numUDContenido = new System.Windows.Forms.NumericUpDown();
            this.barra1 = new ControlCantina.Barra();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBoxMarca);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbBotellaTipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioBtnAgua);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioBtnCerveza);
            this.panel1.Controls.Add(this.numUDCapacidad);
            this.panel1.Controls.Add(this.numUDContenido);
            this.panel1.Location = new System.Drawing.Point(34, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 129);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Botella Tipo";
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(126, 34);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(168, 20);
            this.txtBoxMarca.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(315, 62);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 41);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marca";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Items.AddRange(new object[] {
            "Vidrio",
            "Plastico"});
            this.cmbBotellaTipo.Location = new System.Drawing.Point(315, 33);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 5;
            this.cmbBotellaTipo.SelectedIndexChanged += new System.EventHandler(this.cmbBotellaTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Capacidad";
            // 
            // radioBtnAgua
            // 
            this.radioBtnAgua.AutoSize = true;
            this.radioBtnAgua.Location = new System.Drawing.Point(18, 83);
            this.radioBtnAgua.Name = "radioBtnAgua";
            this.radioBtnAgua.Size = new System.Drawing.Size(50, 17);
            this.radioBtnAgua.TabIndex = 2;
            this.radioBtnAgua.TabStop = true;
            this.radioBtnAgua.Text = "Agua";
            this.radioBtnAgua.UseVisualStyleBackColor = true;
            this.radioBtnAgua.CheckedChanged += new System.EventHandler(this.radioBtnAgua_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contenido";
            // 
            // radioBtnCerveza
            // 
            this.radioBtnCerveza.AutoSize = true;
            this.radioBtnCerveza.Location = new System.Drawing.Point(18, 34);
            this.radioBtnCerveza.Name = "radioBtnCerveza";
            this.radioBtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioBtnCerveza.TabIndex = 1;
            this.radioBtnCerveza.TabStop = true;
            this.radioBtnCerveza.Text = "Cerveza";
            this.radioBtnCerveza.UseVisualStyleBackColor = true;
            this.radioBtnCerveza.CheckedChanged += new System.EventHandler(this.radioBtnCerveza_CheckedChanged);
            // 
            // numUDCapacidad
            // 
            this.numUDCapacidad.Location = new System.Drawing.Point(126, 83);
            this.numUDCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUDCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDCapacidad.Name = "numUDCapacidad";
            this.numUDCapacidad.Size = new System.Drawing.Size(63, 20);
            this.numUDCapacidad.TabIndex = 4;
            this.numUDCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numUDContenido
            // 
            this.numUDContenido.Location = new System.Drawing.Point(231, 83);
            this.numUDContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUDContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDContenido.Name = "numUDContenido";
            this.numUDContenido.Size = new System.Drawing.Size(63, 20);
            this.numUDContenido.TabIndex = 4;
            this.numUDContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(-2, -3);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 368);
            this.barra1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 516);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodi.Yago.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDContenido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnAgua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnCerveza;
        private System.Windows.Forms.NumericUpDown numUDCapacidad;
        private System.Windows.Forms.NumericUpDown numUDContenido;
        private ControlCantina.Barra barra1;
    }
}

