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
    public partial class EscogerPacientes : Form
    {
        ConexionPacientes paciente = new ConexionPacientes();
        public static string IDPaciente;
        public static string NombrePaciente;


        int indice =0;
        
        public EscogerPacientes()
        {
            InitializeComponent();
        }

        private void Datos()
        {
           dataGridView1.DataSource= paciente.MostrarPacientes();
        }

        private void EscogerPacientes_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDPaciente = dataGridView1.Rows[e.RowIndex].Cells["idPaciente"].Value.ToString();
            NombrePaciente = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();


            if (IDPaciente == "")
            {
                MessageBox.Show("Debe Seleccionar el Paciente");
            }
            else
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            indice = cBuscar.SelectedIndex;
            if (tBuscar.Text == string.Empty || indice == -1 )
            {
                Datos();
            }
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Nombre"){
               dataGridView1.DataSource = paciente.BuscarPacientesNombre(tBuscar.Text);
            }
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Cedula")
            {
                dataGridView1.DataSource = paciente.BuscarPacientesCedula(tBuscar.Text);

            }
            else
            {
                Datos();
            }
        }

        private void cBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cBuscar.SelectedIndex;
            //MessageBox.Show(cBuscar.GetItemText(cBuscar.Items[indice]));
            if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Asegurado")
            {
                dataGridView1.DataSource = paciente.BuscarPacientesAsegurado("SI");

            }
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "No Asegurado")
            {
                dataGridView1.DataSource = paciente.BuscarPacientesAsegurado("NO");

            }
            else
            {
                Datos();
            }
        }
    }
}
