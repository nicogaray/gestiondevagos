namespace FrbaCommerce.Menu
{
    partial class Menu_Cliente
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
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Comprar = new System.Windows.Forms.Button();
            this.button_Ofertar = new System.Windows.Forms.Button();
            this.button_HistorialCliente = new System.Windows.Forms.Button();
            this.button_Preguntar = new System.Windows.Forms.Button();
            this.button_FacturarPublicacion = new System.Windows.Forms.Button();
            this.button_RegistroUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Volver
            // 
            this.button_Volver.Location = new System.Drawing.Point(367, 303);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 0;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Comprar
            // 
            this.button_Comprar.Location = new System.Drawing.Point(72, 59);
            this.button_Comprar.Name = "button_Comprar";
            this.button_Comprar.Size = new System.Drawing.Size(310, 40);
            this.button_Comprar.TabIndex = 1;
            this.button_Comprar.Text = "Comprar";
            this.button_Comprar.UseVisualStyleBackColor = true;
            // 
            // button_Ofertar
            // 
            this.button_Ofertar.Location = new System.Drawing.Point(72, 105);
            this.button_Ofertar.Name = "button_Ofertar";
            this.button_Ofertar.Size = new System.Drawing.Size(310, 40);
            this.button_Ofertar.TabIndex = 2;
            this.button_Ofertar.Text = "Ofertar";
            this.button_Ofertar.UseVisualStyleBackColor = true;
            // 
            // button_HistorialCliente
            // 
            this.button_HistorialCliente.Location = new System.Drawing.Point(72, 243);
            this.button_HistorialCliente.Name = "button_HistorialCliente";
            this.button_HistorialCliente.Size = new System.Drawing.Size(310, 40);
            this.button_HistorialCliente.TabIndex = 3;
            this.button_HistorialCliente.Text = "Historial del Cliente";
            this.button_HistorialCliente.UseVisualStyleBackColor = true;
            // 
            // button_Preguntar
            // 
            this.button_Preguntar.Location = new System.Drawing.Point(72, 197);
            this.button_Preguntar.Name = "button_Preguntar";
            this.button_Preguntar.Size = new System.Drawing.Size(310, 40);
            this.button_Preguntar.TabIndex = 4;
            this.button_Preguntar.Text = "Preguntar";
            this.button_Preguntar.UseVisualStyleBackColor = true;
            // 
            // button_FacturarPublicacion
            // 
            this.button_FacturarPublicacion.Location = new System.Drawing.Point(72, 151);
            this.button_FacturarPublicacion.Name = "button_FacturarPublicacion";
            this.button_FacturarPublicacion.Size = new System.Drawing.Size(310, 40);
            this.button_FacturarPublicacion.TabIndex = 5;
            this.button_FacturarPublicacion.Text = "Facturar publicacion";
            this.button_FacturarPublicacion.UseVisualStyleBackColor = true;
            // 
            // button_RegistroUsuario
            // 
            this.button_RegistroUsuario.Location = new System.Drawing.Point(72, 13);
            this.button_RegistroUsuario.Name = "button_RegistroUsuario";
            this.button_RegistroUsuario.Size = new System.Drawing.Size(310, 40);
            this.button_RegistroUsuario.TabIndex = 6;
            this.button_RegistroUsuario.Text = "Registro de usuario";
            this.button_RegistroUsuario.UseVisualStyleBackColor = true;
            // 
            // Menu_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 338);
            this.Controls.Add(this.button_RegistroUsuario);
            this.Controls.Add(this.button_FacturarPublicacion);
            this.Controls.Add(this.button_Preguntar);
            this.Controls.Add(this.button_HistorialCliente);
            this.Controls.Add(this.button_Ofertar);
            this.Controls.Add(this.button_Comprar);
            this.Controls.Add(this.button_Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Cliente";
            this.Text = "Cliente - Seleccione una funcionalidad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Comprar;
        private System.Windows.Forms.Button button_Ofertar;
        private System.Windows.Forms.Button button_HistorialCliente;
        private System.Windows.Forms.Button button_Preguntar;
        private System.Windows.Forms.Button button_FacturarPublicacion;
        private System.Windows.Forms.Button button_RegistroUsuario;
    }
}