using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        string usuario;
        string password;
        string Admin;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void comprobarUsuario()
        {
            usuario = txtUsuario.Text;
            password = txtPassword.Text;
            if (usuario == "Indiana")
            {
                MessageBox.Show("Bienvenido Administrador" +" "+usuario);
                Login login = new Login();
                login.Close();
            }
            else
            {
                MessageBox.Show("Usted no es Administrador");
                Login login = new Login();
                login.ShowDialog();
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comprobarUsuario();
            ControlVisitas cv = new ControlVisitas();
            cv.ShowDialog();

        }
    }

     
    }

