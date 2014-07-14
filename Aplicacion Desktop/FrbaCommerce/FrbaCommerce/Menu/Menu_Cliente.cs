using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Menu
{
    public partial class Menu_Cliente : Form
    {
        public Menu_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Menu_Usuario menu_usuario = new Menu.Menu_Usuario();
            menu_usuario.Show();
        }

        private void Menu_Cliente_Load(object sender, EventArgs e)
        {
            //primera vez que ingresa al sistema
            if (false)
            {
                button_ModificacionUsuario.Hide();
                button_Comprar.Enabled = false;
                button_FacturarPublicacion.Enabled = false;
                button_HistorialCliente.Enabled = false;
                button_Ofertar.Enabled = false;
                button_Preguntar.Enabled = false;
                button_CalificarVendedor.Enabled = false;
            }
            else
            {
                button_RegistroUsuario.Hide();
                button_ModificacionUsuario.Show();
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
            //Facturar_Publicaciones.Facturar facturar = new Facturar_Publicaciones.Facturar();
            //facturar.Show();
            //this.Close();


        }

    
    }
}
