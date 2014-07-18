using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class ListadoSeleccionBaja : Form
    {
        public ListadoSeleccionBaja()
        {
            InitializeComponent();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_RazonSocial.Clear();

        }

        private void textBox_PrecioPublicitar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
