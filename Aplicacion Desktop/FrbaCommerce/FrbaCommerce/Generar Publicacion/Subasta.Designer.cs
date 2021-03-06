﻿namespace FrbaCommerce.Generar_Publicacion
{
    partial class Subasta
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
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ValorInicialDecimal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_Si = new System.Windows.Forms.RadioButton();
            this.textBox_CantidadPorLote = new System.Windows.Forms.TextBox();
            this.label_CantidadLote = new System.Windows.Forms.Label();
            this.dateTimePicker_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label_FechaVencimiento = new System.Windows.Forms.Label();
            this.radioButton_Pausada = new System.Windows.Forms.RadioButton();
            this.radioButton_Borrador = new System.Windows.Forms.RadioButton();
            this.radioButton_Activa = new System.Windows.Forms.RadioButton();
            this.label_Estado = new System.Windows.Forms.Label();
            this.comboBox_Visibilidad = new System.Windows.Forms.ComboBox();
            this.label_Visibilidad = new System.Windows.Forms.Label();
            this.checkedListBox_Rubro = new System.Windows.Forms.CheckedListBox();
            this.label_Rubro = new System.Windows.Forms.Label();
            this.textBox_ValorInicialEntero = new System.Windows.Forms.TextBox();
            this.label_ValorInicial = new System.Windows.Forms.Label();
            this.dateTimePicker_FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Guardar
            // 
            this.button_Guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Guardar.Location = new System.Drawing.Point(345, 280);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 8;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Limpiar.Location = new System.Drawing.Point(426, 280);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 6;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ValorInicialDecimal);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox_CantidadPorLote);
            this.groupBox1.Controls.Add(this.label_CantidadLote);
            this.groupBox1.Controls.Add(this.dateTimePicker_FechaInicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_FechaVencimiento);
            this.groupBox1.Controls.Add(this.radioButton_Pausada);
            this.groupBox1.Controls.Add(this.radioButton_Borrador);
            this.groupBox1.Controls.Add(this.radioButton_Activa);
            this.groupBox1.Controls.Add(this.label_Estado);
            this.groupBox1.Controls.Add(this.comboBox_Visibilidad);
            this.groupBox1.Controls.Add(this.label_Visibilidad);
            this.groupBox1.Controls.Add(this.checkedListBox_Rubro);
            this.groupBox1.Controls.Add(this.label_Rubro);
            this.groupBox1.Controls.Add(this.textBox_ValorInicialEntero);
            this.groupBox1.Controls.Add(this.label_ValorInicial);
            this.groupBox1.Controls.Add(this.dateTimePicker_FechaVencimiento);
            this.groupBox1.Controls.Add(this.textBox_descripcion);
            this.groupBox1.Controls.Add(this.label_Descripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Subasta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_ValorInicialDecimal
            // 
            this.textBox_ValorInicialDecimal.Location = new System.Drawing.Point(262, 44);
            this.textBox_ValorInicialDecimal.MaxLength = 2;
            this.textBox_ValorInicialDecimal.Name = "textBox_ValorInicialDecimal";
            this.textBox_ValorInicialDecimal.Size = new System.Drawing.Size(40, 20);
            this.textBox_ValorInicialDecimal.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_No);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButton_Si);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(6, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 31);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(287, 8);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(39, 17);
            this.radioButton_No.TabIndex = 15;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Permitir preguntas";
            // 
            // radioButton_Si
            // 
            this.radioButton_Si.AutoSize = true;
            this.radioButton_Si.Location = new System.Drawing.Point(247, 8);
            this.radioButton_Si.Name = "radioButton_Si";
            this.radioButton_Si.Size = new System.Drawing.Size(34, 17);
            this.radioButton_Si.TabIndex = 14;
            this.radioButton_Si.TabStop = true;
            this.radioButton_Si.Text = "Si";
            this.radioButton_Si.UseVisualStyleBackColor = true;
            // 
            // textBox_CantidadPorLote
            // 
            this.textBox_CantidadPorLote.Location = new System.Drawing.Point(188, 70);
            this.textBox_CantidadPorLote.MaxLength = 18;
            this.textBox_CantidadPorLote.Name = "textBox_CantidadPorLote";
            this.textBox_CantidadPorLote.Size = new System.Drawing.Size(65, 20);
            this.textBox_CantidadPorLote.TabIndex = 25;
            // 
            // label_CantidadLote
            // 
            this.label_CantidadLote.AutoSize = true;
            this.label_CantidadLote.Location = new System.Drawing.Point(95, 73);
            this.label_CantidadLote.Name = "label_CantidadLote";
            this.label_CantidadLote.Size = new System.Drawing.Size(87, 13);
            this.label_CantidadLote.TabIndex = 24;
            this.label_CantidadLote.Text = "Cantidad por lote";
            // 
            // dateTimePicker_FechaInicio
            // 
            this.dateTimePicker_FechaInicio.Location = new System.Drawing.Point(42, 185);
            this.dateTimePicker_FechaInicio.Name = "dateTimePicker_FechaInicio";
            this.dateTimePicker_FechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FechaInicio.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha Inicio";
            // 
            // label_FechaVencimiento
            // 
            this.label_FechaVencimiento.AutoSize = true;
            this.label_FechaVencimiento.Location = new System.Drawing.Point(243, 208);
            this.label_FechaVencimiento.Name = "label_FechaVencimiento";
            this.label_FechaVencimiento.Size = new System.Drawing.Size(98, 13);
            this.label_FechaVencimiento.TabIndex = 21;
            this.label_FechaVencimiento.Text = "Fecha Vencimineto";
            // 
            // radioButton_Pausada
            // 
            this.radioButton_Pausada.AutoSize = true;
            this.radioButton_Pausada.Location = new System.Drawing.Point(319, 162);
            this.radioButton_Pausada.Name = "radioButton_Pausada";
            this.radioButton_Pausada.Size = new System.Drawing.Size(67, 17);
            this.radioButton_Pausada.TabIndex = 20;
            this.radioButton_Pausada.TabStop = true;
            this.radioButton_Pausada.Text = "Pausada";
            this.radioButton_Pausada.UseVisualStyleBackColor = true;
            // 
            // radioButton_Borrador
            // 
            this.radioButton_Borrador.AutoSize = true;
            this.radioButton_Borrador.Location = new System.Drawing.Point(248, 162);
            this.radioButton_Borrador.Name = "radioButton_Borrador";
            this.radioButton_Borrador.Size = new System.Drawing.Size(65, 17);
            this.radioButton_Borrador.TabIndex = 18;
            this.radioButton_Borrador.TabStop = true;
            this.radioButton_Borrador.Text = "Borrador";
            this.radioButton_Borrador.UseVisualStyleBackColor = true;
            // 
            // radioButton_Activa
            // 
            this.radioButton_Activa.AutoSize = true;
            this.radioButton_Activa.Location = new System.Drawing.Point(187, 162);
            this.radioButton_Activa.Name = "radioButton_Activa";
            this.radioButton_Activa.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Activa.TabIndex = 17;
            this.radioButton_Activa.TabStop = true;
            this.radioButton_Activa.Text = "Activa";
            this.radioButton_Activa.UseVisualStyleBackColor = true;
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Location = new System.Drawing.Point(70, 164);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(112, 13);
            this.label_Estado.TabIndex = 16;
            this.label_Estado.Text = "Estado de publicacion";
            // 
            // comboBox_Visibilidad
            // 
            this.comboBox_Visibilidad.FormattingEnabled = true;
            this.comboBox_Visibilidad.Items.AddRange(new object[] {
            "Platino",
            "Oro",
            "Plata",
            "Bronce",
            "Gratis"});
            this.comboBox_Visibilidad.Location = new System.Drawing.Point(187, 135);
            this.comboBox_Visibilidad.Name = "comboBox_Visibilidad";
            this.comboBox_Visibilidad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Visibilidad.TabIndex = 12;
            // 
            // label_Visibilidad
            // 
            this.label_Visibilidad.AutoSize = true;
            this.label_Visibilidad.Location = new System.Drawing.Point(129, 138);
            this.label_Visibilidad.Name = "label_Visibilidad";
            this.label_Visibilidad.Size = new System.Drawing.Size(53, 13);
            this.label_Visibilidad.TabIndex = 11;
            this.label_Visibilidad.Text = "Visibilidad";
            // 
            // checkedListBox_Rubro
            // 
            this.checkedListBox_Rubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_Rubro.CheckOnClick = true;
            this.checkedListBox_Rubro.FormattingEnabled = true;
            this.checkedListBox_Rubro.Items.AddRange(new object[] {
            "Industrias y Oficinas",
            "Música, Películas y Series",
            "Electrónica, Audio y Video",
            "Otras categorías",
            "Antigüedades",
            "Accesorios para Vehículos",
            "Arte y Artesanías",
            "Computación",
            "Hogar, Muebles y Jardín",
            "Joyas y Relojes",
            "Libros, Revistas y Comics",
            "Entradas para Eventos",
            "Coleccionables y Hobbies",
            "Deportes y Fitness",
            "Instrumentos Musicales",
            "Bebés",
            "Celulares y Teléfonos",
            "Juegos y Juguetes",
            "Cámaras y Accesorios",
            "Ropa y Accesorios",
            "Animales y Mascotas",
            "Delicatessen y Vinos",
            "Salud y Belleza",
            "Electrodomésticos y Aires Ac.",
            "Consolas y Videojuegos"});
            this.checkedListBox_Rubro.Location = new System.Drawing.Point(187, 97);
            this.checkedListBox_Rubro.Name = "checkedListBox_Rubro";
            this.checkedListBox_Rubro.Size = new System.Drawing.Size(188, 32);
            this.checkedListBox_Rubro.TabIndex = 10;
            // 
            // label_Rubro
            // 
            this.label_Rubro.AutoSize = true;
            this.label_Rubro.Location = new System.Drawing.Point(146, 107);
            this.label_Rubro.Name = "label_Rubro";
            this.label_Rubro.Size = new System.Drawing.Size(36, 13);
            this.label_Rubro.TabIndex = 9;
            this.label_Rubro.Text = "Rubro";
            // 
            // textBox_ValorInicialEntero
            // 
            this.textBox_ValorInicialEntero.Location = new System.Drawing.Point(188, 44);
            this.textBox_ValorInicialEntero.MaxLength = 16;
            this.textBox_ValorInicialEntero.Name = "textBox_ValorInicialEntero";
            this.textBox_ValorInicialEntero.Size = new System.Drawing.Size(65, 20);
            this.textBox_ValorInicialEntero.TabIndex = 8;
            // 
            // label_ValorInicial
            // 
            this.label_ValorInicial.AutoSize = true;
            this.label_ValorInicial.Location = new System.Drawing.Point(122, 47);
            this.label_ValorInicial.Name = "label_ValorInicial";
            this.label_ValorInicial.Size = new System.Drawing.Size(60, 13);
            this.label_ValorInicial.TabIndex = 7;
            this.label_ValorInicial.Text = "Valor inicial";
            // 
            // dateTimePicker_FechaVencimiento
            // 
            this.dateTimePicker_FechaVencimiento.Location = new System.Drawing.Point(246, 185);
            this.dateTimePicker_FechaVencimiento.Name = "dateTimePicker_FechaVencimiento";
            this.dateTimePicker_FechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FechaVencimiento.TabIndex = 5;
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(187, 19);
            this.textBox_descripcion.MaxLength = 255;
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(231, 20);
            this.textBox_descripcion.TabIndex = 1;
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(119, 22);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion.TabIndex = 0;
            this.label_Descripcion.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(250, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = ",";
            // 
            // Subasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Subasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subasta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_CantidadPorLote;
        private System.Windows.Forms.Label label_CantidadLote;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FechaVencimiento;
        private System.Windows.Forms.RadioButton radioButton_Pausada;
        private System.Windows.Forms.RadioButton radioButton_Borrador;
        private System.Windows.Forms.RadioButton radioButton_Activa;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.ComboBox comboBox_Visibilidad;
        private System.Windows.Forms.Label label_Visibilidad;
        private System.Windows.Forms.CheckedListBox checkedListBox_Rubro;
        private System.Windows.Forms.Label label_Rubro;
        private System.Windows.Forms.TextBox textBox_ValorInicialEntero;
        private System.Windows.Forms.Label label_ValorInicial;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaVencimiento;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Si;
        private System.Windows.Forms.TextBox textBox_ValorInicialDecimal;
        private System.Windows.Forms.Label label3;

    }
}