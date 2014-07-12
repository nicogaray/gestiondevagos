namespace FrbaCommerce.Abm_Rol
{
    partial class ModificarFuncionalidad
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
            this.textBox_Funcionalidad = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Funcionalidad = new System.Windows.Forms.Label();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Funcionalidad);
            this.groupBox1.Controls.Add(this.textBox_Descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_Funcionalidad);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Funcionalidad";
            // 
            // textBox_Funcionalidad
            // 
            this.textBox_Funcionalidad.Location = new System.Drawing.Point(127, 29);
            this.textBox_Funcionalidad.MaxLength = 15;
            this.textBox_Funcionalidad.Name = "textBox_Funcionalidad";
            this.textBox_Funcionalidad.Size = new System.Drawing.Size(232, 20);
            this.textBox_Funcionalidad.TabIndex = 7;
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(127, 55);
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
            this.label2.Location = new System.Drawing.Point(58, 58);
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
            this.label_Funcionalidad.Location = new System.Drawing.Point(48, 32);
            this.label_Funcionalidad.Name = "label_Funcionalidad";
            this.label_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.label_Funcionalidad.TabIndex = 4;
            this.label_Funcionalidad.Text = "Funcionalidad";
            // 
            // button_Guardar
            // 
            this.button_Guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Guardar.Location = new System.Drawing.Point(181, 126);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 8;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Cancelar.Location = new System.Drawing.Point(343, 126);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 10;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Eliminar.Location = new System.Drawing.Point(262, 126);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar.TabIndex = 11;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // ModificarFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 161);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarFuncionalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Funcionalidad;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Funcionalidad;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Eliminar;
    }
}