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

namespace FrbaCommerce
{
    public partial class Contraseña : Form
    {
        public String idSeleccionado = null;
        private string hashPassword(string password)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = SHA256.Create().ComputeHash(data);

            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }

        public Contraseña()
        {
            InitializeComponent();
        }

        private void Contraseña_Load(object sender, EventArgs e)
        {


        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            String pPassword = textBox_Password.Text;

            if (pPassword != "")
            {String hashDePasswor = hashPassword(pPassword);
               SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
               using (Conexion2)
               {

                 
                   
                   SqlCommand InsertarSesion = new SqlCommand(string.Format("UPDATE LOS_JUS.USUARIO USU_PASSWORD = '{1}' WHERE USU_ID='{2}'",hashDePasswor,idSeleccionado), Conexion2);
                   int retorno = InsertarSesion.ExecuteNonQuery();



               }


                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox_Password.Clear();

            }
            else
            {
                if (pPassword != "")
                {
                    const string mensaje_Rechazo = "Hay campos vacios, debe ingresar todos los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

            
        }
    }

