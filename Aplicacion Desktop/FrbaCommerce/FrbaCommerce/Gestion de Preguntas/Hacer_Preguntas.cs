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
            //falta ver como avisar los campos afectados en caso de error
            const string mensaje_Aceptacion = "La pregunta ha sido guardada con éxito";
            const string mensaje_Rechazo = "La pregunta no pudo ser guardada";
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
    }
}
