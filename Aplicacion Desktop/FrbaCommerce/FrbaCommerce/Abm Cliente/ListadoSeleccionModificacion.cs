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
            decimal pDocumentoConvertido = 0;
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
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * From LOS_JUS.buscarClientes('{0}','{1}','{2}','{3}','{4}')",
                                                               pNombre,pApellido,pEmail,pTipo,pDocumento),Conexion);


                //tira error! hay algun problema en los tipos de datos! veer!
                SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Int32 pColumna0 = reader.GetInt32(0);
                            String pColumna1 = reader.GetString(1);
                            String pColumna2 = reader.GetString(2);
                            Int32 pColumna3 = reader.GetInt32(3);
                            String pColumna4 = reader.GetString(4);
                            DateTime pColumna5 = reader.GetDateTime(5);
                            Int32 pColumnaExtra1 = reader.GetInt32(6);
                            String pColumna6 = reader.GetString(7);
                            Int32 pColumna7 = reader.GetInt32(8);
                            String pColumna8 = reader.GetString(9);
                            String pColumna9 = reader.GetString(10);

                            dataGridView_Modificacion.Rows.Add(pColumna0,pColumna1,pColumna2,pColumna3,pColumna4,pColumna5,pColumna6,pColumna7,pColumna8,pColumna9);


    
                }

            }
        }
    }
}
