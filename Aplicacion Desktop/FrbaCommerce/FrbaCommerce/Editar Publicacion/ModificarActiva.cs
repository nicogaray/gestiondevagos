using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class ModificarActiva : Form
    {
        public bool ReturnId { get; set; }

        public String publicacionCodigoSeleccionado;
        public String descripcionSeleccionada;
        public String cantidadSeleccionada;

        public bool comprobarTipos(String cantidad)
        {
            return (cantidad.All(char.IsDigit));
        }

        public bool comprobarDatosCompletos(String descripcion, String cantidad, String estado)
        {
            if (descripcion == "" ||
                cantidad == "" ||
                estado == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public ModificarActiva()
        {
            InitializeComponent();
        }

        private void label_Estado_Click(object sender, EventArgs e)
        {

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pDescripcion = textBox_descripcion.Text;
            String pCantidad = textBox_cantidad.Text;
            String pEstadoPublicacion = "";

            if (radioButton_Activa.Checked)
            {
                pEstadoPublicacion = "Activa";
            }

            if (radioButton_Borrador.Checked)
            {
                pEstadoPublicacion = "Borrador";
            }

            if (radioButton_Pausada.Checked)
            {
                pEstadoPublicacion = "Pausada";
            }

            if (radioButton_Finalizada.Checked)
            {
                pEstadoPublicacion = "Finalizada";
            }

            bool comprobarTipos = this.comprobarTipos(pCantidad);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pDescripcion, pCantidad,pEstadoPublicacion);
            const string resumen = "";


            if (comprobarTipos && comprobarDatosCompletos)
            {
                //Defino variables y convierto datos
                Int32 pCantidadConvertida = Convert.ToInt32(pCantidad);


                //inserto los datos en la DB
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {


                    SqlCommand InsertarPublicacion = new SqlCommand(string.Format("UPDATE LOS_JUS.publicacion SET pub_descripcion='{0}',pub_estado='{1}' WHERE pub_codigo = {2}",
                                                                    pDescripcion, pEstadoPublicacion,publicacionCodigoSeleccionado ), Conexion);
                    int retorno = InsertarPublicacion.ExecuteNonQuery();


                    SqlCommand InsertarCompra = new SqlCommand(string.Format("UPDATE LOS_JUS.compra SET com_stock={0} WHERE  com_publicacion = {1}",
                                                                    pCantidad,publicacionCodigoSeleccionado ), Conexion);
                    int retorno2 = InsertarCompra.ExecuteNonQuery();



                    }


                    string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                    MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBox_descripcion.Clear();
                    textBox_cantidad.Clear();
                    
                    radioButton_Activa.Checked = false;
                    radioButton_Borrador.Checked = false;
                    radioButton_Pausada.Checked = false;
                    radioButton_Finalizada.Checked = false;

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
                else
                {
                    const string mensaje_Rechazo = "Error de tipos en los datos ingresados.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }






        




        }

        private void ModificarActiva_Load(object sender, EventArgs e)
        {
            textBox_cantidad.Text = cantidadSeleccionada;
            textBox_descripcion.Text = descripcionSeleccionada;
            radioButton_Activa.Checked = true;
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_descripcion.Clear();
            textBox_cantidad.Clear();
            radioButton_Activa.Checked = false;
            radioButton_Borrador.Checked = false;
            radioButton_Finalizada.Checked = false;
            radioButton_Pausada.Checked = false;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
