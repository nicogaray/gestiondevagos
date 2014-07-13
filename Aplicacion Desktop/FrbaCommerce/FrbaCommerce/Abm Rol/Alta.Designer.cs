namespace FrbaCommerce.ABM_Rol
{
    partial class Alta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.label_InfTexto = new System.Windows.Forms.Label();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.textBox_Funcionalidad = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Funcionalidad = new System.Windows.Forms.Label();
            this.dataGridView_ListaFuncionalidades = new System.Windows.Forms.DataGridView();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elimnar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.paner_Alta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(425, 25);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 21;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.MouseLeave += new System.EventHandler(this.button_Guardar_MouseLeave);
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            this.button_Guardar.MouseEnter += new System.EventHandler(this.button_Guardar_MouseEnter);
            // 
            // label_InfTexto
            // 
            this.label_InfTexto.AutoSize = true;
            this.label_InfTexto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_InfTexto.Location = new System.Drawing.Point(22, 294);
            this.label_InfTexto.Name = "label_InfTexto";
            this.label_InfTexto.Size = new System.Drawing.Size(65, 13);
            this.label_InfTexto.TabIndex = 20;
            this.label_InfTexto.Text = "Informacion:";
            // 
            // label_Informacion
            // 
            this.label_Informacion.AutoSize = true;
            this.label_Informacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Informacion.Location = new System.Drawing.Point(91, 295);
            this.label_Informacion.Name = "label_Informacion";
            this.label_Informacion.Size = new System.Drawing.Size(0, 13);
            this.label_Informacion.TabIndex = 19;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Limpiar.Location = new System.Drawing.Point(425, 54);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 18;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.MouseLeave += new System.EventHandler(this.button_Limpiar_MouseLeave);
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            this.button_Limpiar.MouseEnter += new System.EventHandler(this.button_Limpiar_MouseEnter);
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.groupBox1);
            this.paner_Alta.Controls.Add(this.dataGridView_ListaFuncionalidades);
            this.paner_Alta.Controls.Add(this.label_Nombre);
            this.paner_Alta.Controls.Add(this.textBox_Nombre);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.paner_Alta.Location = new System.Drawing.Point(12, 7);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(388, 278);
            this.paner_Alta.TabIndex = 17;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos del Rol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Agregar);
            this.groupBox1.Controls.Add(this.textBox_Funcionalidad);
            this.groupBox1.Controls.Add(this.textBox_Descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_Funcionalidad);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(5, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Funcionalidad";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_Agregar
            // 
            this.button_Agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Agregar.Location = new System.Drawing.Point(296, 76);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 8;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // textBox_Funcionalidad
            // 
            this.textBox_Funcionalidad.Location = new System.Drawing.Point(97, 23);
            this.textBox_Funcionalidad.MaxLength = 15;
            this.textBox_Funcionalidad.Name = "textBox_Funcionalidad";
            this.textBox_Funcionalidad.Size = new System.Drawing.Size(232, 20);
            this.textBox_Funcionalidad.TabIndex = 7;
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(97, 49);
            this.textBox_Descripcion.MaxLength = 15;
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(232, 20);
            this.textBox_Descripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // label_Funcionalidad
            // 
            this.label_Funcionalidad.AutoSize = true;
            this.label_Funcionalidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Funcionalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Funcionalidad.Location = new System.Drawing.Point(18, 26);
            this.label_Funcionalidad.Name = "label_Funcionalidad";
            this.label_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.label_Funcionalidad.TabIndex = 4;
            this.label_Funcionalidad.Text = "Funcionalidad";
            // 
            // dataGridView_ListaFuncionalidades
            // 
            this.dataGridView_ListaFuncionalidades.AllowUserToAddRows = false;
            this.dataGridView_ListaFuncionalidades.AllowUserToDeleteRows = false;
            this.dataGridView_ListaFuncionalidades.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_ListaFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionalidad,
            this.Descripcion,
            this.Elimnar});
            this.dataGridView_ListaFuncionalidades.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView_ListaFuncionalidades.Location = new System.Drawing.Point(6, 158);
            this.dataGridView_ListaFuncionalidades.Name = "dataGridView_ListaFuncionalidades";
            this.dataGridView_ListaFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_ListaFuncionalidades.Size = new System.Drawing.Size(376, 114);
            this.dataGridView_ListaFuncionalidades.TabIndex = 3;
            this.dataGridView_ListaFuncionalidades.MouseLeave += new System.EventHandler(this.dataGridView_ListaFuncionalidades_MouseLeave);
            this.dataGridView_ListaFuncionalidades.MouseEnter += new System.EventHandler(this.dataGridView_ListaFuncionalidades_MouseEnter);
            this.dataGridView_ListaFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListaFuncionalidades_CellContentClick);
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Funcionalidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Elimnar
            // 
            this.Elimnar.HeaderText = "Eliminar";
            this.Elimnar.Name = "Elimnar";
            this.Elimnar.Text = "Eliminar Fila";
            this.Elimnar.UseColumnTextForButtonValue = true;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(53, 21);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(103, 18);
            this.textBox_Nombre.MaxLength = 15;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            this.textBox_Nombre.MouseLeave += new System.EventHandler(this.textBox_Nombre_MouseLeave);
            this.textBox_Nombre.MouseEnter += new System.EventHandler(this.textBox_Nombre_MouseEnter);
            // 
            // Alta
            // 
            this.AcceptButton = this.button_Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.label_InfTexto);
            this.Controls.Add(this.label_Informacion);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.paner_Alta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Label label_InfTexto;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.DataGridView dataGridView_ListaFuncionalidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.TextBox textBox_Funcionalidad;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Funcionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Elimnar;
    }
}