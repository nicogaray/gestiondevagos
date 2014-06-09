using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }

        private void label_DescripcionPublicacion_Click(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            int i;
            int s = checkedListBox_Rubro.Items.Count;
            for (i = 0; i < s; i++)
            {
                checkedListBox_Rubro.SetItemChecked(i, false);
            }
            checkedListBox_Rubro.ClearSelected();

            textBox_Descripcion.Clear();
        }

        private void checkedListBox_Rubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_PagAnt_Click(object sender, EventArgs e)
        {

        }

        private void button_PagSig_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Cliente menu_cliente = new Menu.Menu_Cliente();
            menu_cliente.Show();
            this.Close();
        }
    }
}
