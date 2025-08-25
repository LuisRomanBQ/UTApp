using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp_POO;

namespace UTApp_POO
{
    public partial class configEstudiante : Form
    {
        public configEstudiante()
        {
            InitializeComponent();
        }

        private void Plantilla_Load(object sender, EventArgs e)
        {

        }

        private void configuracionEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            pantallaEstudiante menu = new pantallaEstudiante();
            this.Hide();
            menu.Show();
        }

        private void btnEditarNombre_Click(object sender, EventArgs e)
        {
            editarNombreEstudiante editarNombre = new editarNombreEstudiante();
            this.Hide();
            editarNombre.Show();
        }

        private void btnEditarGrupo_Click(object sender, EventArgs e)
        {
            editarGrupoEstudiante edit = new editarGrupoEstudiante();
            this.Hide();
            edit.Show();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña cambiar = new cambiarContraseña();
            this.Hide();
            cambiar.Show();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar su cuenta?", "Eliminar usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Cuenta eliminada con éxito.", "Usuario eliminado");
                Bienvenida salir = new Bienvenida();
                this.Hide();
                salir.Show();
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
