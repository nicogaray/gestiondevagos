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
    public partial class ModificarBorradorCompra : Form
    {
        public String pPublicacionCodigo;
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



        public ModificarBorradorCompra()
        {
            InitializeComponent();
        }

        private void ModificarBorradorCompra_Load(object sender, EventArgs e)
        {
            textBox_descripcion.Text = pDescripcionSeleccionada;
            textBox_cantidad.Text = pCantidadSeleccionada;
            textBox_precio.Text = pPrecioSeleccionado;
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
                

                    SqlCommand ObtenerRubrosPublicacion = new SqlCommand(string.Format("SELECT rub_descripcion FROM LOS_JUS.rubro join LOS_JUS.RUBROxPUBLICACION on rub_codigo=RUBPUB_RUBRO where RUBPUB_PUBLICACION = '{0}'",pPublicacionCodigo), Conexion);

                    SqlDataReader reader = ObtenerRubrosPublicacion.ExecuteReader();
                    while (reader.Read())
                    {
                        String rubro = reader.GetString(0);

                        
                    }
                    reader.Close();
                
            }










        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pDescripcion = textBox_descripcion.Text;
            String pCantidad = textBox_cantidad.Text;
            String pPrecio = textBox_precio.Text;
            String pFechaInicio = dateTimePicker_FechaInicio.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String pFechaVencimiento = dateTimePicker_FechaVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String pVisibilidadNombre = null;
            Int64 pVisibilidadCodigo = -1;
            String totalRubros = "";
            String pEstadoPublicacion = "";
            Int32 pPermitirPreguntas = -1;

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
                Int64 pPrecioConvertido = Convert.ToInt64(pPrecio);
                Int32 pCantidadConvertida = Convert.ToInt32(pCantidad);


                //inserto los datos en la DB
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    Decimal pPublicacionCodigo = -1;


                    SqlCommand InsertarPublicacion = new SqlCommand(string.Format("INSERT INTO LOS_JUS.publicacion(pub_empresa,pub_descripcion,pub_precio,pub_fecha_inicio,pub_fecha_fin,pub_estado,pub_habilitacion_preguntas) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                                                    35, pDescripcion, pPrecioConvertido, pFechaInicio, pFechaVencimiento, pEstadoPublicacion, pPermitirPreguntas), Conexion);
                    int retorno = InsertarPublicacion.ExecuteNonQuery();

                    SqlCommand ObtenerPublicacionCodigo = new SqlCommand(string.Format("SELECT top 1 pub_codigo FROM LOS_JUS.publicacion WHERE PUB_DESCRIPCION = '{0}'", pDescripcion), Conexion);

                    SqlDataReader reader = ObtenerPublicacionCodigo.ExecuteReader();
                    while (reader.Read())
                    {
                        pPublicacionCodigo = reader.GetDecimal(0);

                    }
                    reader.Close();




                    SqlCommand InsertarCompra = new SqlCommand(string.Format("INSERT INTO LOS_JUS.COMPRA(COM_CODIGO,COM_PUBLICACION,COM_STOCK) Values ('{0}','{1}','{2}')",
                                                                    pPublicacionCodigo, pPublicacionCodigo, pCantidadConvertida), Conexion);
                    int retorno2 = InsertarCompra.ExecuteNonQuery();


                    SqlCommand InsertarVisualizacionXPublicacion = new SqlCommand(string.Format("INSERT INTO LOS_JUS.PUBLICACIONxVISUALIZACION(PUBVIS_PUBLICACION,PUBVIS_VISUALIZACION) Values ('{0}','{1}')",
                                                                    pPublicacionCodigo, pVisibilidadCodigo), Conexion);
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


                            SqlCommand InsertarRubro = new SqlCommand(string.Format("INSERT INTO LOS_JUS.RUBROxPUBLICACION(RUBPUB_RUBRO,RUBPUB_PUBLICACION) Values ('{0}','{1}')",
                                                                        pRubroCodigo, pPublicacionCodigo), Conexion);
                            retorno4 = InsertarRubro.ExecuteNonQuery();


                        }

                    }


                    string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                    MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBox_descripcion.Clear();
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
            textBox_descripcion.Clear();
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
}
