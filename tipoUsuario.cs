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
    public partial class tipoUsuario : Form
    {
        public tipoUsuario()
        {
            InitializeComponent();
        }

        private void continuarSingIn_Click(object sender, EventArgs e)
        {
            if (Docente.Checked)
            {
                registroDocente registro = new registroDocente();
                this.Hide();
                registro.Show();
            }
            else if (Estudiante.Checked)
            {
                registroEstudiante registro = new registroEstudiante();
                this.Hide();
                registro.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de usuario", "ERROR");
            }
        }

        private void tipoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tipoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void tipoUsuario_Load_1(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Bienvenida inicio = new Bienvenida();
            this.Hide();
            inicio.Show();
        }
    }
}
