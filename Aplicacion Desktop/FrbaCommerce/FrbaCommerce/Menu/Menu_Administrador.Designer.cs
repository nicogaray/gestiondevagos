namespace FrbaCommerce.Menu
{
    partial class Menu_Administrador
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
            this.button_ABMRol = new System.Windows.Forms.Button();
            this.button_ABMCliente = new System.Windows.Forms.Button();
            this.button_ABMEmpresa = new System.Windows.Forms.Button();
            this.button_ListadoEstadistico = new System.Windows.Forms.Button();
            this.button_ABMVisibilidad = new System.Windows.Forms.Button();
            this.button_ABMRubro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(367, 300);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 0;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ABMRol
            // 
            this.button_ABMRol.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ABMRol.Location = new System.Drawing.Point(72, 12);
            this.button_ABMRol.Name = "button_ABMRol";
            this.button_ABMRol.Size = new System.Drawing.Size(310, 40);
            this.button_ABMRol.TabIndex = 1;
            this.button_ABMRol.Text = "ABM de Rol";
            this.button_ABMRol.UseVisualStyleBackColor = true;
            this.button_ABMRol.Click += new System.EventHandler(this.button_ABMRol_Click);
            // 
            // button_ABMCliente
            // 
            this.button_ABMCliente.Location = new System.Drawing.Point(72, 58);
            this.button_ABMCliente.Name = "button_ABMCliente";
            this.button_ABMCliente.Size = new System.Drawing.Size(310, 40);
            this.button_ABMCliente.TabIndex = 2;
            this.button_ABMCliente.Text = "ABM de Cliente";
            this.button_ABMCliente.UseVisualStyleBackColor = true;
            this.button_ABMCliente.Click += new System.EventHandler(this.button_ABMCliente_Click);
            // 
            // button_ABMEmpresa
            // 
            this.button_ABMEmpresa.Location = new System.Drawing.Point(72, 104);
            this.button_ABMEmpresa.Name = "button_ABMEmpresa";
            this.button_ABMEmpresa.Size = new System.Drawing.Size(310, 40);
            this.button_ABMEmpresa.TabIndex = 4;
            this.button_ABMEmpresa.Text = "ABM de Empresa";
            this.button_ABMEmpresa.UseVisualStyleBackColor = true;
            this.button_ABMEmpresa.Click += new System.EventHandler(this.button_ABMEmpresa_Click);
            // 
            // button_ListadoEstadistico
            // 
            this.button_ListadoEstadistico.Location = new System.Drawing.Point(72, 242);
            this.button_ListadoEstadistico.Name = "button_ListadoEstadistico";
            this.button_ListadoEstadistico.Size = new System.Drawing.Size(310, 40);
            this.button_ListadoEstadistico.TabIndex = 5;
            this.button_ListadoEstadistico.Text = "Listado Estadistico";
            this.button_ListadoEstadistico.UseVisualStyleBackColor = true;
            this.button_ListadoEstadistico.Click += new System.EventHandler(this.button_ListadoEstadistico_Click);
            // 
            // button_ABMVisibilidad
            // 
            this.button_ABMVisibilidad.Location = new System.Drawing.Point(72, 196);
            this.button_ABMVisibilidad.Name = "button_ABMVisibilidad";
            this.button_ABMVisibilidad.Size = new System.Drawing.Size(310, 40);
            this.button_ABMVisibilidad.TabIndex = 6;
            this.button_ABMVisibilidad.Text = "ABM de Visibilidad";
            this.button_ABMVisibilidad.UseVisualStyleBackColor = true;
            this.button_ABMVisibilidad.Click += new System.EventHandler(this.button_ABMVisibilidad_Click);
            // 
            // button_ABMRubro
            // 
            this.button_ABMRubro.Location = new System.Drawing.Point(72, 150);
            this.button_ABMRubro.Name = "button_ABMRubro";
            this.button_ABMRubro.Size = new System.Drawing.Size(310, 40);
            this.button_ABMRubro.TabIndex = 7;
            this.button_ABMRubro.Text = "ABM de Rubro";
            this.button_ABMRubro.UseVisualStyleBackColor = true;
            this.button_ABMRubro.Click += new System.EventHandler(this.button_ABMRubro_Click);
            // 
            // Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Volver;
            this.ClientSize = new System.Drawing.Size(454, 335);
            this.Controls.Add(this.button_ABMRubro);
            this.Controls.Add(this.button_ABMVisibilidad);
            this.Controls.Add(this.button_ListadoEstadistico);
            this.Controls.Add(this.button_ABMEmpresa);
            this.Controls.Add(this.button_ABMCliente);
            this.Controls.Add(this.button_ABMRol);
            this.Controls.Add(this.button_Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador - Seleccione una funcionalidad";
            this.Load += new System.EventHandler(this.Menu_Administrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_ABMRol;
        private System.Windows.Forms.Button button_ABMCliente;
        private System.Windows.Forms.Button button_ABMEmpresa;
        private System.Windows.Forms.Button button_ListadoEstadistico;
        private System.Windows.Forms.Button button_ABMVisibilidad;
        private System.Windows.Forms.Button button_ABMRubro;
    }
}