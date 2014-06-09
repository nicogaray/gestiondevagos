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
    public partial class Ofertar : Form
    {
        public Ofertar()
        {
            InitializeComponent();
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

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Cliente menu_cliente = new Menu.Menu_Cliente();
            menu_cliente.Show();
            this.Close();
        }
    }
}
