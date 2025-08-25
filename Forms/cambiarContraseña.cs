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
    public partial class cambiarContraseña : Form
    {
        bool ocultar = false;
        public cambiarContraseña()
        {
            InitializeComponent();
        }

        private void cambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void cambiarContraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            configEstudiante goBack = new configEstudiante();
            this.Hide();
            goBack.Show();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if ((txtPass1.Text == txtPass2.Text) && (txtPass2.Text != ""))
            {
                MessageBox.Show("La contraseña se ha actualizado correctamente.", "Contraseña actualizado");
                configEstudiante goBack = new configEstudiante();
                this.Hide();
                goBack.Show();
            }
            else
            {
                MessageBox.Show("No se ha podido actualizar la contraseña.", "Error");
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            pantallaEstudiante home = new pantallaEstudiante();
            this.Hide();
            home.Show();
        }
    }
}
