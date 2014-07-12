using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class ListaOperacionesSeleccion : Form
    {


        public ListaOperacionesSeleccion()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {

                //IMPORTANTE: FALTA OBTENER EL ID DEL CLIENTE DE LA SESION, USO EJEMPLO DE PRUEBA: 1
                SqlCommand cmd = null;
                cmd = new SqlCommand(string.Format("SELECT emp_razon_social,emp_cuit,emp_contacto,emp_mail,ope_codigo,ope_tipo,ope_fecha From LOS_JUS.buscarVendedores('{0}')",
                                                                  1), Conexion);


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String pColumna0 = reader.GetString(0);//EMP_RAZON_SOCIAL
                    String pColumna1 = reader.GetString(1);//EMP_CUIT
                    String pColumna2 = reader.GetString(2);//EMP_CONTACTO
                    String pColumna3 = reader.GetString(3);//EMP_MAIL
                    Int32 pColumna4 = reader.GetInt32(4);//OPE_CODIGO
                    String pColumna5 = reader.GetString(5);//OPE_TIPO
                    DateTime pColumna6 = reader.GetDateTime(6);//OPE_FECHA



                    dataGridView1.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5, pColumna6);

                }
            }


        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Cliente menu = new Menu.Menu_Cliente();
            menu.Show();
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {


        }

        private void Calificar_Vendedor_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (dataGridView1.RowCount != 0)
                {
                    int i = e.RowIndex;
                    using (var form = new Calificar_Vendedor.Calificacion())
                    {
                        //veo si en la ventana calificacion se guardo el valor y luego elimino esta fila de la tabla
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            bool val = form.ReturnId;
                            if (val)
                            {
                            dataGridView1.Rows.RemoveAt(i);
                            }
                            else
                            {
                            }
                        }
                    }

                  
                }

            }
        }
    }
}
