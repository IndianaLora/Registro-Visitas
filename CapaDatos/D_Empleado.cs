using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Empleado
    {
        public Conexion conexion = new Conexion();
        SqlDataReader LeerConsulta;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarEmpleado()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Empleado";
            LeerConsulta = comando.ExecuteReader();
            Tabla.Load(LeerConsulta);
            conexion.CerrarConexion();

            return Tabla;

        }

    }
}
