namespace FrbaCommerce.Abm_Empresa
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
            this.groupBox_SeleccionarUsuario = new System.Windows.Forms.GroupBox();
            this.textBox_IdUsuario = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_IdUsuario = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.button_SeleccionarUsuario = new System.Windows.Forms.Button();
            this.label_CrearComo = new System.Windows.Forms.Label();
            this.radioButton_UsuarioExistente = new System.Windows.Forms.RadioButton();
            this.radioButton_UsuarioNuevo = new System.Windows.Forms.RadioButton();
            this.paner_Alta.SuspendLayout();
            this.groupBox_SeleccionarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(425, 25);
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
            this.button_Limpiar.Location = new System.Drawing.Point(425, 54);
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
            this.paner_Alta.Location = new System.Drawing.Point(12, 12);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(358, 231);
            this.paner_Alta.TabIndex = 12;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos de la Empresa";
            // 
            // dateTimePicker_FechaNacimiento
            // 
            this.dateTimePicker_FechaNacimiento.Location = new System.Drawing.Point(117, 198);
            this.dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            this.dateTimePicker_FechaNacimiento.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker_FechaNacimiento.TabIndex = 22;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(117, 172);
            this.textBox_Mail.MaxLength = 255;
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mail.TabIndex = 20;
            // 
            // textBox_CodigoPostal
            // 
            this.textBox_CodigoPostal.Location = new System.Drawing.Point(117, 146);
            this.textBox_CodigoPostal.MaxLength = 50;
            this.textBox_CodigoPostal.Name = "textBox_CodigoPostal";
            this.textBox_CodigoPostal.Size = new System.Drawing.Size(129, 20);
            this.textBox_CodigoPostal.TabIndex = 19;
            // 
            // textBox_NombreContacto
            // 
            this.textBox_NombreContacto.Location = new System.Drawing.Point(119, 70);
            this.textBox_NombreContacto.MaxLength = 255;
            this.textBox_NombreContacto.Name = "textBox_NombreContacto";
            this.textBox_NombreContacto.Size = new System.Drawing.Size(230, 20);
            this.textBox_NombreContacto.TabIndex = 13;
            this.textBox_NombreContacto.MouseLeave += new System.EventHandler(this.textBox_NombreContacto_MouseLeave);
            this.textBox_NombreContacto.MouseEnter += new System.EventHandler(this.textBox_NombreContacto_MouseEnter);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(117, 96);
            this.textBox_Telefono.MaxLength = 18;
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(129, 20);
            this.textBox_Telefono.TabIndex = 12;
            this.textBox_Telefono.MouseLeave += new System.EventHandler(this.textBox_Telefono_MouseLeave);
            this.textBox_Telefono.MouseEnter += new System.EventHandler(this.textBox_Telefono_MouseEnter);
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(117, 122);
            this.textBox_Direccion.MaxLength = 255;
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(232, 20);
            this.textBox_Direccion.TabIndex = 11;
            this.textBox_Direccion.MouseLeave += new System.EventHandler(this.textBox_Direccion_MouseLeave);
            this.textBox_Direccion.MouseEnter += new System.EventHandler(this.textBox_Direccion_MouseEnter);
            // 
            // textBox_Cuit
            // 
            this.textBox_Cuit.Location = new System.Drawing.Point(117, 44);
            this.textBox_Cuit.MaxLength = 50;
            this.textBox_Cuit.Name = "textBox_Cuit";
            this.textBox_Cuit.Size = new System.Drawing.Size(232, 20);
            this.textBox_Cuit.TabIndex = 10;
            // 
            // label_FechaNacimiento
            // 
            this.label_FechaNacimiento.AutoSize = true;
            this.label_FechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_FechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_FechaNacimiento.Location = new System.Drawing.Point(15, 201);
            this.label_FechaNacimiento.Name = "label_FechaNacimiento";
            this.label_FechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.label_FechaNacimiento.TabIndex = 9;
            this.label_FechaNacimiento.Text = "Fecha de creacion";
            // 
            // label_CodigoPostal
            // 
            this.label_CodigoPostal.AutoSize = true;
            this.label_CodigoPostal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_CodigoPostal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_CodigoPostal.Location = new System.Drawing.Point(41, 149);
            this.label_CodigoPostal.Name = "label_CodigoPostal";
            this.label_CodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.label_CodigoPostal.TabIndex = 8;
            this.label_CodigoPostal.Text = "Codigo Postal";
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Direccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Direccion.Location = new System.Drawing.Point(59, 125);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(52, 13);
            this.label_Direccion.TabIndex = 7;
            this.label_Direccion.Text = "Direccion";
            // 
            // label_Telefono
            // 
            this.label_Telefono.AutoSize = true;
            this.label_Telefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Telefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Telefono.Location = new System.Drawing.Point(64, 99);
            this.label_Telefono.Name = "label_Telefono";
            this.label_Telefono.Size = new System.Drawing.Size(49, 13);
            this.label_Telefono.TabIndex = 6;
            this.label_Telefono.Text = "Telefono";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Mail.Location = new System.Drawing.Point(78, 175);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(33, 13);
            this.label_Mail.TabIndex = 5;
            this.label_Mail.Text = "EMail";
            // 
            // label_NombreContacto
            // 
            this.label_NombreContacto.AutoSize = true;
            this.label_NombreContacto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NombreContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_NombreContacto.Location = new System.Drawing.Point(9, 73);
            this.label_NombreContacto.Name = "label_NombreContacto";
            this.label_NombreContacto.Size = new System.Drawing.Size(104, 13);
            this.label_NombreContacto.TabIndex = 3;
            this.label_NombreContacto.Text = "Nombre de contacto";
            this.label_NombreContacto.Click += new System.EventHandler(this.label_Documento_Click);
            // 
            // label_Cuit
            // 
            this.label_Cuit.AutoSize = true;
            this.label_Cuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Cuit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Cuit.Location = new System.Drawing.Point(79, 47);
            this.label_Cuit.Name = "label_Cuit";
            this.label_Cuit.Size = new System.Drawing.Size(32, 13);
            this.label_Cuit.TabIndex = 2;
            this.label_Cuit.Text = "CUIT";
            // 
            // label_RazonSocial
            // 
            this.label_RazonSocial.AutoSize = true;
            this.label_RazonSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_RazonSocial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_RazonSocial.Location = new System.Drawing.Point(43, 21);
            this.label_RazonSocial.Name = "label_RazonSocial";
            this.label_RazonSocial.Size = new System.Drawing.Size(70, 13);
            this.label_RazonSocial.TabIndex = 1;
            this.label_RazonSocial.Text = "Razon Social";
            // 
            // textBox_RazonSocial
            // 
            this.textBox_RazonSocial.Location = new System.Drawing.Point(117, 18);
            this.textBox_RazonSocial.MaxLength = 255;
            this.textBox_RazonSocial.Name = "textBox_RazonSocial";
            this.textBox_RazonSocial.Size = new System.Drawing.Size(232, 20);
            this.textBox_RazonSocial.TabIndex = 0;
            this.textBox_RazonSocial.TextChanged += new System.EventHandler(this.textBox_RazonSocial_TextChanged);
            this.textBox_RazonSocial.MouseLeave += new System.EventHandler(this.textBox_RazonSocial_MouseLeave);
            this.textBox_RazonSocial.MouseEnter += new System.EventHandler(this.textBox_RazonSocial_MouseEnter);
            // 
            // groupBox_SeleccionarUsuario
            // 
            this.groupBox_SeleccionarUsuario.Controls.Add(this.textBox_IdUsuario);
            this.groupBox_SeleccionarUsuario.Controls.Add(this.textBox_Username);
            this.groupBox_SeleccionarUsuario.Controls.Add(this.label_IdUsuario);
            this.groupBox_SeleccionarUsuario.Controls.Add(this.label_Username);
            this.groupBox_SeleccionarUsuario.Controls.Add(this.button_SeleccionarUsuario);
            this.groupBox_SeleccionarUsuario.Location = new System.Drawing.Point(378, 83);
            this.groupBox_SeleccionarUsuario.Name = "groupBox_SeleccionarUsuario";
            this.groupBox_SeleccionarUsuario.Size = new System.Drawing.Size(123, 187);
            this.groupBox_SeleccionarUsuario.TabIndex = 27;
            this.groupBox_SeleccionarUsuario.TabStop = false;
            // 
            // textBox_IdUsuario
            // 
            this.textBox_IdUsuario.Location = new System.Drawing.Point(6, 147);
            this.textBox_IdUsuario.Name = "textBox_IdUsuario";
            this.textBox_IdUsuario.Size = new System.Drawing.Size(110, 20);
            this.textBox_IdUsuario.TabIndex = 27;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(6, 103);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(110, 20);
            this.textBox_Username.TabIndex = 27;
            // 
            // label_IdUsuario
            // 
            this.label_IdUsuario.AutoSize = true;
            this.label_IdUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_IdUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_IdUsuario.Location = new System.Drawing.Point(3, 127);
            this.label_IdUsuario.Name = "label_IdUsuario";
            this.label_IdUsuario.Size = new System.Drawing.Size(70, 13);
            this.label_IdUsuario.TabIndex = 28;
            this.label_IdUsuario.Text = "ID de usuario";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Username.Location = new System.Drawing.Point(3, 79);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(55, 13);
            this.label_Username.TabIndex = 27;
            this.label_Username.Text = "Username";
            // 
            // button_SeleccionarUsuario
            // 
            this.button_SeleccionarUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_SeleccionarUsuario.Location = new System.Drawing.Point(21, 19);
            this.button_SeleccionarUsuario.Name = "button_SeleccionarUsuario";
            this.button_SeleccionarUsuario.Size = new System.Drawing.Size(82, 37);
            this.button_SeleccionarUsuario.TabIndex = 24;
            this.button_SeleccionarUsuario.Text = "Seleccionar usuario";
            this.button_SeleccionarUsuario.UseVisualStyleBackColor = true;
            this.button_SeleccionarUsuario.Click += new System.EventHandler(this.button_SeleccionarUsuario_Click);
            // 
            // label_CrearComo
            // 
            this.label_CrearComo.AutoSize = true;
            this.label_CrearComo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_CrearComo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_CrearComo.Location = new System.Drawing.Point(59, 251);
            this.label_CrearComo.Name = "label_CrearComo";
            this.label_CrearComo.Size = new System.Drawing.Size(64, 13);
            this.label_CrearComo.TabIndex = 30;
            this.label_CrearComo.Text = "Crear como ";
            // 
            // radioButton_UsuarioExistente
            // 
            this.radioButton_UsuarioExistente.AutoSize = true;
            this.radioButton_UsuarioExistente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_UsuarioExistente.Location = new System.Drawing.Point(229, 250);
            this.radioButton_UsuarioExistente.Name = "radioButton_UsuarioExistente";
            this.radioButton_UsuarioExistente.Size = new System.Drawing.Size(106, 17);
            this.radioButton_UsuarioExistente.TabIndex = 29;
            this.radioButton_UsuarioExistente.TabStop = true;
            this.radioButton_UsuarioExistente.Text = "Usuario existente";
            this.radioButton_UsuarioExistente.UseVisualStyleBackColor = true;
            this.radioButton_UsuarioExistente.CheckedChanged += new System.EventHandler(this.radioButton_UsuarioExistente_CheckedChanged);
            // 
            // radioButton_UsuarioNuevo
            // 
            this.radioButton_UsuarioNuevo.AutoSize = true;
            this.radioButton_UsuarioNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_UsuarioNuevo.Location = new System.Drawing.Point(129, 249);
            this.radioButton_UsuarioNuevo.Name = "radioButton_UsuarioNuevo";
            this.radioButton_UsuarioNuevo.Size = new System.Drawing.Size(94, 17);
            this.radioButton_UsuarioNuevo.TabIndex = 28;
            this.radioButton_UsuarioNuevo.TabStop = true;
            this.radioButton_UsuarioNuevo.Text = "Usuario nuevo";
            this.radioButton_UsuarioNuevo.UseVisualStyleBackColor = true;
            this.radioButton_UsuarioNuevo.CheckedChanged += new System.EventHandler(this.radioButton_UsuarioNuevo_CheckedChanged);
            // 
            // Alta
            // 
            this.AcceptButton = this.button_Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.label_CrearComo);
            this.Controls.Add(this.radioButton_UsuarioExistente);
            this.Controls.Add(this.radioButton_UsuarioNuevo);
            this.Controls.Add(this.groupBox_SeleccionarUsuario);
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
            this.groupBox_SeleccionarUsuario.ResumeLayout(false);
            this.groupBox_SeleccionarUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Label label_InfTexto;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.Button button_Limpiar;
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
        private System.Windows.Forms.GroupBox groupBox_SeleccionarUsuario;
        private System.Windows.Forms.TextBox textBox_IdUsuario;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_IdUsuario;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button button_SeleccionarUsuario;
        private System.Windows.Forms.Label label_CrearComo;
        private System.Windows.Forms.RadioButton radioButton_UsuarioExistente;
        private System.Windows.Forms.RadioButton radioButton_UsuarioNuevo;
    }
}