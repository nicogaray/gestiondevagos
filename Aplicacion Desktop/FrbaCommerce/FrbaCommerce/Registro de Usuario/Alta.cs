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

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class Alta : Form
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

        public Alta()
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
            }

        }

        private void textBox_RolAsignado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_RolAsignado_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Este es el rol que tiene asignado";
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

        private void Alta_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Los datos cargados en este formulario serán requerido al iniciar sesion";

        }

        private void Alta_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_RolAsignado_MouseLeave(object sender, EventArgs e)
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

        private void textBox_Username_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Password_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void Alta_Load(object sender, EventArgs e)
        {
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

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Cliente menu_administrador = new Menu.Menu_Cliente();
            menu_administrador.Show();
        }
    }
}
