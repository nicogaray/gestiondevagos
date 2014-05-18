using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
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
            ABM_Rol.Alta alta = new ABM_Rol.Alta();
            alta.TopLevel = false;
            alta.FormBorderStyle = FormBorderStyle.None;
            alta.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(alta);
            this.panel_Contenedor.Tag = alta;
            alta.Show();
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);

            ABM_Rol.Baja baja = new ABM_Rol.Baja();
            baja.TopLevel = false;
            baja.FormBorderStyle = FormBorderStyle.None;
            baja.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(baja);
            this.panel_Contenedor.Tag = baja;
            baja.Show();
        }

        private void button_Modificacion_Click(object sender, EventArgs e)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            ABM_Rol.Modificacion modificacion = new ABM_Rol.Modificacion();
            modificacion.TopLevel = false;
            modificacion.FormBorderStyle = FormBorderStyle.None;
            modificacion.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(modificacion);
            this.panel_Contenedor.Tag = modificacion;
            modificacion.Show();
        }
    }
}
