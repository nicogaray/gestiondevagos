using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            comboBox_TipoListado.Text = "";
            comboBox_Visibilidad.Text = "";
            numericUpDown_Mes.Value = 1;
            numericUpDown_Anio.Value = 2014;
            comboBox_TipoListado.Text = "";
            comboBox_Trimestre.Text = "";
            if (comboBox_TipoListado.SelectedIndex == 0)
            {
                label_Mes.Hide();
                numericUpDown_Mes.Hide();
                label_TipoVisibilidad.Hide();
                comboBox_Visibilidad.Hide();
                label_Trimestre.Show();
                comboBox_Trimestre.Show();
            }
          
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Menu_Administrador admin = new Menu.Menu_Administrador();
            admin.Show();
        }

        private void comboBox_TipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TipoListado.SelectedIndex == 0)
            {
                label_Trimestre.Hide();
                comboBox_Trimestre.Hide();
                label_TipoVisibilidad.Show();
                label_Mes.Show();
                numericUpDown_Mes.Show();
                comboBox_Visibilidad.Show();
                
            }
            else
            {
                label_Mes.Hide();
                numericUpDown_Mes.Hide();
                label_TipoVisibilidad.Hide();
                comboBox_Visibilidad.Hide();
                label_Trimestre.Show();
                comboBox_Trimestre.Show();
            }
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            label_Mes.Hide();
            numericUpDown_Mes.Hide();
            label_TipoVisibilidad.Hide();
            comboBox_Visibilidad.Hide();
        }

        private void comboBox_TipoListado_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_Visibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
