using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class ControlVisitas : Form
    {
        SqlCommand comando;
        SqlDataReader dr;
        SqlConnection conection = new SqlConnection("Data Source=DESKTOP-KFDKCFE\\SQLEXPRESS;Initial Catalog=Rutas;Integrated Security=True");
         N_Empleado n_Empleado = new N_Empleado();
         D_Empleado obj = new D_Empleado();
       


        public ControlVisitas()
            

        {
            SqlConnection conection = new SqlConnection("Data Source=DESKTOP-KFDKCFE\\SQLEXPRESS;Initial Catalog=Rutas;Integrated Security=True");
            
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
