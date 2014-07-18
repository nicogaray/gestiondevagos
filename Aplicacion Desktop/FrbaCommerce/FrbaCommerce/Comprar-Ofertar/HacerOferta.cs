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
    public partial class HacerOferta : Form
    {
        public bool ReturnId { get; set; }

        public String codigoPublicacionSeleccionada;
        public String valorInicialSeleccionado;
        public String habilitacionPreguntas;


        public HacerOferta()
        {
            InitializeComponent();
        }

        private void HacerOferta_Load(object sender, EventArgs e)
        {
            if (habilitacionPreguntas == "0")
            {
                groupBox1.Enabled = false;
            }
            

            textBox_ValorInicial.Enabled = false;
            textBox_ValorInicial.Text = valorInicialSeleccionado;
            textBox_Fecha.Enabled = false;
            textBox_Fecha.Text = Convert.ToString(DateTime.Now);
           

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
           String oferta = textBox_Oferta.Text;
           decimal ofertaConvertida=0;
            decimal valorConvertido=0;
            String fecha = DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss");



            if (oferta.All(char.IsDigit) && oferta != "")
           {
           ofertaConvertida = Convert.ToDecimal(oferta);
           valorConvertido = Convert.ToDecimal(valorInicialSeleccionado);
           }

           if (oferta.All(char.IsDigit) && oferta != "" && ofertaConvertida >= valorConvertido)
           {

               //CORREGIR INSERSIONES
               SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
               using (Conexion)
               {

                   //FALTA INGRESAR EL ID DE CLIENTE DE LA SESION
                   string sql = string.Format("Insert into LOS_JUS.operacion(OPE_PUBLICACION,OPE_TIPO,OPE_CLIENTE,OPE_OFERTA,OPE_CANTIDAD,OPE_FECHA) values({0},'{1}',{2},{3},null,'{4}')"
                                                                               , codigoPublicacionSeleccionada, 'C', 2, oferta, fecha);
                   SqlCommand InsertarRol = new SqlCommand(sql, Conexion);

                   int retorno = InsertarRol.ExecuteNonQuery();

                   //string sql2 = string.Format("Update LOS_JUS.compra set com_stock = '{0}' where com_publicacion = '{1}'"
                   //                                        , stockFinal, codigoPublicacionSeleccionada);
                   //SqlCommand UpdateStock = new SqlCommand(sql2, Conexion);
                   //int retorno2 = UpdateStock.ExecuteNonQuery();


               }



               string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
               MessageBox.Show(mensaje_Aceptacion, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               this.ReturnId = true;
               this.DialogResult = DialogResult.OK;
               this.Close();

           }
           else
           {
               if (oferta.All(char.IsDigit) == false)
               {
                   const string mensaje_Rechazo = "La oferta solo puede ser un valor numerico.\nLos datos no pudieron ser guardados.";

                   MessageBox.Show(mensaje_Rechazo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               if (oferta == "")
               {
                   const string mensaje_Rechazo = "El campo Oferta esta vacio.\nLos datos no pudieron ser guardados.";

                   MessageBox.Show(mensaje_Rechazo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               if (ofertaConvertida < valorConvertido)
               {
                   const string mensaje_Rechazo = "El campo Oferta es menor a el valor inicial minimo de la subasta.\nLos datos no pudieron ser guardados.";

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
            preguntar.Show();
        }
    }
}
