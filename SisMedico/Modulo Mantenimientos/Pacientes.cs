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
    public partial class Pacientes : Form
    {
        ConexionPacientes paciente = new ConexionPacientes();
        int indice = 0;
        int posicion;
        public Pacientes()
        {
            InitializeComponent();
        }

        private void Datos()
        {
            dataGridView1.DataSource = paciente.MostrarPacientes();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            indice = cAsegurado.SelectedIndex;
            try
            {
                if (tNombre.Text == string.Empty || tCedula.Text == string.Empty ||
                     cAsegurado.GetItemText(cAsegurado.Items[indice]) == string.Empty)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    paciente.Cedula = tCedula.Text;
                    paciente.Nombre = tNombre.Text;
                    paciente.Asegurado = cAsegurado.GetItemText(cAsegurado.Items[indice]);

                    paciente.IngresarPaciente(paciente.Cedula,paciente.Nombre,paciente.Asegurado);
                    MessageBox.Show("Paciente Registrado Correctamente");
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
            indice = cAsegurado.SelectedIndex;
            try
            {
                if (tID.Text == string.Empty|| tNombre.Text == string.Empty || tCedula.Text == string.Empty ||
                     cAsegurado.GetItemText(cAsegurado.Items[indice]) == string.Empty)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    paciente.IDPaciente = int.Parse(tID.Text);
                    paciente.Cedula = tCedula.Text;
                    paciente.Nombre = tNombre.Text;
                    paciente.Asegurado = cAsegurado.GetItemText(cAsegurado.Items[indice]);

                    paciente.ModificarPaciente(paciente.IDPaciente,paciente.Cedula, paciente.Nombre, paciente.Asegurado);
                    MessageBox.Show("Paciente Modificado Correctamente");
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
                if (tID.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar El id del paciente a Eliminar");
                }
                else
                {
                    paciente.IDPaciente = int.Parse(tID.Text);

                    paciente.EliminarPaciente(paciente.IDPaciente);
                    MessageBox.Show("Paciente Eliminado Correctamente");
                    Datos();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //private void bBuscar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (tID.Text == string.Empty)
        //        {
        //            MessageBox.Show("Debe seleccionar El id del paciente a Buscar");
        //        }
        //        else
        //        {
        //            paciente.IDPaciente = int.Parse(tID.Text);

        //           dataGridView1.DataSource = paciente.BuscarPacientesID(paciente.IDPaciente);
                  
        //        }

        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message);
        //    }
        //}

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            tID.Clear();
            tNombre.Clear();
            tCedula.Clear();
            Datos();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            EscogerPacientes paciente = new EscogerPacientes();
            paciente.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            tID.Text = dataGridView1[0, posicion].Value.ToString();
            tNombre.Text = dataGridView1[2, posicion].Value.ToString();
            tCedula.Text = dataGridView1[1, posicion].Value.ToString();
            cAsegurado.Text = dataGridView1[3, posicion].Value.ToString();
        }
    }
}
