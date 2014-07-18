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
    public partial class Menu_Cliente : Form
    {
        public Int32 primeraVez = 0;

        public Menu_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Menu_Cliente_Load(object sender, EventArgs e)
        {

             Int32 id =0;
            String funcionalidad = null;

             SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
             using (Conexion2)
             {
                 SqlCommand ObtenerIdSesion = new SqlCommand(string.Format("SELECT ses_id,ses_primera_vez FROM LOS_JUS.sesion"), Conexion2);
                 SqlDataReader reader = ObtenerIdSesion.ExecuteReader();

                 while (reader.Read())
                 {
                     id = reader.GetInt32(0);
                     primeraVez = reader.GetInt32(1);

                 }

                 if (primeraVez == 1)
                 {
                     comboBox_funcionalidades.Items.Add("Registro Usuario");

                 }
                 else
                 {
                     SqlCommand FuncionalidadesAdministrador = new SqlCommand(string.Format("SELECT fun_funcionalidad FROM LOS_JUS.funcionalidades join los_jus.ROLxFUNCIONALIDADES on ROLFUN_FUNCIONALIDADES = fun_funcionalidad where rolfun_rol = 'Cliente' and fun_funcionalidad = 'REGISTRO USUARIO'"), Conexion2);
                     SqlDataReader reader2 = FuncionalidadesAdministrador.ExecuteReader();

                     while (reader2.Read())
                     {

                         funcionalidad = reader2.GetString(0);

                         comboBox_funcionalidades.Items.Add(funcionalidad);

                     }

                 }
             }
        }

        private void button_RegistroUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_de_Usuario.Alta altaUsuario = new Registro_de_Usuario.Alta();
            altaUsuario.cliente = true;
            altaUsuario.Show();
           
        }

        private void button_ModificacionUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_de_Usuario.Modificacion modUsuario = new Registro_de_Usuario.Modificacion();
            modUsuario.cliente = true;
            modUsuario.Show();
        }

        private void button_HistorialCliente_Click(object sender, EventArgs e)
        {
            Historial_Cliente.Historial historial = new Historial_Cliente.Historial();
            historial.cliente = true;
            historial.Show();
            this.Close();
          
        }

        private void button_CalificarVendedor_Click(object sender, EventArgs e)
        {
            Calificar_Vendedor.ListaOperacionesSeleccion calificar = new Calificar_Vendedor.ListaOperacionesSeleccion();
            calificar.Show();
            this.Close();
        }

        private void button_Comprar_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Comprar comprar = new Comprar_Ofertar.Comprar();
            comprar.Show();
            this.Close();
        }

        private void button_Ofertar_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Ofertar ofertar = new Comprar_Ofertar.Ofertar();
            ofertar.Show();
            this.Close();
        }

        private void button_Preguntar_Click(object sender, EventArgs e)
        {
            Gestion_de_Preguntas.Ver_Respestas preguntas = new Gestion_de_Preguntas.Ver_Respestas();
            preguntas.Show();

            
        }

        private void button_FacturarPublicacion_Click(object sender, EventArgs e)
        {
            Facturar_Publicaciones.FacturarPublicaciones facturar = new Facturar_Publicaciones.FacturarPublicaciones();
            facturar.Show();
            this.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Menu.Menu_Usuario menu_usuario = new Menu.Menu_Usuario();
            menu_usuario.Show();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (comboBox_funcionalidades.SelectedIndex == 0 && primeraVez == 1)
            {
                this.Hide();
                Registro_de_Usuario.Alta altaUsuario = new Registro_de_Usuario.Alta();
                altaUsuario.cliente = true;
                altaUsuario.Show();
            }
            if (comboBox_funcionalidades.SelectedIndex == 0 && primeraVez != 1)
            {
                this.Hide();
                Registro_de_Usuario.Modificacion modUsuario = new Registro_de_Usuario.Modificacion();
                modUsuario.cliente = true;
                modUsuario.Show();
            }
            if (comboBox_funcionalidades.SelectedIndex == 1)
            {
                Comprar_Ofertar.Comprar comprar = new Comprar_Ofertar.Comprar();
                comprar.Show();
                this.Close();
            }
            if (comboBox_funcionalidades.SelectedIndex == 2)
            {
                Comprar_Ofertar.Ofertar ofertar = new Comprar_Ofertar.Ofertar();
                ofertar.Show();
                this.Close();
            }
            if (comboBox_funcionalidades.SelectedIndex == 3)
            {
                Gestion_de_Preguntas.Ver_Respestas preguntas = new Gestion_de_Preguntas.Ver_Respestas();
                preguntas.Show();
            }
            if (comboBox_funcionalidades.SelectedIndex == 4)
            {
                Calificar_Vendedor.ListaOperacionesSeleccion calificar = new Calificar_Vendedor.ListaOperacionesSeleccion();
                calificar.Show();
                this.Close();

            }
            if (comboBox_funcionalidades.SelectedIndex == 5)
            {
                Historial_Cliente.Historial historial = new Historial_Cliente.Historial();
                historial.cliente = true;
                historial.Show();
                this.Close();
          

            }

        }

        private void comboBox_funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
