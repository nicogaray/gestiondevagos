using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Menu
{
    public partial class Menu_Cliente : Form
    {
        public Menu_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Usuario menu_usuario = new Menu.Menu_Usuario();
            menu_usuario.Show();
        }
    }
}
