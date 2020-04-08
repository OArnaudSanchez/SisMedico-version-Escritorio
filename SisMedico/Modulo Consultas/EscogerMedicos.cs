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
    public partial class EscogerMedicos : Form
    {
        ConexionMedicos medico = new ConexionMedicos();
        public static string IDMedico;
        public static string NombreMedico;

        int indice = 0;
        public EscogerMedicos()
        {
            InitializeComponent();
        }


        private void Datos()
        {
            dataGridView1.DataSource = medico.MostrarMedicos();
        }

        private void EscogerMedicos_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDMedico = dataGridView1.Rows[e.RowIndex].Cells["idMedico"].Value.ToString();
            NombreMedico = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

            if (IDMedico == "")
            {
                MessageBox.Show("Debe Seleccionar el Medico");
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
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Nombre")
            {
                dataGridView1.DataSource = medico.BuscarMedicoNombre(tBuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = medico.BuscarMedicoEspecialidad(tBuscar.Text);

            }

        }
    }
}
