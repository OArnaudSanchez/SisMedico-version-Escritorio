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
    public partial class Citas : Form
    {
        ConexionCitas cita = new ConexionCitas();
        int posicion;
        public Citas()
        {
            InitializeComponent();
        }

        private void Datos()
        {
            dataGridView1.DataSource =cita.MostrarCitas();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void bSeleccionarPaciente_Click(object sender, EventArgs e)
        {
            EscogerPacientes paciente = new EscogerPacientes();
            paciente.ShowDialog();
            tPaciente.Text = EscogerPacientes.NombrePaciente;
            lIDPaciente.Text = EscogerPacientes.IDPaciente;
        }

        private void bSeleccionarMedico_Click(object sender, EventArgs e)
        {
            EscogerMedicos medico = new EscogerMedicos();
            medico.ShowDialog();
            tMedico.Text = EscogerMedicos.NombreMedico;
            lIDMedico.Text = EscogerMedicos.IDMedico;
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tPaciente.Text == string.Empty || tMedico.Text == string.Empty || fecha.Value == null)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    cita.IDMedico = int.Parse(lIDMedico.Text);
                    cita.IDPaciente = int.Parse(lIDPaciente.Text);
                    cita.Fecha = fecha.Value;

                    cita.IngresarCita(int.Parse(lIDPaciente.Text),int.Parse(lIDMedico.Text),fecha.Value);
                    MessageBox.Show("Cita Registrada Correctamente");
                    Datos();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tPaciente.Text == string.Empty || tMedico.Text == string.Empty || fecha.Value == null)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    cita.IDMedico = int.Parse(lIDMedico.Text);
                    cita.IDPaciente = int.Parse(lIDPaciente.Text);
                    cita.Fecha = fecha.Value;
                    cita.IDCita = int.Parse(tID.Text);

                    cita.ModificarCita(int.Parse(tID.Text),int.Parse(lIDPaciente.Text),
                        int.Parse(lIDMedico.Text), fecha.Value);
                    MessageBox.Show("Cita Modificada Correctamente");
                    Datos();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tID.Text==string.Empty)
                {
                    MessageBox.Show("Debe seleccionar la Cita a eliminar");
                }
                else
                {

                    cita.IDCita = int.Parse(tID.Text);

                    cita.EliminarCita(int.Parse(tID.Text));
                    MessageBox.Show("Cita Eliminada Correctamente");
                    Datos();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            tID.Clear();
            tPaciente.Clear();
            tMedico.Clear();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            EscogerCitas citas = new EscogerCitas();
            citas.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            tID.Text = dataGridView1[0, posicion].Value.ToString();
            tPaciente.Text = dataGridView1[1, posicion].Value.ToString();
            tMedico.Text = dataGridView1[2, posicion].Value.ToString();
            fecha.Text = dataGridView1[3, posicion].Value.ToString();
        }
    }
}
