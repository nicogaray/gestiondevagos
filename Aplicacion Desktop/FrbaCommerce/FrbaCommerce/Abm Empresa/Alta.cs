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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void label_Documento_Click(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_CodigoPostal.Clear();
            textBox_Cuit.Clear();
            textBox_Direccion.Clear();
            textBox_Mail.Clear();
            textBox_RazonSocial.Clear();
            textBox_NombreContacto.Clear();
            textBox_Telefono.Clear();
            DateTime fecha = DateTime.Now;
            dateTimePicker_FechaNacimiento.Value = fecha;
        }

        private void textBox_RazonSocial_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";
        }

        private void textBox_NombreContacto_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void textBox_Telefono_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void textBox_Direccion_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Calle Altura Ciudad Provincia";

        }

        private void textBox_RazonSocial_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_NombreContacto_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Telefono_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Direccion_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Dia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Dia_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Mes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Mes_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Anio_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            //falta ver como avisar los campos afectados en caso de error
            const string mensaje_Aceptacion = "Los datos han sido guardados con éxito";
            const string mensaje_Rechazo = "Los datos no pudieron ser guardados";
            const string resumen = "";

            if (true)
            {
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de gurdar";

        }

        private void button_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_RazonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }


    

       

    }
}
