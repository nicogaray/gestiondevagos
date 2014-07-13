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
        public bool comprobarTipos(String precioPublicitar, String porcentajeVenta, String decimalPrecio, String decimalPorcentaje)
        {
            return (precioPublicitar.All(char.IsDigit) && porcentajeVenta.All(char.IsDigit) && decimalPrecio.All(char.IsDigit) && decimalPorcentaje.All(char.IsDigit));

        }

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
            String pDecimalPorcentaje = "00";
            pDecimalPorcentaje = textBox_decimalPorcentaje.Text;

            String pDecimalPrecio = "00";
            pDecimalPrecio = textBox_decimalPrecio.Text;

            String pPorcentaje = "0";
            if (textBox_Porcentaje.Text != "")
            {
                pPorcentaje = textBox_Porcentaje.Text;
            }

            String pPrecio = "0";
            if (textBox1_precio.Text != "")
            {
                pPrecio = textBox1_precio.Text;
            }

            String pPorcentajeFinal = pPorcentaje + ',' + pDecimalPorcentaje;
            String pPrecioFinal = pPrecio + ',' + pDecimalPrecio;

            String pNombre = null;
            pNombre = textBox_Nombre.Text;

            bool comprobarTipos = this.comprobarTipos(pPrecio, pPorcentaje, pDecimalPrecio, pDecimalPorcentaje);
            const string resumen = "";

            if (comprobarTipos)
            {
                Decimal pPrecioConvertido = 0;

                //if (pPrecio != "0")
                //{
                    pPrecioConvertido = Convert.ToDecimal(pPrecioFinal);
                //}

                Decimal pPorcentajeConvertido = 0;

                //if (pPorcentaje != "0")
                //{
                    pPorcentajeConvertido = Convert.ToDecimal(pPorcentajeFinal);

               // }


                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    SqlCommand cmd = null;
                    if (pPrecioConvertido == 0 && pPorcentajeConvertido != 0)
                    {
                        cmd = new SqlCommand(string.Format("SELECT VIS_CODIGO,VIS_NOMBRE,VIS_DESCRIPCION,VIS_PRECIO,VIS_PORCENTAJE From LOS_JUS.buscarVisibilidad('{0}',null,'{1}')",
                                                                       pNombre, pPorcentajeConvertido), Conexion);
                    }

                    if (pPrecioConvertido != 0 && pPorcentajeConvertido == 0)
                    {
                        cmd = new SqlCommand(string.Format("SELECT VIS_CODIGO,VIS_NOMBRE,VIS_DESCRIPCION,VIS_PRECIO,VIS_PORCENTAJE From LOS_JUS.buscarVisibilidad('{0}','{1}',null)",
                                                                       pNombre, pPrecioConvertido), Conexion);
                    }
                    if (pPrecioConvertido == 0 && pPorcentajeConvertido == 0)
                    {
                        cmd = new SqlCommand(string.Format("SELECT VIS_CODIGO,VIS_NOMBRE,VIS_DESCRIPCION,VIS_PRECIO,VIS_PORCENTAJE From LOS_JUS.buscarVisibilidad('{0}',null,null)",
                                                                       pNombre), Conexion);
                    }
                    else
                    {
                        cmd = new SqlCommand(string.Format("SELECT VIS_CODIGO,VIS_NOMBRE, VIS_DESCRIPCION, VIS_PRECIO,VIS_PORCENTAJE From LOS_JUS.buscarVisibilidad('{0}','{1}','{2}')",
                                                                       pNombre, pPrecioConvertido, pPorcentajeConvertido), Conexion);
                    }


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

                        Decimal pColumna0 = reader.GetDecimal(0); //VIS_CODIGO
                        String pColumna1 = reader.GetString(1);//VIS_NOMBRE
                        String pColumna2 = reader.GetString(2);//VIS_DESCRIPCION
                        Decimal pColumna3 = reader.GetDecimal(3);//VIS_PRECIO
                        Decimal pColumna4 = reader.GetDecimal(4);//VIS_PORCENTAJE

                        dataGridView1.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3,pColumna4);

                    }

                }

            }
            else
            {
                if (comprobarTipos == false)
                {
                    const string mensaje_Rechazo = "Error de tipos en los datos ingresados.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string precio = dataGridView1[3, i].Value.ToString();
                    string[] parts1 = precio.Split(','); 
                    string precioEntero = int.Parse(parts1[0]).ToString();
                    string precioDecimal = int.Parse(parts1[1]).ToString();

                    string porcentaje = dataGridView1[4, i].Value.ToString();
                    string[] parts2 = porcentaje.Split(',');
                    string porcentajeEntero = int.Parse(parts2[0]).ToString();
                    string porcentajeDecimal = int.Parse(parts2[1]).ToString();
                    
                    Abm_Visibilidad.Modificacion modificacion = new Abm_Visibilidad.Modificacion();
                    modificacion.nombreSeleccionado = dataGridView1[1, i].Value.ToString();
                    modificacion.precioSeleccionado = precioEntero;
                    modificacion.porcentajeSeleccionado = porcentajeEntero;
                    modificacion.decimalPrecioSeleccionado = precioDecimal;
                    modificacion.decimalPorcentajeSeleccionado = porcentajeDecimal;
                    modificacion.Show();

                }
            }
        }
    }
}
