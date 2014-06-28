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
    public partial class Alta : Form
    {
        public bool comprobarDatosCompletos(String nombre)
        {
            if (nombre == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Alta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Especifique el rol";

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Nombre.Clear();
            textBox_Descripcion.Clear();
            textBox_Funcionalidad.Clear();
           dataGridView_ListaFuncionalidades.Rows.Clear();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            
            //int l = dataGridView_ListaFuncionalidades.RowCount;
            //for (int i = 1; i < l; i++)
            //{
            //    String pFuncionalidad = dataGridView_ListaFuncionalidades[1, i].Value.ToString();
            //    MessageBox.Show(pFuncionalidad, "", MessageBoxButtons.OK);
            //}

            String pNombre = textBox_Nombre.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre);
            const string resumen = "";

            if (comprobarDatosCompletos)
            {
                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "Hay campos vacios, debe ingresar todos los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de guardar";

        }

        private void button_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void textBox_Nombre_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

      
        
        private void dataGridView_ListaFuncionalidades_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese que el término del campo Funcionalidad sea simple y concreto";

        }

        private void dataGridView_ListaFuncionalidades_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            String pFuncionalidad = textBox_Funcionalidad.Text;
            String pDescripcion = textBox_Descripcion.Text;

            if (pFuncionalidad == "" || pDescripcion == "")
            {
                MessageBox.Show("Hay campos vacios. Los datos no se pueden agregar.\nComplete todos los campos e intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dataGridView_ListaFuncionalidades.Rows.Add(pFuncionalidad, pDescripcion);
                textBox_Descripcion.Clear();
                textBox_Funcionalidad.Clear();
            }
            

        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (dataGridView_ListaFuncionalidades.RowCount != 0)
                {
                    int i = e.RowIndex;
                    dataGridView_ListaFuncionalidades.Rows.RemoveAt(i);
                }

            }
        }
    }
}
