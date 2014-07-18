using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class Baja : Form
    {
        public String nombreSeleccionado = "";
        public String descripcionSeleccionada = "";
        public String precioSeleccionado = "";
        public String porcentajeSeleccionado = "";
        public String decimalPrecioSeleccionado = "";
        public String decimalPorcentajeSeleccionado = "";
        public String codigoVisualizacionSeleccionada = "";



        public Baja()
        {
            InitializeComponent();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            const string mensaje = "¿Está seguro que desea eliminar la Visibilidad del sistema?";
            const string resumen = "Eliminando Visibilidad";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    string sql = string.Format("UPDATE LOS_JUS.Visualizacion SET vis_eliminado= 1");


                    SqlCommand InsertarRol = new SqlCommand(sql, Conexion);
                    //SqlCommand InsertarRol = new SqlCommand(string.Format("UPDATE LOS_JUS.Visualizacion SET vis_nombre= '{0}',vis_precio= '{1}',vis_porcentaje= '{2}',vis_descripcion= '{3}' WHERE VIS_CODIGO = '{4}'"
                    //                                                                    , pNombre, pPrecioConvertido, pPorcentajeConvertido, pDescripcion, pCodigo), Conexion);


                    int retorno = InsertarRol.ExecuteNonQuery();

                }


                const string mensaje2 = "La Visibilidad ha sido eliminada con éxito";
                const string resumen2 = "";

                MessageBox.Show(mensaje2, resumen2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            textBox_Nombre.Text = nombreSeleccionado;
            textBox_Descripcion.Text = descripcionSeleccionada;
            textBox_Porcentaje.Text = porcentajeSeleccionado;
            textBox1_precio.Text = precioSeleccionado;
            textBox_decimalPrecio.Text = decimalPrecioSeleccionado;
            textBox_decimalPorcentaje.Text = decimalPorcentajeSeleccionado;

            textBox_decimalPorcentaje.Enabled = false;
            textBox_decimalPrecio.Enabled = false;
            textBox_Porcentaje.Enabled = false;
            textBox1_precio.Enabled = false;
            textBox_Descripcion.Enabled = false;
            textBox_Nombre.Enabled = false;
        }

        private void textBox_PrecioPublicitar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos que se muestran en pantalla serán eliminados del sistema";

        }

        private void textBox_PrecioPublicitar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Borrar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Eliminar permanentemente los datos del sistema";

        }

        private void button_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Volver al formulario anterior";

        }

        private void button_Borrar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }
    }
}
