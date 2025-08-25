using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Estudiantes;

namespace UTApp_POO
{
    public partial class registroEstudiante : Form
    {
        bool ocultar = false;
        EstudianteControlador EstControl = new EstudianteControlador();
        List<Estudiante> estudiantes = new List<Estudiante>();
        public registroEstudiante()
        {
            InitializeComponent();
        }

        private void registroEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void registroEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void pbPassword_Click(object sender, EventArgs e)
        {
            ocultar = !ocultar;

            if (ocultar)
            {
                txtPass1.PasswordChar = '\0';
                txtPass2.PasswordChar = '\0';
                pbPassword.Image = UTApp_POO.Properties.Resources.hide;
            }
            else
            {
                txtPass1.PasswordChar = '•';
                txtPass2.PasswordChar = '•';
                pbPassword.Image = UTApp_POO.Properties.Resources.show;
            }
        }

        private void registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            iniciarSesion logIn = new iniciarSesion();
            this.Hide();
            logIn.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            tipoUsuario tipo = new tipoUsuario();
            this.Hide();
            tipo.Show();
        }
        public bool ValidarCampos()
        {
            if (
                !string.IsNullOrEmpty(txtMatricula.Text) &&
                !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtPass1.Text) &&
                !string.IsNullOrEmpty(txtPass2.Text) &&
                cbGrupo.SelectedIndex != -1
                )
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante nuevo = new Estudiante(txtMatricula.Text,txtNombre.Text,txtCorreo.Text,txtPass1.Text,Convert.ToInt16(cbGrupo.SelectedIndex));
                if (ValidarCampos() && EstControl.BuscarCorreoEstudiante(txtCorreo.Text) == null)
                {
                    EstControl.AgregarEstudiante(nuevo);
                    MessageBox.Show("Se ha registrado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    iniciarSesion login = new iniciarSesion();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Este correo ya esta en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
