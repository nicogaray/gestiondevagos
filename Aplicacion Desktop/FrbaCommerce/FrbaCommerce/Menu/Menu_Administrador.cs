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
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Usuario menu_usuario = new Menu.Menu_Usuario();
            menu_usuario.Show();
        }

        private void button_ABMCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void button_ABMRol_Click(object sender, EventArgs e)
        {
           

        }

        private void button_ABMEmpresa_Click(object sender, EventArgs e)
        {
            

        }

        private void button_ABMRubro_Click(object sender, EventArgs e)
        {
            

        }

        private void button_ABMVisibilidad_Click(object sender, EventArgs e)
        {
            

        }

        private void button_ListadoEstadistico_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {

            Int32 id =0;
            String funcionalidad = null;

             SqlConnection Conexion2 = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion2)
            {
                     SqlCommand ObtenerIdSesion = new SqlCommand(string.Format("SELECT ses_id FROM LOS_JUS.sesion"), Conexion2);
                     SqlDataReader reader = ObtenerIdSesion.ExecuteReader();

                      while (reader.Read())
                      {
                         id = reader.GetInt32(0);
                      }

                      SqlCommand FuncionalidadesAdministrador = new SqlCommand(string.Format("SELECT fun_funcionalidad FROM LOS_JUS.funcionalidades join los_jus.ROLxFUNCIONALIDADES on ROLFUN_FUNCIONALIDADES = fun_funcionalidad where rolfun_rol = 'Administrativo'"), Conexion2);
                    SqlDataReader reader2 = FuncionalidadesAdministrador.ExecuteReader();

                    while (reader2.Read())
                    {
                    
                    funcionalidad = reader2.GetString(0);

                    comboBox_funcionalidades.Items.Add(funcionalidad);
               
                }



         
     }
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (comboBox_funcionalidades.SelectedIndex == 0)
            {
                this.Hide();
                ABM_Rol.Form_Base form_base = new ABM_Rol.Form_Base();
                form_base.Show();
            }
            if (comboBox_funcionalidades.SelectedIndex == 1)
            {
                this.Hide();
                Abm_Cliente.Form_Base form_base = new Abm_Cliente.Form_Base();
                form_base.Show();
            }
            if (comboBox_funcionalidades.SelectedIndex == 2)
            {
                this.Hide();
                Abm_Empresa.Form_Base form_base = new Abm_Empresa.Form_Base();
                form_base.Show();
            }
            if (comboBox_funcionalidades.SelectedIndex == 3)
            {
            }
            if (comboBox_funcionalidades.SelectedIndex == 4)
            {
                this.Hide();
                Abm_Visibilidad.Form_Base form_base = new Abm_Visibilidad.Form_Base();
                form_base.Show();
            }
            if (comboBox_funcionalidades.SelectedIndex == 5)
            {
                this.Hide();
                Listado_Estadistico.ListadoEstadistico listado = new Listado_Estadistico.ListadoEstadistico();
                listado.Show();
            }
            

        }

      
    }
}
