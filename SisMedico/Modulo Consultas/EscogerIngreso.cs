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
    public partial class EscogerIngreso : Form
    {
        ConexionIngresos ingreso = new ConexionIngresos();
        public static string IDIngreso;
        public static string Fecha;
        public static string IDPaciente;
        public static string NombrePaciente;
        public static string IDHabitacion;
        public static string TipoHabitacion;
        public static string PrecioHabitacion;
        public static string IDMedico;
        public static string NombreMedico;
        int indice = 0;
        public EscogerIngreso()
        {
            InitializeComponent();
        }

        private void Datos()
        {
            dataGridView1.DataSource =  ingreso.MostrarIngresos();
        }

        private void EscogerIngreso_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDIngreso = dataGridView1.Rows[e.RowIndex].Cells["idIngreso"].Value.ToString();
            NombrePaciente = dataGridView1.Rows[e.RowIndex].Cells["Paciente"].Value.ToString();
            TipoHabitacion = dataGridView1.Rows[e.RowIndex].Cells["Habitacion"].Value.ToString();
            NombreMedico = dataGridView1.Rows[e.RowIndex].Cells["Medico"].Value.ToString();
            Fecha = dataGridView1.Rows[e.RowIndex].Cells["fechaIngreso"].Value.ToString();
            PrecioHabitacion = dataGridView1.Rows[e.RowIndex].Cells["Precio Habitacion"].Value.ToString();
         



            if (IDIngreso == "" || Fecha =="" || NombrePaciente==""
                || TipoHabitacion ==""||NombreMedico=="" || PrecioHabitacion =="")
            {
                MessageBox.Show("Debe Seleccionar el Ingreso");
            }
            else
            {
                this.Close();
            }
        }

        private void tBuscar_TextChanged(object sender, EventArgs e)
        {
            indice = cBuscar.SelectedIndex;
            if (tBuscar.Text == string.Empty || indice == -1)
            {
                Datos();
            }
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Fecha")
            {
                dataGridView1.DataSource = ingreso.BuscarIngresosFecha(tBuscar.Text);
            }
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Habitacion")
            {
                dataGridView1.DataSource = ingreso.BuscarIngresosHabitacion(tBuscar.Text);

            }
            else
            {
                Datos();

            }
        }
    }
}
