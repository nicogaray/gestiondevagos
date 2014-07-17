using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Modificacion : Form
    {
        public bool desdeModificacionUsuario = false;

        public Int32 idSeleccionado = -1;
        public String razonSocialSeleccionada = "";
        public String cuitSeleccionado = "";
        public String contactoSeleccionado= "";
        public String telefonoSeleccionado= "";
        public String direccionSeleccionada = "";
        public String codigoPostalSeleccionado = "";
        public String mailSeleccionado = "";
        public DateTime fechaCreacionSeleccionada;

        public bool comprobarTipos(String telefono)
        {
            return (telefono.All(char.IsDigit));
        }

        public bool comprobarDatosCompletos(String razonSocial, String cuit, String nombreContacto, String telefono, String direccion, String codigoPostal, String mail)
        {
            if (razonSocial == "" ||
                cuit == "" ||
                nombreContacto == "" ||
                telefono == "" ||
                direccion == "" ||
                codigoPostal == "" ||
                mail == "")
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

            Int64 pTelefonoConvertido = Convert.ToInt64(pTelefono);
            bool cuitOriginal = false;
            bool telefonoOriginal = false;
            bool razonSocialOrigianal = false;

            //Veo que el cuil, el telefono y el tipo y numero de documento sean unicos
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand comprobarCuit = new SqlCommand(string.Format("SELECT emp_id FROM LOS_JUS.empresa where emp_cuit = '{0}' and emp_id <> '{1}'", pCuit,idSeleccionado), Conexion);

                SqlDataReader reader = comprobarCuit.ExecuteReader();
                if (reader.HasRows)
                {
                    cuitOriginal = false;
                }
                else
                {
                    cuitOriginal = true;
                }
                reader.Close();

                SqlCommand comprobarTelefono = new SqlCommand(string.Format("SELECT emp_id FROM LOS_JUS.empresa where emp_telefono = '{0}' and emp_id <> '{1}'", pTelefonoConvertido,idSeleccionado), Conexion);

                SqlDataReader reader2 = comprobarTelefono.ExecuteReader();
                if (reader2.HasRows)
                {
                    telefonoOriginal = false;
                }
                else
                {
                    telefonoOriginal = true;
                }
                reader2.Close();

                SqlCommand comprobarRazonSocial = new SqlCommand(string.Format("SELECT emp_id FROM LOS_JUS.empresa where emp_razon_social = '{0}' and emp_id <> '{1}'", pRazonSocial,idSeleccionado), Conexion);

                SqlDataReader reader3 = comprobarRazonSocial.ExecuteReader();
                if (reader3.HasRows)
                {
                    razonSocialOrigianal = false;
                }
                else
                {
                    razonSocialOrigianal = true;
                }
                reader3.Close();


            }

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarTipos = this.comprobarTipos(pTelefono);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pRazonSocial, pCuit, pNombreContacto, pTelefono, pDireccion, pCodigoPostal, pMail);
            const string resumen = "";

            if (comprobarTipos && comprobarDatosCompletos && cuitOriginal && razonSocialOrigianal && telefonoOriginal)
            {

                //inserto los datos en la DB
                SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion2)
                {

                    SqlCommand InsertarCliente = new SqlCommand(string.Format("UPDATE LOS_JUS.EMPRESA SET emp_id ='{0}',emp_razon_social ='{1}',emp_cuit='{2}',emp_contacto='{3}',emp_fecha_creacion='{4}',emp_mail='{5}',emp_telefono='{6}',emp_direccion='{7}',emp_cod_postal='{8}' WHERE emp_id = '{9}'",
                    idSeleccionado,pRazonSocial, pCuit, pNombreContacto, pFecha, pMail, pTelefonoConvertido, pDireccion, pCodigoPostal, idSeleccionado), Conexion2);
                    int resultado = InsertarCliente.ExecuteNonQuery();
                }

                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                textBox_Cuit.Clear();
                textBox_CodigoPostal.Clear();
                textBox_Direccion.Clear();
                textBox_Mail.Clear();
                textBox_Telefono.Clear();
                textBox_NombreContacto.Clear();
                textBox_RazonSocial.Clear();

                DateTime fecha = DateTime.Now;
                dateTimePicker_FechaNacimiento.Value = fecha;

                this.Close();
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
                if (cuitOriginal == false)
                {
                    const string mensaje_Rechazo = "Ha ingresado un Cuit que ya se encuentra en la base de datos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (telefonoOriginal == false)
                {
                    const string mensaje_Rechazo = "Ha ingresado un telefono que ya se encuentra en la base de datos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (razonSocialOrigianal == false)
                {
                    const string mensaje_Rechazo = "Ha ingresado una Razon Social ya se encuentra en la base de datos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Cuit.Clear();
            textBox_CodigoPostal.Clear();
            textBox_Direccion.Clear();
            textBox_Mail.Clear();
            textBox_Telefono.Clear();
            textBox_NombreContacto.Clear();
            textBox_RazonSocial.Clear();

            DateTime fecha = DateTime.Now;
            dateTimePicker_FechaNacimiento.Value = fecha;
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
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

        private void Modificacion_Load(object sender, EventArgs e)
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

            textBox_CodigoPostal.Text = codigoPostalSeleccionado;
            textBox_Cuit.Text = cuitSeleccionado;
            textBox_Direccion.Text = direccionSeleccionada;
            textBox_Mail.Text = mailSeleccionado;
            textBox_NombreContacto.Text = contactoSeleccionado;
            textBox_RazonSocial.Text = razonSocialSeleccionada;
            textBox_Telefono.Text = telefonoSeleccionado;
            dateTimePicker_FechaNacimiento.Value = fechaCreacionSeleccionada;





        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (desdeModificacionUsuario)
            {
            }
            else
            {
                Menu.Menu_Empresa menu_administrador = new Menu.Menu_Empresa();
                menu_administrador.Show();
            }

         
        }
    }
}

       
