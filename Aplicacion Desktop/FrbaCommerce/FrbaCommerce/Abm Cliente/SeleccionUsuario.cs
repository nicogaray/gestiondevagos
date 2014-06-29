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
    public partial class SeleccionUsuario : Form
    {
        public String pIdUsuarioSeleccionado = "";

        public SeleccionUsuario()
        {
            InitializeComponent();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dataGridView1.RowCount != 0)
                {
                    String pIdUsuarioSeleccionado = "";
                    int i = e.RowIndex;
                    pIdUsuarioSeleccionado = dataGridView1[0, i].Value.ToString();
                    
                    
                    this.Hide();
                        
                

                }

            }
        }
      

        private void SeleccionUsuario_Load(object sender, EventArgs e)
        {
           SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
           using (Conexion)
           {
               Int32 resultado = 0;
               int pId =0;
               String pRazonSocial ="";
               String pCuit = "";
               String pContacto = "";

               SqlCommand ObtenerIds = new SqlCommand(string.Format("SELECT emp_id,emp_razon_social,emp_cuit,emp_contacto FROM LOS_JUS.EMPRESA"), Conexion);
               resultado = ObtenerIds.ExecuteNonQuery();

               SqlDataReader reader = ObtenerIds.ExecuteReader();
               while (reader.Read())
               {
                   pId = reader.GetInt32(0);
                   pRazonSocial = reader.GetString(1);
                   pCuit = reader.GetString(2);
                   pContacto = reader.GetString(3);

                   dataGridView1.Rows.Add(pId, pRazonSocial, pCuit, pContacto);



               }

           }
        }
    }
}
