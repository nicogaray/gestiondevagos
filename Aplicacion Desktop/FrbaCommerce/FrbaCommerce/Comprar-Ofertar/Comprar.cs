using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
      public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }
        public Paginar p;

        private void actualizar()
        {
            maskedTextBox1.Text = p.countRow().ToString() ;
            maskedTextBox2.Text = p.numPag().ToString();
            maskedTextBox3.Text = p.countPag().ToString();
            maskedTextBox4.Text = p.limitRow().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.actualizaTope(Convert.ToInt32(maskedTextBox4.Text));
            actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.adelante();
            actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.atras();
            actualizar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.primeraPagina();
            actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.ultimaPagina();
            actualizar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            p.actualizaTope(Convert.ToInt32(maskedTextBox4.Text));
            actualizar();
        }


        private void button_Buscar_Click(object sender, EventArgs e)
        {
            int maximo_x_pagina = 40;//cargar por default
            p = new Comprar_Ofertar.Paginar("SELECT * FROM LOS_JUS.publicacionesComprasActivas(null) ORDER BY VIS_CODIGO ASC", "DataMember1", maximo_x_pagina);
            dataGridView1.DataSource = p.cargar();
            dataGridView1.DataMember = "datamember1";

            actualizar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            p.adelante();
            actualizar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            p.atras();
            actualizar();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            p.primeraPagina();
            actualizar();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            p.ultimaPagina();
            actualizar();
        }

    }
}


