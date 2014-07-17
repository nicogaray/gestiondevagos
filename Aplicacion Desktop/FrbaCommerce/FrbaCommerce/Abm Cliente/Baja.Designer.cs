namespace FrbaCommerce.Abm_Cliente
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
            this.dateTimePicker_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_CodigoPostal = new System.Windows.Forms.TextBox();
            this.radioButton_Pas = new System.Windows.Forms.RadioButton();
            this.radioButton_Ci = new System.Windows.Forms.RadioButton();
            this.radioButton_Le = new System.Windows.Forms.RadioButton();
            this.radioButton_Lc = new System.Windows.Forms.RadioButton();
            this.radioButton_Dni = new System.Windows.Forms.RadioButton();
            this.textBox_Documento = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label_FechaNacimiento = new System.Windows.Forms.Label();
            this.label_CodigoPostal = new System.Windows.Forms.Label();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.label_Telefono = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_TipoDocumento = new System.Windows.Forms.Label();
            this.label_Documento = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.button_Borrar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.textBox_Cuil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.textBox_Cuil);
            this.paner_Alta.Controls.Add(this.label1);
            this.paner_Alta.Controls.Add(this.dateTimePicker_FechaNacimiento);
            this.paner_Alta.Controls.Add(this.textBox_Mail);
            this.paner_Alta.Controls.Add(this.textBox_CodigoPostal);
            this.paner_Alta.Controls.Add(this.radioButton_Pas);
            this.paner_Alta.Controls.Add(this.radioButton_Ci);
            this.paner_Alta.Controls.Add(this.radioButton_Le);
            this.paner_Alta.Controls.Add(this.radioButton_Lc);
            this.paner_Alta.Controls.Add(this.radioButton_Dni);
            this.paner_Alta.Controls.Add(this.textBox_Documento);
            this.paner_Alta.Controls.Add(this.textBox_Telefono);
            this.paner_Alta.Controls.Add(this.textBox_Direccion);
            this.paner_Alta.Controls.Add(this.textBox_Apellido);
            this.paner_Alta.Controls.Add(this.label_FechaNacimiento);
            this.paner_Alta.Controls.Add(this.label_CodigoPostal);
            this.paner_Alta.Controls.Add(this.label_Direccion);
            this.paner_Alta.Controls.Add(this.label_Telefono);
            this.paner_Alta.Controls.Add(this.label_Mail);
            this.paner_Alta.Controls.Add(this.label_TipoDocumento);
            this.paner_Alta.Controls.Add(this.label_Documento);
            this.paner_Alta.Controls.Add(this.label_Apellido);
            this.paner_Alta.Controls.Add(this.label_Nombre);
            this.paner_Alta.Controls.Add(this.textBox_Nombre);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.paner_Alta.Location = new System.Drawing.Point(12, 7);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(388, 284);
            this.paner_Alta.TabIndex = 12;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos del Cliente";
            this.paner_Alta.Enter += new System.EventHandler(this.paner_Alta_Enter);
            // 
            // dateTimePicker_FechaNacimiento
            // 
            this.dateTimePicker_FechaNacimiento.Location = new System.Drawing.Point(133, 257);
            this.dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            this.dateTimePicker_FechaNacimiento.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker_FechaNacimiento.TabIndex = 22;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(133, 205);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mail.TabIndex = 20;
            this.textBox_Mail.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Mail.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_CodigoPostal
            // 
            this.textBox_CodigoPostal.Location = new System.Drawing.Point(133, 179);
            this.textBox_CodigoPostal.Name = "textBox_CodigoPostal";
            this.textBox_CodigoPostal.Size = new System.Drawing.Size(129, 20);
            this.textBox_CodigoPostal.TabIndex = 19;
            this.textBox_CodigoPostal.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_CodigoPostal.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // radioButton_Pas
            // 
            this.radioButton_Pas.AutoSize = true;
            this.radioButton_Pas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_Pas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton_Pas.Location = new System.Drawing.Point(312, 80);
            this.radioButton_Pas.Name = "radioButton_Pas";
            this.radioButton_Pas.Size = new System.Drawing.Size(46, 17);
            this.radioButton_Pas.TabIndex = 18;
            this.radioButton_Pas.TabStop = true;
            this.radioButton_Pas.Text = "PAS";
            this.radioButton_Pas.UseVisualStyleBackColor = true;
            this.radioButton_Pas.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.radioButton_Pas.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // radioButton_Ci
            // 
            this.radioButton_Ci.AutoSize = true;
            this.radioButton_Ci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_Ci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton_Ci.Location = new System.Drawing.Point(183, 80);
            this.radioButton_Ci.Name = "radioButton_Ci";
            this.radioButton_Ci.Size = new System.Drawing.Size(35, 17);
            this.radioButton_Ci.TabIndex = 17;
            this.radioButton_Ci.TabStop = true;
            this.radioButton_Ci.Text = "CI";
            this.radioButton_Ci.UseVisualStyleBackColor = true;
            this.radioButton_Ci.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.radioButton_Ci.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // radioButton_Le
            // 
            this.radioButton_Le.AutoSize = true;
            this.radioButton_Le.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_Le.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton_Le.Location = new System.Drawing.Point(268, 80);
            this.radioButton_Le.Name = "radioButton_Le";
            this.radioButton_Le.Size = new System.Drawing.Size(38, 17);
            this.radioButton_Le.TabIndex = 16;
            this.radioButton_Le.TabStop = true;
            this.radioButton_Le.Text = "LE";
            this.radioButton_Le.UseVisualStyleBackColor = true;
            this.radioButton_Le.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.radioButton_Le.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // radioButton_Lc
            // 
            this.radioButton_Lc.AutoSize = true;
            this.radioButton_Lc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_Lc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton_Lc.Location = new System.Drawing.Point(224, 80);
            this.radioButton_Lc.Name = "radioButton_Lc";
            this.radioButton_Lc.Size = new System.Drawing.Size(38, 17);
            this.radioButton_Lc.TabIndex = 15;
            this.radioButton_Lc.TabStop = true;
            this.radioButton_Lc.Text = "LC";
            this.radioButton_Lc.UseVisualStyleBackColor = true;
            this.radioButton_Lc.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.radioButton_Lc.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // radioButton_Dni
            // 
            this.radioButton_Dni.AutoSize = true;
            this.radioButton_Dni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_Dni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton_Dni.Location = new System.Drawing.Point(133, 80);
            this.radioButton_Dni.Name = "radioButton_Dni";
            this.radioButton_Dni.Size = new System.Drawing.Size(44, 17);
            this.radioButton_Dni.TabIndex = 14;
            this.radioButton_Dni.TabStop = true;
            this.radioButton_Dni.Text = "DNI";
            this.radioButton_Dni.UseVisualStyleBackColor = true;
            this.radioButton_Dni.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.radioButton_Dni.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_Documento
            // 
            this.textBox_Documento.Location = new System.Drawing.Point(133, 103);
            this.textBox_Documento.Name = "textBox_Documento";
            this.textBox_Documento.Size = new System.Drawing.Size(129, 20);
            this.textBox_Documento.TabIndex = 13;
            this.textBox_Documento.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Documento.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(133, 129);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(129, 20);
            this.textBox_Telefono.TabIndex = 12;
            this.textBox_Telefono.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Telefono.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(133, 155);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(232, 20);
            this.textBox_Direccion.TabIndex = 11;
            this.textBox_Direccion.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Direccion.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(133, 54);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(232, 20);
            this.textBox_Apellido.TabIndex = 10;
            this.textBox_Apellido.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Apellido.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_FechaNacimiento
            // 
            this.label_FechaNacimiento.AutoSize = true;
            this.label_FechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_FechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_FechaNacimiento.Location = new System.Drawing.Point(23, 261);
            this.label_FechaNacimiento.Name = "label_FechaNacimiento";
            this.label_FechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.label_FechaNacimiento.TabIndex = 9;
            this.label_FechaNacimiento.Text = "Fecha de nacimiento";
            this.label_FechaNacimiento.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_FechaNacimiento.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_CodigoPostal
            // 
            this.label_CodigoPostal.AutoSize = true;
            this.label_CodigoPostal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_CodigoPostal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_CodigoPostal.Location = new System.Drawing.Point(57, 182);
            this.label_CodigoPostal.Name = "label_CodigoPostal";
            this.label_CodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.label_CodigoPostal.TabIndex = 8;
            this.label_CodigoPostal.Text = "Codigo Postal";
            this.label_CodigoPostal.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_CodigoPostal.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Direccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Direccion.Location = new System.Drawing.Point(75, 158);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(52, 13);
            this.label_Direccion.TabIndex = 7;
            this.label_Direccion.Text = "Direccion";
            this.label_Direccion.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_Direccion.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_Telefono
            // 
            this.label_Telefono.AutoSize = true;
            this.label_Telefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Telefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Telefono.Location = new System.Drawing.Point(80, 132);
            this.label_Telefono.Name = "label_Telefono";
            this.label_Telefono.Size = new System.Drawing.Size(49, 13);
            this.label_Telefono.TabIndex = 6;
            this.label_Telefono.Text = "Telefono";
            this.label_Telefono.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_Telefono.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Mail.Location = new System.Drawing.Point(94, 208);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(33, 13);
            this.label_Mail.TabIndex = 5;
            this.label_Mail.Text = "EMail";
            this.label_Mail.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_Mail.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_TipoDocumento
            // 
            this.label_TipoDocumento.AutoSize = true;
            this.label_TipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TipoDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_TipoDocumento.Location = new System.Drawing.Point(30, 82);
            this.label_TipoDocumento.Name = "label_TipoDocumento";
            this.label_TipoDocumento.Size = new System.Drawing.Size(99, 13);
            this.label_TipoDocumento.TabIndex = 4;
            this.label_TipoDocumento.Text = "Tipo de documento";
            this.label_TipoDocumento.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_TipoDocumento.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_Documento
            // 
            this.label_Documento.AutoSize = true;
            this.label_Documento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Documento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Documento.Location = new System.Drawing.Point(67, 106);
            this.label_Documento.Name = "label_Documento";
            this.label_Documento.Size = new System.Drawing.Size(62, 13);
            this.label_Documento.TabIndex = 3;
            this.label_Documento.Text = "Documento";
            this.label_Documento.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_Documento.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Apellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Apellido.Location = new System.Drawing.Point(85, 57);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 2;
            this.label_Apellido.Text = "Apellido";
            this.label_Apellido.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_Apellido.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(85, 31);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            this.label_Nombre.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_Nombre.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(133, 28);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            this.textBox_Nombre.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Nombre.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // button_Borrar
            // 
            this.button_Borrar.Location = new System.Drawing.Point(426, 12);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(75, 23);
            this.button_Borrar.TabIndex = 16;
            this.button_Borrar.Text = "Borrar";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.MouseLeave += new System.EventHandler(this.button_Borrar_MouseLeave);
            this.button_Borrar.Click += new System.EventHandler(this.button_Guardar_Click);
            this.button_Borrar.MouseEnter += new System.EventHandler(this.button_Borrar_MouseEnter);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(426, 41);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 17;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.MouseLeave += new System.EventHandler(this.button_Cancelar_MouseLeave);
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            this.button_Cancelar.MouseEnter += new System.EventHandler(this.button_Cancelar_MouseEnter);
            // 
            // textBox_Cuil
            // 
            this.textBox_Cuil.Location = new System.Drawing.Point(133, 231);
            this.textBox_Cuil.MaxLength = 50;
            this.textBox_Cuil.Name = "textBox_Cuil";
            this.textBox_Cuil.Size = new System.Drawing.Size(129, 20);
            this.textBox_Cuil.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(103, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cuil";
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
            this.Name = "Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_CodigoPostal;
        private System.Windows.Forms.RadioButton radioButton_Pas;
        private System.Windows.Forms.RadioButton radioButton_Ci;
        private System.Windows.Forms.RadioButton radioButton_Le;
        private System.Windows.Forms.RadioButton radioButton_Lc;
        private System.Windows.Forms.RadioButton radioButton_Dni;
        private System.Windows.Forms.TextBox textBox_Documento;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label_FechaNacimiento;
        private System.Windows.Forms.Label label_CodigoPostal;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.Label label_Telefono;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_TipoDocumento;
        private System.Windows.Forms.Label label_Documento;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaNacimiento;
        private System.Windows.Forms.Button button_Borrar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.TextBox textBox_Cuil;
        private System.Windows.Forms.Label label1;
    }
}