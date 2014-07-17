namespace FrbaCommerce.Editar_Publicacion
{
    partial class ModificarActiva
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
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.label_Cantidad = new System.Windows.Forms.Label();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.radioButton_Pausada = new System.Windows.Forms.RadioButton();
            this.radioButton_Borrador = new System.Windows.Forms.RadioButton();
            this.radioButton_Activa = new System.Windows.Forms.RadioButton();
            this.label_Estado = new System.Windows.Forms.Label();
            this.radioButton_Finalizada = new System.Windows.Forms.RadioButton();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(154, 38);
            this.textBox_cantidad.MaxLength = 18;
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(65, 20);
            this.textBox_cantidad.TabIndex = 7;
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.AutoSize = true;
            this.label_Cantidad.Location = new System.Drawing.Point(100, 41);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.label_Cantidad.TabIndex = 6;
            this.label_Cantidad.Text = "Cantidad";
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(154, 12);
            this.textBox_descripcion.MaxLength = 255;
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(231, 20);
            this.textBox_descripcion.TabIndex = 5;
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(86, 15);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion.TabIndex = 4;
            this.label_Descripcion.Text = "Descripcion";
            // 
            // radioButton_Pausada
            // 
            this.radioButton_Pausada.AutoSize = true;
            this.radioButton_Pausada.Location = new System.Drawing.Point(286, 64);
            this.radioButton_Pausada.Name = "radioButton_Pausada";
            this.radioButton_Pausada.Size = new System.Drawing.Size(67, 17);
            this.radioButton_Pausada.TabIndex = 24;
            this.radioButton_Pausada.TabStop = true;
            this.radioButton_Pausada.Text = "Pausada";
            this.radioButton_Pausada.UseVisualStyleBackColor = true;
            // 
            // radioButton_Borrador
            // 
            this.radioButton_Borrador.AutoSize = true;
            this.radioButton_Borrador.Location = new System.Drawing.Point(215, 64);
            this.radioButton_Borrador.Name = "radioButton_Borrador";
            this.radioButton_Borrador.Size = new System.Drawing.Size(65, 17);
            this.radioButton_Borrador.TabIndex = 23;
            this.radioButton_Borrador.TabStop = true;
            this.radioButton_Borrador.Text = "Borrador";
            this.radioButton_Borrador.UseVisualStyleBackColor = true;
            // 
            // radioButton_Activa
            // 
            this.radioButton_Activa.AutoSize = true;
            this.radioButton_Activa.Location = new System.Drawing.Point(154, 64);
            this.radioButton_Activa.Name = "radioButton_Activa";
            this.radioButton_Activa.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Activa.TabIndex = 22;
            this.radioButton_Activa.TabStop = true;
            this.radioButton_Activa.Text = "Activa";
            this.radioButton_Activa.UseVisualStyleBackColor = true;
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Location = new System.Drawing.Point(37, 66);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(112, 13);
            this.label_Estado.TabIndex = 21;
            this.label_Estado.Text = "Estado de publicacion";
            this.label_Estado.Click += new System.EventHandler(this.label_Estado_Click);
            // 
            // radioButton_Finalizada
            // 
            this.radioButton_Finalizada.AutoSize = true;
            this.radioButton_Finalizada.Location = new System.Drawing.Point(359, 64);
            this.radioButton_Finalizada.Name = "radioButton_Finalizada";
            this.radioButton_Finalizada.Size = new System.Drawing.Size(72, 17);
            this.radioButton_Finalizada.TabIndex = 25;
            this.radioButton_Finalizada.TabStop = true;
            this.radioButton_Finalizada.Text = "Finalizada";
            this.radioButton_Finalizada.UseVisualStyleBackColor = true;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(302, 104);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 26;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(221, 104);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 27;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(383, 104);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 28;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // ModificarActiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 139);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.radioButton_Finalizada);
            this.Controls.Add(this.radioButton_Pausada);
            this.Controls.Add(this.radioButton_Borrador);
            this.Controls.Add(this.radioButton_Activa);
            this.Controls.Add(this.label_Estado);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.label_Cantidad);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.label_Descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarActiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Publicacion Activa";
            this.Load += new System.EventHandler(this.ModificarActiva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.Label label_Cantidad;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.RadioButton radioButton_Pausada;
        private System.Windows.Forms.RadioButton radioButton_Borrador;
        private System.Windows.Forms.RadioButton radioButton_Activa;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.RadioButton radioButton_Finalizada;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button Cancelar;
    }
}