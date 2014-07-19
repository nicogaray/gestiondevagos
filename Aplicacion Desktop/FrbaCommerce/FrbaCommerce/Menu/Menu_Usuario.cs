using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Menu
{
    public partial class Menu_Usuario : Form
    {
        public Menu_Usuario()
        {
            InitializeComponent();
        }

        private void Menu_Usuario_Load(object sender, EventArgs e)
        {
            button_Administrador.Hide();
            button_Cliente.Hide();
            button_Empresa.Hide();

            Int32 id = 0;
            Int32 idCliente = 0;
            Int32 idEmpresa = 0;
 SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
 using (Conexion2)
 {
     SqlCommand ObtenerIdSesion = new SqlCommand(string.Format("SELECT ses_id FROM LOS_JUS.sesion"), Conexion2);
     SqlDataReader reader = ObtenerIdSesion.ExecuteReader();

     while (reader.Read())
     {
         if (reader.IsDBNull(0) == false)
         {

             id = reader.GetInt32(0);//VIS_PORCENTAJE
         }
         else
         {
             id = 0;
         }
         
     }

     SqlCommand ObtenerRolCliente = new SqlCommand(string.Format("SELECT cli_id FROM LOS_JUS.cliente where cli_id= '{0}' and cli_eliminado = 0", id), Conexion2);
     SqlDataReader reader2 = ObtenerRolCliente.ExecuteReader();

     while (reader2.Read())
     {
         if (reader2.IsDBNull(0) == false)
         {

             idCliente = reader2.GetInt32(0);
         }
         else
         {
             idCliente = 0;
         }
     }

     SqlCommand ObtenerRolEmpresa = new SqlCommand(string.Format("SELECT emp_id FROM LOS_JUS.empresa where emp_id= '{0}' and emp_eliminado = 0", id), Conexion2);
     SqlDataReader reader3 = ObtenerRolEmpresa.ExecuteReader();

     while (reader3.Read())
     {
         if (reader3.IsDBNull(0) == false)
         {

             idEmpresa = reader3.GetInt32(0);
         }
         else
         {
             idEmpresa = 0;
         }
     }


 }

            // falta consultar a la base si el usuario es administrador
            if (id == 1)
            {
                button_Administrador.Visible = true;
                button_Cliente.Visible = true;
                button_Empresa.Visible = true;


            }

            // falta consultar a la base si el usuario es cliente
            if (idCliente != 0)
            {
                button_Cliente.Visible = true;
            }

            // falta consultar a la base si el usuario es empresa
            if (idEmpresa != 0)
            {
                button_Empresa.Visible = true;
            }
            
        }

        private void button_Administrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Administrador menu_administrador = new Menu.Menu_Administrador();
            menu_administrador.Show();
        }

        private void button_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Cliente menu_administrador = new Menu.Menu_Cliente();
            menu_administrador.Show();
            
        }

        private void button_Empresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Empresa menu_administrador = new Menu.Menu_Empresa();
            menu_administrador.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Login login = new Login.Login();
            login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
