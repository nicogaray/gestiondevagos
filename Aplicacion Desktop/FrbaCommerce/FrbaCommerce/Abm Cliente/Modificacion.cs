using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Modificacion : Form
    {
        public bool desdeModificacionUsuario = false;

        public bool comprobarTipos(String telefono, String documento)
        {
            return (telefono.All(char.IsDigit) && documento.All(char.IsDigit));
        }

        public bool comprobarDatosCompletos(String nombre, String apellido, String tipoDocumento, String documento, String telefono, String direccion, String codigoPostal, String mail)
        {
            if (nombre == "" ||
                apellido == "" ||
                tipoDocumento == "" ||
                documento == "" ||
                telefono == "" ||
                direccion == "" ||
                codigoPostal == "" ||
                mail == "" )
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Modificacion()
        {
            InitializeComponent();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {

            textBox_Apellido.Clear();
            textBox_CodigoPostal.Clear();
            textBox_Direccion.Clear();
            textBox_Documento.Clear();
            textBox_Mail.Clear();
            textBox_Nombre.Clear();
            textBox_Telefono.Clear();

            DateTime fecha = DateTime.Now;
            dateTimePicker_FechaNacimiento.Value = fecha;

            radioButton_Ci.Checked = false;
            radioButton_Dni.Checked = false;
            radioButton_Lc.Checked = false;
            radioButton_Le.Checked = false;
            radioButton_Pas.Checked = false;
   
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            //Recibo los datos ingresados por el usuario
            String pNombre = textBox_Nombre.Text;
            String pApellido = textBox_Apellido.Text;
            String pDocumento = textBox_Documento.Text;
            String pTelefono = textBox_Telefono.Text;
            String pDireccion = textBox_Direccion.Text;
            String pCodigoPostal = textBox_CodigoPostal.Text;
            String pMail = textBox_Mail.Text;
            String pFecha = dateTimePicker_FechaNacimiento.Value.ToString("yyyy-MM-dd HH:mm:ss");

            //Recibo lo marcado en el radio button
            String pTipo = "";
            if (radioButton_Ci.Checked)
            {
                pTipo = radioButton_Ci.Text;
            }
            if (radioButton_Dni.Checked)
            {
                pTipo = radioButton_Dni.Text;
            }
            if (radioButton_Lc.Checked)
            {
                pTipo = radioButton_Lc.Text;
            }
            if (radioButton_Le.Checked)
            {
                pTipo = radioButton_Le.Text;
            }
            if (radioButton_Pas.Checked)
            {
                pTipo = radioButton_Pas.Text;
            }




            //int pTelefonoConvertido = Convert.ToInt32(telefono);
            //int pDocumentoConvertido = Convert.ToInt32(documento);


            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarTipos = this.comprobarTipos(pTelefono, pDocumento);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre, pApellido, pTipo, pDocumento, pTelefono, pDireccion, pCodigoPostal, pMail);
            const string resumen = "";

            if (comprobarTipos && comprobarDatosCompletos)
            {
                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void textBox_Nombre_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void textBox_Apellido_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void textBox_Documento_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void textBox_Telefono_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void textBox_Direccion_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Calle Altura Departamento Ciudad Provincia";

        }

        private void dateTimePicker1_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Seleccione la fecha correspondiente";

        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Apellido_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Documento_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Telefono_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        

        private void textBox_Direccion_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        public void Modificacion_Load(object sender, EventArgs e)
        {
            if (desdeModificacionUsuario)
            {
                button_Cancelar.Hide();
                button_Volver.Show();
            }
            else
            {
                button_Volver.Hide();
            }
        }

        public void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Abm_Cliente.ListadoSeleccionModificacion listado_modificacion = new Abm_Cliente.ListadoSeleccionModificacion();
            listado_modificacion.Show();
        }

        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de guardar";

        }

        private void button_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void button_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Volver al formulario anterior";

        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (desdeModificacionUsuario)
            {
            }
            else
            {
                Menu.Menu_Cliente menu_administrador = new Menu.Menu_Cliente();
                menu_administrador.Show();
            }
        }
    }
}
