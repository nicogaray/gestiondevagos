using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class Modificacion : Form
    {
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
            //falta ver como avisar los campos afectados en caso de error
            const string mensaje_Aceptacion = "Los datos han sido guardados con éxito";
            const string mensaje_Rechazo = "Los datos no pudieron ser guardados";
            const string resumen = "";

            if (true)
            {
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificacion_Load(object sender, EventArgs e)
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

    }
}
