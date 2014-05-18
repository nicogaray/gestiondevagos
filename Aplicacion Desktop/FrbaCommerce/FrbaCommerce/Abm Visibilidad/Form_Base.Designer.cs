namespace FrbaCommerce.Abm_Visibilidad
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
            this.button_Baja = new System.Windows.Forms.Button();
            this.button_Modificacion = new System.Windows.Forms.Button();
            this.button_Alta = new System.Windows.Forms.Button();
            this.panel_Contenedor = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // button_Baja
            // 
            this.button_Baja.Location = new System.Drawing.Point(12, 41);
            this.button_Baja.Name = "button_Baja";
            this.button_Baja.Size = new System.Drawing.Size(75, 23);
            this.button_Baja.TabIndex = 5;
            this.button_Baja.Text = "Baja";
            this.button_Baja.UseVisualStyleBackColor = true;
            this.button_Baja.Click += new System.EventHandler(this.button_Baja_Click);
            // 
            // button_Modificacion
            // 
            this.button_Modificacion.Location = new System.Drawing.Point(12, 70);
            this.button_Modificacion.Name = "button_Modificacion";
            this.button_Modificacion.Size = new System.Drawing.Size(75, 23);
            this.button_Modificacion.TabIndex = 4;
            this.button_Modificacion.Text = "Modificacion";
            this.button_Modificacion.UseVisualStyleBackColor = true;
            this.button_Modificacion.Click += new System.EventHandler(this.button_Modificacion_Click);
            // 
            // button_Alta
            // 
            this.button_Alta.Location = new System.Drawing.Point(12, 12);
            this.button_Alta.Name = "button_Alta";
            this.button_Alta.Size = new System.Drawing.Size(75, 23);
            this.button_Alta.TabIndex = 3;
            this.button_Alta.Text = "Alta";
            this.button_Alta.UseVisualStyleBackColor = true;
            this.button_Alta.Click += new System.EventHandler(this.button_Alta_Click);
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Contenedor.Location = new System.Drawing.Point(110, 12);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(410, 307);
            this.panel_Contenedor.TabIndex = 6;
            this.panel_Contenedor.TabStop = false;
            this.panel_Contenedor.Text = "Visibilidad";
            // 
            // Form_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 330);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.button_Baja);
            this.Controls.Add(this.button_Modificacion);
            this.Controls.Add(this.button_Alta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Base";
            this.Text = "ABM Visibilidad";
            this.Load += new System.EventHandler(this.Form_Base_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Baja;
        private System.Windows.Forms.Button button_Modificacion;
        private System.Windows.Forms.Button button_Alta;
        private System.Windows.Forms.GroupBox panel_Contenedor;
    }
}