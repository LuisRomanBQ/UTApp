using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp_POO
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            iniciarSesion LogIn = new iniciarSesion();
            this.Hide();
            LogIn.Show();
        }

        private void Bienvenida_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            tipoUsuario tipo = new tipoUsuario();
            this.Hide();
            tipo.Show();
        }
    }
}
