﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class HabilitarCliente : Form
    {
        public HabilitarCliente()
        {
            InitializeComponent();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dataGridView1.RowCount != 0)
                {
                    int i = e.RowIndex;


                    String nombreSeleccionado = dataGridView1[0, i].Value.ToString(); ;

                    const string mensaje = "¿Desea habilitar esta empresa?";
                    const string resumen = "Habilitar empresa";

                    var resultado = MessageBox.Show(mensaje, resumen,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);


                    if (resultado == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                        using (Conexion)
                        {
                            SqlCommand EliminarUsuario = new SqlCommand(string.Format("UPDATE LOS_JUS.usuario SET usu_habilitado = 1 WHERE usu_id = '{0}' ", nombreSeleccionado), Conexion);
                            int retorno = EliminarUsuario.ExecuteNonQuery();
                        }



                    }
                }
            }
        }

        private void HabilitarCliente_Load(object sender, EventArgs e)
        {
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand ObtenerIds = new SqlCommand(string.Format("SELECT usu_id as 'Cliente' FROM LOS_JUS.usuario join los_jus.Cliente on cli_id = usu_id where usu_eliminado <> 1 and usu_habilitado == 0"), Conexion);

                SqlDataReader reader = ObtenerIds.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("No hay Clientes inhabilitados actualmente");
                }

                while (reader.Read())
                {

                    String pColumna0 = reader.GetString(0);


                    dataGridView1.Rows.Add(pColumna0);
                }
            }
        }
        }
    }

