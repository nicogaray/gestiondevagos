using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Rol
{
    public partial class ListadoSeleccionModificacion : Form
    {
        public ListadoSeleccionModificacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se muestra en pantalla todos los roles disponibles en el sistema con sus funcionalidades";
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void ListadoSeleccionModificacion_Load(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand ObtenerIds = new SqlCommand(string.Format("SELECT ROL_NOMBRE FROM LOS_JUS.ROL"), Conexion);

                SqlDataReader reader = ObtenerIds.ExecuteReader();
                while (reader.Read())
                {

                    String pColumna0 = reader.GetString(0);


                    dataGridView1.Rows.Add(pColumna0);
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dataGridView1.RowCount != 0)
                {
                    int i = e.RowIndex;
                    Abm_Rol.Modificacion form = new Abm_Rol.Modificacion();
                    form.nombreSeleccionado = dataGridView1[0, i].Value.ToString();
                    form.Show();
                }
                }
        }
    }
}
