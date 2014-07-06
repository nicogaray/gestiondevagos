using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class SeleccionUsuario : Form
    {
        public string ReturnId { get; set; }

        public SeleccionUsuario()
        {
            InitializeComponent();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dataGridView1.RowCount != 0)
                {
                    String pIdUsuarioSeleccionado = "";
                    int i = e.RowIndex;
                    pIdUsuarioSeleccionado = dataGridView1[0, i].Value.ToString();

                    this.ReturnId = pIdUsuarioSeleccionado;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }
    }
}
