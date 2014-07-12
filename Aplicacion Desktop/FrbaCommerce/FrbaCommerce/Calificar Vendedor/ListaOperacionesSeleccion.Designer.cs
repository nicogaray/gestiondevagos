namespace FrbaCommerce.Calificar_Vendedor
{
    partial class ListaOperacionesSeleccion
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
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoOpercion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 301);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la operacion que desea calificar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazonSocial,
            this.Cuit,
            this.Contacto,
            this.Mail,
            this.CodigoOpercion,
            this.TipoOperacion,
            this.FechaOperacion,
            this.Calificar});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(552, 319);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 25;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(369, 319);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(177, 23);
            this.button_Buscar.TabIndex = 26;
            this.button_Buscar.Text = "Buscar operaciones disponibles";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 95;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            this.Cuit.Width = 50;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            this.Contacto.Width = 75;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 51;
            // 
            // CodigoOpercion
            // 
            this.CodigoOpercion.HeaderText = "Codigo de la Operacion";
            this.CodigoOpercion.Name = "CodigoOpercion";
            this.CodigoOpercion.ReadOnly = true;
            this.CodigoOpercion.Width = 143;
            // 
            // TipoOperacion
            // 
            this.TipoOperacion.HeaderText = "Tipo Operacion";
            this.TipoOperacion.Name = "TipoOperacion";
            this.TipoOperacion.ReadOnly = true;
            this.TipoOperacion.Width = 105;
            // 
            // FechaOperacion
            // 
            this.FechaOperacion.HeaderText = "Fecha Operacion";
            this.FechaOperacion.Name = "FechaOperacion";
            this.FechaOperacion.ReadOnly = true;
            this.FechaOperacion.Width = 114;
            // 
            // Calificar
            // 
            this.Calificar.HeaderText = "Calificar";
            this.Calificar.Name = "Calificar";
            this.Calificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Calificar.Text = "Calificar";
            this.Calificar.UseColumnTextForButtonValue = true;
            this.Calificar.Width = 50;
            // 
            // ListaOperacionesSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Volver;
            this.ClientSize = new System.Drawing.Size(639, 354);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListaOperacionesSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificar Vendedor";
            this.Load += new System.EventHandler(this.Calificar_Vendedor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoOpercion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaOperacion;
        private System.Windows.Forms.DataGridViewButtonColumn Calificar;
    }
}