namespace FrbaCommerce.Comprar_Ofertar
{
    partial class Comprar
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
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.checkedListBox_Rubro = new System.Windows.Forms.CheckedListBox();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_Rubro = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_UltPag = new System.Windows.Forms.Button();
            this.button_PriPag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AntPag = new System.Windows.Forms.Button();
            this.button_SigPag = new System.Windows.Forms.Button();
            this.button_Volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Descripcion);
            this.groupBox1.Controls.Add(this.checkedListBox_Rubro);
            this.groupBox1.Controls.Add(this.label_Descripcion);
            this.groupBox1.Controls.Add(this.label_Rubro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(178, 54);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(404, 20);
            this.textBox_Descripcion.TabIndex = 3;
            // 
            // checkedListBox_Rubro
            // 
            this.checkedListBox_Rubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_Rubro.CheckOnClick = true;
            this.checkedListBox_Rubro.FormattingEnabled = true;
            this.checkedListBox_Rubro.Items.AddRange(new object[] {
            "Rubro1",
            "Rubro2",
            "Rubro3",
            "Rubro4"});
            this.checkedListBox_Rubro.Location = new System.Drawing.Point(178, 14);
            this.checkedListBox_Rubro.Name = "checkedListBox_Rubro";
            this.checkedListBox_Rubro.Size = new System.Drawing.Size(188, 32);
            this.checkedListBox_Rubro.TabIndex = 0;
            this.checkedListBox_Rubro.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Rubro_SelectedIndexChanged);
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(109, 57);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion.TabIndex = 1;
            this.label_Descripcion.Text = "Descripcion";
            this.label_Descripcion.Click += new System.EventHandler(this.label_DescripcionPublicacion_Click);
            // 
            // label_Rubro
            // 
            this.label_Rubro.AutoSize = true;
            this.label_Rubro.Location = new System.Drawing.Point(136, 25);
            this.label_Rubro.Name = "label_Rubro";
            this.label_Rubro.Size = new System.Drawing.Size(36, 13);
            this.label_Rubro.TabIndex = 0;
            this.label_Rubro.Text = "Rubro";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(390, 106);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 12;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(471, 106);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 11;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 174);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_UltPag
            // 
            this.button_UltPag.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_UltPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UltPag.Location = new System.Drawing.Point(366, 319);
            this.button_UltPag.Name = "button_UltPag";
            this.button_UltPag.Size = new System.Drawing.Size(29, 23);
            this.button_UltPag.TabIndex = 14;
            this.button_UltPag.Text = ">>";
            this.button_UltPag.UseVisualStyleBackColor = true;
            this.button_UltPag.Click += new System.EventHandler(this.button_PagSig_Click);
            // 
            // button_PriPag
            // 
            this.button_PriPag.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_PriPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PriPag.Location = new System.Drawing.Point(244, 319);
            this.button_PriPag.Name = "button_PriPag";
            this.button_PriPag.Size = new System.Drawing.Size(29, 23);
            this.button_PriPag.TabIndex = 16;
            this.button_PriPag.Text = "<<";
            this.button_PriPag.UseVisualStyleBackColor = true;
            this.button_PriPag.Click += new System.EventHandler(this.button_PagAnt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "||";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_AntPag
            // 
            this.button_AntPag.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_AntPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AntPag.Location = new System.Drawing.Point(279, 319);
            this.button_AntPag.Name = "button_AntPag";
            this.button_AntPag.Size = new System.Drawing.Size(29, 23);
            this.button_AntPag.TabIndex = 18;
            this.button_AntPag.Text = "<";
            this.button_AntPag.UseVisualStyleBackColor = true;
            this.button_AntPag.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_SigPag
            // 
            this.button_SigPag.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_SigPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SigPag.Location = new System.Drawing.Point(331, 319);
            this.button_SigPag.Name = "button_SigPag";
            this.button_SigPag.Size = new System.Drawing.Size(29, 23);
            this.button_SigPag.TabIndex = 19;
            this.button_SigPag.Text = ">";
            this.button_SigPag.UseVisualStyleBackColor = true;
            this.button_SigPag.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(551, 106);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 20;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // Comprar
            // 
            this.AcceptButton = this.button_Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Volver;
            this.ClientSize = new System.Drawing.Size(639, 354);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_SigPag);
            this.Controls.Add(this.button_AntPag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_PriPag);
            this.Controls.Add(this.button_UltPag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Comprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra inmediata";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.CheckedListBox checkedListBox_Rubro;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_Rubro;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_UltPag;
        private System.Windows.Forms.Button button_PriPag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AntPag;
        private System.Windows.Forms.Button button_SigPag;
        private System.Windows.Forms.Button button_Volver;
    }
}