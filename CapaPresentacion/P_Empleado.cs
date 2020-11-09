using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class P_Empleado : Form
    {
        N_Empleado n_Empleado = new N_Empleado();
        D_Empleado obj = new D_Empleado();
        public P_Empleado()
        {
            SqlConnection cn =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            InitializeComponent();
            try
            {
                cn = new SqlConnection("Data Source=DESKTOP-KFDKCFE\\SQLEXPRESS;Initial Catalog=Rutas;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("No Conectado" + ex.ToString());
            }
        }
        public void  MostrarListado()
        {

            dataGridView1.DataSource = n_Empleado.Listado();
        }
              private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarListado();

        }

        private void P_Empleado_Load(object sender, EventArgs e)
        {
            MostrarListado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                n_Empleado.insertarEmpleado(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtRuta.Text, txtFecha.Text);
                MessageBox.Show("Guardado");
                MostrarListado();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No guardado" + ex);
            }
            
        }
    }
}
