using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Historial : Form
    {
        public bool cliente = false;

        public Historial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_Respuesta1.Hide();
            dataGridView_Respuesta2.Hide();
            dataGridView_Respuesta3.Hide();
            dataGridView1.Show();

            if (cliente)
            {
                comboBox_operaciones.Items.Add("Compras");
                comboBox_operaciones.Items.Add("Ofertas");
                comboBox_operaciones.Items.Add("Calificaciones otorgadas");

            }
            else
            {
                comboBox_operaciones.Items.Add("Ventas");
                comboBox_operaciones.Items.Add("Ofertas recibidas");
                comboBox_operaciones.Items.Add("Calificaciones recibidas");

             }
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            if (cliente)
            {
                Menu.Menu_Cliente menu = new Menu.Menu_Cliente();
                menu.Show();
                this.Close();
            }
            else
            {
                Menu.Menu_Empresa menu = new Menu.Menu_Empresa();
                menu.Show();
                this.Close();
            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            comboBox_operaciones.Text = "";
            dataGridView_Respuesta1.Rows.Clear();
            dataGridView_Respuesta2.Rows.Clear();
            dataGridView_Respuesta3.Rows.Clear();
            dataGridView_Respuesta1.Hide();
            dataGridView_Respuesta2.Hide();
            dataGridView_Respuesta3.Hide();
        }

        private void comboBox_operaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cliente)
            {
               if (comboBox_operaciones.SelectedIndex == 0)
                {
                    dataGridView_Respuesta1.Show();
                    dataGridView_Respuesta2.Hide();
                    dataGridView_Respuesta3.Hide();
                    
                }
                if (comboBox_operaciones.SelectedIndex == 1)
                {
                    dataGridView_Respuesta1.Hide();
                    dataGridView_Respuesta2.Show();
                    dataGridView_Respuesta3.Hide();
                   
                }
                if (comboBox_operaciones.SelectedIndex == 2)
                {
                    dataGridView_Respuesta1.Hide();
                    dataGridView_Respuesta2.Hide();
                    dataGridView_Respuesta3.Show();
                   
                }


            }
            else
            {
                if (comboBox_operaciones.SelectedIndex == 0)
                {
                    dataGridView_Respuesta1.Show();
                    dataGridView_Respuesta2.Hide();
                    dataGridView_Respuesta3.Hide();
                   

                }
                if (comboBox_operaciones.SelectedIndex == 1)
                {
                    dataGridView_Respuesta1.Hide();
                    dataGridView_Respuesta2.Show();
                    dataGridView_Respuesta3.Hide();
                  
                }
                if (comboBox_operaciones.SelectedIndex == 2)
                {
                    dataGridView_Respuesta1.Hide();
                    dataGridView_Respuesta2.Hide();
                    dataGridView_Respuesta3.Show();
                
                }
            }
        }

        private void button_HacerConsulta_Click(object sender, EventArgs e)
        {

        }

        private void button_HacerConsulta_Click_1(object sender, EventArgs e)
        {
            dataGridView_Respuesta1.Rows.Clear();
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            SqlCommand cmd = null;

            using (Conexion)
            {

                if (cliente)
                {

                    if (comboBox_operaciones.SelectedIndex == 0)
                    {
                        //RECIBE COMO PARAMETRO EL ID DEL USUARIO DE LA SESION.EJEMPLO DE PRUEBA, ID = 2
                        cmd = new SqlCommand(string.Format("SELECT OPE_CODIGO,OPE_PUBLICACION,PUB_DESCRIPCION,OPE_TIPO,OPE_FECHA From LOS_JUS.buscarHistorialCompraCliente('{0}')",
                                                                  2), Conexion);



                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Actualmente no hay ninguna operación del tipo seleccionado en el historial", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();

                        }

                        while (reader.Read())
                        {
                            Int32 pColumna0 = reader.GetInt32(0);//OPE_CODIGO
                            Decimal pColumna1 = reader.GetDecimal(1);//OPE_PUBLICACION
                            String pColumna2 = reader.GetString(2);//PUB_DESCRIPCION
                            String pColumna3 = reader.GetString(3);//OPE_TIPO
                            DateTime pColumna4 = reader.GetDateTime(4);//OPE_FECHA

                            dataGridView_Respuesta1.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4);

                        }


                    }
                    if (comboBox_operaciones.SelectedIndex == 1)
                    {
                        //RECIBE COMO PARAMETRO EL ID DEL USUARIO DE LA SESION.EJEMPLO DE PRUEBA, ID = 2
                        cmd = new SqlCommand(string.Format("SELECT OPE_CODIGO,OPE_PUBLICACION,PUB_DESCRIPCION,OPE_TIPO,OPE_FECHA,GANADOR From LOS_JUS.buscarHistorialOfertaCliente('{0}')",
                                                                  2), Conexion);



                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Actualmente no hay ninguna operación del tipo seleccionado en el historial", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();

                        }

                        while (reader.Read())
                        {
                            Int32 pColumna0 = reader.GetInt32(0);//OPE_CODIGO
                            Decimal pColumna1 = reader.GetDecimal(1);//OPE_PUBLICACION
                            String pColumna2 = reader.GetString(2);//PUB_DESCRIPCION
                            String pColumna3 = reader.GetString(3);//OPE_TIPO
                            DateTime pColumna4 = reader.GetDateTime(4);//OPE_FECHA
                            Int32 pColumna5 = reader.GetInt32(5);//GANADOR

                            dataGridView_Respuesta2.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5);

                        }



                    }
                    if (comboBox_operaciones.SelectedIndex == 2)
                    {
                        //RECIBE COMO PARAMETRO EL ID DEL USUARIO DE LA SESION.EJEMPLO DE PRUEBA, ID = 2
                        cmd = new SqlCommand(string.Format("SELECT OPE_CODIGO,PUB_CODIGO,PUB_DESCRIPCION,CAL_ESTRELLAS,CAL_DETALLE From LOS_JUS.buscarHistorialCalificacionesCliente('{0}','Recibidas')",
                                                                  2), Conexion);



                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Actualmente no hay ninguna operación del tipo seleccionado en el historial", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();

                        }

                        while (reader.Read())
                        {
                            Int32 pColumna0 = reader.GetInt32(0);//OPE_CODIGO
                            Decimal pColumna1 = reader.GetDecimal(1);//PUB_CODIGO
                            String pColumna2 = reader.GetString(2);//PUB_DESCRIPCION
                            Decimal pColumna3 = reader.GetDecimal(3);//CAL_ESTRELLAS
                            String pColumna4 = reader.GetString(4);//CAL_DETALLE


                            dataGridView_Respuesta3.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4);

                        }


                    }

                }

                else
                {

                    if (comboBox_operaciones.SelectedIndex == 0)
                    {
                        //RECIBE COMO PARAMETRO EL ID DEL USUARIO DE LA SESION.EJEMPLO DE PRUEBA, ID = 35
                        cmd = new SqlCommand(string.Format("SELECT OPE_CODIGO,OPE_PUBLICACION,PUB_DESCRIPCION,OPE_TIPO,OPE_FECHA From LOS_JUS.buscarHistorialCompraEmpresa('{0}')",
                                                                  35), Conexion);



                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Actualmente no hay ninguna operación del tipo seleccionado en el historial", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();

                        }

                        while (reader.Read())
                        {
                            Int32 pColumna0 = reader.GetInt32(0);//OPE_CODIGO
                            Decimal pColumna1 = reader.GetDecimal(1);//OPE_PUBLICACION
                            String pColumna2 = reader.GetString(2);//PUB_DESCRIPCION
                            String pColumna3 = reader.GetString(3);//OPE_TIPO
                            DateTime pColumna4 = reader.GetDateTime(4);//OPE_FECHA

                            dataGridView_Respuesta1.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4);

                        }


                    }
                    if (comboBox_operaciones.SelectedIndex == 1)
                    {
                        //RECIBE COMO PARAMETRO EL ID DEL USUARIO DE LA SESION.EJEMPLO DE PRUEBA, ID = 35
                        cmd = new SqlCommand(string.Format("SELECT OPE_CODIGO,OPE_PUBLICACION,PUB_DESCRIPCION,OPE_TIPO,OPE_FECHA,GANADOR From LOS_JUS.buscarHistorialOfertaEmpresa('{0}')",
                                                                  35), Conexion);



                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Actualmente no hay ninguna operación del tipo seleccionado en el historial", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();

                        }

                        while (reader.Read())
                        {
                            Int32 pColumna0 = reader.GetInt32(0);//OPE_CODIGO
                            Decimal pColumna1 = reader.GetDecimal(1);//OPE_PUBLICACION
                            String pColumna2 = reader.GetString(2);//PUB_DESCRIPCION
                            String pColumna3 = reader.GetString(3);//OPE_TIPO
                            DateTime pColumna4 = reader.GetDateTime(4);//OPE_FECHA
                            Int32 pColumna5 = reader.GetInt32(5);//GANADOR

                            dataGridView_Respuesta2.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5);

                        }



                    }
                    if (comboBox_operaciones.SelectedIndex == 2)
                    {
                        //RECIBE COMO PARAMETRO EL ID DEL USUARIO DE LA SESION.EJEMPLO DE PRUEBA, ID = 2
                        cmd = new SqlCommand(string.Format("SELECT OPE_CODIGO,PUB_CODIGO,PUB_DESCRIPCION,CAL_ESTRELLAS,CAL_DETALLE From LOS_JUS.buscarHistorialCalificacionesCliente('{0}','Recibidas')",
                                                                  2), Conexion);



                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Actualmente no hay ninguna operación del tipo seleccionado en el historial", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();

                        }

                        while (reader.Read())
                        {
                            Int32 pColumna0 = reader.GetInt32(0);//OPE_CODIGO
                            Decimal pColumna1 = reader.GetDecimal(1);//PUB_CODIGO
                            String pColumna2 = reader.GetString(2);//PUB_DESCRIPCION
                            Decimal pColumna3 = reader.GetDecimal(3);//CAL_ESTRELLAS
                            String pColumna4 = reader.GetString(4);//CAL_DETALLE


                            dataGridView_Respuesta3.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4);

                        }


                    }
                }
            }
        }

        private void dataGridView_ResultadoOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_ResultadoCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
