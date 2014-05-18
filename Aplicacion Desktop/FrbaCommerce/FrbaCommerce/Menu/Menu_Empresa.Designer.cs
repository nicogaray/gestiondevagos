namespace FrbaCommerce.Menu
{
    partial class Menu_Empresa
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
            this.button_Publicar = new System.Windows.Forms.Button();
            this.button_ResponderPregunta = new System.Windows.Forms.Button();
            this.button_HistorialEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Volver
            // 
            this.button_Volver.Location = new System.Drawing.Point(367, 165);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 0;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Publicar
            // 
            this.button_Publicar.Location = new System.Drawing.Point(72, 12);
            this.button_Publicar.Name = "button_Publicar";
            this.button_Publicar.Size = new System.Drawing.Size(310, 40);
            this.button_Publicar.TabIndex = 1;
            this.button_Publicar.Text = "Publicar";
            this.button_Publicar.UseVisualStyleBackColor = true;
            // 
            // button_ResponderPregunta
            // 
            this.button_ResponderPregunta.Location = new System.Drawing.Point(72, 58);
            this.button_ResponderPregunta.Name = "button_ResponderPregunta";
            this.button_ResponderPregunta.Size = new System.Drawing.Size(310, 40);
            this.button_ResponderPregunta.TabIndex = 2;
            this.button_ResponderPregunta.Text = "Responder pregunta";
            this.button_ResponderPregunta.UseVisualStyleBackColor = true;
            // 
            // button_HistorialEmpresa
            // 
            this.button_HistorialEmpresa.Location = new System.Drawing.Point(72, 104);
            this.button_HistorialEmpresa.Name = "button_HistorialEmpresa";
            this.button_HistorialEmpresa.Size = new System.Drawing.Size(310, 40);
            this.button_HistorialEmpresa.TabIndex = 3;
            this.button_HistorialEmpresa.Text = "Historial de la Empresa";
            this.button_HistorialEmpresa.UseVisualStyleBackColor = true;
            // 
            // Menu_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 200);
            this.Controls.Add(this.button_HistorialEmpresa);
            this.Controls.Add(this.button_ResponderPregunta);
            this.Controls.Add(this.button_Publicar);
            this.Controls.Add(this.button_Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Empresa";
            this.Text = "Empresa - Seleccione una funcionalidad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Publicar;
        private System.Windows.Forms.Button button_ResponderPregunta;
        private System.Windows.Forms.Button button_HistorialEmpresa;
    }
}