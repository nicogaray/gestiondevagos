﻿namespace FrbaCommerce.Gestion_de_Preguntas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Pregunta = new System.Windows.Forms.Label();
            this.textBox_Pregunta = new System.Windows.Forms.TextBox();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.label_Inf = new System.Windows.Forms.Label();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 76);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Pregunta);
            this.groupBox2.Controls.Add(this.label_Pregunta);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escribir pregunta";
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
            // textBox_Pregunta
            // 
            this.textBox_Pregunta.Location = new System.Drawing.Point(110, 36);
            this.textBox_Pregunta.Name = "textBox_Pregunta";
            this.textBox_Pregunta.Size = new System.Drawing.Size(420, 20);
            this.textBox_Pregunta.TabIndex = 1;
            this.textBox_Pregunta.MouseLeave += new System.EventHandler(this.textBox_Pregunta_MouseLeave);
            this.textBox_Pregunta.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            // 
            // label_Informacion
            // 
            this.label_Informacion.AutoSize = true;
            this.label_Informacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Informacion.Location = new System.Drawing.Point(83, 289);
            this.label_Informacion.Name = "label_Informacion";
            this.label_Informacion.Size = new System.Drawing.Size(0, 13);
            this.label_Informacion.TabIndex = 2;
            // 
            // label_Inf
            // 
            this.label_Inf.AutoSize = true;
            this.label_Inf.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Inf.Location = new System.Drawing.Point(15, 289);
            this.label_Inf.Name = "label_Inf";
            this.label_Inf.Size = new System.Drawing.Size(62, 13);
            this.label_Inf.TabIndex = 3;
            this.label_Inf.Text = "Informacion";
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(360, 289);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 2;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(441, 289);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 3;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Volver
            // 
            this.button_Volver.Location = new System.Drawing.Point(522, 289);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 4;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // Hacer_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 324);
            this.Controls.Add(this.label_Inf);
            this.Controls.Add(this.label_Informacion);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hacer_Preguntas";
            this.Text = "Hacer preguntas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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