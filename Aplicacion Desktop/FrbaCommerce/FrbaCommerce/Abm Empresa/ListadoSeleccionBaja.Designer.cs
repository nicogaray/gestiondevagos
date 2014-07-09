namespace FrbaCommerce.Abm_Empresa
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
            this.dataGridView_baja = new System.Windows.Forms.DataGridView();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.groupBox_Filtro = new System.Windows.Forms.GroupBox();
            this.textBox_RazonSocial = new System.Windows.Forms.TextBox();
            this.textBox_Cuit = new System.Windows.Forms.TextBox();
            this.label_RazonSocial = new System.Windows.Forms.Label();
            this.label_Cuit = new System.Windows.Forms.Label();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.label_Mail = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baja)).BeginInit();
            this.groupBox_Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_baja
            // 
            this.dataGridView_baja.AllowUserToAddRows = false;
            this.dataGridView_baja.AllowUserToDeleteRows = false;
            this.dataGridView_baja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_baja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RazonSocial,
            this.Cuit,
            this.Contacto,
            this.Telefono,
            this.Direccion,
            this.CodigoPostal,
            this.Email,
            this.FechaCreacion,
            this.Eliminar});
            this.dataGridView_baja.Location = new System.Drawing.Point(6, 144);
            this.dataGridView_baja.Name = "dataGridView_baja";
            this.dataGridView_baja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_baja.Size = new System.Drawing.Size(498, 159);
            this.dataGridView_baja.TabIndex = 7;
            this.dataGridView_baja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_baja_CellContentClick);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(429, 115);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 6;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(6, 115);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 5;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // groupBox_Filtro
            // 
            this.groupBox_Filtro.Controls.Add(this.textBox_RazonSocial);
            this.groupBox_Filtro.Controls.Add(this.textBox_Cuit);
            this.groupBox_Filtro.Controls.Add(this.label_RazonSocial);
            this.groupBox_Filtro.Controls.Add(this.label_Cuit);
            this.groupBox_Filtro.Controls.Add(this.textBox_Mail);
            this.groupBox_Filtro.Controls.Add(this.label_Mail);
            this.groupBox_Filtro.Location = new System.Drawing.Point(3, 5);
            this.groupBox_Filtro.Name = "groupBox_Filtro";
            this.groupBox_Filtro.Size = new System.Drawing.Size(507, 104);
            this.groupBox_Filtro.TabIndex = 4;
            this.groupBox_Filtro.TabStop = false;
            this.groupBox_Filtro.Text = "Filtros de busqueda";
            // 
            // textBox_RazonSocial
            // 
            this.textBox_RazonSocial.Location = new System.Drawing.Point(175, 21);
            this.textBox_RazonSocial.Name = "textBox_RazonSocial";
            this.textBox_RazonSocial.Size = new System.Drawing.Size(232, 20);
            this.textBox_RazonSocial.TabIndex = 0;
            // 
            // textBox_Cuit
            // 
            this.textBox_Cuit.Location = new System.Drawing.Point(175, 47);
            this.textBox_Cuit.Name = "textBox_Cuit";
            this.textBox_Cuit.Size = new System.Drawing.Size(232, 20);
            this.textBox_Cuit.TabIndex = 10;
            // 
            // label_RazonSocial
            // 
            this.label_RazonSocial.AutoSize = true;
            this.label_RazonSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_RazonSocial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_RazonSocial.Location = new System.Drawing.Point(99, 24);
            this.label_RazonSocial.Name = "label_RazonSocial";
            this.label_RazonSocial.Size = new System.Drawing.Size(70, 13);
            this.label_RazonSocial.TabIndex = 1;
            this.label_RazonSocial.Text = "Razon Social";
            // 
            // label_Cuit
            // 
            this.label_Cuit.AutoSize = true;
            this.label_Cuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Cuit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Cuit.Location = new System.Drawing.Point(137, 50);
            this.label_Cuit.Name = "label_Cuit";
            this.label_Cuit.Size = new System.Drawing.Size(32, 13);
            this.label_Cuit.TabIndex = 2;
            this.label_Cuit.Text = "CUIT";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(175, 73);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mail.TabIndex = 20;
            this.textBox_Mail.TextChanged += new System.EventHandler(this.textBox_Mail_TextChanged);
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Mail.Location = new System.Drawing.Point(136, 76);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(33, 13);
            this.label_Mail.TabIndex = 5;
            this.label_Mail.Text = "EMail";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
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
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 74;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 77;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.HeaderText = "Codigo Postal";
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.ReadOnly = true;
            this.CodigoPostal.Width = 97;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha Creacion";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 107;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 49;
            // 
            // ListadoSeleccionBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.dataGridView_baja);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.groupBox_Filtro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadoSeleccionBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ListadoSeleccionBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baja)).EndInit();
            this.groupBox_Filtro.ResumeLayout(false);
            this.groupBox_Filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_baja;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox groupBox_Filtro;
        private System.Windows.Forms.TextBox textBox_RazonSocial;
        private System.Windows.Forms.TextBox textBox_Cuit;
        private System.Windows.Forms.Label label_RazonSocial;
        private System.Windows.Forms.Label label_Cuit;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}