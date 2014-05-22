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
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Usuario menu_usuario = new Menu.Menu_Usuario();
            menu_usuario.Show();
        }

        private void button_ABMCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Cliente.Form_Base form_base = new Abm_Cliente.Form_Base();
            form_base.Show();
        }

        private void button_ABMRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABM_Rol.Form_Base form_base = new ABM_Rol.Form_Base();
            form_base.Show();

        }

        private void button_ABMEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Empresa.Form_Base form_base = new Abm_Empresa.Form_Base();
            form_base.Show();

        }

        private void button_ABMRubro_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Abm_Rubro.Form_Base form_base = new Abm_Rubro.Form_Base();
            //form_base.Show();

        }

        private void button_ABMVisibilidad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Visibilidad.Form_Base form_base = new Abm_Visibilidad.Form_Base();
            form_base.Show();

        }

      
    }
}
