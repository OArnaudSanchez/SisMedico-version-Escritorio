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
    public partial class Habitaciones : Form
    {
        ConexionHabitaciones habitacion = new ConexionHabitaciones();
        int indice = 0;
        int posicion;
        public Habitaciones()
        {
            InitializeComponent();
        }

        private void Datos()
        {
            dataGridView1.DataSource = habitacion.MostrarHabitaciones();
        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            indice = cTipo.SelectedIndex;
            try
            {
                if (tNumero.Text == string.Empty || tPrecio.Text == string.Empty ||
                     cTipo.GetItemText(cTipo.Items[indice]) == string.Empty)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    habitacion.Numero = int.Parse(tNumero.Text);
                    habitacion.PrecioPorDia = int.Parse(tPrecio.Text);
                   habitacion.Tipo = cTipo.GetItemText(cTipo.Items[indice]);

                    habitacion.IngresarHabitacion(habitacion.Numero,habitacion.Tipo,habitacion.PrecioPorDia);
                    MessageBox.Show("Habitacion Registrada Correctamente");
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
            indice = cTipo.SelectedIndex;
            try
            {
                if (tID.Text == string.Empty||tNumero.Text == string.Empty || tPrecio.Text == string.Empty ||
                     cTipo.GetItemText(cTipo.Items[indice]) == string.Empty)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    habitacion.IDHabitacion = int.Parse(tID.Text);
                    habitacion.Numero = int.Parse(tNumero.Text);
                    habitacion.PrecioPorDia = int.Parse(tPrecio.Text);
                    habitacion.Tipo = cTipo.GetItemText(cTipo.Items[indice]);

                    habitacion.ModificarHabitacion(habitacion.IDHabitacion,habitacion.Numero, habitacion.Tipo, habitacion.PrecioPorDia);
                    MessageBox.Show("Habitacion Modificada Correctamente");
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
                    MessageBox.Show("Debe seleccionar el Id A eliminar");
                }
                else
                {
                    habitacion.IDHabitacion = int.Parse(tID.Text);

                    habitacion.EliminarHabitacion(habitacion.IDHabitacion);
                    MessageBox.Show("Habitacion Eliminada Correctamente");
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
            tNumero.Clear();
            tPrecio.Clear();
            Datos();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            EscogerHabitacion habitacion = new EscogerHabitacion();
            habitacion.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            tID.Text = dataGridView1[0, posicion].Value.ToString();
            tNumero.Text = dataGridView1[1, posicion].Value.ToString();
            tPrecio.Text = dataGridView1[3, posicion].Value.ToString();
            cTipo.Text = dataGridView1[2, posicion].Value.ToString();
        }
    }
}
