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
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            const string mensaje = "¿Está seguro que desea eliminar la Visibilidad del sistema?";
            const string resumen = "Eliminando Visibilidad";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                const string mensaje2 = "La Visibilidad ha sido eliminada con éxito";
                const string resumen2 = "";

                MessageBox.Show(mensaje2, resumen2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Abm_Visibilidad.ListadoSeleccionBaja listado_baja = new Abm_Visibilidad.ListadoSeleccionBaja();
            listado_baja.Show();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            textBox_Descripcion.Enabled = false;
            textBox_Nombre.Enabled = false;
            textBox_PorcentajeVenta.Enabled = false;
            textBox_PrecioPublicitar.Enabled = false;
        }

        private void textBox_PrecioPublicitar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos que se muestran en pantalla serán eliminados del sistema";

        }

        private void textBox_PrecioPublicitar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Borrar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Eliminar permanentemente los datos del sistema";

        }

        private void button_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Volver al formulario anterior";

        }

        private void button_Borrar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }
    }
}
