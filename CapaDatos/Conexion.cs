using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    
    public class Conexion
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-KFDKCFE\\SQLEXPRESS;Initial Catalog=Rutas;Integrated Security=True");
    public SqlConnection AbrirConexion()
        {
            if(cn.State == ConnectionState.Closed)
                cn.Open();
                return cn;
            
        }

        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
                 return cn;

        }

    }
}
