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
    public partial class InformeReceta : Form
    {
        public InformeReceta()
        {
            InitializeComponent();
        }

        private void InformeReceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.VistaReceta' Puede moverla o quitarla según sea necesario.
            this.VistaRecetaTableAdapter.Fill(this.ClinicaDataSet.VistaReceta);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Receta VentanaReceta = new Receta();
            VentanaReceta.Show();
            this.Close();
        }
    }
}
