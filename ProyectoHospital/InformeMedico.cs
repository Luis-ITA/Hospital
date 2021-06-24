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
    public partial class InformeMedico : Form
    {
        public InformeMedico()
        {
            InitializeComponent();
        }

        private void InformeMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.MedicoPaciente' Puede moverla o quitarla según sea necesario.
            this.MedicoPacienteTableAdapter.Fill(this.ClinicaDataSet.MedicoPaciente);

            this.reportViewer1.RefreshReport();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Medico VentanaMedico = new Medico();
            VentanaMedico.Show();
            this.Close();
        }
    }
}
