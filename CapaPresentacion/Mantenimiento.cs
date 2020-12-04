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
        private bool Editar = false;
        public Mantenimiento()
        {
            InitializeComponent();
        }

       public void MostrarEdificios()
        {
            N_Empleado cn_Empleado = new N_Empleado();
            dataGridView3.DataSource = cn_Empleado.MostrarEdificio();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar==false) {
                try
                {
                    n_Empleado.insertarEdificio(txtEdificio.Text, txtAula.Text);
                    MessageBox.Show("Edificio agregado");
                    MostrarEdificios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar" + ex);
                } 
            }
            if (Editar== true)
            {
                try
                {
                    n_Empleado.editarE(txtEdificio.Text);
                    MessageBox.Show("Se edito exitosamente");
                    MostrarEdificios();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por    " + ex);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            MostrarEdificios();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                Editar = true;
                txtEdificio.Text = dataGridView3.CurrentRow.Cells["edificio"].Value.ToString();
                txtAula.Text = dataGridView3.CurrentRow.Cells["aula"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Porfavor seleccione una fila para editar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEdificio.Clear();
            txtEdificio.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string edificio = txtEdificio.Text;
            n_Empleado.Borrar(edificio);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTUsuario.Clear();
            txtUsuario.Clear();
        }

     

        private void btnGuardarU_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = monthCalendar1.SelectionStart.Day.ToString() + "/"+ monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();            
                n_Empleado.insertarUsuario(txtNombre.Text, txtApellido.Text,txtUsuario.Text,txtTUsuario.Text);
                MessageBox.Show("Usuario agregado");
                MostrarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar" + ex);
            }
        }
        public void MostrarUsuario()
        {
            N_Empleado cn_Empleado = new N_Empleado();
            dataGridView4.DataSource = cn_Empleado.MostrarUsuarion();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            MostrarUsuario();
        }

       
    }
}
