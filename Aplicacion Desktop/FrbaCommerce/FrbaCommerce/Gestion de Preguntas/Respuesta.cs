using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Respuesta : Form
    {
        public bool ReturnId { get; set; }

        public Int32 codigoPreguntaSeleccionada;
        public Decimal codigoPublicacionSeleccionado;
        public Int32 codigoClienteSeleccionado;

        public bool comprobarDatosCompletos(String respuesta)
        {
            if (respuesta == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Respuesta()
        {
            InitializeComponent();
        }

        private void Respuesta_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string fechaString = fecha.ToShortDateString();
            textBox_Fecha.Text = fechaString;
            textBox_Fecha.Enabled = false;

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Respuesta.Text = "";

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pRespuesta = textBox_Respuesta.Text;
            String pFecha = textBox_Fecha.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pRespuesta);
            const string resumen = "";

            if (comprobarDatosCompletos)
            {
                //inserto los datos en la DB
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {

                    SqlCommand InsertarCliente = new SqlCommand(string.Format("UPDATE LOS_JUS.PREGUNTA SET PRE_RESPUESTA = '{0}', PRE_FECHA_RESPUESTA='{1}' where pre_codigo = '{2}'",
                                        pRespuesta,pFecha,codigoPreguntaSeleccionada), Conexion);
                    int retorno2 = InsertarCliente.ExecuteNonQuery();
                }



                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.ReturnId = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "Hay campos vacios, debe ingresar todos los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox_Fecha_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
