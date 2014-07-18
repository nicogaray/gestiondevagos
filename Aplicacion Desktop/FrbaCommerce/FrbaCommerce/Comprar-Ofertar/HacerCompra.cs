using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class HacerCompra : Form
    {
        public bool ReturnId { get; set; }

        public String codigoPublicacionSeleccionada;
        public String valorInicialSeleccionado;
        public String habilitacionPreguntas;
        public String idEmpresaSeleccionado;
        public String stockDisponibleSeleccionado;

        public HacerCompra()
        {
            InitializeComponent();
        }

        private void HacerCompra_Load(object sender, EventArgs e)
        {
            if (habilitacionPreguntas == "0")
            {
                groupBox1.Enabled = false;
            }


            textBox_ValorInicial.Enabled = false;
            textBox_ValorInicial.Text = valorInicialSeleccionado;
            textBox_Fecha.Enabled = false;
            textBox_Fecha.Text = Convert.ToString(DateTime.Now);
            textBox_stock.Enabled = false;
            textBox_stock.Text = stockDisponibleSeleccionado;

            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand ObtenerIdUsuario = new SqlCommand(string.Format("SELECT emp_id,emp_razon_social,emp_cuit,emp_contacto,emp_telefono,emp_direccion,emp_cod_postal FROM LOS_JUS.empresa where emp_id = '{0}'",idEmpresaSeleccionado), Conexion);

                SqlDataReader reader = ObtenerIdUsuario.ExecuteReader();
                while (reader.Read())
                {
                    Int32 pColumna0 = reader.GetInt32(0);//emp_id
                    String pColumna1 = reader.GetString(1);//emp_razon_social
                    String pColumna2 = reader.GetString(2);//emp_cuit
                    String pColumna3 = reader.GetString(3);//emp_contacto
                    Decimal pColumna4 = reader.GetDecimal(4);//emp_telefono
                    String pColumna5 = reader.GetString(5);//emp_direccion
                    String pColumna6 = reader.GetString(6);//emp_cod_postal

                    dataGridView1.Rows.Add(pColumna0, pColumna1, pColumna2, pColumna3, pColumna4, pColumna5, pColumna6);


                }
                reader.Close();

            }

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            String cantidad = textBox_Oferta.Text;
            String fecha = DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss");
            //DateTime fechaConvertida = Convert.ToDateTime(fecha);
            //String fechaFinal = Convert.ToString(fechaConvertida,"yyyy-MM-dd HH:mm:ss");
            
            decimal cantidadConvertida = 0;
            decimal stockConvertido = 0;

            if (cantidad.All(char.IsDigit) && cantidad != "")
            {
                cantidadConvertida = Convert.ToDecimal(cantidad);
                stockConvertido = Convert.ToDecimal(stockDisponibleSeleccionado);
            }

            if (cantidad.All(char.IsDigit) && cantidad != "" && stockConvertido >= cantidadConvertida)
            {
                string stockFinal = Convert.ToString(stockConvertido-cantidadConvertida);

                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {

                    //FALTA INGRESAR EL ID DE CLIENTE DE LA SESION
                    string sql = string.Format("Insert into LOS_JUS.operacion(OPE_PUBLICACION,OPE_TIPO,OPE_CLIENTE,OPE_OFERTA,OPE_CANTIDAD,OPE_FECHA) values({0},'{1}',{2},null,{3},'{4}')"
                                                                                , codigoPublicacionSeleccionada, 'C', 2, cantidad, fecha);
                    SqlCommand InsertarRol = new SqlCommand(sql, Conexion);

                    int retorno = InsertarRol.ExecuteNonQuery();

                    string sql2 = string.Format("Update LOS_JUS.compra set com_stock = '{0}' where com_publicacion = '{1}'"
                                                            ,stockFinal, codigoPublicacionSeleccionada);
                    SqlCommand UpdateStock = new SqlCommand(sql2, Conexion);
                    int retorno2 = UpdateStock.ExecuteNonQuery();

   



                }


                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.ReturnId = true;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                if (cantidad.All(char.IsDigit) == false)
                {
                    const string mensaje_Rechazo = "La cantidad solo puede ser un valor numerico.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (cantidad == "")
                {
                    const string mensaje_Rechazo = "El campo Cantidad esta vacio.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (stockConvertido < cantidadConvertida)
                {
                    const string mensaje_Rechazo = "No hay suficiente stock de este producto.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
               
            }

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Oferta.Clear();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ir_Click(object sender, EventArgs e)
        {
            Gestion_de_Preguntas.Hacer_Preguntas preguntar = new Gestion_de_Preguntas.Hacer_Preguntas();
            preguntar.publicacion = codigoPublicacionSeleccionada;
            preguntar.Show();
        }
    }
}
