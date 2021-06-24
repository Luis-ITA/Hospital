using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHospital
{
    public partial class InformeMedicamento : Form
    {
        public InformeMedicamento()
        {
            InitializeComponent();
        }

        private void InformeMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.VistaMedicamento' Puede moverla o quitarla según sea necesario.
            this.VistaMedicamentoTableAdapter.Fill(this.ClinicaDataSet.VistaMedicamento);

            this.reportViewer1.RefreshReport();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Medicamento VentanaMedicamento = new Medicamento();
            VentanaMedicamento.Show();
            this.Close();
        }
    }
}
