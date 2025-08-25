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
using UTApp_POO;

namespace UTApp_POO
{
    public partial class pantallaEstudiante : Form
    {
        ClaseEstudianteID estudiante;
        int Pendientes;
        public pantallaEstudiante(ClaseEstudianteID actual)
        {
            InitializeComponent();
            estudiante = actual;
        }
        public pantallaEstudiante()
        {
            InitializeComponent();
        }

        private void pantallaEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHorarioGrupal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente...", "No disponible");
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente...", "No disponible");
        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Bienvenida salir = new Bienvenida();
                this.Hide();
                salir.Show();
            }
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            configEstudiante config = new configEstudiante();
            this.Hide();
            config.Show();
        }
         
        private void pantallaEstudiante_Load(object sender, EventArgs e)
        {
            if (estudiante != null)
            {
                labelSaludo.Text = $"¡Hola, {estudiante.EstudianteNombreCompleto}!";
                labelPendientes.Text = $"Tienes {Pendientes} pendientes.";
            }
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            MisAsignaciones asignaciones = new MisAsignaciones(estudiante);
            asignaciones.Show();
            this.Hide();
        }
    }
}
