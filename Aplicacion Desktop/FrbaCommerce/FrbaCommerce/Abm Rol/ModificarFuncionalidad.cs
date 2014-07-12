using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rol
{
    public partial class ModificarFuncionalidad : Form
    {
        public bool ReturnId { get; set; }
        public String ReturnFunc { get; set; }
        public String ReturnDesc { get; set; }


        public ModificarFuncionalidad()
        {
            InitializeComponent();
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            String pFuncionalidad = textBox_Funcionalidad.Text;
            String pDescripcion = textBox_Descripcion.Text;

            if (pFuncionalidad == "" || pDescripcion == "")
            {
                MessageBox.Show("Hay campos vacios. Los datos no se pueden agregar.\nComplete todos los campos e intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.ReturnId = false;
                this.ReturnFunc = textBox_Funcionalidad.Text;
                this.ReturnDesc = textBox_Descripcion.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            

        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            this.ReturnId = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
