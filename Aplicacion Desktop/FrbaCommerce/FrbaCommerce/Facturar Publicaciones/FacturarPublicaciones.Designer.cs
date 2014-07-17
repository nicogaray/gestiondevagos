namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class FacturarPublicaciones
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
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_cantidadARendir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox_tarjeta = new System.Windows.Forms.GroupBox();
            this.radioButton_MASTERCARD = new System.Windows.Forms.RadioButton();
            this.radioButton_VISA = new System.Windows.Forms.RadioButton();
            this.radioButton_AMEX = new System.Windows.Forms.RadioButton();
            this.textBox_CodigoSeguridad = new System.Windows.Forms.TextBox();
            this.textBox_NombreTitular = new System.Windows.Forms.TextBox();
            this.textBox_numeroTarjeta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_Tarjeta = new System.Windows.Forms.RadioButton();
            this.radioButton_Efectivo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox_tarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(274, 13);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 0;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicaciones a Rendir";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 130);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_cantidadARendir
            // 
            this.textBox_cantidadARendir.Location = new System.Drawing.Point(175, 15);
            this.textBox_cantidadARendir.MaxLength = 2;
            this.textBox_cantidadARendir.Name = "textBox_cantidadARendir";
            this.textBox_cantidadARendir.Size = new System.Drawing.Size(58, 20);
            this.textBox_cantidadARendir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de Productos a rendir";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox_tarjeta);
            this.groupBox2.Controls.Add(this.radioButton_Tarjeta);
            this.groupBox2.Controls.Add(this.radioButton_Efectivo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 197);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox_tarjeta
            // 
            this.groupBox_tarjeta.Controls.Add(this.radioButton_MASTERCARD);
            this.groupBox_tarjeta.Controls.Add(this.radioButton_VISA);
            this.groupBox_tarjeta.Controls.Add(this.radioButton_AMEX);
            this.groupBox_tarjeta.Controls.Add(this.textBox_CodigoSeguridad);
            this.groupBox_tarjeta.Controls.Add(this.textBox_NombreTitular);
            this.groupBox_tarjeta.Controls.Add(this.textBox_numeroTarjeta);
            this.groupBox_tarjeta.Controls.Add(this.label5);
            this.groupBox_tarjeta.Controls.Add(this.label4);
            this.groupBox_tarjeta.Controls.Add(this.label3);
            this.groupBox_tarjeta.Location = new System.Drawing.Point(6, 42);
            this.groupBox_tarjeta.Name = "groupBox_tarjeta";
            this.groupBox_tarjeta.Size = new System.Drawing.Size(441, 149);
            this.groupBox_tarjeta.TabIndex = 3;
            this.groupBox_tarjeta.TabStop = false;
            this.groupBox_tarjeta.Text = "Datos de tarjeta";
            this.groupBox_tarjeta.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton_MASTERCARD
            // 
            this.radioButton_MASTERCARD.AutoSize = true;
            this.radioButton_MASTERCARD.Image = global::FrbaCommerce.Properties.Resources.payment_method_master_card_481;
            this.radioButton_MASTERCARD.Location = new System.Drawing.Point(187, 24);
            this.radioButton_MASTERCARD.Name = "radioButton_MASTERCARD";
            this.radioButton_MASTERCARD.Size = new System.Drawing.Size(62, 30);
            this.radioButton_MASTERCARD.TabIndex = 4;
            this.radioButton_MASTERCARD.TabStop = true;
            this.radioButton_MASTERCARD.UseVisualStyleBackColor = true;
            // 
            // radioButton_VISA
            // 
            this.radioButton_VISA.AutoSize = true;
            this.radioButton_VISA.Image = global::FrbaCommerce.Properties.Resources.payment_method_card_visa_481;
            this.radioButton_VISA.Location = new System.Drawing.Point(80, 24);
            this.radioButton_VISA.Name = "radioButton_VISA";
            this.radioButton_VISA.Size = new System.Drawing.Size(62, 30);
            this.radioButton_VISA.TabIndex = 5;
            this.radioButton_VISA.TabStop = true;
            this.radioButton_VISA.UseVisualStyleBackColor = true;
            // 
            // radioButton_AMEX
            // 
            this.radioButton_AMEX.AutoSize = true;
            this.radioButton_AMEX.Image = global::FrbaCommerce.Properties.Resources.payment_method_american_express_card_48;
            this.radioButton_AMEX.Location = new System.Drawing.Point(299, 24);
            this.radioButton_AMEX.Name = "radioButton_AMEX";
            this.radioButton_AMEX.Size = new System.Drawing.Size(62, 30);
            this.radioButton_AMEX.TabIndex = 6;
            this.radioButton_AMEX.TabStop = true;
            this.radioButton_AMEX.UseVisualStyleBackColor = true;
            // 
            // textBox_CodigoSeguridad
            // 
            this.textBox_CodigoSeguridad.Location = new System.Drawing.Point(152, 123);
            this.textBox_CodigoSeguridad.Name = "textBox_CodigoSeguridad";
            this.textBox_CodigoSeguridad.Size = new System.Drawing.Size(67, 20);
            this.textBox_CodigoSeguridad.TabIndex = 5;
            // 
            // textBox_NombreTitular
            // 
            this.textBox_NombreTitular.Location = new System.Drawing.Point(152, 97);
            this.textBox_NombreTitular.Name = "textBox_NombreTitular";
            this.textBox_NombreTitular.Size = new System.Drawing.Size(249, 20);
            this.textBox_NombreTitular.TabIndex = 4;
            // 
            // textBox_numeroTarjeta
            // 
            this.textBox_numeroTarjeta.Location = new System.Drawing.Point(152, 67);
            this.textBox_numeroTarjeta.Name = "textBox_numeroTarjeta";
            this.textBox_numeroTarjeta.Size = new System.Drawing.Size(249, 20);
            this.textBox_numeroTarjeta.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Codigo de Seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre del titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero de tarjeta";
            // 
            // radioButton_Tarjeta
            // 
            this.radioButton_Tarjeta.AutoSize = true;
            this.radioButton_Tarjeta.Location = new System.Drawing.Point(163, 19);
            this.radioButton_Tarjeta.Name = "radioButton_Tarjeta";
            this.radioButton_Tarjeta.Size = new System.Drawing.Size(109, 17);
            this.radioButton_Tarjeta.TabIndex = 2;
            this.radioButton_Tarjeta.TabStop = true;
            this.radioButton_Tarjeta.Text = "Tarjeta de Credito";
            this.radioButton_Tarjeta.UseVisualStyleBackColor = true;
            this.radioButton_Tarjeta.CheckedChanged += new System.EventHandler(this.radioButton_Tarjeta_CheckedChanged);
            // 
            // radioButton_Efectivo
            // 
            this.radioButton_Efectivo.AutoSize = true;
            this.radioButton_Efectivo.Location = new System.Drawing.Point(93, 19);
            this.radioButton_Efectivo.Name = "radioButton_Efectivo";
            this.radioButton_Efectivo.Size = new System.Drawing.Size(64, 17);
            this.radioButton_Efectivo.TabIndex = 1;
            this.radioButton_Efectivo.TabStop = true;
            this.radioButton_Efectivo.Text = "Efectivo";
            this.radioButton_Efectivo.UseVisualStyleBackColor = true;
            this.radioButton_Efectivo.CheckedChanged += new System.EventHandler(this.radioButton_Efectivo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Forma de Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monto a Pagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Comisiones";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(495, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button_Volver
            // 
            this.button_Volver.Location = new System.Drawing.Point(552, 421);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 8;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(390, 421);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 9;
            this.button_Guardar.Text = "Aceptar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(471, 421);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 10;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(527, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha";
            // 
            // FacturarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 456);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cantidadARendir);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FacturarPublicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.FacturarPublicaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_tarjeta.ResumeLayout(false);
            this.groupBox_tarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_cantidadARendir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_tarjeta;
        private System.Windows.Forms.TextBox textBox_numeroTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_Tarjeta;
        private System.Windows.Forms.RadioButton radioButton_Efectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_MASTERCARD;
        private System.Windows.Forms.RadioButton radioButton_VISA;
        private System.Windows.Forms.RadioButton radioButton_AMEX;
        private System.Windows.Forms.TextBox textBox_CodigoSeguridad;
        private System.Windows.Forms.TextBox textBox_NombreTitular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
    }
}