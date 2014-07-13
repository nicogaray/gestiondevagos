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
    public partial class Modificacion : Form
    {
        public bool comprobarTipos(String precioPublicitar, String porcentajeVenta, String decimalPrecio, String decimalPorcentaje)
        {
            return (precioPublicitar.All(char.IsDigit) && porcentajeVenta.All(char.IsDigit) && decimalPrecio.All(char.IsDigit) && decimalPorcentaje.All(char.IsDigit));

        }

         public bool comprobarDatosCompletos(String nombre, String precioPublicitar, String porcentajeVenta)
         {
             if (nombre == "" ||
                 precioPublicitar == "" ||
                 porcentajeVenta == "")
             {
                 return false;
             }

             else
             {
                 return true;
             }
         }


        public Modificacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pDecimalPorcentaje = textBox_decimalPorcentaje.Text;
            String pDecimalPrecio = textBox_decimalPrecio.Text;
            String pPorcentaje = "0";
            pPorcentaje = textBox_Porcentaje.Text;
            String pPrecio = "0";
            pPrecio = textBox1_precio.Text;

            String pPorcentajeFinal = pPorcentaje + ',' + pDecimalPorcentaje;
            String pPrecioFinal = pPrecio + ',' + pDecimalPrecio;


            String pNombre = textBox_Nombre.Text;
            String pDescripcion = textBox_Descripcion.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarTipos = this.comprobarTipos(pPrecio, pPorcentaje, pDecimalPrecio, pDecimalPorcentaje);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre, pPrecio, pPorcentaje);
            const string resumen = "";


            if (comprobarTipos && comprobarDatosCompletos)
            {

                Decimal pPrecioConvertido = Convert.ToDecimal(pPrecioFinal);
                Decimal pPorcentajeConvertido = Convert.ToDecimal(pPorcentajeFinal);

                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "Hay campos obligatorios vacios, debe ingresar los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    const string mensaje_Rechazo = "Error de tipos en los datos ingresados.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Descripcion.Clear();
            textBox_Nombre.Clear();
            textBox_Porcentaje.Clear();
            textBox1_precio.Clear();
            textBox_decimalPorcentaje.Text = "00";
            textBox_decimalPrecio.Text = "00";
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Abm_Visibilidad.ListadoSeleccionModificacion listado_modificacion = new Abm_Visibilidad.ListadoSeleccionModificacion();
            listado_modificacion.Show();
        }

        private void textBox_Nombre_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Ingrese un nombre representativo, corto y concreto";

        }

        private void textBox_Descripcion_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void textBox_PrecioPublicitar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void textBox_PorcentajeVenta_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de guardar";

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void button_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Volver al formulario anterior";

        }

        private void textBox_Nombre_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Descripcion_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_PrecioPublicitar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_PorcentajeVenta_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void Modificacion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_precio_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se aceptan valores numericos";

        }

        private void textBox_Porcentaje_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se aceptan valores numericos";

        }

        private void textBox1_precio_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Porcentaje_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_decimalPrecio_Click(object sender, EventArgs e)
        {
            textBox_decimalPrecio.Text = "";

        }

        private void textBox_decimalPrecio_Leave(object sender, EventArgs e)
        {
            if (textBox_decimalPrecio.Text == "")
            {
                textBox_decimalPrecio.Text = "00";
            }
        }

        private void textBox_decimalPorcentaje_Leave(object sender, EventArgs e)
        {

            if (textBox_decimalPorcentaje.Text == "")
            {
                textBox_decimalPorcentaje.Text = "00";
            }
        }
    }
}
