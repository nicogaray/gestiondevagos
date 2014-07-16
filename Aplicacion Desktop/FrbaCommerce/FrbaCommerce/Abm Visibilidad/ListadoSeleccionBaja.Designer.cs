namespace FrbaCommerce.Abm_Visibilidad
{
    partial class ListadoSeleccionBaja
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
            this.textBox_PrecioPublicitar = new System.Windows.Forms.TextBox();
            this.textBox_PorcentajeVenta = new System.Windows.Forms.TextBox();
            this.label_PorcentajeVenta = new System.Windows.Forms.Label();
            this.label_PrecioPublicitar = new System.Windows.Forms.Label();
            this.textBox_RazonSocial = new System.Windows.Forms.TextBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 165);
            this.dataGridView1.TabIndex = 11;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(429, 115);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 10;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Limpiar.Location = new System.Drawing.Point(6, 115);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 9;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // groupBox_Filtro
            // 
            this.groupBox_Filtro.Controls.Add(this.textBox_PrecioPublicitar);
            this.groupBox_Filtro.Controls.Add(this.textBox_PorcentajeVenta);
            this.groupBox_Filtro.Controls.Add(this.label_PorcentajeVenta);
            this.groupBox_Filtro.Controls.Add(this.label_PrecioPublicitar);
            this.groupBox_Filtro.Controls.Add(this.textBox_RazonSocial);
            this.groupBox_Filtro.Controls.Add(this.label_Nombre);
            this.groupBox_Filtro.Location = new System.Drawing.Point(3, 5);
            this.groupBox_Filtro.Name = "groupBox_Filtro";
            this.groupBox_Filtro.Size = new System.Drawing.Size(507, 104);
            this.groupBox_Filtro.TabIndex = 8;
            this.groupBox_Filtro.TabStop = false;
            this.groupBox_Filtro.Text = "Filtros de busqueda";
            // 
            // textBox_PrecioPublicitar
            // 
            this.textBox_PrecioPublicitar.Location = new System.Drawing.Point(196, 47);
            this.textBox_PrecioPublicitar.Name = "textBox_PrecioPublicitar";
            this.textBox_PrecioPublicitar.Size = new System.Drawing.Size(129, 20);
            this.textBox_PrecioPublicitar.TabIndex = 17;
            this.textBox_PrecioPublicitar.TextChanged += new System.EventHandler(this.textBox_PrecioPublicitar_TextChanged);
            // 
            // textBox_PorcentajeVenta
            // 
            this.textBox_PorcentajeVenta.Location = new System.Drawing.Point(196, 73);
            this.textBox_PorcentajeVenta.Name = "textBox_PorcentajeVenta";
            this.textBox_PorcentajeVenta.Size = new System.Drawing.Size(129, 20);
            this.textBox_PorcentajeVenta.TabIndex = 16;
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
            // textBox_RazonSocial
            // 
            this.textBox_RazonSocial.Location = new System.Drawing.Point(196, 21);
            this.textBox_RazonSocial.Name = "textBox_RazonSocial";
            this.textBox_RazonSocial.Size = new System.Drawing.Size(232, 20);
            this.textBox_RazonSocial.TabIndex = 0;
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
            // ListadoSeleccionBaja
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
            this.Name = "ListadoSeleccionBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
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
        private System.Windows.Forms.TextBox textBox_RazonSocial;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_PrecioPublicitar;
        private System.Windows.Forms.TextBox textBox_PorcentajeVenta;
        private System.Windows.Forms.Label label_PorcentajeVenta;
        private System.Windows.Forms.Label label_PrecioPublicitar;
    }
}