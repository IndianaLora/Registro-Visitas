using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Empleado

    {
        private int id;
        private string nombre;
        private string apellido;
        private string ruta;
        private string disponibilidad;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
    }
}
