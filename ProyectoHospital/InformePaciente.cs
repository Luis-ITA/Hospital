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
    public partial class InformePaciente : Form
    {
        public InformePaciente()
        {
            InitializeComponent();
        }

        private void InformePaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.VistaPaciente' Puede moverla o quitarla según sea necesario.
            this.VistaPacienteTableAdapter.Fill(this.ClinicaDataSet.VistaPaciente);
            this.reportViewer1.RefreshReport();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Paciente VentanaPaciente = new Paciente();
            VentanaPaciente.Show();
            this.Close();
        }
    }
}
