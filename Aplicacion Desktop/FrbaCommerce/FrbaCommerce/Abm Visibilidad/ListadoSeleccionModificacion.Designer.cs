namespace FrbaCommerce.Abm_Visibilidad
{
    partial class ListadoSeleccionModificacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.groupBox_Filtro = new System.Windows.Forms.GroupBox();
            this.label_PorcentajeVenta = new System.Windows.Forms.Label();
            this.label_PrecioPublicitar = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_decimalPrecio = new System.Windows.Forms.TextBox();
            this.textBox_decimalPorcentaje = new System.Windows.Forms.TextBox();
            this.textBox_Porcentaje = new System.Windows.Forms.TextBox();
            this.textBox1_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPublicitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajePublicitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.PrecioPublicitar,
            this.PorcentajePublicitar,
            this.Modificar});
            this.dataGridView1.Location = new System.Drawing.Point(6, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 165);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(429, 115);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 10;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(6, 115);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 13;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click_1);
            // 
            // groupBox_Filtro
            // 
            this.groupBox_Filtro.Controls.Add(this.textBox_decimalPrecio);
            this.groupBox_Filtro.Controls.Add(this.textBox_decimalPorcentaje);
            this.groupBox_Filtro.Controls.Add(this.textBox_Porcentaje);
            this.groupBox_Filtro.Controls.Add(this.label_PorcentajeVenta);
            this.groupBox_Filtro.Controls.Add(this.textBox1_precio);
            this.groupBox_Filtro.Controls.Add(this.label1);
            this.groupBox_Filtro.Controls.Add(this.label_PrecioPublicitar);
            this.groupBox_Filtro.Controls.Add(this.label2);
            this.groupBox_Filtro.Controls.Add(this.textBox_Nombre);
            this.groupBox_Filtro.Controls.Add(this.label_Nombre);
            this.groupBox_Filtro.Location = new System.Drawing.Point(3, 5);
            this.groupBox_Filtro.Name = "groupBox_Filtro";
            this.groupBox_Filtro.Size = new System.Drawing.Size(507, 104);
            this.groupBox_Filtro.TabIndex = 8;
            this.groupBox_Filtro.TabStop = false;
            this.groupBox_Filtro.Text = "Filtros de busqueda";
            // 
            // label_PorcentajeVenta
            // 
            this.label_PorcentajeVenta.AutoSize = true;
            this.label_PorcentajeVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PorcentajeVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_PorcentajeVenta.Location = new System.Drawing.Point(78, 76);
            this.label_PorcentajeVenta.Name = "label_PorcentajeVenta";
            this.label_PorcentajeVenta.Size = new System.Drawing.Size(114, 13);
            this.label_PorcentajeVenta.TabIndex = 15;
            this.label_PorcentajeVenta.Text = "Porcentaje de la venta";
            // 
            // label_PrecioPublicitar
            // 
            this.label_PrecioPublicitar.AutoSize = true;
            this.label_PrecioPublicitar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PrecioPublicitar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_PrecioPublicitar.Location = new System.Drawing.Point(92, 50);
            this.label_PrecioPublicitar.Name = "label_PrecioPublicitar";
            this.label_PrecioPublicitar.Size = new System.Drawing.Size(100, 13);
            this.label_PrecioPublicitar.TabIndex = 14;
            this.label_PrecioPublicitar.Text = "Precio por publicitar";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(196, 21);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(146, 24);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_decimalPrecio
            // 
            this.textBox_decimalPrecio.Location = new System.Drawing.Point(302, 47);
            this.textBox_decimalPrecio.MaxLength = 2;
            this.textBox_decimalPrecio.Name = "textBox_decimalPrecio";
            this.textBox_decimalPrecio.Size = new System.Drawing.Size(44, 20);
            this.textBox_decimalPrecio.TabIndex = 21;
            // 
            // textBox_decimalPorcentaje
            // 
            this.textBox_decimalPorcentaje.Location = new System.Drawing.Point(302, 73);
            this.textBox_decimalPorcentaje.MaxLength = 2;
            this.textBox_decimalPorcentaje.Name = "textBox_decimalPorcentaje";
            this.textBox_decimalPorcentaje.Size = new System.Drawing.Size(44, 20);
            this.textBox_decimalPorcentaje.TabIndex = 20;
            // 
            // textBox_Porcentaje
            // 
            this.textBox_Porcentaje.Location = new System.Drawing.Point(196, 73);
            this.textBox_Porcentaje.MaxLength = 16;
            this.textBox_Porcentaje.Name = "textBox_Porcentaje";
            this.textBox_Porcentaje.Size = new System.Drawing.Size(100, 20);
            this.textBox_Porcentaje.TabIndex = 19;
            // 
            // textBox1_precio
            // 
            this.textBox1_precio.Location = new System.Drawing.Point(196, 47);
            this.textBox1_precio.MaxLength = 16;
            this.textBox1_precio.Name = "textBox1_precio";
            this.textBox1_precio.Size = new System.Drawing.Size(100, 20);
            this.textBox1_precio.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(293, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(293, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = ",";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // PrecioPublicitar
            // 
            this.PrecioPublicitar.HeaderText = "Precio por publicitar";
            this.PrecioPublicitar.Name = "PrecioPublicitar";
            this.PrecioPublicitar.ReadOnly = true;
            this.PrecioPublicitar.Width = 125;
            // 
            // PorcentajePublicitar
            // 
            this.PorcentajePublicitar.HeaderText = "Porcentaje por Publicitar ";
            this.PorcentajePublicitar.Name = "PorcentajePublicitar";
            this.PorcentajePublicitar.ReadOnly = true;
            this.PorcentajePublicitar.Width = 150;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            this.Modificar.Width = 56;
            // 
            // ListadoSeleccionModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.groupBox_Filtro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadoSeleccionModificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ListadoSeleccionModificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_Filtro.ResumeLayout(false);
            this.groupBox_Filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox groupBox_Filtro;
        private System.Windows.Forms.Label label_PorcentajeVenta;
        private System.Windows.Forms.Label label_PrecioPublicitar;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_decimalPrecio;
        private System.Windows.Forms.TextBox textBox_decimalPorcentaje;
        private System.Windows.Forms.TextBox textBox_Porcentaje;
        private System.Windows.Forms.TextBox textBox1_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPublicitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajePublicitar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;

    }
}