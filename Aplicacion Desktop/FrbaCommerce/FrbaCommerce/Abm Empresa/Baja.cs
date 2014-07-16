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
    public partial class Baja : Form
    {
        public Int32 idSeleccionado;
        public String razonSocialSeleccionada;
        public String cuitSeleccionado;
        public String contactoSeleccionado;
        public String telefonoSeleccionado;
        public String direccionSeleccionada;
        public String codigoPostalSeleccionado;
        public String mailSeleccionado;
        public DateTime fechaCreacionSeleccionada;

        public Baja()
        {
            InitializeComponent();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
             const string mensaje = "¿Está seguro que desea eliminar a la Empresa del sistema?";
            const string resumen = "Eliminando Empresa";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    //FALTA sentencia SQL para eliminar empresa
                    SqlCommand EliminarUsuario = new SqlCommand(string.Format("UPDATE LOS_JUS.EMPRESA SET EMP_ELIMINADO = 1 WHERE EMP_ID = '{0}'",idSeleccionado), Conexion);
                    int resul = EliminarUsuario.ExecuteNonQuery();
                }

                const string mensaje2 = "La Empresa ha sido eliminada con éxito";
                const string resumen2 = "";

                MessageBox.Show(mensaje2, resumen2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox_Anio_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos que se muestran en pantalla seran eliminados del sistema";

        }

        private void textBox_Anio_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void Baja_Load(object sender, EventArgs e)
        {
            
            textBox_CodigoPostal.Text = codigoPostalSeleccionado;
            textBox_Cuit.Text = cuitSeleccionado;
            textBox_Direccion.Text = direccionSeleccionada;
            textBox_Mail.Text = mailSeleccionado;
            textBox_NombreContacto.Text = contactoSeleccionado;
            textBox_RazonSocial.Text = razonSocialSeleccionada;
            textBox_Telefono.Text = telefonoSeleccionado;
            dateTimePicker_FechaNacimiento.Value = fechaCreacionSeleccionada;

            textBox_CodigoPostal.Enabled = false;
            textBox_Cuit.Enabled = false;
            textBox_Direccion.Enabled = false;
            textBox_Mail.Enabled = false;
            textBox_NombreContacto.Enabled = false;
            textBox_RazonSocial.Enabled = false;
            textBox_Telefono.Enabled = false;
            dateTimePicker_FechaNacimiento.Enabled = false;
        }

        private void textBox_RazonSocial_TextChanged(object sender, EventArgs e)
        {

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
    }
}
