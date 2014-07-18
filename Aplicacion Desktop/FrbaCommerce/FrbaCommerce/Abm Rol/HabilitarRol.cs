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
    public partial class HabilitarRol : Form
    {
        public HabilitarRol()
        {
            InitializeComponent();
        }

        private void HabilitarRol_Load(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand ObtenerIds = new SqlCommand(string.Format("SELECT ROL_NOMBRE FROM LOS_JUS.ROL where rol_eliminado <> 1 and rol_habilitado == 0"), Conexion);

                SqlDataReader reader = ObtenerIds.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("No hay roles inhabilitados actualmente");
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
                    
                    const string mensaje = "¿Desea habilitar este rol?";   
            const string resumen = "Habilitar roles";
            
            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            { 
                dataGridView1.Rows.RemoveAt(i);
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    SqlCommand EliminarUsuario = new SqlCommand(string.Format("UPDATE LOS_JUS.rol SET rol_habilitado = 1 WHERE rol_nombre = '{0}' ", nombreSeleccionado), Conexion);
                    int retorno = EliminarUsuario.ExecuteNonQuery();
                }



            }

                }
                }
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

