using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Empleado
    {
        public Conexion conexion = new Conexion();
        public SqlDataReader LeerConsulta;
        public SqlCommand comando = new SqlCommand();
        public DataTable Tabla = new DataTable();
        

        public DataTable MostrarVisitante()
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from visitante";
            LeerConsulta = comando.ExecuteReader();
            Tabla.Load(LeerConsulta);
            conexion.CerrarConexion();

            return Tabla;

        }
        public DataTable MostrarEdificio()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText= "Select * from edificios";
            LeerConsulta = comando.ExecuteReader();
            Tabla.Load(LeerConsulta);
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable cargarCombo()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from edificios";
            LeerConsulta = comando.ExecuteReader();
            Tabla.Load(LeerConsulta);
            conexion.CerrarConexion();
            return Tabla;
                ;
        }
        public void InsertarEdificio(string edificio,string aula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = ($"Insert into edificios (edificio,aula) values('{edificio}','{aula}')");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        public void Insertar(string nombre,string apellido,string carrera,string edificio,string aula )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText =( $"Insert into visitante (nombre,apellido,carrera,edificio,aula) values('{nombre}','{apellido}','{carrera}','{edificio}','{aula}')");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
     
    }
    
}
