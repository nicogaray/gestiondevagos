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
    public partial class ModificarBorradorSubasta : Form
    {
        public String pPublicacionCodigoSeleccionado;
        public String pDescripcionSeleccionada;
        public String pCantidadSeleccionada;
        public String pPrecioSeleccionado;
        public String pFechaFinSeleccionada;
        public String pFechaInicioSeleccionda;
        public String pHabilitarPreguntasSeleccionado;

        public bool ReturnId { get; set; }


        public bool comprobarTipos(String precio, String cantidad)
        {
            return (precio.All(char.IsDigit) && cantidad.All(char.IsDigit));
        }

        public bool comprobarDatosCompletos(String descripcion, String precio, String cantidad, String visibilidad, String estadoPublicacion, Int32 peritirPreguntas)
        {
            if (descripcion == "" ||
                precio == "" ||
                cantidad == "" ||
                visibilidad == "" ||
                estadoPublicacion == "" ||
                peritirPreguntas == -1)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public ModificarBorradorSubasta()
        {
            InitializeComponent();
        }

        private void ModificarBorradorSubasta_Load(object sender, EventArgs e)
        {
            textBox_descripcion.Text = pDescripcionSeleccionada;
            textBox_cantidad.Text = pCantidadSeleccionada;


            string i1;
            string i2;

            if (pPrecioSeleccionado.Contains(','))
            {
                string[] parts = pPrecioSeleccionado.Split(',');
                i1 = parts[0];
                i2 = parts[1];

                textBox_precio.Text = i1;
                textBox_decimal.Text = i2;
            }
            else
            {
                textBox_precio.Text = pPrecioSeleccionado;
                textBox_decimal.Text = "00";
            }


            radioButton_Borrador.Checked = true;
            radioButton_Activa.Checked = false;
            radioButton_Pausada.Checked = false;

            if (pHabilitarPreguntasSeleccionado == "1")
            {
                radioButton_Si.Checked = true;

            }
            if (pHabilitarPreguntasSeleccionado == "0")
            {
                radioButton_No.Checked = true;

            }



            DateTime fechaInicio = Convert.ToDateTime(pFechaInicioSeleccionda);
            dateTimePicker_FechaInicio.Value = fechaInicio;

            DateTime fechaFin = Convert.ToDateTime(pFechaFinSeleccionada);
            dateTimePicker_FechaVencimiento.Value = fechaFin;

            //selecciono los rubros de la publicacion

            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                // veo si el usuario es nuevo y en ese caso, inserto un nuevo usuario. Obtengo el id de ese usuario creado


                SqlCommand ObtenerRubrosPublicacion = new SqlCommand(string.Format("SELECT rub_descripcion FROM LOS_JUS.rubro join LOS_JUS.RUBROxPUBLICACION on rub_codigo=RUBPUB_RUBRO where RUBPUB_PUBLICACION = '{0}'", pPublicacionCodigoSeleccionado), Conexion);

                SqlDataReader reader = ObtenerRubrosPublicacion.ExecuteReader();
                while (reader.Read())
                {
                    String rubro = reader.GetString(0);


                    for (int i = 0; i < checkedListBox_Rubro.Items.Count; i++)
                    {
                        if ((string)checkedListBox_Rubro.Items[i] == rubro)
                        {
                            checkedListBox_Rubro.SetItemChecked(i, true);
                        }
                    }
                }
                reader.Close();

                SqlCommand ObtenerVisibilidadPublicacion = new SqlCommand(string.Format("SELECT vis_nombre FROM LOS_JUS.visualizacion join los_jus.PUBLICACIONxVISUALIZACION on vis_codigo = pubvis_visualizacion where pubvis_publicacion= {0}", pPublicacionCodigoSeleccionado), Conexion);

                SqlDataReader reader2 = ObtenerVisibilidadPublicacion.ExecuteReader();
                while (reader2.Read())
                {

                    String visibilidad = reader2.GetString(0);

                    for (int i = 0; i < comboBox_Visibilidad.Items.Count; i++)
                    {
                        if ((string)comboBox_Visibilidad.Items[i] == visibilidad)
                        {
                            comboBox_Visibilidad.SelectedIndex = i;

                        }
                    }

                }




            }








        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pDescripcion = textBox_descripcion.Text;
            String pCantidad = textBox_cantidad.Text;
            String pPrecio = textBox_precio.Text;
            if (pPrecio == "")
            {
                pPrecio = "0";
            }
            String pDecimal = textBox_decimal.Text;
            if (pDecimal == "")
            {
                pDecimal = "0";
            }
            String precioCompleto = pPrecio + '.' + pDecimal;

            String pFechaInicio = dateTimePicker_FechaInicio.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String pFechaVencimiento = dateTimePicker_FechaVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String pVisibilidadNombre = null;
            Int64 pVisibilidadCodigo = -1;
            String totalRubros = "";
            String pEstadoPublicacion = "";
            Int32 pPermitirPreguntas = -1;

            //precio entero y decimales
            
            if (comboBox_Visibilidad.SelectedIndex == 0)
            {
                pVisibilidadNombre = "Platino";
                pVisibilidadCodigo = 10002;

            }
            if (comboBox_Visibilidad.SelectedIndex == 1)
            {
                pVisibilidadNombre = "Oro";
                pVisibilidadCodigo = 10003;
            }
            if (comboBox_Visibilidad.SelectedIndex == 2)
            {
                pVisibilidadNombre = "Plata";
                pVisibilidadCodigo = 10004;

            }
            if (comboBox_Visibilidad.SelectedIndex == 3)
            {
                pVisibilidadNombre = "Bronce";
                pVisibilidadCodigo = 10005;
            }
            if (comboBox_Visibilidad.SelectedIndex == 4)
            {
                pVisibilidadNombre = "Gratis";
                pVisibilidadCodigo = 10006;
            }

            if (checkedListBox_Rubro.CheckedItems.Count != 0)
            {
                for (int x = 0; x <= checkedListBox_Rubro.CheckedItems.Count - 1; x++)
                {
                    totalRubros = totalRubros + checkedListBox_Rubro.CheckedItems[x].ToString();
                }

            }

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

            if (radioButton_Si.Checked)
            {
                pPermitirPreguntas = 1;
            }
            if (radioButton_No.Checked)
            {
                pPermitirPreguntas = 0;
            }

            DateTime hoy = DateTime.Today;
            bool comprobarTipos = this.comprobarTipos(pPrecio, pCantidad);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pDescripcion, pPrecio, pCantidad, pVisibilidadNombre, pEstadoPublicacion, pPermitirPreguntas);
            const string resumen = "";

            bool comprobarFechas = false;

            if (dateTimePicker_FechaInicio.Value <= dateTimePicker_FechaVencimiento.Value
                && hoy <= dateTimePicker_FechaInicio.Value)
            {
                comprobarFechas = true;
            }


            if (comprobarTipos && comprobarDatosCompletos && comprobarFechas)
            {
                //Defino variables y convierto datos
                Decimal pCantidadConvertida = Convert.ToDecimal(pCantidad);


                //inserto los datos en la DB
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    Decimal pPublicacionCodigo = -1;


                    SqlCommand InsertarPublicacion = new SqlCommand(string.Format("update LOS_JUS.publicacion SET pub_descripcion = '{0}',pub_precio = '{1}',pub_fecha_inicio = '{2}',pub_fecha_fin = '{3}',pub_estado = '{4}',pub_habilitacion_preguntas = '{5}' WHERE PUB_CODIGO = '{6}'",
                                                                    pDescripcion, precioCompleto, pFechaInicio, pFechaVencimiento, pEstadoPublicacion, pPermitirPreguntas, pPublicacionCodigoSeleccionado), Conexion);
                    int retorno = InsertarPublicacion.ExecuteNonQuery();


                    SqlCommand InsertarCompra = new SqlCommand(string.Format("UPDATE LOS_JUS.COMPRA SET COM_CODIGO= {0},COM_PUBLICACION ={1},COM_STOCK = {2} WHERE COM_PUBLICACION = {3}",
                                                                    pPublicacionCodigoSeleccionado, pPublicacionCodigoSeleccionado, pCantidadConvertida, pPublicacionCodigoSeleccionado), Conexion);
                    int retorno2 = InsertarCompra.ExecuteNonQuery();


                    SqlCommand InsertarVisualizacionXPublicacion = new SqlCommand(string.Format("UPDATE LOS_JUS.PUBLICACIONxVISUALIZACION SET PUBVIS_PUBLICACION = '{0}', PUBVIS_VISUALIZACION = '{1}' WHERE PUBVIS_PUBLICACION = '{2}'",
                                                                    pPublicacionCodigoSeleccionado, pVisibilidadCodigo,pPublicacionCodigoSeleccionado), Conexion);
                    int retorno3 = InsertarVisualizacionXPublicacion.ExecuteNonQuery();

                    SqlCommand ObtenerRubroCodigo = null;
                    SqlDataReader reader2 = null;
                    int retorno4 = -1;

                    if (checkedListBox_Rubro.CheckedItems.Count != 0)
                    {
                        for (int x = 0; x <= checkedListBox_Rubro.CheckedItems.Count - 1; x++)
                        {
                            String pRubroNombre = checkedListBox_Rubro.CheckedItems[x].ToString();

                            ObtenerRubroCodigo = new SqlCommand(string.Format("SELECT rub_codigo FROM LOS_JUS.rubro where rub_DESCRIPCION = '{0}'", pRubroNombre), Conexion);
                            Int32 pRubroCodigo = -1;

                            reader2 = ObtenerRubroCodigo.ExecuteReader();
                            while (reader2.Read())
                            {
                                pRubroCodigo = reader2.GetInt32(0);

                            }
                            reader2.Close();


                            SqlCommand InsertarRubro = new SqlCommand(string.Format("UPDATE LOS_JUS.RUBROxPUBLICACION SET RUBPUB_RUBRO= '{0}' WHERE RUBPUB_PUBLICACION = '{1}'",
                                                                        pRubroCodigo, pPublicacionCodigo), Conexion);
                            retorno4 = InsertarRubro.ExecuteNonQuery();


                        }



                    }


                    this.ReturnId = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                    string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                    MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBox_descripcion.Clear();
                    textBox_decimal.Clear();

                    textBox_cantidad.Clear();
                    textBox_precio.Clear();
                    comboBox_Visibilidad.Text = "";

                    DateTime fecha = DateTime.Now;
                    dateTimePicker_FechaVencimiento.Value = fecha;
                    dateTimePicker_FechaInicio.Value = fecha;

                    radioButton_Activa.Checked = false;
                    radioButton_Borrador.Checked = false;
                    radioButton_Pausada.Checked = false;
                    radioButton_Si.Checked = false;
                    radioButton_No.Checked = false;

                    checkedListBox_Rubro.ClearSelected();



                }

            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "Hay campos vacios, debe ingresar todos los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (comprobarTipos == false)
                {
                    const string mensaje_Rechazo = "Error de tipos en los datos ingresados.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (comprobarFechas == false)
                {
                    const string mensaje_Rechazo = "Error de fechas en los datos ingresados.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_decimal.Clear();
            textBox_precio.Clear();

            textBox_descripcion.Clear();
            textBox_cantidad.Clear();
            comboBox_Visibilidad.Text = "";

            DateTime fecha = DateTime.Now;
            dateTimePicker_FechaVencimiento.Value = fecha;
            dateTimePicker_FechaInicio.Value = fecha;

            radioButton_Activa.Checked = false;
            radioButton_Borrador.Checked = false;
            radioButton_Pausada.Checked = false;
            radioButton_Si.Checked = false;
            radioButton_No.Checked = false;

            checkedListBox_Rubro.ClearSelected();
        }
    }
}
