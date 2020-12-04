using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Mantenimiento : Form
    {
        N_Empleado n_Empleado = new N_Empleado();
        public Mantenimiento()
        {
            InitializeComponent();
        }

       public void MostrarEdificios()
        {
            dataGridView3.DataSource = n_Empleado.MostrarEdificio();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarEdificios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                n_Empleado.insertarEdificio( txtEdificio.Text, txtAula.Text);
                MessageBox.Show("Edificio agregado");
                MostrarEdificios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar" + ex);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            MostrarEdificios();
        }
    }
}
