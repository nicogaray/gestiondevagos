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
    public partial class Baja : Form
    {
        //creo variables locales para mostrar los valores
        public Int32 idSeleccionado = 0;
        public String nombreSeleccionado = "";
        public String apellidoSeleccionado = "";
        public String documentoSeleccionado;
        public String tipoDocumentoSeleccionado = "";
        public DateTime fechaSeleccionada;
        public String mailSeleccionado = "";
        public String direccionSeleccionada = "";
        public String codigoPostalSeleccionado = "";
        public String telefonoSeleccionado;
        
        public Baja()
        {
            InitializeComponent();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            const string mensaje = "¿Está seguro que desea eliminar al Cliente del sistema?";
            const string resumen = "Eliminando Cliente";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    //FALTA sentencia SQL para eliminar cliente
                    SqlCommand EliminarUsuario = new SqlCommand(string.Format("UPDATE LOS_JUS.Cliente SET CLI_HABILITADO = 0 WHERE CLI_ID = '{0}' ", idSeleccionado), Conexion);
                 }

                const string mensaje2 = "El cliente ha sido eliminado con éxito";
                const string resumen2 = "";

                MessageBox.Show(mensaje2, resumen2,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Close();

            }

           
        }

        private void textBox_Anio_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos que se muestran en pantalla seran eliminados del sistema";
        }

        private void textBox_Anio_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

       

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            //imprimo en pantalla los valores seleccionados

            textBox_Nombre.Text = nombreSeleccionado;
            textBox_Apellido.Text = apellidoSeleccionado;

            // selecciono el radio button correcto
            if (tipoDocumentoSeleccionado == "CI")
            {
                radioButton_Ci.Select();
            }
            if (tipoDocumentoSeleccionado == "DNI")
            {
                radioButton_Dni.Select();
            }
            if (tipoDocumentoSeleccionado == "LC")
            {
                radioButton_Lc.Select();
            }
            if (tipoDocumentoSeleccionado == "LE")
            {
                radioButton_Le.Select();
            }
            if (tipoDocumentoSeleccionado == "PAS")
            {
                radioButton_Pas.Select();
            }

            textBox_Documento.Text = Convert.ToString(documentoSeleccionado);
            textBox_Telefono.Text = Convert.ToString(telefonoSeleccionado);
            textBox_Direccion.Text = direccionSeleccionada;
            textBox_CodigoPostal.Text = codigoPostalSeleccionado;
            textBox_Mail.Text = mailSeleccionado;
            dateTimePicker_FechaNacimiento.Value = fechaSeleccionada;

            
            textBox_Nombre.Enabled = false;
            textBox_Nombre.Enabled = false;
            textBox_Apellido.Enabled = false;
            textBox_CodigoPostal.Enabled = false;
            textBox_Direccion.Enabled = false;
            textBox_Documento.Enabled = false;
            textBox_Mail.Enabled = false;
            textBox_Telefono.Enabled = false;
            radioButton_Ci.Enabled = false;
            radioButton_Dni.Enabled = false;
            radioButton_Lc.Enabled = false;
            radioButton_Le.Enabled = false;
            radioButton_Pas.Enabled = false;
            dateTimePicker_FechaNacimiento.Enabled = false;

        }

        private void paner_Alta_Enter(object sender, EventArgs e)
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
