using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


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
                this.Close();
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
            this.Hide();
            Menu.Menu_Usuario menu_usuario = new Menu.Menu_Usuario();
            menu_usuario.Show();

        }
    }
}
