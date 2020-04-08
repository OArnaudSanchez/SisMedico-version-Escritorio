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
    public partial class EscogerHabitacion : Form
    {
        ConexionHabitaciones habitacion = new ConexionHabitaciones();
        public static string IDHabitacion;
        public static string TipoHabitacion;
        public static string PrecioHabitacion;
        int indice = 0;
        public EscogerHabitacion()
        {
            InitializeComponent();
        }
        private void Datos()
        {
           dataGridView1.DataSource= habitacion.MostrarHabitaciones();
        }

        private void EscogerHabitacion_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDHabitacion = dataGridView1.Rows[e.RowIndex].Cells["idHabitacion"].Value.ToString();
            TipoHabitacion = dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            PrecioHabitacion = dataGridView1.Rows[e.RowIndex].Cells["precioDia"].Value.ToString();



            if (IDHabitacion == "" || TipoHabitacion=="")
            {
                MessageBox.Show("Debe Seleccionar el La Habitacion");
            }
            else
            {
                this.Close();
            }
        }

        private void cBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cBuscar.SelectedIndex;
            if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Seleccionar Habitacion")
            {
                Datos();
            }
             else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Doble")
            {
                dataGridView1.DataSource = habitacion.BuscarHabitacionesTipo("DOBLE");
            }
             else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Suite")
            {
                dataGridView1.DataSource = habitacion.BuscarHabitacionesTipo("SUITE");

            }
            else
            {
                dataGridView1.DataSource = habitacion.BuscarHabitacionesTipo("PRIVADA");


            }
        }
    }
}
