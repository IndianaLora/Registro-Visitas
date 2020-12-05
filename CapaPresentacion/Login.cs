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
        public static string usuario;
        private string password;
        
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
                MessageBox.Show("Hola!"+usuario+" "+"Bienvenido Administrador");
                Login login = new Login();
                login.Close();
            }
            if (usuario == "Keren" )
            {
                MessageBox.Show("Hola!"+usuario+" "+"Bienvenido Usuario general");
                Login login = new Login();
                login.Close();
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

