namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class Hacer_Preguntas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Pregunta = new System.Windows.Forms.TextBox();
            this.label_Pregunta = new System.Windows.Forms.Label();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.label_Inf = new System.Windows.Forms.Label();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Volver = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Pregunta);
            this.groupBox2.Controls.Add(this.label_Pregunta);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escribir pregunta";
            // 
            // textBox_Pregunta
            // 
            this.textBox_Pregunta.Location = new System.Drawing.Point(110, 36);
            this.textBox_Pregunta.MaxLength = 255;
            this.textBox_Pregunta.Name = "textBox_Pregunta";
            this.textBox_Pregunta.Size = new System.Drawing.Size(420, 20);
            this.textBox_Pregunta.TabIndex = 1;
            this.textBox_Pregunta.TextChanged += new System.EventHandler(this.textBox_Pregunta_TextChanged);
            this.textBox_Pregunta.MouseLeave += new System.EventHandler(this.textBox_Pregunta_MouseLeave);
            this.textBox_Pregunta.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            // 
            // label_Pregunta
            // 
            this.label_Pregunta.AutoSize = true;
            this.label_Pregunta.Location = new System.Drawing.Point(54, 39);
            this.label_Pregunta.Name = "label_Pregunta";
            this.label_Pregunta.Size = new System.Drawing.Size(50, 13);
            this.label_Pregunta.TabIndex = 0;
            this.label_Pregunta.Text = "Pregunta";
            this.label_Pregunta.MouseLeave += new System.EventHandler(this.label_Pregunta_MouseLeave);
            this.label_Pregunta.MouseEnter += new System.EventHandler(this.label_Pregunta_MouseEnter);
            // 
            // label_Informacion
            // 
            this.label_Informacion.AutoSize = true;
            this.label_Informacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Informacion.Location = new System.Drawing.Point(83, 110);
            this.label_Informacion.Name = "label_Informacion";
            this.label_Informacion.Size = new System.Drawing.Size(0, 13);
            this.label_Informacion.TabIndex = 2;
            // 
            // label_Inf
            // 
            this.label_Inf.AutoSize = true;
            this.label_Inf.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Inf.Location = new System.Drawing.Point(15, 110);
            this.label_Inf.Name = "label_Inf";
            this.label_Inf.Size = new System.Drawing.Size(62, 13);
            this.label_Inf.TabIndex = 3;
            this.label_Inf.Text = "Informacion";
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(360, 110);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 2;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(441, 110);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 3;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(522, 110);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 4;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // Hacer_Preguntas
            // 
            this.AcceptButton = this.button_Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Volver;
            this.ClientSize = new System.Drawing.Size(609, 155);
            this.Controls.Add(this.label_Inf);
            this.Controls.Add(this.label_Informacion);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hacer_Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacer preguntas";
            this.Load += new System.EventHandler(this.Hacer_Preguntas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Inf;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.TextBox textBox_Pregunta;
        private System.Windows.Forms.Label label_Pregunta;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Volver;
    }
}