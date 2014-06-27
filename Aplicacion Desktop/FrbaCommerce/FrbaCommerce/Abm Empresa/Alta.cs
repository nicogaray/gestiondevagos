using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Alta : Form
    {
        public bool comprobarTipos(String telefono)
        {
            return (telefono.All(char.IsDigit));
        }

        public bool comprobarDatosCompletos(String razonSocial, String cuit, String nombreContacto, String telefono, String direccion, String codigoPostal, String mail, String usuario, String username, String id)
        {
            if (razonSocial == "" ||
                cuit == "" ||
                nombreContacto == "" ||
                telefono == "" ||
                direccion == "" ||
                codigoPostal == "" ||
                mail == "" ||
                usuario == "")
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

        private void label_Documento_Click(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_CodigoPostal.Clear();
            textBox_Cuit.Clear();
            textBox_Direccion.Clear();
            textBox_Mail.Clear();
            textBox_RazonSocial.Clear();
            textBox_NombreContacto.Clear();
            textBox_Telefono.Clear();
            DateTime fecha = DateTime.Now;
            dateTimePicker_FechaNacimiento.Value = fecha;
        }

        private void textBox_RazonSocial_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";
        }

        private void textBox_NombreContacto_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void textBox_Telefono_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void textBox_Direccion_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Calle Altura Ciudad Provincia";

        }

        private void textBox_RazonSocial_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_NombreContacto_MouseLeave(object sender, EventArgs e)
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

        private void textBox_Dia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Dia_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Mes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Mes_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Anio_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            //Recibo los datos ingresados por el usuario
            String pRazonSocial = textBox_RazonSocial.Text;
            String pCuit = textBox_Cuit.Text;
            String pNombreContacto = textBox_NombreContacto.Text;
            String pTelefono = textBox_Telefono.Text;
            String pDireccion = textBox_Direccion.Text;
            String pCodigoPostal = textBox_CodigoPostal.Text;
            String pMail = textBox_Mail.Text;
            String pFecha = dateTimePicker_FechaNacimiento.Value.ToString("yyyy-MM-dd HH:mm:ss");

            String pUsuario = "";
            if (radioButton_UsuarioNuevo.Checked)
            {
                pUsuario = "Nuevo";
            }
            if (radioButton_UsuarioExistente.Checked)
            {
                pUsuario = "Existente";
            }

            String pUsername = label_Username.Text;
            String pIdUsuario = label_IdUsuario.Text;


            //int pTelefonoConvertido = Convert.ToInt32(telefono);


            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarTipos = this.comprobarTipos(pTelefono);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pRazonSocial, pCuit, pNombreContacto, pTelefono, pDireccion, pCodigoPostal, pMail, pUsuario, pUsername, pIdUsuario);
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

        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de gurdar";

        }

        private void button_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_RazonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Load(object sender, EventArgs e)
        {
            groupBox_SeleccionarUsuario.Hide();
            textBox_IdUsuario.Enabled = false;
            textBox_Username.Enabled = false;

        }

        private void radioButton_UsuarioExistente_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_SeleccionarUsuario.Show();

        }

        private void radioButton_UsuarioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_SeleccionarUsuario.Hide();

        }

        private void button_SeleccionarUsuario_Click(object sender, EventArgs e)
        {
            Abm_Empresa.SeleccionUsuario seleccion = new Abm_Empresa.SeleccionUsuario();
            seleccion.Show();
        }


    

       

    }
}
