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
    public partial class ListadoSeleccionBaja : Form
    {
        public ListadoSeleccionBaja()
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
            dataGridView_baja.Rows.Clear();
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
                    cmd = new SqlCommand(string.Format("SELECT CLI_ID,CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_TIPO_DNI,CLI_FECHA_NACIMIENTO,CLI_MAIL,CLI_TELEFONO,CLI_DIRECCION,CLI_COD_POSTAL From LOS_JUS.buscarClientes('{0}','{1}','{2}','{3}',null)",
                                                                   pNombre, pApellido, pEmail, pTipo), Conexion);
                }
                else
                {
                    cmd = new SqlCommand(string.Format("SELECT CLI_ID,CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_TIPO_DNI,CLI_FECHA_NACIMIENTO,CLI_MAIL,CLI_TELEFONO,CLI_DIRECCION,CLI_COD_POSTAL From LOS_JUS.buscarClientes('{0}','{1}','{2}','{3}','{4}')",
                                                                      pNombre, pApellido, pEmail, pTipo, pDocumentoConvertido), Conexion);
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

                    dataGridView_baja.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5, pColumna6, pColumna7, pColumna8, pColumna9);



                }


            }
        }

        private void dataGridView_baja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (dataGridView_baja.RowCount != 0)
                {
                    int i = e.RowIndex;

                    Abm_Cliente.Baja baja = new Abm_Cliente.Baja();
                    baja.nombreSeleccionado = dataGridView_baja[1, i].Value.ToString();
                    baja.apellidoSeleccionado = dataGridView_baja[2, i].Value.ToString();
                    baja.documentoSeleccionado = dataGridView_baja[3, i].Value.ToString();
                    baja.tipoDocumentoSeleccionado = dataGridView_baja[4, i].Value.ToString();
                    String fecha1 = dataGridView_baja[5, i].Value.ToString();
                    baja.fechaSeleccionada = Convert.ToDateTime(fecha1);
                    baja.mailSeleccionado = dataGridView_baja[6, i].Value.ToString();
                    baja.telefonoSeleccionado = dataGridView_baja[7, i].Value.ToString();
                    baja.direccionSeleccionada = dataGridView_baja[8, i].Value.ToString();
                    baja.codigoPostalSeleccionado = dataGridView_baja[9, i].Value.ToString();
                    baja.Show();

                    textBox_Apellido.Clear();
                    textBox_Documento.Clear();
                    textBox_Mail.Clear();
                    textBox_Nombre.Clear();
                    comboBox_TipoDocumento.Text = "";
                    dataGridView_baja.Rows.Clear();



                }
            }
        }

        private void ListadoSeleccionBaja_Load(object sender, EventArgs e)
        {

        }
    }
}
