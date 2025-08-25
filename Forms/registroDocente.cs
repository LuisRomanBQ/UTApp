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

namespace UTApp_POO
{
    public partial class registroDocente : Form
    {
        DocenteControlador DocControl = new DocenteControlador();
        List<Docente> docentes = new List<Docente>();
        bool ocultar = false;
        public registroDocente()
        {
            InitializeComponent();
        }

        private void registroDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void registroDocente_Load(object sender, EventArgs e)
        {
            docentes = DocControl.ListarDocentes();
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
        public bool ValidarCampos()
        {
            if (
                !string.IsNullOrEmpty(txtCorreo.Text) &&
                !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtNumeroEmpleado.Text) &&
                !string.IsNullOrEmpty(txtPass1.Text) &&
                !string.IsNullOrEmpty(txtPass2.Text) &&
                !string.IsNullOrEmpty(txtTituloAcademico.Text)
                )
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            iniciarSesion logIn = new iniciarSesion();
            this.Hide();
            logIn.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            tipoUsuario tipo = new tipoUsuario();
            this.Hide();
            tipo.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    Docente nuevo = new Docente(txtNumeroEmpleado.Text, txtNombre.Text, txtTituloAcademico.Text, txtCorreo.Text, txtPass1.Text);
                    if (DocControl.BuscarCorreoDocente(txtCorreo.Text) == null)
                    {
                        DocControl.AgregarDocente(nuevo);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
