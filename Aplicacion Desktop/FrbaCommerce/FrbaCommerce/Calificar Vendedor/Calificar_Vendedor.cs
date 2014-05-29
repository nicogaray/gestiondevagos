using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class Calificar_Vendedor : Form
    {
        public Calificar_Vendedor()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Descripcion.SelectedIndex == 0)
            {
                label_EscribaAqui.Show();
                textBox_EscribaAqui.Show();
            }
            else
            {
                label_EscribaAqui.Hide();
                textBox_EscribaAqui.Hide();
            }

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            comboBox_Descripcion.Text = "";
            textBox_EscribaAqui.Text = "";
            label_EscribaAqui.Hide();
            textBox_EscribaAqui.Hide();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Cliente menu = new Menu.Menu_Cliente();
            menu.Show();
            this.Close();
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

        private void Calificar_Vendedor_Load(object sender, EventArgs e)
        {
            label_EscribaAqui.Hide();
            textBox_EscribaAqui.Hide();
        }
    }
}
