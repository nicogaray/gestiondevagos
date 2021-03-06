﻿namespace FrbaCommerce.Abm_Cliente
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
            this.comboBox_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.label_Documento = new System.Windows.Forms.Label();
            this.label_TipoDocumento = new System.Windows.Forms.Label();
            this.textBox_Documento = new System.Windows.Forms.TextBox();
            this.label_Mail = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView_baja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_baja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Tipo,
            this.Nacimiento,
            this.Email,
            this.Telefono,
            this.Direccion,
            this.CodigoPostal,
            this.Cuil,
            this.Eliminar});
            this.dataGridView_baja.Location = new System.Drawing.Point(6, 144);
            this.dataGridView_baja.Name = "dataGridView_baja";
            this.dataGridView_baja.Size = new System.Drawing.Size(498, 165);
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
            this.groupBox_Filtro.Controls.Add(this.comboBox_TipoDocumento);
            this.groupBox_Filtro.Controls.Add(this.textBox_Nombre);
            this.groupBox_Filtro.Controls.Add(this.textBox_Apellido);
            this.groupBox_Filtro.Controls.Add(this.label_Nombre);
            this.groupBox_Filtro.Controls.Add(this.label_Apellido);
            this.groupBox_Filtro.Controls.Add(this.textBox_Mail);
            this.groupBox_Filtro.Controls.Add(this.label_Documento);
            this.groupBox_Filtro.Controls.Add(this.label_TipoDocumento);
            this.groupBox_Filtro.Controls.Add(this.textBox_Documento);
            this.groupBox_Filtro.Controls.Add(this.label_Mail);
            this.groupBox_Filtro.Location = new System.Drawing.Point(3, 5);
            this.groupBox_Filtro.Name = "groupBox_Filtro";
            this.groupBox_Filtro.Size = new System.Drawing.Size(507, 104);
            this.groupBox_Filtro.TabIndex = 4;
            this.groupBox_Filtro.TabStop = false;
            this.groupBox_Filtro.Text = "Filtros de busqueda";
            // 
            // comboBox_TipoDocumento
            // 
            this.comboBox_TipoDocumento.FormattingEnabled = true;
            this.comboBox_TipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "CI",
            "LC",
            "LE",
            "PAS"});
            this.comboBox_TipoDocumento.Location = new System.Drawing.Point(403, 20);
            this.comboBox_TipoDocumento.Name = "comboBox_TipoDocumento";
            this.comboBox_TipoDocumento.Size = new System.Drawing.Size(92, 21);
            this.comboBox_TipoDocumento.TabIndex = 21;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(58, 21);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(58, 47);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(232, 20);
            this.textBox_Apellido.TabIndex = 10;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(8, 24);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Apellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Apellido.Location = new System.Drawing.Point(8, 50);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 2;
            this.label_Apellido.Text = "Apellido";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(58, 73);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mail.TabIndex = 20;
            // 
            // label_Documento
            // 
            this.label_Documento.AutoSize = true;
            this.label_Documento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Documento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Documento.Location = new System.Drawing.Point(298, 51);
            this.label_Documento.Name = "label_Documento";
            this.label_Documento.Size = new System.Drawing.Size(62, 13);
            this.label_Documento.TabIndex = 3;
            this.label_Documento.Text = "Documento";
            // 
            // label_TipoDocumento
            // 
            this.label_TipoDocumento.AutoSize = true;
            this.label_TipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TipoDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_TipoDocumento.Location = new System.Drawing.Point(298, 24);
            this.label_TipoDocumento.Name = "label_TipoDocumento";
            this.label_TipoDocumento.Size = new System.Drawing.Size(99, 13);
            this.label_TipoDocumento.TabIndex = 4;
            this.label_TipoDocumento.Text = "Tipo de documento";
            // 
            // textBox_Documento
            // 
            this.textBox_Documento.Location = new System.Drawing.Point(366, 48);
            this.textBox_Documento.Name = "textBox_Documento";
            this.textBox_Documento.Size = new System.Drawing.Size(129, 20);
            this.textBox_Documento.TabIndex = 13;
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Mail.Location = new System.Drawing.Point(19, 76);
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
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 69;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 87;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 53;
            // 
            // Nacimiento
            // 
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.ReadOnly = true;
            this.Nacimiento.Width = 85;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
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
            // Cuil
            // 
            this.Cuil.HeaderText = "Cuil";
            this.Cuil.Name = "Cuil";
            this.Cuil.ReadOnly = true;
            this.Cuil.Width = 49;
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
            this.AcceptButton = this.button_Buscar;
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
            this.Text = "Form1";
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
        private System.Windows.Forms.ComboBox comboBox_TipoDocumento;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.Label label_Documento;
        private System.Windows.Forms.Label label_TipoDocumento;
        private System.Windows.Forms.TextBox textBox_Documento;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuil;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}