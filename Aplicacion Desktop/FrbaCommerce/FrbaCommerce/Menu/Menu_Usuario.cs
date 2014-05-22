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
        }

        private void Menu_Usuario_Load(object sender, EventArgs e)
        {
            // falta consultar a la base si el usuario es administrador
            if (true)
            {
                button_Administrador.Visible = true;
            }

            // falta consultar a la base si el usuario es cliente
            if (true)
            {
                button_Cliente.Visible = true;
            }

            // falta consultar a la base si el usuario es empresa
            if (true)
            {
                button_Empresa.Visible = true;
            }
            
        }

        private void button_Administrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Administrador menu_administrador = new Menu.Menu_Administrador();
            menu_administrador.Show();
        }

        private void button_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (true) //no estan cargados los datos de usuario
            {
                Registro_de_Usuario.Alta registro_alta = new Registro_de_Usuario.Alta();
                registro_alta.Show();
            }
            else
            {
                Menu.Menu_Cliente menu_administrador = new Menu.Menu_Cliente();
                menu_administrador.Show();
            }
        }

        private void button_Empresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Empresa menu_administrador = new Menu.Menu_Empresa();
            menu_administrador.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Login login = new Login.Login();
            login.Show();
        }
    }
}
