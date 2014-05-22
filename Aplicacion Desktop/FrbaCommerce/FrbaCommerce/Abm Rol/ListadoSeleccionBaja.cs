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
    public partial class ListadoSeleccionBaja : Form
    {
        public ListadoSeleccionBaja()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se muestra en pantalla todos los roles disponibles en el sistema con sus funcionalidades";

        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void ListadoSeleccionBaja_Load(object sender, EventArgs e)
        {

        }
    }
}
