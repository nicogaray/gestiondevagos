using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce
{
    public partial class ModificarContraseña : Form
    {
        public ModificarContraseña()
        {
            InitializeComponent();
        }

        private void ModificarContraseña_Load(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand ObtenerIds = new SqlCommand(string.Format("SELECT usu_id FROM LOS_JUS.usuario", Conexion));

                SqlDataReader reader = ObtenerIds.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("No hay usuarios en el sistema");
                }

                while (reader.Read())
                {

                    String pColumna0 = reader.GetString(0);


                    dataGridView1.Rows.Add(pColumna0);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dataGridView1.RowCount != 0)
                {
                    int i = e.RowIndex;


                    String nombreSeleccionado = dataGridView1[0, i].Value.ToString(); ;

                    FrbaCommerce.Contraseña cont = new FrbaCommerce.Contraseña();
                    cont.idSeleccionado = nombreSeleccionado;
                    cont.Show();




                    
                }
            }
        }
    }
}
