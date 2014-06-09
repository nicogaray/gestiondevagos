using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Form_Base : Form
    {
        public Form_Base()
        {
            InitializeComponent();
        }

        private void Form_Base_Load(object sender, EventArgs e)
        {
            this.AcceptButton = null;

        }

        private void button_Alta_Click(object sender, EventArgs e)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Abm_Cliente.Alta alta = new Abm_Cliente.Alta();
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
            Abm_Cliente.ListadoSeleccionBaja baja = new Abm_Cliente.ListadoSeleccionBaja();
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
            Abm_Cliente.ListadoSeleccionModificacion modificacion = new Abm_Cliente.ListadoSeleccionModificacion();
            modificacion.TopLevel = false;
            modificacion.FormBorderStyle = FormBorderStyle.None;
            modificacion.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(modificacion);
            this.panel_Contenedor.Tag = modificacion;
            modificacion.Show();
        }

        private void panel_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Administrador menu_administrador = new Menu.Menu_Administrador();
            menu_administrador.Show();
        }

        private void panel_Contenedor_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void Form_Base_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    const string mensaje = "¿Está seguro que desea cerrar el sistema?";
        //    const string resumen = "Cerrando el sistema";

        //    var resultado = MessageBox.Show(mensaje, resumen,
        //                         MessageBoxButtons.YesNo,
        //                         MessageBoxIcon.Question);


        //    if (resultado == DialogResult.Yes)
        //    {
        //        e.Cancel = false;
        //    }
        }
    }

