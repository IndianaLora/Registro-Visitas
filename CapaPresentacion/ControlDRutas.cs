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
    public partial class ControlDRutas : Form
    {
        SqlCommand comando;
        SqlDataReader dr;
        SqlConnection conection = new SqlConnection("Data Source=DESKTOP-KFDKCFE\\SQLEXPRESS;Initial Catalog=Rutas;Integrated Security=True");
         N_Empleado n_Empleado = new N_Empleado();
         D_Empleado obj = new D_Empleado();
        public ControlDRutas()
            

        {
            SqlConnection conection = new SqlConnection("Data Source=DESKTOP-KFDKCFE\\SQLEXPRESS;Initial Catalog=Rutas;Integrated Security=True");
            
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void MostarListadoRutas()
        {
            dataGridView1.DataSource = n_Empleado.BuscarRuta();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ControlDRutas_Load(object sender, EventArgs e)
        {
            MostarListadoRutas();
        }
    }
}
