using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Docentes;
using UTApp.Forms.Estudiantes;

namespace UTApp_POO
{
    public partial class iniciarSesion : Form
    {
        bool ocultar = false;
        List<ClaseDocenteID> docentes = new List<ClaseDocenteID>();
        DocenteControlador DocControl = new DocenteControlador();
        List<ClaseEstudianteID> estudiantes = new List<ClaseEstudianteID>();
        EstudianteControlador EstControl = new EstudianteControlador();
        public iniciarSesion()
        {
            InitializeComponent();
        }

        private void iniciarSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void iniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bienvenida inicio = new Bienvenida();
            this.Hide();
            inicio.Show();
        }

        private void pbPassword_Click(object sender, EventArgs e)
        {
            ocultar = !ocultar;

            if (ocultar)
            {
                txtPass.PasswordChar = '\0';
                pbPassword.Image = UTApp_POO.Properties.Resources.hide;
            }
            else
            {
                txtPass.PasswordChar = '•';
                pbPassword.Image = UTApp_POO.Properties.Resources.show;
            }
        }

        private void registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tipoUsuario registrarse = new tipoUsuario();
            this.Hide();
            registrarse.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string user = txtId.Text; string password = txtPass.Text; bool signedIn = false;
            estudiantes = EstControl.ListarEstudiantesID();
            docentes = DocControl.ListarDocentesID();
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
            {
                foreach (ClaseDocenteID docente in docentes)
                {
                    if (docente.DocenteNumeroEmpleado == user && docente.DocentePassword == password)
                    {
                        signedIn = true;
                        MessageBox.Show("Se ha iniciado sesion", "", MessageBoxButtons.OK);
                    }
                }
                foreach (ClaseEstudianteID estudiante in estudiantes)
                {
                    if (estudiante.EstudianteMatricula == user && estudiante.EstudiantePassword == password)
                    {
                        signedIn = true;
                        pantallaEstudiante loginest = new pantallaEstudiante(estudiante);
                        loginest.Show();
                        this.Hide();
                    }
                }
                if (!signedIn)
                {
                    MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
