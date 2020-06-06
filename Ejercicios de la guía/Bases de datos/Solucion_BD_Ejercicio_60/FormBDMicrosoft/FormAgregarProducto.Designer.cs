namespace FormBDMicrosoft
{
    partial class FormAgregarProducto
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
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtNumeroProducto = new System.Windows.Forms.TextBox();
            this.lblNumeroProducto = new System.Windows.Forms.Label();
            this.lblColorProducto = new System.Windows.Forms.Label();
            this.cmboxColor = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(12, 23);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(161, 31);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre del producto :";
            this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(179, 23);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(161, 31);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumeroProducto
            // 
            this.txtNumeroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroProducto.Location = new System.Drawing.Point(179, 71);
            this.txtNumeroProducto.Multiline = true;
            this.txtNumeroProducto.Name = "txtNumeroProducto";
            this.txtNumeroProducto.Size = new System.Drawing.Size(161, 31);
            this.txtNumeroProducto.TabIndex = 3;
            this.txtNumeroProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumeroProducto
            // 
            this.lblNumeroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroProducto.Location = new System.Drawing.Point(12, 71);
            this.lblNumeroProducto.Name = "lblNumeroProducto";
            this.lblNumeroProducto.Size = new System.Drawing.Size(161, 31);
            this.lblNumeroProducto.TabIndex = 2;
            this.lblNumeroProducto.Text = "Número del producto :";
            this.lblNumeroProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblColorProducto
            // 
            this.lblColorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorProducto.Location = new System.Drawing.Point(12, 112);
            this.lblColorProducto.Name = "lblColorProducto";
            this.lblColorProducto.Size = new System.Drawing.Size(161, 31);
            this.lblColorProducto.TabIndex = 4;
            this.lblColorProducto.Text = "Color :";
            this.lblColorProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboxColor
            // 
            this.cmboxColor.FormattingEnabled = true;
            this.cmboxColor.Location = new System.Drawing.Point(179, 119);
            this.cmboxColor.Name = "cmboxColor";
            this.cmboxColor.Size = new System.Drawing.Size(161, 21);
            this.cmboxColor.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 163);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 56);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(179, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 56);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 229);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmboxColor);
            this.Controls.Add(this.lblColorProducto);
            this.Controls.Add(this.txtNumeroProducto);
            this.Controls.Add(this.lblNumeroProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Name = "FormAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarProducto";
            this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtNumeroProducto;
        private System.Windows.Forms.Label lblNumeroProducto;
        private System.Windows.Forms.Label lblColorProducto;
        private System.Windows.Forms.ComboBox cmboxColor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}