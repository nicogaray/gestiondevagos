﻿namespace FrbaCommerce.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.groupBox_Consultas = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Mes = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Visibilidad = new System.Windows.Forms.ComboBox();
            this.label_Mes = new System.Windows.Forms.Label();
            this.numericUpDown_Anio = new System.Windows.Forms.NumericUpDown();
            this.label_TipoVisibilidad = new System.Windows.Forms.Label();
            this.label_Trimestre = new System.Windows.Forms.Label();
            this.comboBox_TipoListado = new System.Windows.Forms.ComboBox();
            this.label_TipoListado = new System.Windows.Forms.Label();
            this.comboBox_Trimestre = new System.Windows.Forms.ComboBox();
            this.label_Anio = new System.Windows.Forms.Label();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_HacerConsulta = new System.Windows.Forms.Button();
            this.dataGridView_Resultado = new System.Windows.Forms.DataGridView();
            this.groupBox_Consultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Anio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Consultas
            // 
            this.groupBox_Consultas.Controls.Add(this.numericUpDown_Mes);
            this.groupBox_Consultas.Controls.Add(this.comboBox_Visibilidad);
            this.groupBox_Consultas.Controls.Add(this.label_Mes);
            this.groupBox_Consultas.Controls.Add(this.numericUpDown_Anio);
            this.groupBox_Consultas.Controls.Add(this.label_TipoVisibilidad);
            this.groupBox_Consultas.Controls.Add(this.label_Trimestre);
            this.groupBox_Consultas.Controls.Add(this.comboBox_TipoListado);
            this.groupBox_Consultas.Controls.Add(this.label_TipoListado);
            this.groupBox_Consultas.Controls.Add(this.comboBox_Trimestre);
            this.groupBox_Consultas.Controls.Add(this.label_Anio);
            this.groupBox_Consultas.Controls.Add(this.button_Volver);
            this.groupBox_Consultas.Controls.Add(this.button_Limpiar);
            this.groupBox_Consultas.Controls.Add(this.button_HacerConsulta);
            this.groupBox_Consultas.Location = new System.Drawing.Point(12, 13);
            this.groupBox_Consultas.Name = "groupBox_Consultas";
            this.groupBox_Consultas.Size = new System.Drawing.Size(615, 115);
            this.groupBox_Consultas.TabIndex = 0;
            this.groupBox_Consultas.TabStop = false;
            this.groupBox_Consultas.Text = "Consultas";
            // 
            // numericUpDown_Mes
            // 
            this.numericUpDown_Mes.Location = new System.Drawing.Point(277, 29);
            this.numericUpDown_Mes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_Mes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Mes.Name = "numericUpDown_Mes";
            this.numericUpDown_Mes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Mes.TabIndex = 16;
            this.numericUpDown_Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Mes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_Visibilidad
            // 
            this.comboBox_Visibilidad.FormattingEnabled = true;
            this.comboBox_Visibilidad.Location = new System.Drawing.Point(140, 56);
            this.comboBox_Visibilidad.Name = "comboBox_Visibilidad";
            this.comboBox_Visibilidad.Size = new System.Drawing.Size(245, 21);
            this.comboBox_Visibilidad.TabIndex = 15;
            this.comboBox_Visibilidad.SelectedIndexChanged += new System.EventHandler(this.comboBox_Visibilidad_SelectedIndexChanged);
            // 
            // label_Mes
            // 
            this.label_Mes.AutoSize = true;
            this.label_Mes.Location = new System.Drawing.Point(244, 33);
            this.label_Mes.Name = "label_Mes";
            this.label_Mes.Size = new System.Drawing.Size(27, 13);
            this.label_Mes.TabIndex = 12;
            this.label_Mes.Text = "Mes";
            // 
            // numericUpDown_Anio
            // 
            this.numericUpDown_Anio.Location = new System.Drawing.Point(90, 30);
            this.numericUpDown_Anio.Maximum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.numericUpDown_Anio.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericUpDown_Anio.Name = "numericUpDown_Anio";
            this.numericUpDown_Anio.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Anio.TabIndex = 11;
            this.numericUpDown_Anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Anio.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // label_TipoVisibilidad
            // 
            this.label_TipoVisibilidad.AutoSize = true;
            this.label_TipoVisibilidad.Location = new System.Drawing.Point(84, 59);
            this.label_TipoVisibilidad.Name = "label_TipoVisibilidad";
            this.label_TipoVisibilidad.Size = new System.Drawing.Size(53, 13);
            this.label_TipoVisibilidad.TabIndex = 9;
            this.label_TipoVisibilidad.Text = "Visibilidad";
            // 
            // label_Trimestre
            // 
            this.label_Trimestre.AutoSize = true;
            this.label_Trimestre.Location = new System.Drawing.Point(221, 33);
            this.label_Trimestre.Name = "label_Trimestre";
            this.label_Trimestre.Size = new System.Drawing.Size(50, 13);
            this.label_Trimestre.TabIndex = 4;
            this.label_Trimestre.Text = "Trimestre";
            // 
            // comboBox_TipoListado
            // 
            this.comboBox_TipoListado.FormattingEnabled = true;
            this.comboBox_TipoListado.Items.AddRange(new object[] {
            "Vendedores con mayor cantidad de productos no vendidos",
            "Vendedores con mayor facturacion",
            "Vendedores con mayores calificaciones",
            "Clientes con mayor cantidad de publicaciones sin calificar"});
            this.comboBox_TipoListado.Location = new System.Drawing.Point(140, 81);
            this.comboBox_TipoListado.Name = "comboBox_TipoListado";
            this.comboBox_TipoListado.Size = new System.Drawing.Size(309, 21);
            this.comboBox_TipoListado.TabIndex = 0;
            this.comboBox_TipoListado.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipoListado_SelectedIndexChanged);
            this.comboBox_TipoListado.SelectedValueChanged += new System.EventHandler(this.comboBox_TipoListado_SelectedValueChanged);
            // 
            // label_TipoListado
            // 
            this.label_TipoListado.AutoSize = true;
            this.label_TipoListado.Location = new System.Drawing.Point(58, 84);
            this.label_TipoListado.Name = "label_TipoListado";
            this.label_TipoListado.Size = new System.Drawing.Size(76, 13);
            this.label_TipoListado.TabIndex = 7;
            this.label_TipoListado.Text = "Tipo de listado";
            // 
            // comboBox_Trimestre
            // 
            this.comboBox_Trimestre.FormattingEnabled = true;
            this.comboBox_Trimestre.Items.AddRange(new object[] {
            "1ro",
            "2do",
            "3ro",
            "4to"});
            this.comboBox_Trimestre.Location = new System.Drawing.Point(277, 29);
            this.comboBox_Trimestre.Name = "comboBox_Trimestre";
            this.comboBox_Trimestre.Size = new System.Drawing.Size(68, 21);
            this.comboBox_Trimestre.TabIndex = 5;
            // 
            // label_Anio
            // 
            this.label_Anio.AutoSize = true;
            this.label_Anio.Location = new System.Drawing.Point(58, 32);
            this.label_Anio.Name = "label_Anio";
            this.label_Anio.Size = new System.Drawing.Size(26, 13);
            this.label_Anio.TabIndex = 3;
            this.label_Anio.Text = "Año";
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(534, 81);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 2;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(534, 52);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 1;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_HacerConsulta
            // 
            this.button_HacerConsulta.Location = new System.Drawing.Point(534, 11);
            this.button_HacerConsulta.Name = "button_HacerConsulta";
            this.button_HacerConsulta.Size = new System.Drawing.Size(75, 35);
            this.button_HacerConsulta.TabIndex = 0;
            this.button_HacerConsulta.Text = "Hacer consulta";
            this.button_HacerConsulta.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Resultado
            // 
            this.dataGridView_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Resultado.Location = new System.Drawing.Point(12, 136);
            this.dataGridView_Resultado.Name = "dataGridView_Resultado";
            this.dataGridView_Resultado.Size = new System.Drawing.Size(614, 205);
            this.dataGridView_Resultado.TabIndex = 1;
            // 
            // ListadoEstadistico
            // 
            this.AcceptButton = this.button_HacerConsulta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Volver;
            this.ClientSize = new System.Drawing.Size(639, 354);
            this.Controls.Add(this.dataGridView_Resultado);
            this.Controls.Add(this.groupBox_Consultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados Estadísticos";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.groupBox_Consultas.ResumeLayout(false);
            this.groupBox_Consultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Anio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Consultas;
        private System.Windows.Forms.DataGridView dataGridView_Resultado;
        private System.Windows.Forms.Button button_HacerConsulta;
        private System.Windows.Forms.Label label_TipoListado;
        private System.Windows.Forms.ComboBox comboBox_Trimestre;
        private System.Windows.Forms.Label label_Trimestre;
        private System.Windows.Forms.Label label_Anio;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.ComboBox comboBox_TipoListado;
        private System.Windows.Forms.Label label_TipoVisibilidad;
        private System.Windows.Forms.NumericUpDown numericUpDown_Anio;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mes;
        private System.Windows.Forms.ComboBox comboBox_Visibilidad;
        private System.Windows.Forms.Label label_Mes;
    }
}