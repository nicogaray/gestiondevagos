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
    public partial class Menu_Usuario : Form
    {
        public Menu_Usuario()
        {
            InitializeComponent();
            //inicializo los botones
            this.button_Administrador.Visible = false;
            this.button_Cliente.Visible = false;
            this.button_Empresa.Visible = false;
        }

        private void Menu_Usuario_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Administrador_Click(object sender, EventArgs e)
        {
            // falta consultar a la base si el usuario es administrador
            if (true)
            {
                this.button_Administrador.Visible = true;
            }
        }

        private void button_Cliente_Click(object sender, EventArgs e)
        {
            // falta consultar a la base si el usuario es cliente
            if (true)
            {
                this.button_Cliente.Visible = false;
            }
 
        }

        private void button_Empresa_Click(object sender, EventArgs e)
        {
            // falta consultar a la base si el usuario es empresa
            if (true)
            {
                this.button_Empresa.Visible = true;
            }

        }
    }
}
