using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace FrbaCommerce.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        
        public string Password { get; set; }
        
        public Boolean isValidPassword(string password)
        {
            string hashedPassword = hashPassword(password);
            return this.Password.Equals(hashedPassword);
        }

        private string hashPassword(string password)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = SHA256.Create().ComputeHash(data);

            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Contrasenia_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            const string mensaje = "¿Está seguro que desea cerrar el sistema?";   
            const string resumen = "Cerrando el sistema";
            
            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
               Application.Exit();
            }
           
        }

        private void formaLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void ABMLogin_Load(object sender, EventArgs e)
        {

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {

            String pUsername = textBox_Usuario.Text;
            String pContrasenia = textBox_Contrasenia.Text;
            String contraseñaGuardada = null; 
            Int32 id = 0;
            Int32 intentos = 0;

            SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion2)
            {
                SqlCommand EliminoSesionAnterior = new SqlCommand(string.Format("DELETE FROM LOS_JUS.Sesion"), Conexion2);
                int retorno2 = EliminoSesionAnterior.ExecuteNonQuery();

                SqlCommand ObtenerContraseña = new SqlCommand(string.Format("SELECT usu_id,usu_password,usu_intentos FROM LOS_JUS.usuario where usu_username = '{0}' and usu_habilitado = 1", pUsername), Conexion2);

                SqlDataReader reader = ObtenerContraseña.ExecuteReader();

                
                while (reader.Read())
                {
                    id=reader.GetInt32(0);
                    contraseñaGuardada = reader.GetString(1);
                    intentos = reader.GetInt32(2);

                }


                String hashPasswordIngresado = hashPassword(pContrasenia);


                if (contraseñaGuardada == hashPasswordIngresado)
                {
                    SqlCommand InsertarSesion = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Sesion(ses_username,ses_id) Values ('{0}','{1}')", pUsername,id), Conexion2);
                    int retorno = InsertarSesion.ExecuteNonQuery();

                    SqlCommand ReinicioContador = new SqlCommand(string.Format("UPDATE LOS_JUS.USUARIO SET USU_INTENTOS = 0 WHERE USU_USERNAME = '{0}'", pUsername), Conexion2);
                    int retorno3 = ReinicioContador.ExecuteNonQuery();

                    if (hashPasswordIngresado == "8623f73bbb01f6c2eb02a97f652301f6a59a1be8c75da5266bc3475c9e1e569d")
                    {

                        SqlCommand PrimerIngreso = new SqlCommand(string.Format("UPDATE LOS_JUS.sesion SET SES_PRIMERA_VEZ= 1 WHERE ses_USERNAME = '{0}'", pUsername), Conexion2);
                        int retorno4 = PrimerIngreso.ExecuteNonQuery();

                    }
                    string mensaje_Aceptacion = "Bienvenido a FRBA-Commerce";
                    MessageBox.Show(mensaje_Aceptacion, "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Menu.Menu_Usuario menu_usuario = new Menu.Menu_Usuario();
                    menu_usuario.Show();
                    this.Hide();
                    
                }
                else
                {
                    string mensaje_Aceptacion = "Error en los datos ingresados";
                    MessageBox.Show(mensaje_Aceptacion, "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (reader.HasRows && (contraseñaGuardada != hashPasswordIngresado || pContrasenia == ""))
                    {
                        intentos = intentos + 1;

                        SqlCommand intentoFallido = new SqlCommand(string.Format("UPDATE LOS_JUS.USUARIO SET USU_INTENTOS = '{0}' WHERE USU_USERNAME = '{1}'", intentos, pUsername), Conexion2);
                        int retorno4 = intentoFallido.ExecuteNonQuery();
                    }
                    
                    reader.Close();
                    

                }
            }





         


        }
    }
}
