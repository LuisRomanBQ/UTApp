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
    public partial class editarNombreEstudiante : Form
    {
        public editarNombreEstudiante()
        {
            InitializeComponent();
        }

        private void Plantilla_Load(object sender, EventArgs e)
        {

        }

        private void editarNombreEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
           configEstudiante goBack = new configEstudiante();
            this.Hide();
            goBack.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            if ((txtNewName1.Text == txtNewName2.Text) && (txtNewName1.Text != ""))
            {
                MessageBox.Show("El nombre se ha actualizado correctamente.", "Nombre actualizado");
                configEstudiante goBack = new configEstudiante();
                this.Hide();
                goBack.Show();
                
            }
            else
            {
                MessageBox.Show("No se ha podido actualizar el nombre.", "Error");
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
