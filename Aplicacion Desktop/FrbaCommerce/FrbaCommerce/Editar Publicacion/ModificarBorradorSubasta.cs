using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class ModificarBorradorSubasta : Form
    {
        public String descripcionSeleccionada;
        public String valorInicialSeleccionado;
        public String cantidadLoteSeleccionado;
        public Decimal codigoPublicacionSeleccionado;

        public ModificarBorradorSubasta()
        {
            InitializeComponent();
        }

        private void ModificarBorradorSubasta_Load(object sender, EventArgs e)
        {

        }
    }
}
