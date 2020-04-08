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
    public partial class Altas : Form
    {
        ConexionAltas alta = new ConexionAltas();
       
        int posicion;

        public Altas()
        {
            
            InitializeComponent();
        }


        private void Datos()
        {
            dataGridView1.DataSource = alta.MostrarAltas();
        }

        private void Altas_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void bSeleccionarIngreso_Click(object sender, EventArgs e)
        {
            EscogerIngreso ingreso = new EscogerIngreso();
            ingreso.ShowDialog();
            tIngreso.Text = EscogerIngreso.IDIngreso;
            tFechaIngreso.Text = EscogerIngreso.Fecha;
            tPaciente.Text = EscogerIngreso.NombrePaciente;
            tMedico.Text = EscogerIngreso.NombreMedico;
            tHabitacion.Text =EscogerIngreso.TipoHabitacion;
            lPrecio.Text = EscogerIngreso.PrecioHabitacion;
            
         
        }

       

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tPaciente.Text == string.Empty || tHabitacion.Text == string.Empty
                    || tMedico.Text == string.Empty || fecha.Value == null ||
                    tIngreso.Text == string.Empty)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    alta.IDIngreso = int.Parse(tIngreso.Text);

                    alta.fechaSalida = fecha.Value;
                    alta.Monto = int.Parse(tMonto.Text);

                    alta.IngresarAlta(int.Parse(tIngreso.Text), fecha.Value, int.Parse(tMonto.Text));
                    MessageBox.Show("Alta Registrada Correctamente");
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
                if (tID.Text==string.Empty||tPaciente.Text == string.Empty || tHabitacion.Text == string.Empty
                    || tMedico.Text == string.Empty || fecha.Value == null ||
                    tIngreso.Text == string.Empty)
                {
                    MessageBox.Show("No campos Vacios");
                }
                else
                {
                    alta.IDAlta = int.Parse(tID.Text);
                    alta.IDIngreso = int.Parse(tIngreso.Text);

                    alta.fechaSalida = fecha.Value;
                    alta.Monto = int.Parse(tMonto.Text);

                    alta.ModificarAlta(int.Parse(tID.Text),int.Parse(tIngreso.Text), fecha.Value, int.Parse(tMonto.Text));
                    MessageBox.Show("Alta Modificada Correctamente");
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
                    MessageBox.Show("Seleccione el Id que desea Modificar");
                }
                else
                {
                    alta.IDAlta = int.Parse(tID.Text);


                    alta.EliminarAlta(int.Parse(tID.Text));
                    MessageBox.Show("Alta Eliminada Correctamente");
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
            Datos();
            tIngreso.Clear();
            tMedico.Clear();
            tHabitacion.Clear();
            tFechaIngreso.Clear();
            tPaciente.Clear();
            tMonto.Clear();
            lPrecio.Text = "";
 
        }
 

        private string CalcularMonto(int dias,string tipo, int precio)
        {

            if (tipo == "DOBLE")
            {
                return tMonto.Text = (precio * dias).ToString();
                
            }
            else if (tipo == "PRIVADA")
            {
                return tMonto.Text = (precio * dias).ToString();

            }
            else if (tipo == "SUITE")
            {
                return tMonto.Text = (precio * dias).ToString();

            }
            else
            {
                return tMonto.Text = (0).ToString();
            }
            
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            if(tFechaIngreso.Text != string.Empty)
            {
                DateTime fechaInicio = DateTime.Parse(tFechaIngreso.Text);
                DateTime fechaSalida = DateTime.Parse(fecha.Value.ToString());


                TimeSpan time = fechaSalida - fechaInicio;

               int dias = time.Days;

                CalcularMonto(dias, tHabitacion.Text, int.Parse(EscogerIngreso.PrecioHabitacion));
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            EscogerAltas altas = new EscogerAltas();
            altas.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            tID.Text = dataGridView1[0, posicion].Value.ToString();
            tIngreso.Text = dataGridView1[1, posicion].Value.ToString();
         
            tPaciente.Text = dataGridView1[3, posicion].Value.ToString();
            tMedico.Text = dataGridView1[4, posicion].Value.ToString();
            tHabitacion.Text = dataGridView1[5, posicion].Value.ToString();
            lPrecio.Text = dataGridView1[6, posicion].Value.ToString();
            tFechaIngreso.Text = dataGridView1[7, posicion].Value.ToString();
            tMonto.Text = dataGridView1[9, posicion].Value.ToString();
            


        }
    }
}
