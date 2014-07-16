using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Rol
{
    public partial class Modificacion : Form
    {
        public String nombreSeleccionado = "";

        public bool comprobarDatosCompletos(String nombre)
        {
            if (nombre == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Modificacion()
        {
            InitializeComponent();
        }

          private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Nombre.Clear();
            dataGridView_ListaFuncionalidades.Rows.Clear();

        }

        private void textBox_Nombre_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Especifique el rol";
                    }

        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de guardar";

        }

        private void button_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void dataGridView_ListaFuncionalidades_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese que el término del campo Funcionalidad sea simple y concreto";

        }

        private void dataGridView_ListaFuncionalidades_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void textBox_Nombre_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Guardar_Click_1(object sender, EventArgs e)
        {
            String pNombre = textBox_Nombre.Text;

            //Muestro mensaje de aceptacion o rechazo, y el tipo de error ocurrido
            bool comprobarDatosCompletos = this.comprobarDatosCompletos(pNombre);
            const string resumen = "";

            if (comprobarDatosCompletos)
            {
                SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
                using (Conexion)
                {
                    SqlCommand updateFuncionalidades = new SqlCommand(string.Format("update LOS_JUS.funcionalidades set fun_eliminado=1 where fun_funcionalidad in (select fun_funcionalidad from los_jus.funcionalidades f join LOS_JUS.ROLxFUNCIONALIDADES r on f.fun_funcionalidad=r.rolfun_funcionalidades where rolfun_rol = '{0}')", nombreSeleccionado), Conexion);
                    int retorno6 = updateFuncionalidades.ExecuteNonQuery();


                    SqlCommand eliminarFuncionalidadesXRol = new SqlCommand(string.Format("delete from LOS_JUS.ROLxFUNCIONALIDADES where rolfun_rol='{0}'", nombreSeleccionado), Conexion);
                    int retorno3 = eliminarFuncionalidadesXRol.ExecuteNonQuery();

                    SqlCommand eliminarRol = new SqlCommand(string.Format("delete from LOS_JUS.Rol where rol_nombre='{0}'", nombreSeleccionado), Conexion);
                    int retorno4 = eliminarRol.ExecuteNonQuery();

                    SqlCommand eliminarFuncionalidades = new SqlCommand(string.Format("delete from LOS_JUS.funcionalidades where fun_eliminado=1 "), Conexion);
                    int retorno5 = eliminarFuncionalidades.ExecuteNonQuery();

                    SqlCommand InsertarRol = new SqlCommand(string.Format("INSERT INTO LOS_JUS.Rol(rol_nombre) Values ('{0}')", pNombre), Conexion);
                    int retorno = InsertarRol.ExecuteNonQuery();


                    SqlCommand InsertarFuncionalidades = new SqlCommand("INSERT INTO LOS_JUS.Funcionalidades(fun_funcionalidad,fun_descripcion) Values (@funcionalidad,@descripcion)", Conexion);

                    SqlCommand InsertarFuncionalidadesXRol = new SqlCommand("INSERT INTO LOS_JUS.ROLxFUNCIONALIDADES(ROLFUN_ROL,ROLFUN_FUNCIONALIDADES) Values (@nombre,@funcionalidad)", Conexion);


                    foreach (DataGridViewRow row in dataGridView_ListaFuncionalidades.Rows)
                    {
                        InsertarFuncionalidades.Parameters.Clear();
                        InsertarFuncionalidadesXRol.Parameters.Clear();
                        InsertarFuncionalidades.Parameters.AddWithValue("@funcionalidad", Convert.ToString(row.Cells["Funcionalidad"].Value));
                        InsertarFuncionalidades.Parameters.AddWithValue("@descripcion", Convert.ToString(row.Cells["Descripcion"].Value));
                        int resultado1 = InsertarFuncionalidades.ExecuteNonQuery();

                        InsertarFuncionalidadesXRol.Parameters.AddWithValue("@nombre", pNombre);
                        InsertarFuncionalidadesXRol.Parameters.AddWithValue("@funcionalidad", Convert.ToString(row.Cells["Funcionalidad"].Value));
                        int resultado2 = InsertarFuncionalidadesXRol.ExecuteNonQuery();
                    }



                    string mensaje_Aceptacion = "Los datos han sigo guardados con éxito";
                    MessageBox.Show(mensaje_Aceptacion, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();

                }
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

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click_1(object sender, EventArgs e)
        {
            textBox_Nombre.Clear();
            dataGridView_ListaFuncionalidades.Rows.Clear();

        }

        private void button_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            label_Informacion.Text = "Volver al formulario anterior";

        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            textBox_Nombre.Text = nombreSeleccionado;
            //falta fun_descripcion!
            SqlConnection Conexion = Base_de_Datos.BD_Conexion.ObternerConexion();
            using (Conexion)
            {
                SqlCommand ObtenerIds = new SqlCommand(string.Format("SELECT FUN_FUNCIONALIDAD,fun_descripcion FROM LOS_JUS.ROL JOIN LOS_JUS.ROLxFUNCIONALIDADES ON ROLFUN_ROL=ROL_NOMBRE JOIN LOS_JUS.FUNCIONALIDADES ON ROLFUN_FUNCIONALIDADES=FUN_FUNCIONALIDAD WHERE ROL_NOMBRE = '{0}'", nombreSeleccionado), Conexion);

                SqlDataReader reader = ObtenerIds.ExecuteReader();
                while (reader.Read())
                {

                    String pColumna0 = reader.GetString(0);
                    String pColumna1 = reader.GetString(1);


                    dataGridView_ListaFuncionalidades.Rows.Add(pColumna0,pColumna1);
                }
                
                
            }
        }

        private void button_Limpiar_MouseEnter_1(object sender, EventArgs e)
        {
            label_Informacion.Text = "Se borrarán todos los datos ingresados en el formulario hasta el momento";

        }

        private void button_Guardar_MouseEnter_1(object sender, EventArgs e)
        {
            label_Informacion.Text = "Asegurese de haber ingresado los datos correctamente antes de guardar";

        }

        private void button_Guardar_MouseLeave_1(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Limpiar_MouseLeave_1(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            label_Informacion.Text = "";

        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (dataGridView_ListaFuncionalidades.RowCount != 0)
                {
                    int i = e.RowIndex;

                    using (var form = new Abm_Rol.ModificarFuncionalidad())
                    {
                        form.funcionalidadSeleccionada = dataGridView_ListaFuncionalidades[0, i].Value.ToString();
                        if (dataGridView_ListaFuncionalidades[1, i].Value != null)
                        {
                            form.descripcionSeleccionada = dataGridView_ListaFuncionalidades[1, i].Value.ToString();
                        }

                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        bool val = form.ReturnId;
                        string funcionalidad = form.ReturnFunc;
                        string descripcion = form.ReturnDesc;

                        if (val)
                        {
                            dataGridView_ListaFuncionalidades.Rows.RemoveAt(i);
                        }
                        if (val != true)
                        {
                            dataGridView_ListaFuncionalidades[0,i].Value = funcionalidad;
                            dataGridView_ListaFuncionalidades[1,i].Value = descripcion;
                            //dataGridView_ListaFuncionalidades.Refresh();

                        }
                    }
                }
            
                    //dataGridView_ListaFuncionalidades.Rows.RemoveAt(i);
                }
               
            }
        }
    }
}
