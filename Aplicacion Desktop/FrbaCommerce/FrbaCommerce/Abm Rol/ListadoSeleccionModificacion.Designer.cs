namespace FrbaCommerce.Abm_Rol
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
            this.groupBox_Filtro = new System.Windows.Forms.GroupBox();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Filtro
            // 
            this.groupBox_Filtro.Controls.Add(this.label_Informacion);
            this.groupBox_Filtro.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox_Filtro.Location = new System.Drawing.Point(3, 258);
            this.groupBox_Filtro.Name = "groupBox_Filtro";
            this.groupBox_Filtro.Size = new System.Drawing.Size(507, 51);
            this.groupBox_Filtro.TabIndex = 12;
            this.groupBox_Filtro.TabStop = false;
            this.groupBox_Filtro.Text = "Informacion";
            // 
            // label_Informacion
            // 
            this.label_Informacion.AutoSize = true;
            this.label_Informacion.Location = new System.Drawing.Point(19, 19);
            this.label_Informacion.Name = "label_Informacion";
            this.label_Informacion.Size = new System.Drawing.Size(0, 13);
            this.label_Informacion.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol,
            this.Modificar});
            this.dataGridView1.Location = new System.Drawing.Point(68, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 212);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // ListadoSeleccionModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_Filtro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadoSeleccionModificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ListadoSeleccionModificacion_Load);
            this.groupBox_Filtro.ResumeLayout(false);
            this.groupBox_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Filtro;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
    }
}