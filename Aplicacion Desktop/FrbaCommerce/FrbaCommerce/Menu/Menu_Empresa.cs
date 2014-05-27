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
    public partial class Menu_Empresa : Form
    {
        public Menu_Empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Usuario menu_usuario = new Menu.Menu_Usuario();
            menu_usuario.Show();
        }

        private void Menu_Empresa_Load(object sender, EventArgs e)
        {
            //primera vez que ingresa al sistema
            if (false)
            {
                button_ModificacionUsuario.Hide();
                button_HistorialEmpresa.Enabled = false;
                button_Publicar.Enabled = false;
                button_ResponderPregunta.Enabled = false;
                button_RegistroUsuario.Show();
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
            altaUsuario.cliente = false;
            altaUsuario.Show();
        }

        private void button_ModificacionUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_de_Usuario.Modificacion modUsuario = new Registro_de_Usuario.Modificacion();
            modUsuario.Show();
        }

        private void button_HistorialEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial_Cliente.Historial historial = new Historial_Cliente.Historial();
            historial.cliente = false;
            historial.Show();
        }
    }
}
