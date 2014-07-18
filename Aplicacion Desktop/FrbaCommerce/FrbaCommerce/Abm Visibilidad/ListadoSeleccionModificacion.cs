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
    public partial class ListadoSeleccionModificacion : Form
    {

        public ListadoSeleccionModificacion()
        {
            InitializeComponent();
        }

             

        private void button_Limpiar_Click_1(object sender, EventArgs e)
        {
            textBox_Nombre.Clear();
        }

        private void ListadoSeleccionModificacion_Load(object sender, EventArgs e)
        {

        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {

            String pNombre = null;
            pNombre = textBox_Nombre.Text;

            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand cmd = null;

                cmd = new SqlCommand(string.Format("SELECT VIS_CODIGO,VIS_NOMBRE,VIS_DESCRIPCION,VIS_PRECIO,VIS_PORCENTAJE From LOS_JUS.buscarVisibilidad('{0}',null,null)",
                                                               pNombre), Conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                }
                else
                {
                    MessageBox.Show("No existen datos que coincidan con los filtros de busqueda seleccionados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                while (reader.Read())
                {
                    String pColumna2;
                    Decimal pColumna3;
                    Decimal pColumna4;

                    Decimal pColumna0 = reader.GetDecimal(0); //VIS_CODIGO
                    String pColumna1;

                    if (reader.IsDBNull(1) == false)
                    {
                        pColumna1 = reader.GetString(1);//VIS_NOMBRE
                    }
                    else
                    {
                        pColumna1 = string.Empty;
                    }

                    if (reader.IsDBNull(2) == false)
                    {
                        pColumna2 = reader.GetString(2);//VIS_NOMBRE
                    }
                    else
                    {
                        pColumna2 = string.Empty;
                    }

                    if (reader.IsDBNull(3) == false)
                    {
                        pColumna3 = reader.GetDecimal(3);//VIS_PRECIO
                    }
                    else
                    {
                        pColumna3 = 0;
                    }

                    if (reader.IsDBNull(4) == false)
                    {

                        pColumna4 = reader.GetDecimal(4);//VIS_PORCENTAJE
                    }
                    else
                    {
                        pColumna4 = 0;
                    }

                    dataGridView1.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna4, pColumna3);

                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (dataGridView1.RowCount != 0)
                {
                    int i = e.RowIndex;

                    string precio = dataGridView1[4, i].Value.ToString();

                    string[] parts1 = precio.Split(','); 
                    string precioEntero = int.Parse(parts1[0]).ToString();
                    string precioDecimal = int.Parse(parts1[1]).ToString();

                    string porcentaje = dataGridView1[3, i].Value.ToString();
                    string[] parts2 = porcentaje.Split(',');
                    string porcentajeEntero = parts2[0];
                    string porcentajeDecimal = parts2[1];
                    
                    Abm_Visibilidad.Modificacion modificacion = new Abm_Visibilidad.Modificacion();
                    modificacion.nombreSeleccionado = dataGridView1[1, i].Value.ToString();
                    modificacion.codigoVisualizacionSeleccionada = dataGridView1[0, i].Value.ToString();
                    modificacion.precioSeleccionado = precioEntero;
                    modificacion.porcentajeSeleccionado = porcentajeEntero;
                    modificacion.decimalPrecioSeleccionado = precioDecimal;
                    modificacion.decimalPorcentajeSeleccionado = porcentajeDecimal;
                    modificacion.Show();

                    dataGridView1.Rows.Clear();

                }
            }
        }
    }
}
