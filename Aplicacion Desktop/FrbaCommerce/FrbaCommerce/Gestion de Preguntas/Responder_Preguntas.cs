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
    public partial class Responder_Preguntas : Form
    {


        public Responder_Preguntas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Responder_Preguntas_Load(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Empresa menu = new Menu.Menu_Empresa();
            menu.Show();
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {

                //IMPORTANTE: FALTA OBTENER EL ID DE LA EMPRESA DE LA SESION, USO EJEMPLO DE PRUEBA: 1
                SqlCommand cmd = null;
                cmd = new SqlCommand(string.Format("SELECT PRE_CODIGO,PRE_PREGUNTA From LOS_JUS.buscarPreguntasSinResponder('{0}')",
                                                                  29), Conexion);


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Int32 pColumna0 = reader.GetInt32(0);//PRE_CODIGO
                    Int32 pColumna1 = reader.GetInt32(1);//PRE_PREGUNTA


                    dataGridView1.Rows.Add(pColumna0, pColumna1);

                }
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (dataGridView1.RowCount != 0)
                {
                    int i = e.RowIndex;
                    using (var form = new Gestion_de_Preguntas.Respuesta())
                    {
                        //veo si en la ventana respuesta se guardo el valor y luego elimino esta fila de la tabla
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
