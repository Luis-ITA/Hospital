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
    public partial class InformeConsulta : Form
    {
        public InformeConsulta()
        {
            InitializeComponent();
        }

        private void InformeConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.VistaConsulta' Puede moverla o quitarla según sea necesario.
            this.VistaConsultaTableAdapter.Fill(this.ClinicaDataSet.VistaConsulta);

            this.reportViewer1.RefreshReport();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Consulta VentanaConsulta = new Consulta();
            VentanaConsulta.Show();
            this.Close();
        }
    }
}
