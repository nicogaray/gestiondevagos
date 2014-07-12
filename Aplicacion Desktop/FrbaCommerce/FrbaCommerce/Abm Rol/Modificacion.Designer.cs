namespace FrbaCommerce.Abm_Rol
{
    partial class Modificacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_InfTexto = new System.Windows.Forms.Label();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.dataGridView_ListaFuncionalidades = new System.Windows.Forms.DataGridView();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_ListadoFuncionalidades = new System.Windows.Forms.Label();
            this.paner_Alta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label_InfTexto
            // 
            this.label_InfTexto.AutoSize = true;
            this.label_InfTexto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_InfTexto.Location = new System.Drawing.Point(22, 294);
            this.label_InfTexto.Name = "label_InfTexto";
            this.label_InfTexto.Size = new System.Drawing.Size(65, 13);
            this.label_InfTexto.TabIndex = 25;
            this.label_InfTexto.Text = "Informacion:";
            // 
            // label_Informacion
            // 
            this.label_Informacion.AutoSize = true;
            this.label_Informacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Informacion.Location = new System.Drawing.Point(91, 295);
            this.label_Informacion.Name = "label_Informacion";
            this.label_Informacion.Size = new System.Drawing.Size(0, 13);
            this.label_Informacion.TabIndex = 24;
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.label_ListadoFuncionalidades);
            this.paner_Alta.Controls.Add(this.dataGridView_ListaFuncionalidades);
            this.paner_Alta.Controls.Add(this.label_Nombre);
            this.paner_Alta.Controls.Add(this.textBox_Nombre);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.paner_Alta.Location = new System.Drawing.Point(12, 7);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(388, 278);
            this.paner_Alta.TabIndex = 22;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos del Rol";
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
            this.Modificar});
            this.dataGridView_ListaFuncionalidades.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView_ListaFuncionalidades.Location = new System.Drawing.Point(6, 74);
            this.dataGridView_ListaFuncionalidades.Name = "dataGridView_ListaFuncionalidades";
            this.dataGridView_ListaFuncionalidades.ReadOnly = true;
            this.dataGridView_ListaFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_ListaFuncionalidades.Size = new System.Drawing.Size(376, 198);
            this.dataGridView_ListaFuncionalidades.TabIndex = 3;
            this.dataGridView_ListaFuncionalidades.MouseLeave += new System.EventHandler(this.dataGridView_ListaFuncionalidades_MouseLeave);
            this.dataGridView_ListaFuncionalidades.MouseEnter += new System.EventHandler(this.dataGridView_ListaFuncionalidades_MouseEnter);
            this.dataGridView_ListaFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListaFuncionalidades_CellContentClick);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(53, 20);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(103, 17);
            this.textBox_Nombre.MaxLength = 15;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            this.textBox_Nombre.MouseLeave += new System.EventHandler(this.textBox_Nombre_MouseLeave);
            this.textBox_Nombre.MouseEnter += new System.EventHandler(this.textBox_Nombre_MouseEnter);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(413, 7);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(88, 52);
            this.button_Guardar.TabIndex = 27;
            this.button_Guardar.Text = "Guardar modificaciones";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.MouseLeave += new System.EventHandler(this.button_Guardar_MouseLeave_1);
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click_1);
            this.button_Guardar.MouseEnter += new System.EventHandler(this.button_Guardar_MouseEnter_1);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Limpiar.Location = new System.Drawing.Point(413, 65);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(88, 32);
            this.button_Limpiar.TabIndex = 26;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.MouseLeave += new System.EventHandler(this.button_Limpiar_MouseLeave_1);
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click_1);
            this.button_Limpiar.MouseEnter += new System.EventHandler(this.button_Limpiar_MouseEnter_1);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Cancelar.Location = new System.Drawing.Point(413, 103);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(88, 31);
            this.button_Cancelar.TabIndex = 28;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.MouseLeave += new System.EventHandler(this.button_Cancelar_MouseLeave);
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            this.button_Cancelar.MouseEnter += new System.EventHandler(this.button_Cancelar_MouseEnter);
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Funcionalidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle8;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Modificar
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = "Eliminar Fila";
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle9;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // label_ListadoFuncionalidades
            // 
            this.label_ListadoFuncionalidades.AutoSize = true;
            this.label_ListadoFuncionalidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_ListadoFuncionalidades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_ListadoFuncionalidades.Location = new System.Drawing.Point(53, 50);
            this.label_ListadoFuncionalidades.Name = "label_ListadoFuncionalidades";
            this.label_ListadoFuncionalidades.Size = new System.Drawing.Size(133, 13);
            this.label_ListadoFuncionalidades.TabIndex = 4;
            this.label_ListadoFuncionalidades.Text = "Listado de funcionalidades";
            // 
            // Modificacion
            // 
            this.AcceptButton = this.button_Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancelar;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.label_InfTexto);
            this.Controls.Add(this.label_Informacion);
            this.Controls.Add(this.paner_Alta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InfTexto;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.DataGridView dataGridView_ListaFuncionalidades;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.Label label_ListadoFuncionalidades;
    }
}