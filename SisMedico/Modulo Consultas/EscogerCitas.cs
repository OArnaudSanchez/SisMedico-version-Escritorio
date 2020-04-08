using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisMedico.Modulo_Consultas
{
    public partial class EscogerCitas : Form
    {
        ConexionCitas citas = new ConexionCitas();
        int indice = 0;
        public EscogerCitas()
        {
            InitializeComponent();
        }

        private void Datos()
        {
            dataGridView1.DataSource = citas.MostrarCitas();
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
                dataGridView1.DataSource = citas.BuscarCitasFecha(tBuscar.Text);
            }
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Doctor")
            {
                dataGridView1.DataSource = citas.BuscarCitasDoctor(tBuscar.Text);

            }
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Paciente")
            {
                dataGridView1.DataSource = citas.BuscarCitasPaciente(tBuscar.Text);

            }
            else
            {
                Datos();
            }
        }

        private void EscogerCitas_Load(object sender, EventArgs e)
        {
            Datos();
        }
    }
}
