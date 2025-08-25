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
    public partial class editarGrupoEstudiante : Form
    {
        public editarGrupoEstudiante()
        {
            InitializeComponent();
        }

        private void editarGrupoEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            configEstudiante goBack = new configEstudiante();
            this.Hide();
            goBack.Show();
        }

        private void editarGrupoEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            pantallaEstudiante home = new pantallaEstudiante();
            this.Hide();
            home.Show();
        }
    }
}
