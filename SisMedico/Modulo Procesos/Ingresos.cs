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
    public partial class Ingresos : Form
    {
        ConexionIngresos ingreso = new ConexionIngresos();
        int posicion;
        public Ingresos()
        {
            InitializeComponent();
        }

        private void Datos()
        {
            dataGridView1.DataSource = ingreso.MostrarIngresos();
        }
        private void Ingresos_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void bSeleccionarHabitacion_Click(object sender, EventArgs e)
        {
            EscogerHabitacion habitacion = new EscogerHabitacion();
            habitacion.ShowDialog();
            tHabitacion.Text = EscogerHabitacion.TipoHabitacion;
            lIDHabitacion.Text = EscogerHabitacion.IDHabitacion;
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
                if (tPaciente.Text == string.Empty | tHabitacion.Text ==  string.Empty 
                    || tMedico.Text == string.Empty || fecha.Value == null)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    ingreso.IDMedico = int.Parse(lIDMedico.Text);
                    ingreso.IDHabitacion = int.Parse(lIDHabitacion.Text);
                    ingreso.IDPaciente = int.Parse(lIDPaciente.Text);
                    ingreso.FechaIngreso = fecha.Value;

                    ingreso.IngresarIngreso(int.Parse(lIDPaciente.Text),
                        int.Parse(lIDHabitacion.Text),int.Parse(lIDMedico.Text), fecha.Value);
                    MessageBox.Show("Ingreso Registrado Correctamente");
                    Datos();
                }

            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tID.Text==string.Empty ||tPaciente.Text == string.Empty | tHabitacion.Text == string.Empty
                    || tMedico.Text == string.Empty || fecha.Value == null)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    ingreso.IDIngreso = int.Parse(tID.Text);
                    ingreso.IDMedico = int.Parse(lIDMedico.Text);
                    ingreso.IDHabitacion = int.Parse(lIDHabitacion.Text);
                    ingreso.IDPaciente = int.Parse(lIDPaciente.Text);
                    ingreso.FechaIngreso = fecha.Value;

                    ingreso.ModificarIngreso(int.Parse(tID.Text), int.Parse(lIDPaciente.Text),
                        int.Parse(lIDHabitacion.Text), int.Parse(lIDMedico.Text), fecha.Value);
                    MessageBox.Show("Ingreso Modificado Correctamente");
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
                if (tID.Text == string.Empty )
                {
                    MessageBox.Show("Debe seleccionar el ID a eliminar");
                }
                else
                {
                    ingreso.IDIngreso = int.Parse(tID.Text);
                    

                    ingreso.EliminarIngreso(int.Parse(tID.Text));
                    MessageBox.Show("Ingreso Eliminado Correctamente");
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
            tHabitacion.Clear();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            EscogerIngreso ingreso = new EscogerIngreso();
            ingreso.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            tID.Text = dataGridView1[0, posicion].Value.ToString();
            tPaciente.Text = dataGridView1[1, posicion].Value.ToString();
            tHabitacion.Text = dataGridView1[2, posicion].Value.ToString();
            tMedico.Text = dataGridView1[4, posicion].Value.ToString();
            fecha.Text = dataGridView1[5, posicion].Value.ToString();

        }
    }
}
