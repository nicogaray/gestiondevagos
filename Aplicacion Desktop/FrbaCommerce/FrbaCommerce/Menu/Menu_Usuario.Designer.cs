namespace FrbaCommerce.Menu
{
    partial class Menu_Usuario
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
            this.button_Administrador = new System.Windows.Forms.Button();
            this.button_Cliente = new System.Windows.Forms.Button();
            this.button_Empresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Administrador
            // 
            this.button_Administrador.Location = new System.Drawing.Point(85, 36);
            this.button_Administrador.Name = "button_Administrador";
            this.button_Administrador.Size = new System.Drawing.Size(227, 51);
            this.button_Administrador.TabIndex = 0;
            this.button_Administrador.Text = "Administrador";
            this.button_Administrador.UseVisualStyleBackColor = true;
            this.button_Administrador.Click += new System.EventHandler(this.button_Administrador_Click);
            // 
            // button_Cliente
            // 
            this.button_Cliente.Location = new System.Drawing.Point(85, 104);
            this.button_Cliente.Name = "button_Cliente";
            this.button_Cliente.Size = new System.Drawing.Size(227, 51);
            this.button_Cliente.TabIndex = 1;
            this.button_Cliente.Text = "Cliente";
            this.button_Cliente.UseVisualStyleBackColor = true;
            this.button_Cliente.Click += new System.EventHandler(this.button_Cliente_Click);
            // 
            // button_Empresa
            // 
            this.button_Empresa.Location = new System.Drawing.Point(85, 174);
            this.button_Empresa.Name = "button_Empresa";
            this.button_Empresa.Size = new System.Drawing.Size(227, 51);
            this.button_Empresa.TabIndex = 2;
            this.button_Empresa.Text = "Empresa";
            this.button_Empresa.UseVisualStyleBackColor = true;
            this.button_Empresa.Click += new System.EventHandler(this.button_Empresa_Click);
            // 
            // Menu_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 265);
            this.Controls.Add(this.button_Empresa);
            this.Controls.Add(this.button_Cliente);
            this.Controls.Add(this.button_Administrador);
            this.Name = "Menu_Usuario";
            this.Text = "Seleccione el rol ";
            this.Load += new System.EventHandler(this.Menu_Usuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Administrador;
        private System.Windows.Forms.Button button_Cliente;
        private System.Windows.Forms.Button button_Empresa;
    }
}