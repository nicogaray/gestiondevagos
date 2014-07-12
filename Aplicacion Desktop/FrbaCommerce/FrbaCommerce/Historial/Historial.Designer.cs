namespace FrbaCommerce.Historial_Cliente
{
    partial class Historial
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
            this.dataGridView_Resultado = new System.Windows.Forms.DataGridView();
            this.groupBox_Consultas = new System.Windows.Forms.GroupBox();
            this.comboBox_operaciones = new System.Windows.Forms.ComboBox();
            this.label_OperacionesRealizadas = new System.Windows.Forms.Label();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_HacerConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resultado)).BeginInit();
            this.groupBox_Consultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Resultado
            // 
            this.dataGridView_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Resultado.Location = new System.Drawing.Point(12, 107);
            this.dataGridView_Resultado.Name = "dataGridView_Resultado";
            this.dataGridView_Resultado.Size = new System.Drawing.Size(614, 234);
            this.dataGridView_Resultado.TabIndex = 3;
            // 
            // groupBox_Consultas
            // 
            this.groupBox_Consultas.Controls.Add(this.comboBox_operaciones);
            this.groupBox_Consultas.Controls.Add(this.label_OperacionesRealizadas);
            this.groupBox_Consultas.Location = new System.Drawing.Point(12, 13);
            this.groupBox_Consultas.Name = "groupBox_Consultas";
            this.groupBox_Consultas.Size = new System.Drawing.Size(615, 57);
            this.groupBox_Consultas.TabIndex = 2;
            this.groupBox_Consultas.TabStop = false;
            this.groupBox_Consultas.Text = "Consultas";
            // 
            // comboBox_operaciones
            // 
            this.comboBox_operaciones.FormattingEnabled = true;
            this.comboBox_operaciones.Location = new System.Drawing.Point(277, 19);
            this.comboBox_operaciones.Name = "comboBox_operaciones";
            this.comboBox_operaciones.Size = new System.Drawing.Size(189, 21);
            this.comboBox_operaciones.TabIndex = 4;
            this.comboBox_operaciones.SelectedIndexChanged += new System.EventHandler(this.comboBox_operaciones_SelectedIndexChanged);
            // 
            // label_OperacionesRealizadas
            // 
            this.label_OperacionesRealizadas.AutoSize = true;
            this.label_OperacionesRealizadas.Location = new System.Drawing.Point(149, 22);
            this.label_OperacionesRealizadas.Name = "label_OperacionesRealizadas";
            this.label_OperacionesRealizadas.Size = new System.Drawing.Size(122, 13);
            this.label_OperacionesRealizadas.TabIndex = 3;
            this.label_OperacionesRealizadas.Text = "Operaciones Realizadas";
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(538, 76);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(88, 25);
            this.button_Volver.TabIndex = 2;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Limpiar.Location = new System.Drawing.Point(444, 76);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(88, 25);
            this.button_Limpiar.TabIndex = 1;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_HacerConsulta
            // 
            this.button_HacerConsulta.Location = new System.Drawing.Point(350, 76);
            this.button_HacerConsulta.Name = "button_HacerConsulta";
            this.button_HacerConsulta.Size = new System.Drawing.Size(88, 25);
            this.button_HacerConsulta.TabIndex = 0;
            this.button_HacerConsulta.Text = "Hacer consulta";
            this.button_HacerConsulta.UseVisualStyleBackColor = true;
            this.button_HacerConsulta.Click += new System.EventHandler(this.button_HacerConsulta_Click_1);
            // 
            // Historial
            // 
            this.AcceptButton = this.button_HacerConsulta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Volver;
            this.ClientSize = new System.Drawing.Size(639, 354);
            this.Controls.Add(this.dataGridView_Resultado);
            this.Controls.Add(this.groupBox_Consultas);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_HacerConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resultado)).EndInit();
            this.groupBox_Consultas.ResumeLayout(false);
            this.groupBox_Consultas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Resultado;
        private System.Windows.Forms.GroupBox groupBox_Consultas;
        private System.Windows.Forms.Label label_OperacionesRealizadas;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.ComboBox comboBox_operaciones;
        private System.Windows.Forms.Button button_HacerConsulta;
    }
}