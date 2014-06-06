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
            //falta ver como avisar los campos afectados en caso de error
            const string mensaje_Aceptacion = "La respuesta ha sido guardada con éxito";
            const string mensaje_Rechazo = "La respuesta no pudo ser guardada";
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
    }
}
