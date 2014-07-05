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
                SqlCommand cmd = new SqlCommand(string.Format("SELECT CLI_ID,CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_TIPO_DNI,CLI_FECHA_NACIMIENTO,CLI_MAIL,CLI_TELEFONO,CLI_DIRECCION,CLI_COD_POSTAL From LOS_JUS.buscarClientes('{0}','{1}','{2}','{3}','{4}')",
                                                               pNombre,pApellido,pEmail,pTipo,pDocumentoConvertido),Conexion);


                SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            
                            Int32 pColumna0 = reader.GetInt32(0); //CLI_ID
                            String pColumna1 = reader.GetString(1);//CLI_NOMBRE
                            String pColumna2 = reader.GetString(2);//CLI_APELLIDO
                            Int64 pColumna3 = reader.GetInt64(3);//CLI_DNI
                            String pColumna4 = reader.GetString(4);//CLI_TIPO_DNI
                            DateTime pColumna5 = reader.GetDateTime(5);//CLI_FECHA
                            String pColumna6 = reader.GetString(6);//CLI_MAIL
                            Int64 pColumna7 = reader.GetInt64(7);//CLI_TELEFONO
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
//               (Alta)Parent.textBox_IdUsuario.Text = "";

            }
        }
    }
}
