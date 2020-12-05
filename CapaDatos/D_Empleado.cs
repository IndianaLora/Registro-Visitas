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
            comando.CommandText = "Select * from edificios";
            LeerConsulta = comando.ExecuteReader();
            Tabla.Load(LeerConsulta);
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable MostrarUsuarios()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from usuarios";
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

        public void Insertar(string nombre, string apellido, string carrera, string edificio, string aula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = ($"Insert into visitante (nombre,apellido,carrera,edificio,aula) values('{nombre}','{apellido}','{carrera}','{edificio}','{aula}')");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        public void InsertarEdificio(string edificio, string aula , string carrera)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = ($"Insert into edificios (edificio,aula,carrera) values('{edificio}','{aula}','{carrera}')");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarUsuario(string nombre, string apellido, string usuario, string tipoUsuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = ($"Insert into usuarios (nombre,apellido,usuario,tipoUsuario) values('{nombre}','{apellido}','{usuario}','{tipoUsuario}')");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        public void Editar(string edificio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = ($"update edificios set edificio={edificio} where edificio={edificio}");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void delete(string edificio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = ($"delete from edificio");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
    }
}

