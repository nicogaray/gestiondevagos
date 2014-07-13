using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class Form_Base : Form
    {
        public Form_Base()
        {
            InitializeComponent();
        }

        private void button_PublicacionActiva_Click(object sender, EventArgs e)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Editar_Publicacion.Activa activa = new Editar_Publicacion.Activa();
            activa.TopLevel = false;
            activa.FormBorderStyle = FormBorderStyle.None;
            activa.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(activa);
            this.panel_Contenedor.Tag = activa;
            activa.Show();
        }

        private void button_PublicacionBorrador_Click(object sender, EventArgs e)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Editar_Publicacion.Borrador borrador = new Editar_Publicacion.Borrador();
            borrador.TopLevel = false;
            borrador.FormBorderStyle = FormBorderStyle.None;
            borrador.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(borrador);
            this.panel_Contenedor.Tag = borrador;
            borrador.Show();

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Empresa empresa = new Menu.Menu_Empresa();
            empresa.Show();
            this.Close();
        }
    }
}
