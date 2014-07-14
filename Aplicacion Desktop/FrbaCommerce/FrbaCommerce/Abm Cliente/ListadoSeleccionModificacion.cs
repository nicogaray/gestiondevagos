using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FrbaCommerce.Abm_Cliente
{
    public partial class ListadoSeleccionModificacion : Form
    {
        
        public ListadoSeleccionModificacion()
        {
            InitializeComponent();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Apellido.Clear();
            textBox_Documento.Clear();
            textBox_Mail.Clear();
            textBox_Nombre.Clear();
            comboBox_TipoDocumento.Text = "";
            dataGridView_Modificacion.Rows.Clear();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            String pNombre = null;
            if (textBox_Nombre.Text != "")
            {
                pNombre = textBox_Nombre.Text;
            }

            String pApellido = null;
            if (textBox_Apellido.Text != "")
            {
                pApellido = textBox_Apellido.Text;
            }

            String pEmail = null;
            if (textBox_Mail.Text != "")
            {
                pEmail = textBox_Mail.Text;
            }

            String pDocumento = null;
            decimal pDocumentoConvertido = -1;
            if (textBox_Documento.Text != "")
            {
                pDocumento = textBox_Documento.Text;
                pDocumentoConvertido = Convert.ToDecimal(pDocumento);
            }
                        
            String pTipo = null;
            if (comboBox_TipoDocumento.SelectedIndex == 0) 
            {
                pTipo = "DNI";
            }
            if (comboBox_TipoDocumento.SelectedIndex == 1)
            {
                pTipo = "CI";

            }
            if (comboBox_TipoDocumento.SelectedIndex == 2)
            {
                pTipo = "LC";

            }
            if (comboBox_TipoDocumento.SelectedIndex == 3)
            {
                pTipo = "LE";

            }
            if (comboBox_TipoDocumento.SelectedIndex == 4)
            {
                pTipo = "PAS";
            }

            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand cmd = null;
                if (pDocumentoConvertido == -1)
                {
                    cmd = new SqlCommand(string.Format("SELECT CLI_ID,CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_TIPO_DNI,CLI_FECHA_NACIMIENTO,CLI_MAIL,CLI_TELEFONO,CLI_DIRECCION,CLI_COD_POSTAL From LOS_JUS.buscarClientes('{0}','{1}','{2}','{3}',null) WHERE CLI_HABILITADO != 0",
                                                                   pNombre, pApellido, pEmail, pTipo), Conexion);
                }
                else
                {
                    cmd = new SqlCommand(string.Format("SELECT CLI_ID,CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_TIPO_DNI,CLI_FECHA_NACIMIENTO,CLI_MAIL,CLI_TELEFONO,CLI_DIRECCION,CLI_COD_POSTAL From LOS_JUS.buscarClientes('{0}','{1}','{2}','{3}','{4}') WHERE CLI_HABILITADO != 0",
                                                                      pNombre, pApellido, pEmail, pTipo,pDocumentoConvertido), Conexion);
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
                            
                            Int32 pColumna0 = reader.GetInt32(0); //CLI_ID
                            String pColumna1 = reader.GetString(1);//CLI_NOMBRE
                            String pColumna2 = reader.GetString(2);//CLI_APELLIDO
                            Decimal pColumna3 = reader.GetDecimal(3);//CLI_DNI
                            String pColumna4 = reader.GetString(4);//CLI_TIPO_DNI
                            DateTime pColumna5 = reader.GetDateTime(5);//CLI_FECHA
                            String pColumna6 = reader.GetString(6);//CLI_MAIL
                            Decimal pColumna7 = reader.GetDecimal(7);//CLI_TELEFONO
                            String pColumna8 = reader.GetString(8);//CLI_DIRECCION
                            String pColumna9 = reader.GetString(9);//CLI_COD_POSTAL

                            dataGridView_Modificacion.Rows.Add(pColumna0,pColumna1,pColumna2,pColumna3,pColumna4,pColumna5,pColumna6,pColumna7,pColumna8,pColumna9);


                            
                }



            }
        }

        private void dataGridView_Modificacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (dataGridView_Modificacion.RowCount != 0)
                {
                    int i = e.RowIndex;

                    Abm_Cliente.Modificacion modificacion = new Abm_Cliente.Modificacion();
                    modificacion.idSeleccionado = Convert.ToInt32(dataGridView_Modificacion[0, i].Value.ToString());
                    modificacion.nombreSeleccionado = dataGridView_Modificacion[1, i].Value.ToString();
                    modificacion.apellidoSeleccionado = dataGridView_Modificacion[2, i].Value.ToString();
                    modificacion.documentoSeleccionado = dataGridView_Modificacion[3, i].Value.ToString();
                    modificacion.tipoDocumentoSeleccionado = dataGridView_Modificacion[4, i].Value.ToString();
                    String fecha1 = dataGridView_Modificacion[5, i].Value.ToString();
                    modificacion.fechaSeleccionada = Convert.ToDateTime(fecha1);
                    modificacion.mailSeleccionado = dataGridView_Modificacion[6, i].Value.ToString();
                    modificacion.telefonoSeleccionado = dataGridView_Modificacion[7, i].Value.ToString();
                    modificacion.direccionSeleccionada = dataGridView_Modificacion[8, i].Value.ToString();
                    modificacion.codigoPostalSeleccionado = dataGridView_Modificacion[9, i].Value.ToString();
                    modificacion.Show();

                    textBox_Apellido.Clear();
                    textBox_Documento.Clear();
                    textBox_Mail.Clear();
                    textBox_Nombre.Clear();
                    comboBox_TipoDocumento.Text = "";
                    dataGridView_Modificacion.Rows.Clear();



                }
            }
        }

        private void ListadoSeleccionModificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
