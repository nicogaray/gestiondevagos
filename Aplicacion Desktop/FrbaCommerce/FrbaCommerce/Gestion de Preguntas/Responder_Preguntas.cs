using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Responder_Preguntas : Form
    {
        public bool comprobarDatosCompletos(String respuesta)
        {
            if (respuesta == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Responder_Preguntas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Responder_Preguntas_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string fechaString = fecha.ToShortDateString();
            textBox_Fecha.Text = fechaString;
            textBox_Fecha.Enabled = false;
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Respuesta.Text = "";

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Empresa menu = new Menu.Menu_Empresa();
            menu.Show();
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pRespuesta = textBox_Respuesta.Text;
            String pFecha = textBox_Fecha.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pRespuesta);
            const string resumen = "";

            if (comprobarDatosCompletos)
            {
                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "Hay campos vacios, debe ingresar todos los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
