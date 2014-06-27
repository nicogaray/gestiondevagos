using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Alta : Form
    {
        public bool comprobarTipos(String telefono, String documento)
        {
            return (telefono.All(char.IsDigit) && documento.All(char.IsDigit));
        }

        public bool comprobarDatosCompletos(String nombre, String apellido, String tipoDocumento, String documento, String telefono, String direccion, String codigoPostal, String mail,String usuario, String username, String id)
        {
            if (nombre == "" ||
                apellido == "" ||
                tipoDocumento == "" ||
                documento == "" ||
                telefono == "" ||
                direccion == "" ||
                codigoPostal == "" ||
                mail == "" ||
                usuario == "" )
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
        
        


        private void textBox_Nombre_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";

        }

        private void textBox_Nombre_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Apellido_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Hasta 255 caracteres";
        }

        private void textBox_Apellido_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";
        }

        private void textBox_Documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Documento_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void textBox_Documento_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Telefono_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Solo se acepta un valor numerico";

        }

        private void textBox_Telefono_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Direccion_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Direccion_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Calle Altura Departamento Ciudad Provincia";

        }
 

        private void button2_Click(object sender, EventArgs e)
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
            radioButton_UsuarioExistente.Checked = false;
            radioButton_UsuarioNuevo.Checked = false;

            groupBox_SeleccionarUsuario.Hide();
            textBox_Username.Clear();
            textBox_IdUsuario.Clear();
   
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

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

            String pUsuario = "";
            if (radioButton_UsuarioNuevo.Checked)
            {
                pUsuario = "Nuevo";
            }
            if(radioButton_UsuarioExistente.Checked)
            {
                pUsuario = "Existente";
            }

            String pUsername = label_Username.Text;
            String pIdUsuario = label_IdUsuario.Text;


            //int pTelefonoConvertido = Convert.ToInt32(telefono);
            //int pDocumentoConvertido = Convert.ToInt32(documento);


    //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarTipos = this.comprobarTipos(pTelefono,pDocumento);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre, pApellido, pTipo, pDocumento, pTelefono, pDireccion, pCodigoPostal, pMail, pUsuario,pUsername,pIdUsuario);
            const string resumen = "";
        
           if(comprobarTipos && comprobarDatosCompletos)           
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
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de guardar";
        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void dateTimePicker1_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Seleccione la fecha correspondiente";

        }

        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void dateTimePicker_FechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Load(object sender, EventArgs e)
        {
            groupBox_SeleccionarUsuario.Hide();
            textBox_IdUsuario.Enabled = false;
            textBox_Username.Enabled = false;

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_SeleccionarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_UsuarioExistente_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_SeleccionarUsuario.Show();
        }

        private void radioButton_UsuarioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_SeleccionarUsuario.Hide();
        }

       
       

    }
}
