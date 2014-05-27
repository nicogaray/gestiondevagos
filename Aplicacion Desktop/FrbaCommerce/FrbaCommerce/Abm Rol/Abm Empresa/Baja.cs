using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            const string mensaje = "¿Está seguro que desea eliminar a la Empresa del sistema?";
            const string resumen = "Eliminando Empresa";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                const string mensaje2 = "La Empresa ha sido eliminada con éxito";
                const string resumen2 = "";

                MessageBox.Show(mensaje2, resumen2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Abm_Empresa.ListadoSeleccionBaja listado_baja = new Abm_Empresa.ListadoSeleccionBaja();
            listado_baja.Show();

        }

        private void textBox_Anio_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos que se muestran en pantalla seran eliminados del sistema";

        }

        private void textBox_Anio_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void Baja_Load(object sender, EventArgs e)
        {
            //falta hacer la consulta sql para traer los datos que van en cada control

            textBox_CodigoPostal.Text = "";
            textBox_Cuit.Text = "";
            textBox_Direccion.Text = "";
            textBox_Mail.Text = "";
            textBox_NombreContacto.Text = "";
            textBox_RazonSocial.Text = "";
            textBox_Telefono.Text = "";

            //seleccionar la fecha que corresponda
            DateTime fecha = DateTime.Now;
            dateTimePicker_FechaNacimiento.Value = fecha;

            textBox_CodigoPostal.Enabled = false;
            textBox_Cuit.Enabled = false;
            textBox_Direccion.Enabled = false;
            textBox_Mail.Enabled = false;
            textBox_NombreContacto.Enabled = false;
            textBox_RazonSocial.Enabled = false;
            textBox_Telefono.Enabled = false;
            dateTimePicker_FechaNacimiento.Enabled = false;
        }

        private void textBox_RazonSocial_TextChanged(object sender, EventArgs e)
        {

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
