using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Ver_Respestas : Form
    {
        public Ver_Respestas()
        {
            InitializeComponent();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void Ver_Respestas_Load(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {

                //IMPORTANTE: FALTA OBTENER EL ID DEL CLIENTE DE LA SESION, USO EJEMPLO DE PRUEBA: 52165955
                SqlCommand cmd = null;
                cmd = new SqlCommand(string.Format("SELECT pre_fecha_RESPUESTA,pre_pregunta,pre_respuesta From LOS_JUS.verRespuestas('{0}')",
                                                                  52165955), Conexion);





                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                }
                else
                {
                    MessageBox.Show("Actualmente no hay ninguna pregunta respondida para mostrar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }

                while (reader.Read())
                {
                    DateTime pColumna0 = reader.GetDateTime(0);//PRE_FECHA
                    String pColumna1 = reader.GetString(1);//PRE_PREGUNTA
                    String pColumna2 = reader.GetString(2);//PRE_RESPUESTA




                    dataGridView1.Rows.Add(pColumna0, pColumna1, pColumna2);

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
