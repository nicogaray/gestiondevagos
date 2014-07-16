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
    public partial class Hacer_Preguntas : Form
    {
        public bool comprobarDatosCompletos(String pregunta)
        {
            if (pregunta == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Hacer_Preguntas()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";
        }

        private void label_Pregunta_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Pregunta.Text = "";

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pPregunta = textBox_Pregunta.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pPregunta);
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

        private void button_Volver_Click(object sender, EventArgs e)
        {
            //esta funcionalidad deberia volver a la pantalla "Comprar" O "Ofertar" de la que salio
            this.Close();

        }

        private void textBox_Pregunta_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void label_Pregunta_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void Hacer_Preguntas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_Pregunta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
