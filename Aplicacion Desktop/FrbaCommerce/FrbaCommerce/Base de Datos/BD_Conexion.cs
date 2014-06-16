using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using FrbaCommerce.Properties;
using System.Configuration;


namespace FrbaCommerce.Base_de_Datos
{
    public class BD_Conexion
    {
        public static string ObtenerCadenaConexion()
        {
            return Settings.Default.GD1C2014ConnectionString;
        }

        public static SqlConnection ObternerConexion()
        {
            SqlConnection Con = new SqlConnection(ObtenerCadenaConexion());
            Con.Open();
            return Con;
        }

    }
}
