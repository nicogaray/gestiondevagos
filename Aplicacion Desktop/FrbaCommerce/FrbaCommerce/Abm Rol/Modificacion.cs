using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Seleccione el Rol que desea modificar";

        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Buscar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Haga Click aquí para buscar todos los roles del sistema";

        }

        private void button_Buscar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }
    }
}
