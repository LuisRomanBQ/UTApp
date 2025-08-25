using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Clases;
using UTApp.ClasesControladoras;
using UTApp.Forms.Estudiantes;

namespace UTApp_POO
{
    public partial class misAsignaciones : Form
    {
        AsignacionControlador AsigControl = new AsignacionControlador();
        List<Asignacion> asignaciones = new List<Asignacion>();
        PlataformaControlador PlatControl = new PlataformaControlador();
        List<Plataforma> plataformas = new List<Plataforma>();
        ClaseEstudianteID estudiante;

        public misAsignaciones(ClaseEstudianteID actual)
        {
            InitializeComponent();
            asignaciones = AsigControl.ListarAsignaciones();
            plataformas = PlatControl.ListarPlataformas();
            estudiante = actual;
        }
        public Panel CrearPanelAsignacion(Asignacion asignacion)
        {
            Panel PnlAsignacion = new Panel();
            PnlAsignacion.Width = 270;
            PnlAsignacion.Height = 120;
            PnlAsignacion.Margin = new Padding(10);
            PnlAsignacion.BackColor = Color.WhiteSmoke;
            PnlAsignacion.ForeColor = Color.Black;

            Label Titulo = new Label();
            Titulo.Dock = DockStyle.Top;
            Titulo.TextAlign = ContentAlignment.TopCenter;
            Titulo.Font = new Font ("Segoe UI", 12, FontStyle.Regular);
            Titulo.Text = asignacion.AsignacionTitulo;

            Label Info = new Label();
            Info.Dock = DockStyle.Fill;
            Info.AutoSize = false;
            Info.TextAlign = ContentAlignment.MiddleLeft;
            Info.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            Info.ForeColor = Color.White;
            Info.BackColor = Color.SeaGreen;
            foreach (Plataforma plataforma in plataformas)
            {
                if (plataforma.PlataformaID == asignacion.PlataformaID)
                {
                    Info.Text = $"{plataforma.PlataformaNombre}\n{asignacion.AsignacionFechaLimite.ToString()}";
                }
            }

            Label Entrega = new Label();
            Button Check = new Button();
            Check.Dock = DockStyle.Bottom;
            Check.Width = 50;
            Check.Height = 30;
            Check.ForeColor = Color.White;
            Check.FlatStyle = FlatStyle.Popup;
            Check.BackColor = Color.IndianRed;
            Check.Text = "Sin Entregar";
            Check.Location = new Point(PnlAsignacion.Width - Check.Width - 10, PnlAsignacion.Height - Check.Height - 10);

            Check.Click += (s, e) =>
            {
                asignacion.AsignacionEntrega = !asignacion.AsignacionEntrega;
                if (asignacion.AsignacionEntrega == false)
                {
                    if (AsigControl.EditarAsignacion(asignacion))
                    {
                        Check.BackColor = Color.IndianRed;
                        Check.Text = "Sin Entregar";
                    }
                }
                else
                {
                    if (AsigControl.EditarAsignacion(asignacion))
                    {
                        Check.BackColor = Color.DarkSeaGreen;
                        Check.Text = "Entregado";
                    }
                }
            };

            PnlAsignacion.Controls.Add(Titulo);
            PnlAsignacion.Controls.Add(Info);
            PnlAsignacion.Controls.Add(Check);

            return PnlAsignacion;
        }
        private void MisAsignaciones_Load(object sender, EventArgs e)
        {
            if (asignaciones.Count > 0)
            {
                foreach (Asignacion asignacion in asignaciones)
                {
                    Asignaciones.Controls.Add(CrearPanelAsignacion(asignacion));
                }
            }
            else
            {
                Label Titulo = new Label();
                Titulo.Dock = DockStyle.Top;
                Titulo.TextAlign = ContentAlignment.MiddleCenter;
                Titulo.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                Titulo.Text = "Usted no se le ha asignado ninguna actividad";
                Titulo.ForeColor = Color.White;
                Titulo.BackColor = Color.SeaGreen;
                Asignaciones.Controls.Add(Titulo);
            }
        }

        private void MisAsignaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            pantallaEstudiante pEstudiante = new pantallaEstudiante(estudiante);
            this.Hide();
            pEstudiante.Show();
        }

        private void Asignaciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
