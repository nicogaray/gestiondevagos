namespace FrbaCommerce.Editar_Publicacion
{
    partial class Borrador
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PublicacionCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpresaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HabilitacionPreguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Volver
            // 
            this.button_Volver.Location = new System.Drawing.Point(416, 270);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 3;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PublicacionCodigo,
            this.EmpresaCodigo,
            this.Descripcion,
            this.Precio,
            this.FechaInicio,
            this.FechaFin,
            this.HabilitacionPreguntas,
            this.Stock,
            this.CantidadLote,
            this.Modificar});
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(479, 252);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // PublicacionCodigo
            // 
            this.PublicacionCodigo.HeaderText = "Publicacion ";
            this.PublicacionCodigo.Name = "PublicacionCodigo";
            this.PublicacionCodigo.ReadOnly = true;
            this.PublicacionCodigo.Width = 90;
            // 
            // EmpresaCodigo
            // 
            this.EmpresaCodigo.HeaderText = "Codigo de Empresa";
            this.EmpresaCodigo.Name = "EmpresaCodigo";
            this.EmpresaCodigo.ReadOnly = true;
            this.EmpresaCodigo.Width = 124;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio/Valor Inicial";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 121;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha de Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 105;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha de Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 94;
            // 
            // HabilitacionPreguntas
            // 
            this.HabilitacionPreguntas.HeaderText = "Habilitacion Preguntas";
            this.HabilitacionPreguntas.Name = "HabilitacionPreguntas";
            this.HabilitacionPreguntas.ReadOnly = true;
            this.HabilitacionPreguntas.Width = 138;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Compra Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 99;
            // 
            // CantidadLote
            // 
            this.CantidadLote.HeaderText = "Subasta Cantidad por Lote";
            this.CantidadLote.Name = "CantidadLote";
            this.CantidadLote.ReadOnly = true;
            this.CantidadLote.Width = 158;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            this.Modificar.Width = 56;
            // 
            // Borrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 305);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_Volver);
            this.Name = "Borrador";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Borrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicacionCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HabilitacionPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadLote;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;

    }
}