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
    public partial class EscogerAltas : Form
    {
        int indice = 0;
        ConexionAltas altas = new ConexionAltas();
        public EscogerAltas()
        {
            InitializeComponent();
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
                dataGridView1.DataSource = altas.BuscarAltasFecha(tBuscar.Text);
            }
            else if (cBuscar.GetItemText(cBuscar.Items[indice]) == "Paciente")
            {
                dataGridView1.DataSource = altas.BuscarAltasPacientes(tBuscar.Text);

            }
            else
            {
                Datos();
            }
        }

        private void Datos()
        {
            dataGridView1.DataSource = altas.MostrarAltas();
        }

        private void EscogerAltas_Load(object sender, EventArgs e)
        {
            Datos();
        }
    }
}
