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

        public bool comprobarDatosCompletos(String nombre, String apellido, String tipoDocumento, String documento, String telefono, String direccion, String codigoPostal, String mail,String usuario, String username, String id, String cuil)
        {
            if (nombre == "" ||
                apellido == "" ||
                tipoDocumento == "" ||
                documento == "" ||
                telefono == "" ||
                direccion == "" ||
                codigoPostal == "" ||
                mail == "" ||
                usuario == "" ||
                (usuario == "Existente" && id == "") ||
                cuil == "")
                                     
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

            String pUsuario = "";
            if (radioButton_UsuarioNuevo.Checked)
            {
                pUsuario = "Nuevo";
            }
            if(radioButton_UsuarioExistente.Checked)
            {
                pUsuario = "Existente";
            }

            String pUsername = textBox_Username.Text;
            String pIdUsuario = textBox_IdUsuario.Text;

            Int32 pId = 0;
           
             //Defino variables y convierto datos
            Int64 pTelefonoConvertido = Convert.ToInt64(pTelefono);
            Int32 pDocumentoConvertido = Convert.ToInt32(pDocumento);

            bool cuilOriginal = false;
            bool telefonoOriginal = false;
            bool documentoOrigianal = false;

            //Veo que el cuil, el telefono y el tipo y numero de documento sean unicos
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand comprobarCuil = new SqlCommand(string.Format("SELECT cli_id FROM LOS_JUS.cliente where cli_cuil = '{0}'",pCuil), Conexion);

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

                SqlCommand comprobarTelefono = new SqlCommand(string.Format("SELECT cli_id FROM LOS_JUS.cliente where cli_telefono = '{0}'", pTelefonoConvertido), Conexion);

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

                SqlCommand comprobarDocumento = new SqlCommand(string.Format("SELECT cli_id FROM LOS_JUS.cliente where cli_dni = '{0}' and cli_tipo_dni = '{1}'", pDocumentoConvertido,pTipo), Conexion);

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
            bool comprobarTipos = this.comprobarTipos(pTelefono,pDocumento);
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre, pApellido, pTipo, pDocumento, pTelefono, pDireccion, pCodigoPostal, pMail, pUsuario,pUsername,pIdUsuario,pCuil);
            const string resumen = "";
        
           if(comprobarTipos && comprobarDatosCompletos && cuilOriginal && telefonoOriginal && documentoOrigianal)           
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
                        SqlCommand InsertarUsuario = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Usuario(USU_USERNAME,USU_PASSWORD) Values ('{0}','{1}')",pId,pId), Conexion2);
                        int retorno = InsertarUsuario.ExecuteNonQuery();

                        String pRetorno = Convert.ToString(retorno);

                     
                            SqlCommand InsertarCliente = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Cliente(cli_id, cli_nombre,cli_apellido,cli_dni,cli_tipo_dni,cli_fecha_nacimiento,cli_mail,cli_telefono,cli_direccion,cli_cod_postal,cli_cuil) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                                pId, pNombre, pApellido, pDocumentoConvertido, pTipo, pFecha, pMail, pTelefonoConvertido, pDireccion, pCodigoPostal,pCuil), Conexion2);
                            int retorno2 = InsertarCliente.ExecuteNonQuery();}
                        catch { MessageBox.Show("Algunos datos ingresados ya se encuentran repetidos en la base de datos", resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); };

                          
                    }
                    if (pUsuario == "Existente")
                    {
                        pId = Convert.ToInt32(textBox_IdUsuario.Text);

                        SqlCommand InsertarCliente = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Cliente(cli_id, cli_nombre,cli_apellido,cli_dni,cli_tipo_dni,cli_fecha_nacimiento,cli_mail,cli_telefono,cli_direccion,cli_cod_postal,cli_cuil) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                                                                                                pId, pNombre, pApellido, pDocumentoConvertido, pTipo, pFecha, pMail, pTelefonoConvertido, pDireccion, pCodigoPostal,pCuil), Conexion2);
                        int retorno6 = InsertarCliente.ExecuteNonQuery();

                    }

                    string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                    MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
                    radioButton_UsuarioExistente.Checked = false;
                    radioButton_UsuarioNuevo.Checked = false;

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
                  
        }
       
      
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_SeleccionarUsuario_Click(object sender, EventArgs e)
        {

            using (var form = new Abm_Cliente.SeleccionUsuario())
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
                Int32 pIdSeleccionadoConvertido = Convert.ToInt32(IdSeleccionado);

                SqlCommand ObtenerUsername = new SqlCommand(string.Format("SELECT USU_USERNAME FROM LOS_JUS.USUARIO WHERE USU_ID = '{0}'",pIdSeleccionadoConvertido),Conexion);
                SqlDataReader reader = ObtenerUsername.ExecuteReader();

                while (reader.Read())
                {
                    String pUsernameSeleccionado = reader.GetString(0);

                    textBox_Username.Text = pUsernameSeleccionado;
                }

            }
        }
        private void radioButton_UsuarioExistente_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_SeleccionarUsuario.Show();
        }

        private void radioButton_UsuarioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_SeleccionarUsuario.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
            
        }

        public void textBox_IdUsuario_TextChanged(object sender, EventArgs e)
        {
        }

       

       
       

    }
}
