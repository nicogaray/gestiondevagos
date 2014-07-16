using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.ABM_Rol
{
    public partial class Baja : Form
    {
        public bool ReturnId { get; set; }

        public String nombreSeleccionado = "";

        public Baja()
        {
            InitializeComponent();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            
            const string mensaje = "¿Está seguro que desea eliminar al Rol del sistema?";
            const string resumen = "Eliminando Rol";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    SqlCommand EliminarUsuario = new SqlCommand(string.Format("UPDATE LOS_JUS.rol SET rol_eliminado = 1 WHERE rol_nombre = '{0}' ", nombreSeleccionado), Conexion);
                    int retorno = EliminarUsuario.ExecuteNonQuery();
                }

                const string mensaje2 = "El Rol ha sido eliminado con éxito";
                const string resumen2 = "";

                MessageBox.Show(mensaje2, resumen2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.ReturnId = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            textBox_Nombre.Enabled = false;
            dataGridView_ListaFuncionalidades.Enabled = false;

            textBox_Nombre.Text = nombreSeleccionado;

            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand ObtenerIds = new SqlCommand(string.Format("SELECT FUN_FUNCIONALIDAD FROM LOS_JUS.ROL JOIN LOS_JUS.ROLxFUNCIONALIDADES ON ROLFUN_ROL=ROL_NOMBRE JOIN LOS_JUS.FUNCIONALIDADES ON ROLFUN_FUNCIONALIDADES=FUN_FUNCIONALIDAD WHERE ROL_NOMBRE = '{0}'", nombreSeleccionado), Conexion);

                SqlDataReader reader = ObtenerIds.ExecuteReader();
                while (reader.Read())
                {

                    String pColumna0 = reader.GetString(0);


                    dataGridView_ListaFuncionalidades.Rows.Add(pColumna0);
                }
            }
        }

        private void dataGridView_ListaFuncionalidades_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos que se muestran en pantalla serán eliminados del sistema";

        }

        private void dataGridView_ListaFuncionalidades_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Borrar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Eliminar permanentemente los datos del sistema";

        }

        private void button_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Volver al formulario anterior";

        }

        private void button_Borrar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
