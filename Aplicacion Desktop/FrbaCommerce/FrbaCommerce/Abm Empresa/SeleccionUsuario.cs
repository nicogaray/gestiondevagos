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
    public partial class SeleccionUsuario : Form
    {
        public string ReturnId { get; set; }

        public SeleccionUsuario()
        {
            InitializeComponent();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (dataGridView1.RowCount != 0)
                {
                    String pIdUsuarioSeleccionado = "";
                    int i = e.RowIndex;
                    pIdUsuarioSeleccionado = dataGridView1[0, i].Value.ToString();

                    this.ReturnId = pIdUsuarioSeleccionado;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void SeleccionUsuario_Load(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {

                Int32 pId = 0;
                String pApellido = "";
                String pNombre = "";
                Decimal pDocumento = 0;
                String pTipo = "";


                SqlCommand comando = new SqlCommand(string.Format("SELECT cli_id,cli_nombre,cli_apellido,cli_dni,cli_tipo_dni FROM LOS_JUS.cliente"), Conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pId = reader.GetInt32(0);
                    pApellido = reader.GetString(1);
                    pNombre = reader.GetString(2);
                    pDocumento = reader.GetDecimal(3);
                    pTipo = reader.GetString(4);
                    dataGridView1.Rows.Add(pId, pApellido, pNombre,pDocumento,pTipo);
                }

            }
        }
    }
}
