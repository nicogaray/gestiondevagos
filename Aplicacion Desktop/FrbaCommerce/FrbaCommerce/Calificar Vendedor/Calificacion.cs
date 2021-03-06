﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class Calificacion : Form
    {
        public Decimal pOperacionCodigo;

        public bool ReturnId { get; set; }

        public bool comprobarDatosCompletos(int calificacion)
        {
            if (calificacion == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Calificacion()
        {
            InitializeComponent();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            int pCalificacion = 0;
            if (radioButton_1.Checked)
            {
                pCalificacion = 1;
            }
            if (radioButton_2.Checked)
            {
                pCalificacion = 2;
            }
            if (radioButton_3.Checked)
            {
                pCalificacion = 3;
            }
            if (radioButton_4.Checked)
            {
                pCalificacion = 4;
            }
            if (radioButton_5.Checked)
            {
                pCalificacion = 5;
            }

            String pDescripcion = null;
                pDescripcion= comboBox_Descripcion.Text;
            String pEscribaAqui = null;
            pEscribaAqui = textBox_EscribaAqui.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pCalificacion);
            const string resumen = "";

            if (comprobarDatosCompletos)
            {
                 SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                 using (Conexion)
                 {
                     if (pEscribaAqui == "")
                     {
                         SqlCommand InsertarCalificacion1 = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Calificacion(cal_operacion,cal_detalle,cal_estrellas,cal_tipo) Values ('{0}','{1}','{2}','{3}')",
                                                                     pOperacionCodigo, pDescripcion, pCalificacion,'E'), Conexion);
                         int retorno2 = InsertarCalificacion1.ExecuteNonQuery();
                     }
                     if (pEscribaAqui != "")
                     {
                         SqlCommand InsertarCalificacion2 = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Calificacion(cal_operacion,cal_detalle,cal_estrellas,cal_tipo) Values ('{0}','{1}','{2}','{3}')",
                                               5,pOperacionCodigo, pEscribaAqui, pCalificacion,'E'), Conexion);
                         int retorno3 = InsertarCalificacion2.ExecuteNonQuery();

                     }
                 }

                string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                this.ReturnId = true;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                if (comprobarDatosCompletos == false)
                {
                    const string mensaje_Rechazo = "Hay campos vacios, debe ingresar todos los datos requeridos.\nLos datos no pudieron ser guardados.";

                    MessageBox.Show(mensaje_Rechazo, resumen, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void comboBox_Descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Descripcion.SelectedIndex == 6)
            {
                // label_EscribaAqui.Show();
                textBox_EscribaAqui.Show();
            }
            else
            {
                // label_EscribaAqui.Hide();
                textBox_EscribaAqui.Hide();
            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            comboBox_Descripcion.Text = "";
            textBox_EscribaAqui.Text = "";
            textBox_EscribaAqui.Hide();
            radioButton_1.Checked = false;
            radioButton_2.Checked = false;
            radioButton_3.Checked = false;
            radioButton_4.Checked = false;
            radioButton_5.Checked = false;
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calificacion_Load(object sender, EventArgs e)
        {
            textBox_EscribaAqui.Hide();

        }

        private void radioButton_1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
