using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class FacturarPublicaciones : Form
    {
        public FacturarPublicaciones()
        {
            InitializeComponent();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Cliente cliente = new Menu.Menu_Cliente();
            cliente.Show();
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_cantidadARendir.Clear();
            textBox_CodigoSeguridad.Clear();
            textBox_NombreTitular.Clear();
            textBox_numeroTarjeta.Clear();
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Enabled = false;
            textBox2.Enabled = true;

            dataGridView1.Rows.Clear();

            radioButton_Efectivo.Checked = false;
            radioButton_Tarjeta.Checked = false;
            
            radioButton_AMEX.Checked = false;
            radioButton_MASTERCARD.Checked = false;
            radioButton_VISA.Checked = false;

            groupBox_tarjeta.Enabled = false;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FacturarPublicaciones_Load(object sender, EventArgs e)
        {
            groupBox_tarjeta.Enabled = false;

            
        }

        private void radioButton_Tarjeta_CheckedChanged(object sender, EventArgs e)
        {
           
                groupBox_tarjeta.Enabled = true;

            
        }

        private void radioButton_Efectivo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_tarjeta.Enabled = false;

            radioButton_AMEX.Checked = false;
            radioButton_MASTERCARD.Checked = false;
            radioButton_VISA.Checked = false;
            textBox_CodigoSeguridad.Clear();
            textBox_NombreTitular.Clear();
            textBox_numeroTarjeta.Clear();


        }
    }
}
