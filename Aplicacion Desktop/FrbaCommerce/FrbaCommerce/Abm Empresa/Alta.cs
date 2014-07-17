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
                usuario == "" ||
               (usuario == "Existente" && id == ""))
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

            String pUsername = textBox_Username.Text;
            String pIdUsuario = textBox_IdUsuario.Text;


            Int32 pId = 0;
            //Defino variables y convierto datos
            Int64 pTelefonoConvertido = Convert.ToInt64(pTelefono);
            bool cuitOriginal = false;
            bool telefonoOriginal = false;
            bool razonSocialOrigianal = false;

            //Veo que el cuil, el telefono y el tipo y numero de documento sean unicos
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand comprobarCuit = new SqlCommand(string.Format("SELECT emp_id FROM LOS_JUS.empresa where emp_cuit = '{0}'", pCuit), Conexion);

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

                SqlCommand comprobarTelefono = new SqlCommand(string.Format("SELECT emp_id FROM LOS_JUS.empresa where emp_telefono = '{0}'", pTelefonoConvertido), Conexion);

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

                SqlCommand comprobarRazonSocial = new SqlCommand(string.Format("SELECT emp_id FROM LOS_JUS.empresa where emp_razon_social = '{0}'", pRazonSocial), Conexion);

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
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pRazonSocial, pCuit, pNombreContacto, pTelefono, pDireccion, pCodigoPostal, pMail, pUsuario, pUsername, pIdUsuario);
            const string resumen = "";

            if (comprobarTipos && comprobarDatosCompletos && cuitOriginal && razonSocialOrigianal && telefonoOriginal)
            {

                //inserto los datos en la DB
                SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion2)
                {
                    // veo si el usuario es nuevo y en ese caso, inserto un nuevo usuario. Obtengo el id de ese usuario creado
                    if (pUsuario == "Nuevo")
                    {

                        SqlCommand ObtenerIdUsuario = new SqlCommand(string.Format("SELECT top 1 usu_id FROM LOS_JUS.usuario ORDER BY usu_id desc"), Conexion2);

                        SqlDataReader reader = ObtenerIdUsuario.ExecuteReader();
                        while (reader.Read())
                        {
                            Int32 pIdAnterior = reader.GetInt32(0);
                            pId = pIdAnterior + 1;

                        }
                        reader.Close();
                        try
                        {
                            SqlCommand InsertarUsuario = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Usuario(USU_USERNAME,USU_PASSWORD) Values ('{0}','{1}')", pId, pId), Conexion2);
                            int retorno = InsertarUsuario.ExecuteNonQuery();

                            String pRetorno = Convert.ToString(retorno);


                            SqlCommand InsertarCliente = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Empresa(emp_id,emp_razon_social,emp_cuit,emp_contacto,emp_fecha_creacion,emp_mail,emp_telefono,emp_direccion,emp_cod_postal) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                                                pId, pRazonSocial, pCuit,pNombreContacto, pFecha, pMail, pTelefonoConvertido, pDireccion, pCodigoPostal), Conexion2);
                            int retorno2 = InsertarCliente.ExecuteNonQuery();
                        }
                        catch { MessageBox.Show("Algunos datos ingresados ya se encuentran repetidos en la base de datos", resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); };


                    }
                    if (pUsuario == "Existente")
                    {
                        pId = Convert.ToInt32(textBox_IdUsuario.Text);

                        SqlCommand InsertarCliente = new SqlCommand(string.Format("INSERT INTO LOS_JUS.EMPRESAemp_id,emp_razon_social,emp_cuit,emp_contacto,emp_fecha_creacion,emp_mail,emp_telefono,emp_direccion,emp_cod_postal) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                        pId, pRazonSocial, pCuit, pNombreContacto, pFecha, pMail, pTelefonoConvertido, pDireccion, pCodigoPostal), Conexion2);


                    }

                    string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                    MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    textBox_CodigoPostal.Clear();
                    textBox_Cuit.Clear();
                    textBox_Direccion.Clear();
                    textBox_Mail.Clear();
                    textBox_RazonSocial.Clear();
                    textBox_NombreContacto.Clear();
                    textBox_Telefono.Clear();
                    DateTime fecha = DateTime.Now;
                    dateTimePicker_FechaNacimiento.Value = fecha;

                    groupBox_SeleccionarUsuario.Hide();
                    textBox_Username.Clear();
                    textBox_IdUsuario.Clear();


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

            using (var form = new Abm_Empresa.SeleccionUsuario())
            {

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.ReturnId;

                    this.textBox_IdUsuario.Text = val;

                }
            }

            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                String IdSeleccionado = this.textBox_IdUsuario.Text;
               // Int32 pIdSeleccionadoConvertido = Convert.ToInt32(IdSeleccionado);
                Int16 pIdSeleccionadoConvertido = Convert.ToInt16(IdSeleccionado);


                SqlCommand ObtenerUsername = new SqlCommand(string.Format("SELECT USU_USERNAME FROM LOS_JUS.USUARIO WHERE USU_ID = '{0}'", pIdSeleccionadoConvertido), Conexion);
                SqlDataReader reader = ObtenerUsername.ExecuteReader();

                while (reader.Read())
                {
                    String pUsernameSeleccionado = reader.GetString(0);

                    textBox_Username.Text = pUsernameSeleccionado;
                }

            }

        }

        private void groupBox_SeleccionarUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }


    

       

    }
}
