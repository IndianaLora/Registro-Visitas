using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
   
    public class N_Empleado
    {
        D_Empleado d_Empleado = new D_Empleado();

        public DataTable MostrarVisita()
        {
            DataTable Tabla = new DataTable();
            Tabla = d_Empleado.MostrarVisitante();
            return Tabla;
        }
        public DataTable MostrarEdificio()
        {
            DataTable Tabla = new DataTable();
            Tabla = d_Empleado.MostrarEdificio();
            return Tabla;
        }
        public DataTable MostrarUsuarion()
        {
            DataTable Tabla = new DataTable();
            Tabla = d_Empleado.MostrarUsuarios();
            return Tabla;
        }
        public DataTable MostrarComboBox()
        {
            DataTable Tabla = new DataTable();
            Tabla = d_Empleado.cargarCombo();
            return Tabla;
        }
        public void insertarVisita(string nombre, string apellido, string carrera, string edificio, string aula)
        {
            d_Empleado.Insertar(nombre, apellido, carrera, edificio, aula);
        }
        public void insertarEdificio(string edificio, string aula)
        {
            d_Empleado.InsertarEdificio(edificio, aula);
        }
        public void insertarUsuario(string nombre, string apellido,string usuario, string tipoUsuario)
        {
            d_Empleado.InsertarUsuario(nombre, apellido, usuario,tipoUsuario);
        }

        public void editarE(string edificio)
        {
            d_Empleado.Editar(edificio);
        }
        public void Borrar(string edificio)
        {
            d_Empleado.delete(edificio);
        }
    }
}