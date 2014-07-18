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
    public partial class Modificacion : Form
    {
        public bool desdeModificacionUsuario = false;

        //creo variables locales para mostrar los valores
        public Int32 idSeleccionado = -1;
        public String nombreSeleccionado = "";
        public String apellidoSeleccionado = "";
        public String documentoSeleccionado;
        public String tipoDocumentoSeleccionado = "";
        public DateTime fechaSeleccionada;
        public String mailSeleccionado = "";
        public String direccionSeleccionada = "";
        public String codigoPostalSeleccionado = "";
        public String cuilSeleccionado = "";
        public String telefonoSeleccionado;


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
            textBox_Cuil.Clear();

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
            String pCuil = textBox_Cuil.Text;
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

            //Defino variables y convierto datos
            Int64 pTelefonoConvertido = Convert.ToInt64(pTelefono);
            Int64 pDocumentoConvertido = Convert.ToInt64(pDocumento);
            bool cuilOriginal = false;
            bool telefonoOriginal = false;
            bool documentoOrigianal = false;
            //Veo que el cuil, el telefono y el tipo y numero de documento sean unicos
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand comprobarCuil = new SqlCommand(string.Format("SELECT cli_id FROM LOS_JUS.cliente where cli_cuil = '{0}' and cli_id <> '{1}'", pCuil,idSeleccionado), Conexion);

                SqlDataReader reader = comprobarCuil.ExecuteReader();
                if (reader.HasRows)
                {
                    cuilOriginal = false;
                }
                else
                {
                    cuilOriginal = true;
                }
                reader.Close();

                SqlCommand comprobarTelefono = new SqlCommand(string.Format("SELECT cli_id FROM LOS_JUS.cliente where cli_telefono = '{0}' and cli_id <> '{1}'", pTelefonoConvertido,idSeleccionado), Conexion);

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

                SqlCommand comprobarDocumento = new SqlCommand(string.Format("SELECT cli_id FROM LOS_JUS.cliente where cli_dni = '{0}' and cli_tipo_dni = '{1}' and cli_id <> '{2}'", pDocumentoConvertido, pTipo,idSeleccionado), Conexion);

                SqlDataReader reader3 = comprobarDocumento.ExecuteReader();
                if (reader3.HasRows)
                {
                    documentoOrigianal = false;
                }
                else
                {
                    documentoOrigianal = true;
                }
                reader3.Close();


            }


            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarTipos = this.comprobarTipos(pTelefono, pDocumento);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre, pApellido, pTipo, pDocumento, pTelefono, pDireccion, pCodigoPostal, pMail);
            const string resumen = "";

            if (comprobarTipos && comprobarDatosCompletos && cuilOriginal && telefonoOriginal && documentoOrigianal)
            {


                //inserto los datos en la DB
                SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                    {

                        SqlCommand InsertarCliente = new SqlCommand(string.Format("UPDATE LOS_JUS.Cliente SET cli_nombre ='{0}',cli_apellido ='{1}',cli_dni='{2}',cli_tipo_dni='{3}',cli_fecha_nacimiento='{4}',cli_mail='{5}',cli_telefono='{6}',cli_direccion='{7}',cli_cod_postal='{8}' WHERE cli_id = '{9}'",
                        pNombre, pApellido, pDocumentoConvertido, pTipo, pFecha, pMail, pTelefonoConvertido, pDireccion, pCodigoPostal,idSeleccionado), Conexion2);
                        int resultado = InsertarCliente.ExecuteNonQuery();
                    }

                    string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                    MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                if (cuilOriginal == false)
                {
                    const string mensaje_Rechazo = "Ha ingresado un Cuil que ya se encuentra en la base de datos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (telefonoOriginal == false)
                {
                    const string mensaje_Rechazo = "Ha ingresado un telefono que ya se encuentra en la base de datos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (documentoOrigianal == false)
                {
                    const string mensaje_Rechazo = "Ha ingresado un tipo y numero de documento que ya se encuentra en la base de datos.\nLos datos no pudieron ser guardados.";

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
                button_Habilitar.Hide();

            }
            else
            {
                
                button_Volver.Hide();
            }

            //imprimo en pantalla los valores seleccionados

            textBox_Nombre.Text = nombreSeleccionado;
            textBox_Apellido.Text = apellidoSeleccionado;
            textBox_Cuil.Text = cuilSeleccionado;

            // selecciono el radio button correcto
            if (tipoDocumentoSeleccionado == "CI")
            {
                radioButton_Ci.Checked = true;
            }
            if (tipoDocumentoSeleccionado == "DNI")
            {
                radioButton_Dni.Checked = true;
            }
            if (tipoDocumentoSeleccionado == "LC")
            {
                radioButton_Lc.Checked = true;
            }
            if (tipoDocumentoSeleccionado == "LE")
            {
                radioButton_Le.Checked = true;
            }
            if (tipoDocumentoSeleccionado == "PAS")
            {
                radioButton_Pas.Checked = true;
            }

            textBox_Documento.Text = Convert.ToString(documentoSeleccionado);
            textBox_Telefono.Text = Convert.ToString(telefonoSeleccionado);
            textBox_Direccion.Text = direccionSeleccionada;
            textBox_CodigoPostal.Text = codigoPostalSeleccionado;
            textBox_Mail.Text = mailSeleccionado;
            dateTimePicker_FechaNacimiento.Value = fechaSeleccionada;

        }

        public void button_Cancelar_Click(object sender, EventArgs e)
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

        private void button_Habilitar_Click(object sender, EventArgs e)
        {
            Abm_Cliente.HabilitarCliente cli = new Abm_Cliente.HabilitarCliente();
            cli.Show();
        }
    }
}
