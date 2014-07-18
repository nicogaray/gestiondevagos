﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class Modificacion : Form
    {
                public string Password { get; set; }

        private string hashPassword(string password)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = SHA256.Create().ComputeHash(data);

            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }

        public bool comprobarDatosCompletos(String usuario, String contrasenia)
        {
            if (usuario == "" ||
                contrasenia == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool cliente = false;

        public Modificacion()
        {
            InitializeComponent();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Password.Clear();
            textBox_Username.Clear();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pUsername = textBox_Username.Text;
            String pPassword = textBox_Password.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pUsername,pPassword);
            const string resumen = "";

            if (comprobarDatosCompletos)
            {
               String hashDePasswor = hashPassword(pPassword);
               SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
               using (Conexion2)
               {
                   Int32 id = 0;

                 SqlCommand ObtenerIdSesion = new SqlCommand(string.Format("SELECT ses_id FROM LOS_JUS.sesion"), Conexion2);
                SqlDataReader reader = ObtenerIdSesion.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(0);

                }
                   
                   SqlCommand InsertarSesion = new SqlCommand(string.Format("UPDATE LOS_JUS.USUARIO SET USU_USERNAME='{0}',USU_PASSWORD = '{1}' WHERE USU_ID='{2}'", pUsername,hashDePasswor,id), Conexion2);
                   int retorno = InsertarSesion.ExecuteNonQuery();

                   SqlCommand InsertarSesion2 = new SqlCommand(string.Format("UPDATE LOS_JUS.SESION SET SES_PRIMERA_VEZ=0 WHERE SES_ID='{0}'", id), Conexion2);
                   int retorno2 = InsertarSesion2.ExecuteNonQuery();


               }


                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox_Password.Clear();
                textBox_Username.Clear();
            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "Hay campos vacios, debe ingresar todos los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        
    

        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            richTextBox_Datos.Enabled = false;

            textBox_RolAsignado.Enabled = false;
            if (cliente)
            {
                textBox_RolAsignado.Text = "Cliente";
            }
            else
            {
                textBox_RolAsignado.Text = "Empresa";

            }
        }

        private void textBox_Username_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Ingrese un nombre de usuario";

        }

        private void textBox_Password_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Ingrese una contraseña de no mas de * caracteres";

        }

        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los campos correctamente antes de guardar";

        }

        private void button_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void Modificacion_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos cargados en este formulario serán requerido al iniciar sesion";

        }

        private void textBox_RolAsignado_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Este es el rol que tiene asignado";

        }

        private void button_IrA_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Ir al formulario de modificacion";

        }

        private void Modificacion_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Username_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Password_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_RolAsignado_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_IrA_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            if (cliente)
            {
                Menu.Menu_Cliente menu_administrador = new Menu.Menu_Cliente();
                menu_administrador.Show();
                this.Close();

            }
            else
            {
                Menu.Menu_Empresa menu_empresa = new Menu.Menu_Empresa();
                menu_empresa.Show();
                this.Close();

            }
            
          
        }

        private void button_IrA_Click(object sender, EventArgs e)
        {
            if (cliente)
            {
                Abm_Cliente.Modificacion modificacion = new Abm_Cliente.Modificacion();
                modificacion.desdeModificacionUsuario = true;
                
                modificacion.Show();
            }
            else
            {
                Abm_Empresa.Modificacion modificacion = new Abm_Empresa.Modificacion();
                modificacion.desdeModificacionUsuario = true;
                modificacion.Show();
            }
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox_RolAsignado_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
