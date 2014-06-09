namespace FrbaCommerce.Login
{
    partial class Login
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
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contrasenia = new System.Windows.Forms.Label();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Contrasenia = new System.Windows.Forms.TextBox();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(62, 55);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(46, 13);
            this.label_Usuario.TabIndex = 0;
            this.label_Usuario.Text = "Usuario:";
            this.label_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Contrasenia
            // 
            this.label_Contrasenia.AutoSize = true;
            this.label_Contrasenia.Location = new System.Drawing.Point(44, 119);
            this.label_Contrasenia.Name = "label_Contrasenia";
            this.label_Contrasenia.Size = new System.Drawing.Size(64, 13);
            this.label_Contrasenia.TabIndex = 1;
            this.label_Contrasenia.Text = "Contraseña:";
            this.label_Contrasenia.Click += new System.EventHandler(this.label_Contrasenia_Click);
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(114, 55);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(202, 20);
            this.textBox_Usuario.TabIndex = 2;
            this.textBox_Usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Contrasenia
            // 
            this.textBox_Contrasenia.Location = new System.Drawing.Point(114, 116);
            this.textBox_Contrasenia.Name = "textBox_Contrasenia";
            this.textBox_Contrasenia.Size = new System.Drawing.Size(201, 20);
            this.textBox_Contrasenia.TabIndex = 3;
            this.textBox_Contrasenia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cerrar.Location = new System.Drawing.Point(213, 185);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(86, 27);
            this.button_Cerrar.TabIndex = 4;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(97, 185);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(79, 27);
            this.button_Aceptar.TabIndex = 5;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.button_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cerrar;
            this.ClientSize = new System.Drawing.Size(382, 239);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.textBox_Contrasenia);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.label_Contrasenia);
            this.Controls.Add(this.label_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese al sistema";
            this.Load += new System.EventHandler(this.ABMLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contrasenia;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.TextBox textBox_Contrasenia;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button button_Aceptar;
    }
}