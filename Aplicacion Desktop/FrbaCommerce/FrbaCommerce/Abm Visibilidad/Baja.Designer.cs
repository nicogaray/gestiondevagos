namespace FrbaCommerce.Abm_Visibilidad
{
    partial class Baja
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
            this.label_InfTexto = new System.Windows.Forms.Label();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.label_PorcentajeVenta = new System.Windows.Forms.Label();
            this.label_PrecioPublicitar = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Borrar = new System.Windows.Forms.Button();
            this.textBox_decimalPrecio = new System.Windows.Forms.TextBox();
            this.textBox_decimalPorcentaje = new System.Windows.Forms.TextBox();
            this.textBox_Porcentaje = new System.Windows.Forms.TextBox();
            this.textBox1_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paner_Alta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_InfTexto
            // 
            this.label_InfTexto.AutoSize = true;
            this.label_InfTexto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_InfTexto.Location = new System.Drawing.Point(22, 294);
            this.label_InfTexto.Name = "label_InfTexto";
            this.label_InfTexto.Size = new System.Drawing.Size(65, 13);
            this.label_InfTexto.TabIndex = 20;
            this.label_InfTexto.Text = "Informacion:";
            // 
            // label_Informacion
            // 
            this.label_Informacion.AutoSize = true;
            this.label_Informacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Informacion.Location = new System.Drawing.Point(91, 295);
            this.label_Informacion.Name = "label_Informacion";
            this.label_Informacion.Size = new System.Drawing.Size(0, 13);
            this.label_Informacion.TabIndex = 19;
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.textBox_decimalPrecio);
            this.paner_Alta.Controls.Add(this.textBox_Descripcion);
            this.paner_Alta.Controls.Add(this.textBox_decimalPorcentaje);
            this.paner_Alta.Controls.Add(this.label_PorcentajeVenta);
            this.paner_Alta.Controls.Add(this.textBox_Porcentaje);
            this.paner_Alta.Controls.Add(this.label_PrecioPublicitar);
            this.paner_Alta.Controls.Add(this.textBox1_precio);
            this.paner_Alta.Controls.Add(this.label1);
            this.paner_Alta.Controls.Add(this.label_Descripcion);
            this.paner_Alta.Controls.Add(this.label2);
            this.paner_Alta.Controls.Add(this.label_Nombre);
            this.paner_Alta.Controls.Add(this.textBox_Nombre);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.paner_Alta.Location = new System.Drawing.Point(12, 7);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(388, 278);
            this.paner_Alta.TabIndex = 17;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos de Visibilidad";
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(137, 77);
            this.textBox_Descripcion.Multiline = true;
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(232, 99);
            this.textBox_Descripcion.TabIndex = 10;
            this.textBox_Descripcion.MouseLeave += new System.EventHandler(this.textBox_PrecioPublicitar_MouseLeave);
            this.textBox_Descripcion.MouseEnter += new System.EventHandler(this.textBox_PrecioPublicitar_MouseEnter);
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
            this.label_PorcentajeVenta.MouseLeave += new System.EventHandler(this.textBox_PrecioPublicitar_MouseLeave);
            this.label_PorcentajeVenta.MouseEnter += new System.EventHandler(this.textBox_PrecioPublicitar_MouseEnter);
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
            this.label_PrecioPublicitar.MouseLeave += new System.EventHandler(this.textBox_PrecioPublicitar_MouseLeave);
            this.label_PrecioPublicitar.MouseEnter += new System.EventHandler(this.textBox_PrecioPublicitar_MouseEnter);
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
            this.label_Descripcion.MouseLeave += new System.EventHandler(this.textBox_PrecioPublicitar_MouseLeave);
            this.label_Descripcion.MouseEnter += new System.EventHandler(this.textBox_PrecioPublicitar_MouseEnter);
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
            this.label_Nombre.MouseLeave += new System.EventHandler(this.textBox_PrecioPublicitar_MouseLeave);
            this.label_Nombre.MouseEnter += new System.EventHandler(this.textBox_PrecioPublicitar_MouseEnter);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(137, 51);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            this.textBox_Nombre.MouseLeave += new System.EventHandler(this.textBox_PrecioPublicitar_MouseLeave);
            this.textBox_Nombre.MouseEnter += new System.EventHandler(this.textBox_PrecioPublicitar_MouseEnter);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(426, 41);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 22;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.MouseLeave += new System.EventHandler(this.button_Cancelar_MouseLeave);
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            this.button_Cancelar.MouseEnter += new System.EventHandler(this.button_Cancelar_MouseEnter);
            // 
            // button_Borrar
            // 
            this.button_Borrar.Location = new System.Drawing.Point(426, 12);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(75, 23);
            this.button_Borrar.TabIndex = 21;
            this.button_Borrar.Text = "Borrar";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.MouseLeave += new System.EventHandler(this.button_Borrar_MouseLeave);
            this.button_Borrar.Click += new System.EventHandler(this.button_Borrar_Click);
            this.button_Borrar.MouseEnter += new System.EventHandler(this.button_Borrar_MouseEnter);
            // 
            // textBox_decimalPrecio
            // 
            this.textBox_decimalPrecio.Location = new System.Drawing.Point(245, 182);
            this.textBox_decimalPrecio.MaxLength = 2;
            this.textBox_decimalPrecio.Name = "textBox_decimalPrecio";
            this.textBox_decimalPrecio.Size = new System.Drawing.Size(44, 20);
            this.textBox_decimalPrecio.TabIndex = 26;
            // 
            // textBox_decimalPorcentaje
            // 
            this.textBox_decimalPorcentaje.Location = new System.Drawing.Point(245, 208);
            this.textBox_decimalPorcentaje.MaxLength = 2;
            this.textBox_decimalPorcentaje.Name = "textBox_decimalPorcentaje";
            this.textBox_decimalPorcentaje.Size = new System.Drawing.Size(44, 20);
            this.textBox_decimalPorcentaje.TabIndex = 25;
            // 
            // textBox_Porcentaje
            // 
            this.textBox_Porcentaje.Location = new System.Drawing.Point(139, 208);
            this.textBox_Porcentaje.MaxLength = 16;
            this.textBox_Porcentaje.Name = "textBox_Porcentaje";
            this.textBox_Porcentaje.Size = new System.Drawing.Size(100, 20);
            this.textBox_Porcentaje.TabIndex = 24;
            // 
            // textBox1_precio
            // 
            this.textBox1_precio.Location = new System.Drawing.Point(139, 182);
            this.textBox1_precio.MaxLength = 16;
            this.textBox1_precio.Name = "textBox1_precio";
            this.textBox1_precio.Size = new System.Drawing.Size(100, 20);
            this.textBox1_precio.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(236, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(236, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = ",";
            // 
            // Baja
            // 
            this.AcceptButton = this.button_Borrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Borrar);
            this.Controls.Add(this.label_InfTexto);
            this.Controls.Add(this.label_Informacion);
            this.Controls.Add(this.paner_Alta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InfTexto;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.Label label_PorcentajeVenta;
        private System.Windows.Forms.Label label_PrecioPublicitar;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Borrar;
        private System.Windows.Forms.TextBox textBox_decimalPrecio;
        private System.Windows.Forms.TextBox textBox_decimalPorcentaje;
        private System.Windows.Forms.TextBox textBox_Porcentaje;
        private System.Windows.Forms.TextBox textBox1_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}