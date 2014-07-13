namespace FrbaCommerce.Editar_Publicacion
{
    partial class Form_Base
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
            this.panel_Contenedor = new System.Windows.Forms.GroupBox();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_PublicacionBorrador = new System.Windows.Forms.Button();
            this.button_PublicacionActiva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Contenedor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Contenedor.Location = new System.Drawing.Point(109, 12);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(528, 340);
            this.panel_Contenedor.TabIndex = 9;
            this.panel_Contenedor.TabStop = false;
            this.panel_Contenedor.Text = "Publicacion";
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(12, 329);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 12;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_PublicacionBorrador
            // 
            this.button_PublicacionBorrador.Location = new System.Drawing.Point(12, 65);
            this.button_PublicacionBorrador.Name = "button_PublicacionBorrador";
            this.button_PublicacionBorrador.Size = new System.Drawing.Size(75, 47);
            this.button_PublicacionBorrador.TabIndex = 11;
            this.button_PublicacionBorrador.Text = "Publicacion Borrador";
            this.button_PublicacionBorrador.UseVisualStyleBackColor = true;
            this.button_PublicacionBorrador.Click += new System.EventHandler(this.button_PublicacionBorrador_Click);
            // 
            // button_PublicacionActiva
            // 
            this.button_PublicacionActiva.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_PublicacionActiva.Location = new System.Drawing.Point(12, 12);
            this.button_PublicacionActiva.Name = "button_PublicacionActiva";
            this.button_PublicacionActiva.Size = new System.Drawing.Size(75, 47);
            this.button_PublicacionActiva.TabIndex = 10;
            this.button_PublicacionActiva.Text = "Publicacion Activa";
            this.button_PublicacionActiva.UseVisualStyleBackColor = true;
            this.button_PublicacionActiva.Click += new System.EventHandler(this.button_PublicacionActiva_Click);
            // 
            // Form_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 364);
            this.Controls.Add(this.button_PublicacionBorrador);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.button_PublicacionActiva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel_Contenedor;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_PublicacionBorrador;
        private System.Windows.Forms.Button button_PublicacionActiva;
    }
}