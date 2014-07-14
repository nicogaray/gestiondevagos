using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public bool comprobarDatosCompletos(String año, Decimal trimestre, String mes, int visibilidad, int tipoListado)
        {
            if ((tipoListado == 0 && (mes == "" || visibilidad == -1) ||
                 tipoListado == -1 || año =="" || 
                 ((tipoListado == 1 || tipoListado == 2 || tipoListado ==3) && trimestre==-1)))
            {
                return false;
            }

            else
            {
                return true;
            }
        }
        
        
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

            dataGridView_Resultado.Rows.Clear();
            dataGridView_Resultado2.Rows.Clear();
          
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
            if (comboBox_TipoListado.SelectedIndex == 3)
            {
                dataGridView_Resultado2.Show();
                dataGridView_Resultado.Hide();
            }
            else
            {
                dataGridView_Resultado2.Hide();
                dataGridView_Resultado.Show();
            }

        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            label_Mes.Hide();
            numericUpDown_Mes.Hide();
            label_TipoVisibilidad.Hide();
            comboBox_Visibilidad.Hide();
            dataGridView_Resultado2.Hide(); 
            


        }

        private void comboBox_TipoListado_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_Visibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Consultas_Enter(object sender, EventArgs e)
        {

        }

        private void button_HacerConsulta_Click(object sender, EventArgs e)
        {
            dataGridView_Resultado.Rows.Clear();
            dataGridView_Resultado2.Rows.Clear();
            
            int pTipoListado = -1;
            pTipoListado = comboBox_TipoListado.SelectedIndex;
            String pMes = null;
            pMes = Convert.ToString(numericUpDown_Mes.Value);
            String pAnio = null;
            pAnio = Convert.ToString(numericUpDown_Anio.Value);
            int pVisibilidad = -1;
            if (comboBox_Visibilidad.SelectedIndex == 0)
            {
                pVisibilidad = 10002;
            }
            if (comboBox_Visibilidad.SelectedIndex == 1)
            {
                pVisibilidad = 10003;
            }
            if (comboBox_Visibilidad.SelectedIndex == 2)
            {
                pVisibilidad = 10004;
            }
            if (comboBox_Visibilidad.SelectedIndex == 3)
            {
                pVisibilidad = 10005;
            }
            if (comboBox_Visibilidad.SelectedIndex == 4)
            {
                pVisibilidad = 10006;
            }

            Decimal pTrimestre = -1;
            if (comboBox_Trimestre.SelectedIndex == 0)
            {
                pTrimestre = 1;
            }
              if (comboBox_Trimestre.SelectedIndex == 1)
            {
                pTrimestre = 2;
            }
              if (comboBox_Trimestre.SelectedIndex == 2)
            {
                pTrimestre = 3;
            }
              if (comboBox_Trimestre.SelectedIndex == 3)
            {
                pTrimestre = 4;
            }

            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pAnio,pTrimestre,pMes,pVisibilidad,pTipoListado);


            


            if (comprobarDatosCompletos)
            {

                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    SqlCommand cmd = null;
                    SqlCommand cmd2 = null;

                    if (pTipoListado != 3)
                    {

                        if (pTipoListado == 0)
                        {
                            cmd = new SqlCommand(string.Format("SELECT PUB_COUNT,EMP_ID,EMP_RAZON_SOCIAL,EMP_CUIT,EMP_CONTACTO,EMP_FECHA_CREACION,EMP_MAIL From LOS_JUS.estadisticas1('{0}','{1}','{2}',null,'{3}')", pAnio, pMes, pAnio, pVisibilidad), Conexion);
                        }
                        if (pTipoListado == 1)
                        {
                            cmd = new SqlCommand(string.Format("SELECT FAC_SUMA,EMP_ID,EMP_RAZON_SOCIAL,EMP_CUIT,EMP_CONTACTO,EMP_FECHA_CREACION,EMP_MAIL From LOS_JUS.estadisticas2('{0}','{1}')", pAnio, pTrimestre), Conexion);
                        }
                        if (pTipoListado == 2)
                        {
                            cmd = new SqlCommand(string.Format("SELECT CAL_SUMA,EMP_ID,EMP_RAZON_SOCIAL,EMP_CUIT,EMP_CONTACTO,EMP_FECHA_CREACION,EMP_MAIL From LOS_JUS.estadisticas3('{0}','{1}')", pAnio, pTrimestre), Conexion);
                        }

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                        }
                        else
                        {
                            MessageBox.Show("No existe un listado estadistico que cumpla los criterios de busqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        while (reader.Read())
                        {
                            Int32 pColumna0 = reader.GetInt32(0);//PUB_COUNT
                            Int32 pColumna1 = reader.GetInt32(1);//EMP_ID
                            String pColumna2 = reader.GetString(2);//EMP_RAZON_SOCIAL
                            String pColumna3 = reader.GetString(3);//EMP_CUIT
                            String pColumna4 = reader.GetString(4);//EMP_CONTACTO
                            DateTime pColumna5 = reader.GetDateTime(5);//EMP_FECHA_CREACION
                            String pColumna6 = reader.GetString(6);//EMP_MAIL

                            dataGridView_Resultado.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5, pColumna6);
                        }
                    }

                    if (pTipoListado == 4)
                    {
                        cmd2 = new SqlCommand(string.Format("SELECT CAL_COUNT,CLI_ID,CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_TIPO_DNI,CLI_FECHA_NACIMIENTO,CLI_MAIL From LOS_JUS.estadisticas4('{0}','{1}')", pAnio, pTrimestre), Conexion);


                        SqlDataReader reader2 = cmd2.ExecuteReader();

                        if (reader2.HasRows)
                        {
                        }
                        else
                        {
                            MessageBox.Show("No existe un listado estadistico que cumpla los criterios de busqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        while (reader2.Read())
                        {
                            Int32 pColumna0 = reader2.GetInt32(0);//CAL_COUNT
                            Int32 pColumna1 = reader2.GetInt32(1);//CLI_ID
                            String pColumna2 = reader2.GetString(2);//CLI_NOMBRE
                            String pColumna3 = reader2.GetString(3);//CLI_APELLIDO
                            Int32 pColumna4 = reader2.GetInt32(4);//CLI_DNI
                            String pColumna5 = reader2.GetString(5);//CLI_TIPO_DNI
                            DateTime pColumna6 = reader2.GetDateTime(6);//CLI_FECHA_NACIMIENTO
                            String pColumna7 = reader2.GetString(7);//CLI_MAIL

                            dataGridView_Resultado2.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5, pColumna6, pColumna7);
                        }
                    }
                }


            }
            else
            {
            }

        }
    }
}
