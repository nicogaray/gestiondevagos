using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Historial : Form
    {
        public bool cliente = false;

        public Historial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cliente)
            {
                comboBox_operaciones.Items.Add("Compras");
                comboBox_operaciones.Items.Add("Ofertas");
                comboBox_operaciones.Items.Add("Calificaciones otorgadas");
            }
            else
            {
                comboBox_operaciones.Items.Add("Ventas");
                comboBox_operaciones.Items.Add("Ofertas recibidas");
                comboBox_operaciones.Items.Add("Calificaciones recibidas");
            }
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            if (cliente)
            {
                Menu.Menu_Cliente menu = new Menu.Menu_Cliente();
                menu.Show();
                this.Close();
            }
            else
            {
                Menu.Menu_Empresa menu = new Menu.Menu_Empresa();
                menu.Show();
                this.Close();
            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            comboBox_operaciones.Text = "";
        }

        private void comboBox_operaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_HacerConsulta_Click(object sender, EventArgs e)
        {

        }

        private void button_HacerConsulta_Click_1(object sender, EventArgs e)
        {
            if (cliente)
            {
                
            }
            else
            {
            }
        }
    }
}
