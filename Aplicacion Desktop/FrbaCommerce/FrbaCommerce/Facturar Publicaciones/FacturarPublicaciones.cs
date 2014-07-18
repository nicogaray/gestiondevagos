using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class FacturarPublicaciones : Form
    {
        public bool comprobarDatosCompletos(String formaDePago, String numeroTarjeta, String nombreTarjeta, String titular, String codigoSeguridad)
        {
            if (formaDePago == "" ||
                (formaDePago == "Tarjeta" && (nombreTarjeta == "" || titular == "" || codigoSeguridad =="" || numeroTarjeta == ""))
                )
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public FacturarPublicaciones()
        {
            InitializeComponent();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            Menu.Menu_Cliente cliente = new Menu.Menu_Cliente();
            cliente.Show();
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_cantidadARendir.Clear();
            textBox_CodigoSeguridad.Clear();
            textBox_NombreTitular.Clear();
            textBox_numeroTarjeta.Clear();
            textBox_montoTotal.Clear();
            textBox_comisiones.Clear();
            textBox1.Clear();

            textBox_montoTotal.Enabled = false;
            textBox_comisiones.Enabled = true;

            dataGridView1.Rows.Clear();

            radioButton_Efectivo.Checked = false;
            radioButton_Tarjeta.Checked = false;
            
            radioButton_AMEX.Checked = false;
            radioButton_MASTERCARD.Checked = false;
            radioButton_VISA.Checked = false;

            groupBox_tarjeta.Enabled = false;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FacturarPublicaciones_Load(object sender, EventArgs e)
        {
            groupBox_tarjeta.Enabled = false;

            DateTime hoy = DateTime.Now;
            textBox_fecha.Enabled = false;
            textBox_fecha.Text = Convert.ToString(hoy);


            
        }

        private void radioButton_Tarjeta_CheckedChanged(object sender, EventArgs e)
        {
           
                groupBox_tarjeta.Enabled = true;

            
        }

        private void radioButton_Efectivo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_tarjeta.Enabled = false;

            radioButton_AMEX.Checked = false;
            radioButton_MASTERCARD.Checked = false;
            radioButton_VISA.Checked = false;
            textBox_CodigoSeguridad.Clear();
            textBox_NombreTitular.Clear();
            textBox_numeroTarjeta.Clear();


        }

        private void textBox_cantidadARendir_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            String pCantidad = textBox_cantidadARendir.Text;
            Int32 pCantidadConvertida = Convert.ToInt32(pCantidad);

            if (pCantidad.All(char.IsDigit) && pCantidadConvertida < 10 && pCantidad != "")
            {
                SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion2)
                {
                    //defino variables
                    
                    //sumo todos los valores
                    Decimal pMontoTotal = 0;

                    //sumo todas las comisiones
                    Decimal pComisiones = 0;

                    //almaceno el precio de una publicacion
                    Decimal precioPublicacion = 0;
                    
                    //sumo precioPublicacion + comisionPrecio
                    Decimal precioPublicacionTotal = 0;

                    //almaceno la comision de una publicacion
                    Decimal comisionPrecio = 0;

                    //almaceno porcentaje de una publicacion
                    Decimal comisionPorcentaje = 0;

                    //obtengo porcentaje de la publicacion
                    Decimal porcentajeVenta = 0;


                    Decimal numeroFactura = 0;

                    //falta id de usuario
                    SqlCommand ObtenerIdUsuario = new SqlCommand(string.Format("SELECT ope_codigo,ope_publicacion,pub_descripcion,ope_tipo,ope_oferta,ope_cantidad,ope_fecha FROM LOS_JUS.operacionesSinPagar('{0}')", 2), Conexion2);

                    SqlDataReader reader = ObtenerIdUsuario.ExecuteReader();
                    int contar = 0;
                    while (reader.Read() && contar <= pCantidadConvertida)
                    {
                        Int32 pColumna0 = reader.GetInt32(0);//ope_codigo
                        Decimal pColumna1 = reader.GetDecimal(1);//ope_publicacion
                        String pColumna2 = reader.GetString(2);//pub_descripcion
                        String pColumna3 = reader.GetString(3);//ope_tipo
                        Decimal pColumna4 = reader.GetDecimal(4);//ope_oferta
                        Decimal pColumna5 = reader.GetDecimal(5);//ope_cantidad
                        DateTime pColumna6 = reader.GetDateTime(6);//ope_fecha
                        
                        contar++;

                        //calculo monto total como la suma de los precios de las publicaciones individuales si es COMPRA
                        if (pColumna3 == "C")
                        {
                            SqlCommand ObtenerMontoDelItem = new SqlCommand(string.Format("SELECT pub_precio FROM LOS_JUS.publicacion where pub_codigo='{0}'", pColumna1), Conexion2);

                            SqlDataReader reader2 = ObtenerMontoDelItem.ExecuteReader();
                            while (reader2.Read())
                            {
                                precioPublicacion = (reader2.GetDecimal(0)) * pColumna4;
                            }
                            reader2.Close();

                            pMontoTotal = pMontoTotal + precioPublicacion;

                        }
                        if (pColumna3 == "S")
                        {

                            SqlCommand ObtenerMontoDelItem = new SqlCommand(string.Format("SELECT ope_oferta FROM LOS_JUS.operacion where ope_codigo='{0}'", pColumna0), Conexion2);

                            SqlDataReader reader2 = ObtenerMontoDelItem.ExecuteReader();
                            while (reader2.Read())
                            {
                                precioPublicacion = reader2.GetDecimal(0);
                            }
                            reader2.Close();

                            pMontoTotal = pMontoTotal + precioPublicacion;
                        }

                        reader.Close();

                        SqlCommand ObtenerComision = new SqlCommand(string.Format("SELECT vis_precio,vis_porcentaje FROM LOS_JUS.visualizacion join los_jus.PUBLICACIONxVISUALIZACION on vis_codigo = pubvis_visualizacion join los_jus.PUBLICACION on pub_codigo=pubvis_publicacion where pub_codigo='{0}'", pColumna1), Conexion2);

                        SqlDataReader reader3 = ObtenerComision.ExecuteReader();
                        while (reader3.Read())
                        {
                            comisionPrecio = reader3.GetDecimal(0);
                            comisionPorcentaje = reader3.GetDecimal(1);
                        }

                        reader3.Close();

                        //obtengo el numero de factura
                        SqlCommand ObtenerNumeroFactura = new SqlCommand(string.Format("SELECT (top 1) fac_codigo FROM LOS_JUS.facturacion ORDER BY fac_codigo desc"), Conexion2);

                        SqlDataReader reader4 = ObtenerNumeroFactura.ExecuteReader();
                        while (reader4.Read())
                        {
                            Decimal numeroAnterior = reader4.GetDecimal(0);
                            numeroFactura = numeroAnterior + 1;
                        }

                        reader4.Close();
                        
                        porcentajeVenta = porcentajeVenta + (precioPublicacion * comisionPorcentaje);

                        //TODO: ANTES DE LLENAR LA COMISION TOTAL, CONSULTAR SI ES GRATIS (10 PUBLICACIONES DEL MISMO TIPO) CON FUNCION, LE MANDO ID_EMPRESA, ID_VISUALIZACION. si devuelve 0 cobras, si devuelve 1 es gratis.
  
                        pComisiones = pComisiones + comisionPrecio;

                        textBox_Numero.Text = Convert.ToString(numeroFactura);

                        precioPublicacionTotal = comisionPrecio + precioPublicacion;

                        dataGridView1.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5, pColumna6, precioPublicacionTotal,comisionPrecio);

                    }

                    textBox_montoTotal.Text =Convert.ToString(pComisiones+pMontoTotal);
                    textBox_comisiones.Text = Convert.ToString(pComisiones);
                    textBox1.Text = Convert.ToString(porcentajeVenta);

                }
            }
            else
            {
                MessageBox.Show("La cantidad seleccionada debe ser un numero del 1 al 10", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_cantidadARendir.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {

            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                //inicializo variables con los datos seleccionados

                String pFormaDePago = null;
                if (radioButton_Efectivo.Checked)
                {
                    pFormaDePago = "Efectivo";
                }
                if (radioButton_Tarjeta.Checked)
                {
                    pFormaDePago = "Tarjeta";
                }

                String pNombreTarjeta = null;

                if (radioButton_VISA.Checked)
                {
                    pNombreTarjeta = "Visa";
                }

                if (radioButton_MASTERCARD.Checked)
                {
                    pNombreTarjeta = "Mastercard";
                }

                if (radioButton_AMEX.Checked)
                {
                    pNombreTarjeta = "American Express";
                }

                String pNumeroDeTarjeta = null;
                if (textBox_numeroTarjeta.Text == "")
                {
                    pNumeroDeTarjeta = textBox_numeroTarjeta.Text;
                }

                String pNombreTitular = null;
                if (textBox_NombreTitular.Text == "")
                {
                    pNombreTitular = textBox_NombreTitular.Text;
                }

                String pCodigoSeguridad = null;
                if (textBox_CodigoSeguridad.Text == "")
                {
                    pCodigoSeguridad = textBox_CodigoSeguridad.Text;
                }

                String pNumeroFactura = null;
                pNumeroFactura = textBox_Numero.Text;

                String pMontoAPagar = null;
                pMontoAPagar = textBox_montoTotal.Text;

                String pComisiones = null;
                pComisiones = textBox_comisiones.Text;

                String pFecha = textBox_fecha.Text;




                //falta ver que hacer con fac_operacion
                SqlCommand InsertarRol = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Faturacion(fac_codigo,fac_operacion,fac_forma_pago,FAC_NOMBRE_TARJETA,FAC_NUMERO_TARJETA,FAC_TITULAR_TARJETA,FAC_CODIGO_TARJETA,fac_fecha) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'.'{7}')",
                                                            pNumeroFactura, 11, pFormaDePago, pNombreTarjeta, pNumeroDeTarjeta, pNombreTitular, pCodigoSeguridad, pFecha), Conexion);
                int retorno = InsertarRol.ExecuteNonQuery();


                bool comprobarDatosCompletos = this.comprobarDatosCompletos(pFormaDePago, pNumeroDeTarjeta, pNombreTarjeta, pNombreTitular, pCodigoSeguridad);
                const string resumen = "";

                if (comprobarDatosCompletos)
                {


                    SqlCommand InsertarItem = new SqlCommand("INSERT INTO LOS_JUS.item(ite_factura,ite_monto,ite_cantidad) Values (@codigoFactura,@monto,@cantidad)", Conexion);

                    //SqlCommand InsertarFuncionalidadesXRol = new SqlCommand("INSERT INTO LOS_JUS.ROLxFUNCIONALIDADES(ROLFUN_ROL,ROLFUN_FUNCIONALIDADES) Values (@nombre,@funcionalidad)", Conexion);


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        InsertarItem.Parameters.Clear();

                        //InsertarFuncionalidadesXRol.Parameters.Clear();
                        InsertarItem.Parameters.AddWithValue("@codigoFactura", pNumeroFactura);
                        InsertarItem.Parameters.AddWithValue("@monto", Convert.ToString(row.Cells["Precio"].Value));
                        InsertarItem.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["OperacionCantidad"].Value));

                        int resultado1 = InsertarItem.ExecuteNonQuery();

                    }


                    string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                    MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBox_cantidadARendir.Clear();
                    textBox_CodigoSeguridad.Clear();
                    textBox_NombreTitular.Clear();
                    textBox_numeroTarjeta.Clear();
                    textBox_montoTotal.Clear();
                    textBox_comisiones.Clear();
                    textBox1.Clear();

                    textBox_montoTotal.Enabled = false;
                    textBox_comisiones.Enabled = true;

                    dataGridView1.Rows.Clear();

                    radioButton_Efectivo.Checked = false;
                    radioButton_Tarjeta.Checked = false;

                    radioButton_AMEX.Checked = false;
                    radioButton_MASTERCARD.Checked = false;
                    radioButton_VISA.Checked = false;

                    groupBox_tarjeta.Enabled = false;
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
