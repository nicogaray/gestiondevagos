using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class Borrador : Form
    {
        public Borrador()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Borrador_Load(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {

                //IMPORTANTE: FALTA OBTENER EL ID DEL CLIENTE DE LA SESION, USO EJEMPLO DE PRUEBA: 52165955
                SqlCommand cmd = null;
                cmd = new SqlCommand(string.Format("SELECT pub_codigo,pub_empresa,pub_descripcion,pub_precio,pub_fecha_inicio,pub_fecha_fin,pub_habilitacion_preguntas,com_stock,sub_cant_lote From LOS_JUS.publicacionesActivas('{0}')",
                                                                  52165955), Conexion);




                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                }
                else
                {
                    MessageBox.Show("Actualmente no hay ninguna Publicacion Activa para modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                while (reader.Read())
                {
                    Decimal pColumna0 = reader.GetDecimal(0);//pub_codigo
                    DateTime pColumna1 = reader.GetDateTime(1);//pub_empresa
                    String pColumna2 = reader.GetString(2);//pub_descripcion
                    String pColumna3 = reader.GetString(3);//pub_precio
                    DateTime pColumna4 = reader.GetDateTime(4);//pub_fecha_inicio
                    DateTime pColumna5 = reader.GetDateTime(5);//pub_fecha_fin
                    Int32 pColumna6 = reader.GetInt32(6);//pub_habilitacion_preguntas
                    Decimal pColumna7 = reader.GetDecimal(7);//com_stock
                    Decimal pColumna8 = reader.GetDecimal(8);//sub_cant_lote                


                    dataGridView2.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5, pColumna6, pColumna7, pColumna8);

                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (dataGridView2.RowCount != 0)
                {
                    int i = e.RowIndex;
                    using (var form = new Editar_Publicacion.ModificarBorradorCompra())
                    {
                        form.pDescripcionSeleccionada = dataGridView2[2, i].Value.ToString();
                        form.pPrecioSeleccionado = dataGridView2[3, i].Value.ToString();
                        form.pFechaInicioSeleccionda = dataGridView2[4, i].Value.ToString();
                        form.pFechaFinSeleccionada = dataGridView2[5, i].Value.ToString();
                        form.pHabilitarPreguntasSeleccionado = dataGridView2[6, i].Value.ToString();
                        form.pCantidadSeleccionada = dataGridView2[7, i].Value.ToString();
                        form.pPublicacionCodigo = dataGridView2[0, i].Value.ToString();

                        //veo si en la ventana calificacion se guardo el valor y luego elimino esta fila de la tabla
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            bool val = form.ReturnId;
                            if (val)
                            {
                                dataGridView2.Rows.RemoveAt(i);
                            }
                            else
                            {
                            }
                        }
                        Editar_Publicacion.ModificarActiva activa = new Editar_Publicacion.ModificarActiva();
                        activa.Show();

                    }
                }
            }
        }
    }
}
