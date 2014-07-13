namespace FrbaCommerce.Abm_Visibilidad
{
    partial class Alta
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
            this.button_Guardar = new System.Windows.Forms.Button();
            this.label_InfTexto = new System.Windows.Forms.Label();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.label_PorcentajeVenta = new System.Windows.Forms.Label();
            this.label_PrecioPublicitar = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox1_precio = new System.Windows.Forms.TextBox();
            this.textBox_Porcentaje = new System.Windows.Forms.TextBox();
            this.textBox_decimalPorcentaje = new System.Windows.Forms.TextBox();
            this.textBox_decimalPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paner_Alta.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(426, 12);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 16;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.MouseLeave += new System.EventHandler(this.button_Guardar_MouseLeave);
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            this.button_Guardar.MouseEnter += new System.EventHandler(this.button_Guardar_MouseEnter);
            // 
            // label_InfTexto
            // 
            this.label_InfTexto.AutoSize = true;
            this.label_InfTexto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_InfTexto.Location = new System.Drawing.Point(22, 294);
            this.label_InfTexto.Name = "label_InfTexto";
            this.label_InfTexto.Size = new System.Drawing.Size(65, 13);
            this.label_InfTexto.TabIndex = 15;
            this.label_InfTexto.Text = "Informacion:";
            // 
            // label_Informacion
            // 
            this.label_Informacion.AutoSize = true;
            this.label_Informacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Informacion.Location = new System.Drawing.Point(91, 295);
            this.label_Informacion.Name = "label_Informacion";
            this.label_Informacion.Size = new System.Drawing.Size(0, 13);
            this.label_Informacion.TabIndex = 14;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Limpiar.Location = new System.Drawing.Point(426, 41);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 13;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.MouseLeave += new System.EventHandler(this.button_Limpiar_MouseLeave);
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            this.button_Limpiar.MouseEnter += new System.EventHandler(this.button_Limpiar_MouseEnter);
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.textBox_decimalPrecio);
            this.paner_Alta.Controls.Add(this.textBox_decimalPorcentaje);
            this.paner_Alta.Controls.Add(this.textBox_Porcentaje);
            this.paner_Alta.Controls.Add(this.textBox1_precio);
            this.paner_Alta.Controls.Add(this.textBox_Descripcion);
            this.paner_Alta.Controls.Add(this.label_PorcentajeVenta);
            this.paner_Alta.Controls.Add(this.label_PrecioPublicitar);
            this.paner_Alta.Controls.Add(this.label_Descripcion);
            this.paner_Alta.Controls.Add(this.label_Nombre);
            this.paner_Alta.Controls.Add(this.textBox_Nombre);
            this.paner_Alta.Controls.Add(this.label1);
            this.paner_Alta.Controls.Add(this.label2);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.paner_Alta.Location = new System.Drawing.Point(12, 7);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(388, 278);
            this.paner_Alta.TabIndex = 12;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos de Visibilidad";
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(137, 77);
            this.textBox_Descripcion.MaxLength = 255;
            this.textBox_Descripcion.Multiline = true;
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(232, 99);
            this.textBox_Descripcion.TabIndex = 10;
            this.textBox_Descripcion.TextChanged += new System.EventHandler(this.textBox_Descripcion_TextChanged);
            this.textBox_Descripcion.MouseLeave += new System.EventHandler(this.textBox_Descripcion_MouseLeave);
            this.textBox_Descripcion.MouseEnter += new System.EventHandler(this.textBox_Descripcion_MouseEnter);
            // 
            // label_PorcentajeVenta
            // 
            this.label_PorcentajeVenta.AutoSize = true;
            this.label_PorcentajeVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PorcentajeVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_PorcentajeVenta.Location = new System.Drawing.Point(19, 211);
            this.label_PorcentajeVenta.Name = "label_PorcentajeVenta";
            this.label_PorcentajeVenta.Size = new System.Drawing.Size(114, 13);
            this.label_PorcentajeVenta.TabIndex = 6;
            this.label_PorcentajeVenta.Text = "Porcentaje de la venta";
            // 
            // label_PrecioPublicitar
            // 
            this.label_PrecioPublicitar.AutoSize = true;
            this.label_PrecioPublicitar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PrecioPublicitar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_PrecioPublicitar.Location = new System.Drawing.Point(33, 185);
            this.label_PrecioPublicitar.Name = "label_PrecioPublicitar";
            this.label_PrecioPublicitar.Size = new System.Drawing.Size(100, 13);
            this.label_PrecioPublicitar.TabIndex = 3;
            this.label_PrecioPublicitar.Text = "Precio por publicitar";
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Descripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Descripcion.Location = new System.Drawing.Point(70, 80);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion.TabIndex = 2;
            this.label_Descripcion.Text = "Descripcion";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(89, 54);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(137, 51);
            this.textBox_Nombre.MaxLength = 50;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            this.textBox_Nombre.MouseLeave += new System.EventHandler(this.textBox_Nombre_MouseLeave);
            this.textBox_Nombre.MouseEnter += new System.EventHandler(this.textBox_Nombre_MouseEnter);
            // 
            // textBox1_precio
            // 
            this.textBox1_precio.Location = new System.Drawing.Point(137, 182);
            this.textBox1_precio.MaxLength = 16;
            this.textBox1_precio.Name = "textBox1_precio";
            this.textBox1_precio.Size = new System.Drawing.Size(100, 20);
            this.textBox1_precio.TabIndex = 11;
            this.textBox1_precio.MouseLeave += new System.EventHandler(this.textBox1_precio_MouseLeave);
            this.textBox1_precio.MouseEnter += new System.EventHandler(this.textBox1_precio_MouseEnter);
            // 
            // textBox_Porcentaje
            // 
            this.textBox_Porcentaje.Location = new System.Drawing.Point(137, 208);
            this.textBox_Porcentaje.MaxLength = 16;
            this.textBox_Porcentaje.Name = "textBox_Porcentaje";
            this.textBox_Porcentaje.Size = new System.Drawing.Size(100, 20);
            this.textBox_Porcentaje.TabIndex = 12;
            this.textBox_Porcentaje.MouseLeave += new System.EventHandler(this.textBox_Porcentaje_MouseLeave);
            this.textBox_Porcentaje.MouseEnter += new System.EventHandler(this.textBox_Porcentaje_MouseEnter);
            // 
            // textBox_decimalPorcentaje
            // 
            this.textBox_decimalPorcentaje.Location = new System.Drawing.Point(243, 208);
            this.textBox_decimalPorcentaje.MaxLength = 2;
            this.textBox_decimalPorcentaje.Name = "textBox_decimalPorcentaje";
            this.textBox_decimalPorcentaje.Size = new System.Drawing.Size(44, 20);
            this.textBox_decimalPorcentaje.TabIndex = 14;
            this.textBox_decimalPorcentaje.Click += new System.EventHandler(this.textBox_decimalPorcentaje_Click);
            this.textBox_decimalPorcentaje.Leave += new System.EventHandler(this.textBox_decimalPorcentaje_Leave);
            // 
            // textBox_decimalPrecio
            // 
            this.textBox_decimalPrecio.Location = new System.Drawing.Point(243, 182);
            this.textBox_decimalPrecio.MaxLength = 2;
            this.textBox_decimalPrecio.Name = "textBox_decimalPrecio";
            this.textBox_decimalPrecio.Size = new System.Drawing.Size(44, 20);
            this.textBox_decimalPrecio.TabIndex = 15;
            this.textBox_decimalPrecio.Click += new System.EventHandler(this.textBox_decimalPrecio_Click);
            this.textBox_decimalPrecio.Leave += new System.EventHandler(this.textBox_decimalPrecio_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(234, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(234, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = ",";
            // 
            // Alta
            // 
            this.AcceptButton = this.button_Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.label_InfTexto);
            this.Controls.Add(this.label_Informacion);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.paner_Alta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Alta_Load);
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Label label_InfTexto;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.Label label_PorcentajeVenta;
        private System.Windows.Forms.Label label_PrecioPublicitar;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_decimalPrecio;
        private System.Windows.Forms.TextBox textBox_decimalPorcentaje;
        private System.Windows.Forms.TextBox textBox_Porcentaje;
        private System.Windows.Forms.TextBox textBox1_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}