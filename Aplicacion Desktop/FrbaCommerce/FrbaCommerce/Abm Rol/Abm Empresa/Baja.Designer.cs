namespace FrbaCommerce.Abm_Empresa
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
            this.button_Borrar = new System.Windows.Forms.Button();
            this.label_InfTexto = new System.Windows.Forms.Label();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_CodigoPostal = new System.Windows.Forms.TextBox();
            this.textBox_NombreContacto = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Cuit = new System.Windows.Forms.TextBox();
            this.label_FechaNacimiento = new System.Windows.Forms.Label();
            this.label_CodigoPostal = new System.Windows.Forms.Label();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.label_Telefono = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_NombreContacto = new System.Windows.Forms.Label();
            this.label_Cuit = new System.Windows.Forms.Label();
            this.label_RazonSocial = new System.Windows.Forms.Label();
            this.textBox_RazonSocial = new System.Windows.Forms.TextBox();
            this.paner_Alta.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Borrar
            // 
            this.button_Borrar.Location = new System.Drawing.Point(425, 25);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(75, 23);
            this.button_Borrar.TabIndex = 21;
            this.button_Borrar.Text = "Borrar";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.MouseLeave += new System.EventHandler(this.button_Borrar_MouseLeave);
            this.button_Borrar.Click += new System.EventHandler(this.button_Borrar_Click);
            this.button_Borrar.MouseEnter += new System.EventHandler(this.button_Borrar_MouseEnter);
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
            // button_Cancelar
            // 
            this.button_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Cancelar.Location = new System.Drawing.Point(425, 54);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 18;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.MouseLeave += new System.EventHandler(this.button_Cancelar_MouseLeave);
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            this.button_Cancelar.MouseEnter += new System.EventHandler(this.button_Cancelar_MouseEnter);
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.dateTimePicker_FechaNacimiento);
            this.paner_Alta.Controls.Add(this.textBox_Mail);
            this.paner_Alta.Controls.Add(this.textBox_CodigoPostal);
            this.paner_Alta.Controls.Add(this.textBox_NombreContacto);
            this.paner_Alta.Controls.Add(this.textBox_Telefono);
            this.paner_Alta.Controls.Add(this.textBox_Direccion);
            this.paner_Alta.Controls.Add(this.textBox_Cuit);
            this.paner_Alta.Controls.Add(this.label_FechaNacimiento);
            this.paner_Alta.Controls.Add(this.label_CodigoPostal);
            this.paner_Alta.Controls.Add(this.label_Direccion);
            this.paner_Alta.Controls.Add(this.label_Telefono);
            this.paner_Alta.Controls.Add(this.label_Mail);
            this.paner_Alta.Controls.Add(this.label_NombreContacto);
            this.paner_Alta.Controls.Add(this.label_Cuit);
            this.paner_Alta.Controls.Add(this.label_RazonSocial);
            this.paner_Alta.Controls.Add(this.textBox_RazonSocial);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.paner_Alta.Location = new System.Drawing.Point(12, 7);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(388, 278);
            this.paner_Alta.TabIndex = 17;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos de la Empresa";
            // 
            // dateTimePicker_FechaNacimiento
            // 
            this.dateTimePicker_FechaNacimiento.Location = new System.Drawing.Point(133, 219);
            this.dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            this.dateTimePicker_FechaNacimiento.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker_FechaNacimiento.TabIndex = 23;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(133, 193);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mail.TabIndex = 20;
            this.textBox_Mail.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Mail.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_CodigoPostal
            // 
            this.textBox_CodigoPostal.Location = new System.Drawing.Point(133, 167);
            this.textBox_CodigoPostal.Name = "textBox_CodigoPostal";
            this.textBox_CodigoPostal.Size = new System.Drawing.Size(129, 20);
            this.textBox_CodigoPostal.TabIndex = 19;
            this.textBox_CodigoPostal.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_CodigoPostal.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_NombreContacto
            // 
            this.textBox_NombreContacto.Location = new System.Drawing.Point(133, 91);
            this.textBox_NombreContacto.Name = "textBox_NombreContacto";
            this.textBox_NombreContacto.Size = new System.Drawing.Size(230, 20);
            this.textBox_NombreContacto.TabIndex = 13;
            this.textBox_NombreContacto.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_NombreContacto.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(133, 117);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(129, 20);
            this.textBox_Telefono.TabIndex = 12;
            this.textBox_Telefono.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Telefono.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(133, 143);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(232, 20);
            this.textBox_Direccion.TabIndex = 11;
            this.textBox_Direccion.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Direccion.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_Cuit
            // 
            this.textBox_Cuit.Location = new System.Drawing.Point(133, 65);
            this.textBox_Cuit.Name = "textBox_Cuit";
            this.textBox_Cuit.Size = new System.Drawing.Size(232, 20);
            this.textBox_Cuit.TabIndex = 10;
            this.textBox_Cuit.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_Cuit.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_FechaNacimiento
            // 
            this.label_FechaNacimiento.AutoSize = true;
            this.label_FechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_FechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_FechaNacimiento.Location = new System.Drawing.Point(31, 222);
            this.label_FechaNacimiento.Name = "label_FechaNacimiento";
            this.label_FechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.label_FechaNacimiento.TabIndex = 9;
            this.label_FechaNacimiento.Text = "Fecha de creacion";
            this.label_FechaNacimiento.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_FechaNacimiento.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_CodigoPostal
            // 
            this.label_CodigoPostal.AutoSize = true;
            this.label_CodigoPostal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_CodigoPostal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_CodigoPostal.Location = new System.Drawing.Point(57, 170);
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
            this.label_Direccion.Location = new System.Drawing.Point(75, 146);
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
            this.label_Telefono.Location = new System.Drawing.Point(80, 120);
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
            this.label_Mail.Location = new System.Drawing.Point(94, 196);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(33, 13);
            this.label_Mail.TabIndex = 5;
            this.label_Mail.Text = "EMail";
            this.label_Mail.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_Mail.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_NombreContacto
            // 
            this.label_NombreContacto.AutoSize = true;
            this.label_NombreContacto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NombreContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_NombreContacto.Location = new System.Drawing.Point(25, 94);
            this.label_NombreContacto.Name = "label_NombreContacto";
            this.label_NombreContacto.Size = new System.Drawing.Size(104, 13);
            this.label_NombreContacto.TabIndex = 3;
            this.label_NombreContacto.Text = "Nombre de contacto";
            this.label_NombreContacto.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_NombreContacto.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_Cuit
            // 
            this.label_Cuit.AutoSize = true;
            this.label_Cuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Cuit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Cuit.Location = new System.Drawing.Point(95, 68);
            this.label_Cuit.Name = "label_Cuit";
            this.label_Cuit.Size = new System.Drawing.Size(32, 13);
            this.label_Cuit.TabIndex = 2;
            this.label_Cuit.Text = "CUIT";
            this.label_Cuit.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_Cuit.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // label_RazonSocial
            // 
            this.label_RazonSocial.AutoSize = true;
            this.label_RazonSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_RazonSocial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_RazonSocial.Location = new System.Drawing.Point(59, 42);
            this.label_RazonSocial.Name = "label_RazonSocial";
            this.label_RazonSocial.Size = new System.Drawing.Size(70, 13);
            this.label_RazonSocial.TabIndex = 1;
            this.label_RazonSocial.Text = "Razon Social";
            this.label_RazonSocial.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.label_RazonSocial.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // textBox_RazonSocial
            // 
            this.textBox_RazonSocial.Location = new System.Drawing.Point(133, 39);
            this.textBox_RazonSocial.Name = "textBox_RazonSocial";
            this.textBox_RazonSocial.Size = new System.Drawing.Size(232, 20);
            this.textBox_RazonSocial.TabIndex = 0;
            this.textBox_RazonSocial.TextChanged += new System.EventHandler(this.textBox_RazonSocial_TextChanged);
            this.textBox_RazonSocial.MouseLeave += new System.EventHandler(this.textBox_Anio_MouseLeave);
            this.textBox_RazonSocial.MouseEnter += new System.EventHandler(this.textBox_Anio_MouseEnter);
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.button_Borrar);
            this.Controls.Add(this.label_InfTexto);
            this.Controls.Add(this.label_Informacion);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.paner_Alta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Baja";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Borrar;
        private System.Windows.Forms.Label label_InfTexto;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_CodigoPostal;
        private System.Windows.Forms.TextBox textBox_NombreContacto;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Cuit;
        private System.Windows.Forms.Label label_FechaNacimiento;
        private System.Windows.Forms.Label label_CodigoPostal;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.Label label_Telefono;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_NombreContacto;
        private System.Windows.Forms.Label label_Cuit;
        private System.Windows.Forms.Label label_RazonSocial;
        private System.Windows.Forms.TextBox textBox_RazonSocial;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaNacimiento;
    }
}