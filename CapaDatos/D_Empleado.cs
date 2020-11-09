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
            comando.CommandText = "MostrarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            LeerConsulta = comando.ExecuteReader();
            Tabla.Load(LeerConsulta);
            conexion.CerrarConexion();

            return Tabla;

        }
        public void Insertar(int cedula,string nombre,string apellido,string ruta,string disponibilidad )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText =( $"Insert into Choferes (cedula,nombre,apellido,ruta,disponibilidad) values({cedula},'{nombre}','{apellido}','{ruta}','{disponibilidad}')");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        public DataTable MostrarRutas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostarRutaz";
            comando.CommandType = CommandType.StoredProcedure;
            LeerConsulta = comando.ExecuteReader();
            Tabla.Load(LeerConsulta);
            conexion.CerrarConexion();

            return Tabla;
        }
    }
    
}
