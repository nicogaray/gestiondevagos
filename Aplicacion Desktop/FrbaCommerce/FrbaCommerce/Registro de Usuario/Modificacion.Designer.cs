namespace FrbaCommerce.Registro_de_Usuario
{
    partial class Modificacion
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
            this.groupBox_ModificarDatos = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_IrA = new System.Windows.Forms.Button();
            this.groupBox_Rol = new System.Windows.Forms.GroupBox();
            this.label_RolAsignado = new System.Windows.Forms.Label();
            this.textBox_RolAsignado = new System.Windows.Forms.TextBox();
            this.groupBox_Informacion = new System.Windows.Forms.GroupBox();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.groupBox_RegistroUsuario = new System.Windows.Forms.GroupBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.button_Volver = new System.Windows.Forms.Button();
            this.groupBox_ModificarDatos.SuspendLayout();
            this.groupBox_Rol.SuspendLayout();
            this.groupBox_Informacion.SuspendLayout();
            this.groupBox_RegistroUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ModificarDatos
            // 
            this.groupBox_ModificarDatos.Controls.Add(this.richTextBox1);
            this.groupBox_ModificarDatos.Controls.Add(this.button_IrA);
            this.groupBox_ModificarDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_ModificarDatos.Location = new System.Drawing.Point(12, 167);
            this.groupBox_ModificarDatos.Name = "groupBox_ModificarDatos";
            this.groupBox_ModificarDatos.Size = new System.Drawing.Size(614, 62);
            this.groupBox_ModificarDatos.TabIndex = 6;
            this.groupBox_ModificarDatos.TabStop = false;
            this.groupBox_ModificarDatos.Text = "Modificar datos";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(62, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 30);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Si desea cambiar sus datos personales haga click en el botón \n\"Ir\" para acceder a" +
                "l formulario de modificación de usuario";
            // 
            // button_IrA
            // 
            this.button_IrA.Location = new System.Drawing.Point(476, 23);
            this.button_IrA.Name = "button_IrA";
            this.button_IrA.Size = new System.Drawing.Size(75, 23);
            this.button_IrA.TabIndex = 2;
            this.button_IrA.Text = "Ir";
            this.button_IrA.UseVisualStyleBackColor = true;
            this.button_IrA.MouseLeave += new System.EventHandler(this.button_IrA_MouseLeave);
            this.button_IrA.Click += new System.EventHandler(this.button_IrA_Click);
            this.button_IrA.MouseEnter += new System.EventHandler(this.button_IrA_MouseEnter);
            // 
            // groupBox_Rol
            // 
            this.groupBox_Rol.Controls.Add(this.label_RolAsignado);
            this.groupBox_Rol.Controls.Add(this.textBox_RolAsignado);
            this.groupBox_Rol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Rol.Location = new System.Drawing.Point(371, 12);
            this.groupBox_Rol.Name = "groupBox_Rol";
            this.groupBox_Rol.Size = new System.Drawing.Size(256, 149);
            this.groupBox_Rol.TabIndex = 20;
            this.groupBox_Rol.TabStop = false;
            this.groupBox_Rol.Text = "Rol";
            // 
            // label_RolAsignado
            // 
            this.label_RolAsignado.AutoSize = true;
            this.label_RolAsignado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_RolAsignado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_RolAsignado.Location = new System.Drawing.Point(95, 53);
            this.label_RolAsignado.Name = "label_RolAsignado";
            this.label_RolAsignado.Size = new System.Drawing.Size(69, 13);
            this.label_RolAsignado.TabIndex = 15;
            this.label_RolAsignado.Text = "Rol asignado";
            // 
            // textBox_RolAsignado
            // 
            this.textBox_RolAsignado.Location = new System.Drawing.Point(55, 75);
            this.textBox_RolAsignado.Name = "textBox_RolAsignado";
            this.textBox_RolAsignado.Size = new System.Drawing.Size(147, 20);
            this.textBox_RolAsignado.TabIndex = 16;
            this.textBox_RolAsignado.MouseLeave += new System.EventHandler(this.textBox_RolAsignado_MouseLeave);
            this.textBox_RolAsignado.MouseEnter += new System.EventHandler(this.textBox_RolAsignado_MouseEnter);
            // 
            // groupBox_Informacion
            // 
            this.groupBox_Informacion.Controls.Add(this.label_Informacion);
            this.groupBox_Informacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox_Informacion.Location = new System.Drawing.Point(12, 276);
            this.groupBox_Informacion.Name = "groupBox_Informacion";
            this.groupBox_Informacion.Size = new System.Drawing.Size(614, 51);
            this.groupBox_Informacion.TabIndex = 19;
            this.groupBox_Informacion.TabStop = false;
            this.groupBox_Informacion.Text = "Informacion";
            // 
            // label_Informacion
            // 
            this.label_Informacion.AutoSize = true;
            this.label_Informacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Informacion.Location = new System.Drawing.Point(42, 26);
            this.label_Informacion.Name = "label_Informacion";
            this.label_Informacion.Size = new System.Drawing.Size(0, 13);
            this.label_Informacion.TabIndex = 2;
            // 
            // groupBox_RegistroUsuario
            // 
            this.groupBox_RegistroUsuario.Controls.Add(this.textBox_Password);
            this.groupBox_RegistroUsuario.Controls.Add(this.button_Guardar);
            this.groupBox_RegistroUsuario.Controls.Add(this.button_Limpiar);
            this.groupBox_RegistroUsuario.Controls.Add(this.textBox_Username);
            this.groupBox_RegistroUsuario.Controls.Add(this.label_Password);
            this.groupBox_RegistroUsuario.Controls.Add(this.label_Username);
            this.groupBox_RegistroUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_RegistroUsuario.Location = new System.Drawing.Point(12, 12);
            this.groupBox_RegistroUsuario.Name = "groupBox_RegistroUsuario";
            this.groupBox_RegistroUsuario.Size = new System.Drawing.Size(352, 149);
            this.groupBox_RegistroUsuario.TabIndex = 18;
            this.groupBox_RegistroUsuario.TabStop = false;
            this.groupBox_RegistroUsuario.Text = "Registro de Usuario";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(91, 77);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(232, 20);
            this.textBox_Password.TabIndex = 14;
            this.textBox_Password.MouseLeave += new System.EventHandler(this.textBox_Password_MouseLeave);
            this.textBox_Password.MouseEnter += new System.EventHandler(this.textBox_Password_MouseEnter);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(190, 119);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 4;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.MouseLeave += new System.EventHandler(this.button_Guardar_MouseLeave);
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            this.button_Guardar.MouseEnter += new System.EventHandler(this.button_Guardar_MouseEnter);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(271, 119);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 3;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.MouseLeave += new System.EventHandler(this.button_Limpiar_MouseLeave);
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            this.button_Limpiar.MouseEnter += new System.EventHandler(this.button_Limpiar_MouseEnter);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(91, 51);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(232, 20);
            this.textBox_Username.TabIndex = 11;
            this.textBox_Username.MouseLeave += new System.EventHandler(this.textBox_Username_MouseLeave);
            this.textBox_Username.MouseEnter += new System.EventHandler(this.textBox_Username_MouseEnter);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Password.Location = new System.Drawing.Point(32, 80);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 13;
            this.label_Password.Text = "Password";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Username.Location = new System.Drawing.Point(30, 54);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(55, 13);
            this.label_Username.TabIndex = 12;
            this.label_Username.Text = "Username";
            // 
            // button_Volver
            // 
            this.button_Volver.Location = new System.Drawing.Point(552, 247);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 21;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 354);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.groupBox_Rol);
            this.Controls.Add(this.groupBox_Informacion);
            this.Controls.Add(this.groupBox_RegistroUsuario);
            this.Controls.Add(this.groupBox_ModificarDatos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Usuario";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.MouseEnter += new System.EventHandler(this.Modificacion_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Modificacion_MouseLeave);
            this.groupBox_ModificarDatos.ResumeLayout(false);
            this.groupBox_Rol.ResumeLayout(false);
            this.groupBox_Rol.PerformLayout();
            this.groupBox_Informacion.ResumeLayout(false);
            this.groupBox_Informacion.PerformLayout();
            this.groupBox_RegistroUsuario.ResumeLayout(false);
            this.groupBox_RegistroUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ModificarDatos;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_IrA;
        private System.Windows.Forms.GroupBox groupBox_Rol;
        private System.Windows.Forms.Label label_RolAsignado;
        private System.Windows.Forms.TextBox textBox_RolAsignado;
        private System.Windows.Forms.GroupBox groupBox_Informacion;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.GroupBox groupBox_RegistroUsuario;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button button_Volver;
    }
}