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
    public partial class Hacer_Preguntas : Form
    {
        public String publicacion;

        public bool comprobarDatosCompletos(String pregunta)
        {
            if (pregunta == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Hacer_Preguntas()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";
        }

        private void label_Pregunta_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Pregunta.Text = "";

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pPregunta = textBox_Pregunta.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pPregunta);
            const string resumen = "";

            if (comprobarDatosCompletos)
            {
                                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                                using (Conexion)
                                {

                                    //FALTA INGRESAR EL ID DE CLIENTE DE LA SESION
                                    string sql = string.Format("Insert into LOS_JUS.pregunta(PRE_PUBLICACION,PRE_CLIENTE,PRE_PREGUNTA,PRE_RESPUESTA,PRE_FECHA_RESPUESTA) values({0},{1},'{2}',null,null)"
                                                                                                , publicacion, 2, pPregunta);
                                    SqlCommand InsertarRol = new SqlCommand(sql, Conexion);

                                        int retorno = InsertarRol.ExecuteNonQuery();
                                }

                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox_Pregunta.Clear();
            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "El campo Pregunta esta vacio, debe ingresar todos los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox_Pregunta_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void label_Pregunta_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void Hacer_Preguntas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_Pregunta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
