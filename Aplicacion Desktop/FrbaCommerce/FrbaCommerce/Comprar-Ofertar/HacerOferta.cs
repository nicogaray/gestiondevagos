using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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


            if (oferta.All(char.IsDigit) && oferta != "")
           {
           ofertaConvertida = Convert.ToDecimal(oferta);
           valorConvertido = Convert.ToDecimal(valorInicialSeleccionado);
           }

           if (oferta.All(char.IsDigit) && oferta != "" && ofertaConvertida >= valorConvertido)
           {



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
