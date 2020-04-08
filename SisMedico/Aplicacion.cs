using SisMedico.Modulo_Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisMedico
{
    public partial class Aplicacion : Form
    {
        public Aplicacion()
        {
            InitializeComponent();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicos medico = new Medicos();
            medico.MdiParent = this;
            medico.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Habitaciones habitacion = new Habitaciones();
            habitacion.MdiParent = this;
            habitacion.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas cita = new Citas();
            cita.MdiParent = this;
            cita.Show();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresos ingreso = new Ingresos();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Altas alta = new Altas();
            alta.MdiParent = this;
            alta.Show();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EscogerPacientes paciente = new EscogerPacientes();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void medicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EscogerMedicos medico = new EscogerMedicos();
            medico.MdiParent = this;
            medico.Show();
        }

        private void habitacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EscogerHabitacion habitacion = new EscogerHabitacion();
            habitacion.MdiParent = this;
            habitacion.Show();
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EscogerCitas cita = new EscogerCitas();
            cita.MdiParent = this;
            cita.Show();
        }

        private void ingresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EscogerIngreso ingreso = new EscogerIngreso();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void altasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EscogerAltas altas = new EscogerAltas();
            altas.MdiParent = this;
            altas.Show();
        }
    }
}
