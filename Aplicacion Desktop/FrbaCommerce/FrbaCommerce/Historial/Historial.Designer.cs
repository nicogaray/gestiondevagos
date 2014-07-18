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
            this.dataGridView_Respuesta1 = new System.Windows.Forms.DataGridView();
            this.CodigoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Consultas = new System.Windows.Forms.GroupBox();
            this.comboBox_operaciones = new System.Windows.Forms.ComboBox();
            this.label_OperacionesRealizadas = new System.Windows.Forms.Label();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_HacerConsulta = new System.Windows.Forms.Button();
            this.dataGridView_Respuesta2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_Respuesta3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEstrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Respuesta1)).BeginInit();
            this.groupBox_Consultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Respuesta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Respuesta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Respuesta1
            // 
            this.dataGridView_Respuesta1.AllowUserToAddRows = false;
            this.dataGridView_Respuesta1.AllowUserToDeleteRows = false;
            this.dataGridView_Respuesta1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Respuesta1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoOperacion,
            this.CodigoPublicacion,
            this.Descripcion,
            this.Tipo,
            this.Fecha});
            this.dataGridView_Respuesta1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView_Respuesta1.Name = "dataGridView_Respuesta1";
            this.dataGridView_Respuesta1.Size = new System.Drawing.Size(614, 236);
            this.dataGridView_Respuesta1.TabIndex = 3;
            this.dataGridView_Respuesta1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ResultadoCompra_CellContentClick);
            // 
            // CodigoOperacion
            // 
            this.CodigoOperacion.HeaderText = "Codigo Operacion";
            this.CodigoOperacion.Name = "CodigoOperacion";
            this.CodigoOperacion.ReadOnly = true;
            this.CodigoOperacion.Width = 117;
            // 
            // CodigoPublicacion
            // 
            this.CodigoPublicacion.HeaderText = "Codigo Publicacion";
            this.CodigoPublicacion.Name = "CodigoPublicacion";
            this.CodigoPublicacion.ReadOnly = true;
            this.CodigoPublicacion.Width = 123;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 53;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
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
            // dataGridView_Respuesta2
            // 
            this.dataGridView_Respuesta2.AllowUserToAddRows = false;
            this.dataGridView_Respuesta2.AllowUserToDeleteRows = false;
            this.dataGridView_Respuesta2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Respuesta2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Ganador});
            this.dataGridView_Respuesta2.Location = new System.Drawing.Point(12, 106);
            this.dataGridView_Respuesta2.Name = "dataGridView_Respuesta2";
            this.dataGridView_Respuesta2.Size = new System.Drawing.Size(614, 236);
            this.dataGridView_Respuesta2.TabIndex = 4;
            this.dataGridView_Respuesta2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ResultadoOfertas_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo Operacion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 117;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo Publicacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 123;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 53;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 62;
            // 
            // Ganador
            // 
            this.Ganador.HeaderText = "Ganador";
            this.Ganador.Name = "Ganador";
            this.Ganador.ReadOnly = true;
            this.Ganador.Width = 73;
            // 
            // dataGridView_Respuesta3
            // 
            this.dataGridView_Respuesta3.AllowUserToAddRows = false;
            this.dataGridView_Respuesta3.AllowUserToDeleteRows = false;
            this.dataGridView_Respuesta3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Respuesta3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.CantidadEstrellas,
            this.DetalleCalificacion});
            this.dataGridView_Respuesta3.Location = new System.Drawing.Point(12, 106);
            this.dataGridView_Respuesta3.Name = "dataGridView_Respuesta3";
            this.dataGridView_Respuesta3.Size = new System.Drawing.Size(614, 236);
            this.dataGridView_Respuesta3.TabIndex = 5;
            this.dataGridView_Respuesta3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Respuesta3_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Codigo Operacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 117;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Codigo Publicacion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 123;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 88;
            // 
            // CantidadEstrellas
            // 
            this.CantidadEstrellas.HeaderText = "Cantidad de Estrellas";
            this.CantidadEstrellas.Name = "CantidadEstrellas";
            this.CantidadEstrellas.ReadOnly = true;
            this.CantidadEstrellas.Width = 131;
            // 
            // DetalleCalificacion
            // 
            this.DetalleCalificacion.HeaderText = "Detalle de Calificacion";
            this.DetalleCalificacion.Name = "DetalleCalificacion";
            this.DetalleCalificacion.ReadOnly = true;
            this.DetalleCalificacion.Width = 137;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 236);
            this.dataGridView1.TabIndex = 6;
            // 
            // Historial
            // 
            this.AcceptButton = this.button_HacerConsulta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Volver;
            this.ClientSize = new System.Drawing.Size(639, 354);
            this.Controls.Add(this.dataGridView_Respuesta3);
            this.Controls.Add(this.dataGridView_Respuesta2);
            this.Controls.Add(this.dataGridView_Respuesta1);
            this.Controls.Add(this.groupBox_Consultas);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_HacerConsulta);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Respuesta1)).EndInit();
            this.groupBox_Consultas.ResumeLayout(false);
            this.groupBox_Consultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Respuesta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Respuesta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Respuesta1;
        private System.Windows.Forms.GroupBox groupBox_Consultas;
        private System.Windows.Forms.Label label_OperacionesRealizadas;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.ComboBox comboBox_operaciones;
        private System.Windows.Forms.Button button_HacerConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridView dataGridView_Respuesta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganador;
        private System.Windows.Forms.DataGridView dataGridView_Respuesta3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEstrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCalificacion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}