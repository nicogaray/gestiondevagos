﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class ListadoSeleccionBaja : Form
    {
        public ListadoSeleccionBaja()
        {
            InitializeComponent();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_PorcentajeVenta.Clear();
            textBox_PrecioPublicitar.Clear();
            textBox_RazonSocial.Clear();

        }
    }
}