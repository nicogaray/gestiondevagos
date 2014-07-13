using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class Form_Base : Form
    {
        public Form_Base()
        {
            InitializeComponent();
        }

        private void button_Alta_Click(object sender, EventArgs e)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Generar_Publicacion.Compra_Inmediata compra = new Generar_Publicacion.Compra_Inmediata();
            compra.TopLevel = false;
            compra.FormBorderStyle = FormBorderStyle.None;
            compra.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(compra);
            this.panel_Contenedor.Tag = compra;
            compra.Show();
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Generar_Publicacion.Subasta subasta = new Generar_Publicacion.Subasta();
            subasta.TopLevel = false;
            subasta.FormBorderStyle = FormBorderStyle.None;
            subasta.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(subasta);
            this.panel_Contenedor.Tag = subasta;
            subasta.Show();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Empresa empresa = new Menu.Menu_Empresa();
            empresa.Show();
            this.Close();

        }
    }
}
