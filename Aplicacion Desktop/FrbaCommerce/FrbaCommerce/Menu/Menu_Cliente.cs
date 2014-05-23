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

        private void Menu_Cliente_Load(object sender, EventArgs e)
        {
            //primera vez que ingresa al sistema
            if (false)
            {
                button_ModificacionUsuario.Hide();
                button_Comprar.Enabled = false;
                button_FacturarPublicacion.Enabled = false;
                button_HistorialCliente.Enabled = false;
                button_Ofertar.Enabled = false;
                button_Preguntar.Enabled = false;
            }
            else
            {
                button_RegistroUsuario.Hide();
                button_ModificacionUsuario.Show();
            }
        }

        private void button_RegistroUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_de_Usuario.Alta altaUsuario = new Registro_de_Usuario.Alta();
            altaUsuario.cliente = true;
            altaUsuario.Show();
           
        }

        private void button_ModificacionUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_de_Usuario.Modificacion modUsuario = new Registro_de_Usuario.Modificacion();
            modUsuario.cliente = true;
            modUsuario.Show();
        }
    }
}
