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
    public partial class Alta : Form
    {
        public bool comprobarTipos(String precioPublicitar, String porcentajeVenta)
        {
            return ( precioPublicitar.All(char.IsDigit) &&  porcentajeVenta.All(char.IsDigit));
                   
        }

        public bool comprobarDatosCompletos(String nombre,String precioPublicitar, String porcentajeVenta)
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

        public Alta()
        {
            InitializeComponent();
        }

        private void textBox_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pNombre = textBox_Nombre.Text;
            String pDescripcion = textBox_Descripcion.Text;
            String pPrecioPublicitar = textBox_PrecioPublicitar.Text;
            String pPorcentajeVenta = textBox_PorcentajeVenta.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarTipos = this.comprobarTipos(pPrecioPublicitar, pPorcentajeVenta);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre,pPrecioPublicitar,pPorcentajeVenta);
            const string resumen = "";

            if (comprobarTipos && comprobarDatosCompletos)
            {
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

        private void Alta_Load(object sender, EventArgs e)
        {
            
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

        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de guardar";

        }

        private void button_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

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

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Descripcion.Clear();
            textBox_Nombre.Clear();
            textBox_PorcentajeVenta.Clear();
            textBox_PrecioPublicitar.Clear();
        }
    }
}
