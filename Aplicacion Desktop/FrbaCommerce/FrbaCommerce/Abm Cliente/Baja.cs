using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            const string mensaje = "¿Está seguro que desea eliminar al Cliente del sistema?";
            const string resumen = "Eliminando Cliente";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                const string mensaje2 = "El cliente ha sido eliminado con éxito";
                const string resumen2 = "";

                MessageBox.Show(mensaje2, resumen2,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }

           
        }

        private void textBox_Anio_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos que se muestran en pantalla seran eliminados del sistema";
        }

        private void textBox_Anio_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

       

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Abm_Cliente.ListadoSeleccionBaja listado_baja = new Abm_Cliente.ListadoSeleccionBaja();
            listado_baja.Show();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            //falta hacer la consulta sql para traer los datos que van en cada control
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            textBox_CodigoPostal.Text = "";
            textBox_Direccion.Text = "";
            textBox_Documento.Text = "";
            textBox_Mail.Text = "";
            textBox_Telefono.Text = "";
            //marcar el tipo de documento que corresponda
            radioButton_Ci.Select();
            //seleccionar la fecha que corresponda
            DateTime fecha = DateTime.Now;
            dateTimePicker_FechaNacimiento.Value = fecha;

            textBox_Nombre.Enabled = false;
            textBox_Nombre.Enabled = false;
            textBox_Apellido.Enabled = false;
            textBox_CodigoPostal.Enabled = false;
            textBox_Direccion.Enabled = false;
            textBox_Documento.Enabled = false;
            textBox_Mail.Enabled = false;
            textBox_Telefono.Enabled = false;
            radioButton_Ci.Enabled = false;
            radioButton_Dni.Enabled = false;
            radioButton_Lc.Enabled = false;
            radioButton_Le.Enabled = false;
            radioButton_Pas.Enabled = false;
            dateTimePicker_FechaNacimiento.Enabled = false;

        }

        private void paner_Alta_Enter(object sender, EventArgs e)
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
