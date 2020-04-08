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
    public partial class Medicos : Form
    {
        ConexionMedicos medico = new ConexionMedicos();
        int indice = 0;
        int posicion;
        public Medicos()
        {
            InitializeComponent();
        }

        private void Datos()
        {
            dataGridView1.DataSource = medico.MostrarMedicos();
        }

        private void Medicos_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            indice = cEspecialidad.SelectedIndex;
            try {
                if (tNombre.Text == string.Empty || tExequatur.Text==string.Empty ||
                     cEspecialidad.GetItemText(cEspecialidad.Items[indice]) == string.Empty)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    medico.Nombre = tNombre.Text;
                    medico.Exequatur = tExequatur.Text;

                    medico.Especialidad = cEspecialidad.GetItemText(cEspecialidad.Items[indice]);

                    medico.IngresarMedico(medico.Nombre,medico.Exequatur,medico.Especialidad);
                    MessageBox.Show("Medico Registrado Correctamente");
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
            indice = cEspecialidad.SelectedIndex;
            try
            {
                if (tID.Text==string.Empty||tNombre.Text == string.Empty || tExequatur.Text == string.Empty ||
                     cEspecialidad.GetItemText(cEspecialidad.Items[indice]) == string.Empty)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    medico.IDMedico = int.Parse(tID.Text);
                    medico.Nombre = tNombre.Text;
                    medico.Exequatur = tExequatur.Text;

                    medico.Especialidad = cEspecialidad.GetItemText(cEspecialidad.Items[indice]);
                    medico.ModificarMedico(medico.IDMedico,medico.Nombre, medico.Exequatur, medico.Especialidad);

                    MessageBox.Show("Medico Modificado Correctamente");
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
                    MessageBox.Show("Debe Ingresar El ID del medico que desea eliminar");
                }
                else
                {
                    medico.IDMedico = int.Parse(tID.Text);

                    medico.EliminarMedico(medico.IDMedico);
                    MessageBox.Show("Medico Eliminado Correctamente");
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
        //            MessageBox.Show("Debe Ingresar El ID del medico que desea eliminar");
        //        }
        //        else
        //        {
        //            medico.IDMedico = int.Parse(tID.Text);

        //             dataGridView1.DataSource =   medico.BuscarMedicoID(medico.IDMedico);
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
            tExequatur.Clear();
            Datos();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            EscogerMedicos medico = new EscogerMedicos();
            medico.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            tID.Text = dataGridView1[0, posicion].Value.ToString();
            tNombre.Text = dataGridView1[1, posicion].Value.ToString();
            tExequatur.Text = dataGridView1[2, posicion].Value.ToString();
            cEspecialidad.Text = dataGridView1[3, posicion].Value.ToString();
        }
    }
}
