namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class Respuesta
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
            this.groupBox_ResponderPreguntas = new System.Windows.Forms.GroupBox();
            this.textBox_Respuesta = new System.Windows.Forms.TextBox();
            this.textBox_Fecha = new System.Windows.Forms.TextBox();
            this.label_Respuesta = new System.Windows.Forms.Label();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.groupBox_ResponderPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ResponderPreguntas
            // 
            this.groupBox_ResponderPreguntas.Controls.Add(this.textBox_Respuesta);
            this.groupBox_ResponderPreguntas.Controls.Add(this.textBox_Fecha);
            this.groupBox_ResponderPreguntas.Controls.Add(this.label_Respuesta);
            this.groupBox_ResponderPreguntas.Controls.Add(this.label_Fecha);
            this.groupBox_ResponderPreguntas.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ResponderPreguntas.Name = "groupBox_ResponderPreguntas";
            this.groupBox_ResponderPreguntas.Size = new System.Drawing.Size(489, 240);
            this.groupBox_ResponderPreguntas.TabIndex = 1;
            this.groupBox_ResponderPreguntas.TabStop = false;
            this.groupBox_ResponderPreguntas.Text = "Responder";
            // 
            // textBox_Respuesta
            // 
            this.textBox_Respuesta.Location = new System.Drawing.Point(123, 94);
            this.textBox_Respuesta.MaxLength = 255;
            this.textBox_Respuesta.Multiline = true;
            this.textBox_Respuesta.Name = "textBox_Respuesta";
            this.textBox_Respuesta.Size = new System.Drawing.Size(306, 98);
            this.textBox_Respuesta.TabIndex = 3;
            // 
            // textBox_Fecha
            // 
            this.textBox_Fecha.Location = new System.Drawing.Point(123, 67);
            this.textBox_Fecha.Name = "textBox_Fecha";
            this.textBox_Fecha.Size = new System.Drawing.Size(74, 20);
            this.textBox_Fecha.TabIndex = 2;
            this.textBox_Fecha.TextChanged += new System.EventHandler(this.textBox_Fecha_TextChanged);
            // 
            // label_Respuesta
            // 
            this.label_Respuesta.AutoSize = true;
            this.label_Respuesta.Location = new System.Drawing.Point(59, 97);
            this.label_Respuesta.Name = "label_Respuesta";
            this.label_Respuesta.Size = new System.Drawing.Size(58, 13);
            this.label_Respuesta.TabIndex = 1;
            this.label_Respuesta.Text = "Respuesta";
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Location = new System.Drawing.Point(80, 70);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(37, 13);
            this.label_Fecha.TabIndex = 0;
            this.label_Fecha.Text = "Fecha";
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(426, 280);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 7;
            this.button_Volver.Text = "Cancelar";
            this.button_Volver.UseVisualStyleBackColor = true;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(345, 280);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 6;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(264, 280);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 5;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // Respuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.groupBox_ResponderPreguntas);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Respuesta";
            this.Text = "Responder";
            this.Load += new System.EventHandler(this.Respuesta_Load);
            this.groupBox_ResponderPreguntas.ResumeLayout(false);
            this.groupBox_ResponderPreguntas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ResponderPreguntas;
        private System.Windows.Forms.TextBox textBox_Respuesta;
        private System.Windows.Forms.TextBox textBox_Fecha;
        private System.Windows.Forms.Label label_Respuesta;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
    }
}