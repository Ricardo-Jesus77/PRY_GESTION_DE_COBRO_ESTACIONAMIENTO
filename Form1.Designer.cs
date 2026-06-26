namespace PRY_GESTION_DE_COBRO_ESTACIONAMIENTO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBX_TIPO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_CALCULA = new System.Windows.Forms.Button();
            this.TXT_HORAS = new System.Windows.Forms.TextBox();
            this.LBL_TOTAL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_PAGO = new System.Windows.Forms.TextBox();
            this.BTN_PAGO = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_PAGO);
            this.groupBox1.Controls.Add(this.TXT_PAGO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LBL_TOTAL);
            this.groupBox1.Controls.Add(this.TXT_HORAS);
            this.groupBox1.Controls.Add(this.BTN_CALCULA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBX_TIPO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TARIFA DE COBRO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONAR TIPO DE VEHICULO";
            // 
            // CBX_TIPO
            // 
            this.CBX_TIPO.FormattingEnabled = true;
            this.CBX_TIPO.Location = new System.Drawing.Point(112, 132);
            this.CBX_TIPO.Name = "CBX_TIPO";
            this.CBX_TIPO.Size = new System.Drawing.Size(121, 24);
            this.CBX_TIPO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESAR HORAS";
            // 
            // BTN_CALCULA
            // 
            this.BTN_CALCULA.Location = new System.Drawing.Point(141, 257);
            this.BTN_CALCULA.Name = "BTN_CALCULA";
            this.BTN_CALCULA.Size = new System.Drawing.Size(75, 23);
            this.BTN_CALCULA.TabIndex = 3;
            this.BTN_CALCULA.Text = "CALCULAR";
            this.BTN_CALCULA.UseVisualStyleBackColor = true;
            this.BTN_CALCULA.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_HORAS
            // 
            this.TXT_HORAS.Location = new System.Drawing.Point(116, 210);
            this.TXT_HORAS.Name = "TXT_HORAS";
            this.TXT_HORAS.Size = new System.Drawing.Size(121, 22);
            this.TXT_HORAS.TabIndex = 4;
            // 
            // LBL_TOTAL
            // 
            this.LBL_TOTAL.AutoSize = true;
            this.LBL_TOTAL.Location = new System.Drawing.Point(28, 322);
            this.LBL_TOTAL.Name = "LBL_TOTAL";
            this.LBL_TOTAL.Size = new System.Drawing.Size(54, 16);
            this.LBL_TOTAL.TabIndex = 5;
            this.LBL_TOTAL.Text = "TOTAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "INGRESAR PAGO:";
            // 
            // TXT_PAGO
            // 
            this.TXT_PAGO.Location = new System.Drawing.Point(119, 392);
            this.TXT_PAGO.Name = "TXT_PAGO";
            this.TXT_PAGO.Size = new System.Drawing.Size(118, 22);
            this.TXT_PAGO.TabIndex = 7;
            // 
            // BTN_PAGO
            // 
            this.BTN_PAGO.Location = new System.Drawing.Point(141, 437);
            this.BTN_PAGO.Name = "BTN_PAGO";
            this.BTN_PAGO.Size = new System.Drawing.Size(75, 23);
            this.BTN_PAGO.TabIndex = 8;
            this.BTN_PAGO.Text = "PAGAR";
            this.BTN_PAGO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 541);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBX_TIPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_HORAS;
        private System.Windows.Forms.Button BTN_CALCULA;
        private System.Windows.Forms.Button BTN_PAGO;
        private System.Windows.Forms.TextBox TXT_PAGO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_TOTAL;
    }
}

