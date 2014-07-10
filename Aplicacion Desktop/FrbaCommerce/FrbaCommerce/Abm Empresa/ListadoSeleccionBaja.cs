using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class ListadoSeleccionBaja : Form
    {
        public ListadoSeleccionBaja()
        {
            InitializeComponent();
        }

        private void textBox_Mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Cuit.Clear();
            textBox_Mail.Clear();
            textBox_RazonSocial.Clear();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            String pRazonSocial = null;
            if (textBox_RazonSocial.Text != "")
            {
                pRazonSocial = textBox_RazonSocial.Text;
            }
            String pCuit = null;
            if (textBox_Cuit.Text != "")
            {
                pCuit = textBox_Cuit.Text;
            }
            String pMail = null;
            if (textBox_Mail.Text != "")
            {
                pMail = textBox_Mail.Text;
            }



            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                 SqlCommand cmd = null;
                 cmd = new SqlCommand(string.Format("SELECT EMP_ID,EMP_RAZON_SOCIAL,EMP_CUIT,EMP_CONTACTO,EMP_FECHA_CREACION,EMP_MAIL,EMP_TELEFONO,EMP_DIRECCION,EMP_COD_POSTAL From LOS_JUS.buscarEmpresas('{0}','{1}','{2}')",
                                                                   pRazonSocial, pCuit, pMail), Conexion);
                


   

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

                    Int32 pColumna0 = reader.GetInt32(0); //EMP_ID
                    String pColumna1 = reader.GetString(1);//EMP_RAZON_SOCIAL
                    String pColumna2 = reader.GetString(2);//EMP_CUIT
                    String pColumna3 = reader.GetString(3);//EMP_CONTACTO
                    DateTime pColumna8 = reader.GetDateTime(4);//EMP_FECHA_CREACION
                    String pColumna7 = reader.GetString(5);//EMP_MAIL
                    Decimal pColumna4 = reader.GetDecimal(6);//EMP_TELEFONO
                    String pColumna5 = reader.GetString(7);//EMP_DIRECCION
                    String pColumna6 = reader.GetString(8);//EMP_COD_POSTAL
           
                    
                    
                   dataGridView_baja.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5, pColumna6, pColumna7, pColumna8);
                    
                }


            }
        }

        private void dataGridView_baja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          if (e.ColumnIndex == 9)
            {
                if (dataGridView_baja.RowCount != 0)
                {
                    int i = e.RowIndex;
                    Abm_Empresa.Baja baja = new Abm_Empresa.Baja();
                    String id = dataGridView_baja[0, i].Value.ToString();
                    baja.idSeleccionado = Convert.ToInt32(id);
                    baja.razonSocialSeleccionada = dataGridView_baja[1, i].Value.ToString();
                    baja.cuitSeleccionado = dataGridView_baja[2, i].Value.ToString();
                    baja.contactoSeleccionado = dataGridView_baja[3, i].Value.ToString();
                    baja.telefonoSeleccionado = dataGridView_baja[4, i].Value.ToString();
                    baja.direccionSeleccionada = dataGridView_baja[5, i].Value.ToString();
                    baja.codigoPostalSeleccionado = dataGridView_baja[6, i].Value.ToString();
                    baja.mailSeleccionado = dataGridView_baja[7, i].Value.ToString();
                    String fecha1 = dataGridView_baja[8, i].Value.ToString();
                    baja.fechaCreacionSeleccionada = Convert.ToDateTime(fecha1);
                    baja.Show();

                    textBox_Cuit.Clear();
                    textBox_Mail.Clear();
                    textBox_RazonSocial.Clear();
                    dataGridView_baja.Rows.Clear();
                }

            }
        }

        private void ListadoSeleccionBaja_Load(object sender, EventArgs e)
        {

        }
    }
}
