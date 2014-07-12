namespace FrbaCommerce.Abm_Rol
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
            this.groupBox_Filtro = new System.Windows.Forms.GroupBox();
            this.label_Informacion = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(68, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 212);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox_Filtro
            // 
            this.groupBox_Filtro.Controls.Add(this.label_Informacion);
            this.groupBox_Filtro.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox_Filtro.Location = new System.Drawing.Point(3, 258);
            this.groupBox_Filtro.Name = "groupBox_Filtro";
            this.groupBox_Filtro.Size = new System.Drawing.Size(507, 51);
            this.groupBox_Filtro.TabIndex = 15;
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
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // ListadoSeleccionBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_Filtro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadoSeleccionBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListadoSeleccionBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_Filtro.ResumeLayout(false);
            this.groupBox_Filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_Filtro;
        private System.Windows.Forms.Label label_Informacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}