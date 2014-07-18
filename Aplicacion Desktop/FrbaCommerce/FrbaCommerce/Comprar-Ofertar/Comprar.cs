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
            maskedTextBox4.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;


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

        private void Comprar_Load(object sender, EventArgs e)
        {
            maskedTextBox4.Enabled = false;
            button3.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox_filtro_Enter(object sender, EventArgs e)
        {

        }

    }
}


