using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class Alta : Form
    {
        public bool comprobarTipos(String precioPublicitar, String porcentajeVenta, String decimalPrecio, String decimalPorcentaje)
        {
            return (precioPublicitar.All(char.IsDigit) && porcentajeVenta.All(char.IsDigit) && decimalPrecio.All(char.IsDigit) && decimalPorcentaje.All(char.IsDigit));
                   
        }

        public bool comprobarDatosCompletos(String nombre,String precioPublicitar, String porcentajeVenta)
        {
            if (nombre == "" ||
                precioPublicitar == "" ||
                porcentajeVenta == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Alta()
        {
            InitializeComponent();
        }

        private void textBox_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pDecimalPorcentaje = textBox_decimalPorcentaje.Text;
            String pDecimalPrecio = textBox_decimalPrecio.Text;
            String pPorcentaje = "0";
            pPorcentaje = textBox_Porcentaje.Text;
            String pPrecio = "0";
            pPrecio = textBox1_precio.Text;

            String pPorcentajeFinal = pPorcentaje + '.' + pDecimalPorcentaje;
            String pPrecioFinal = pPrecio + '.' + pDecimalPrecio;


            String pNombre = textBox_Nombre.Text;
            String pDescripcion = null;
            pDescripcion = textBox_Descripcion.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarTipos = this.comprobarTipos(pPrecio, pPorcentaje, pDecimalPrecio, pDecimalPorcentaje);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre, pPrecio, pPorcentaje);
            const string resumen = "";


            if (comprobarTipos && comprobarDatosCompletos)
            {
                Decimal pId = 0;
                  SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
                  using (Conexion2)
                  {
                      SqlCommand ObtenerIdUsuario = new SqlCommand(string.Format("SELECT top 1 VIS_CODIGO FROM LOS_JUS.VISUALIZACION ORDER BY VIS_CODIGO desc"), Conexion2);

                      SqlDataReader reader = ObtenerIdUsuario.ExecuteReader();
                      while (reader.Read())
                      {
                          Decimal pIdAnterior = reader.GetDecimal(0);
                          pId = pIdAnterior + 1;

                      }
                      reader.Close();
                  }

                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    string sql = string.Format("Insert into LOS_JUS.Visualizacion(VIS_CODIGO,vis_nombre,vis_precio,vis_porcentaje,vis_descripcion) values('{0}','{1}','{2}','{3}','{4}')",pId, pNombre, pPrecioFinal, pPorcentajeFinal, pDescripcion);


                    SqlCommand InsertarRol = new SqlCommand(sql, Conexion);

                    
                    int retorno = InsertarRol.ExecuteNonQuery();

                }
                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.Close();
                
            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "Hay campos obligatorios vacios, debe ingresar los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    const string mensaje_Rechazo = "Error de tipos en los datos ingresados.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            

          

        }

        private void Alta_Load(object sender, EventArgs e)
        {
           
            textBox_decimalPorcentaje.Text = "00";
            textBox_decimalPrecio.Text = "00";

        }

        private void textBox_Nombre_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Ingrese un nombre representativo, corto y concreto";

        }

        private void textBox_Descripcion_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void textBox_PrecioPublicitar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void textBox_PorcentajeVenta_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de guardar";

        }

        private void button_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void textBox_Nombre_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Descripcion_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_PrecioPublicitar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_PorcentajeVenta_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Descripcion.Clear();
            textBox_Nombre.Clear();
            textBox_Porcentaje.Clear();
            textBox1_precio.Clear();
            textBox_decimalPorcentaje.Text = "00";
            textBox_decimalPrecio.Text = "00";



        }

        private void maskedTextBox_precioPublicitar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_precio_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se aceptan valores numericos";

        }

        private void textBox_Porcentaje_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se aceptan valores numericos";

        }

        private void textBox1_precio_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Porcentaje_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_decimalPrecio_Click(object sender, EventArgs e)
        {
            textBox_decimalPrecio.Text = "";

        }

        private void textBox_decimalPorcentaje_Click(object sender, EventArgs e)
        {
            textBox_decimalPorcentaje.Text = "";

        }

        private void textBox_decimalPrecio_Leave(object sender, EventArgs e)
        {
            if (textBox_decimalPrecio.Text == "")
            {
                textBox_decimalPrecio.Text = "00";
            }

        }

        private void textBox_decimalPorcentaje_Leave(object sender, EventArgs e)
        {

            if (textBox_decimalPorcentaje.Text == "")
            {
                textBox_decimalPorcentaje.Text = "00";
            }
        }
    }
}
