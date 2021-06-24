using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoHospital
{
    public partial class Receta : Form
    {
        public Receta()
        {
            InitializeComponent();
        }

        private void Receta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Medicamento' Puede moverla o quitarla según sea necesario.
            this.medicamentoTableAdapter1.Fill(this.clinicaDataSet1.Medicamento);
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter1.Fill(this.clinicaDataSet1.Paciente);
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Medico' Puede moverla o quitarla según sea necesario.
            this.medicoTableAdapter1.Fill(this.clinicaDataSet1.Medico);
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter1.Fill(this.clinicaDataSet1.Receta);

        }

        public SqlConnection conectaBDReceta()
        {
            SqlConnection receta = new SqlConnection();
            receta.ConnectionString = "Data Source=PEPE-PC;Initial Catalog=Clinica;Integrated Security=True";
            try
            {
                receta.Open();
            }
            catch (SqlException ex)
            {
                Console.Write("No se pudo abrir la base de datos" + ex.Message);
            }
            return receta;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            SqlConnection receta = conectaBDReceta();
            if (mtbFOLIO.Text != "" && mtbFOLIO.MaskCompleted)
            {
                if (mtbFECHA.Text != "" && mtbFECHA.MaskCompleted)
                {
                    if (mtbHORA.Text != "" && mtbHORA.MaskCompleted)
                    {
                        if (cbDoctor.SelectedIndex != -1)
                        {
                            if (cbPaciente.SelectedIndex != -1)
                            {
                                if (cbMedicamento.SelectedIndex != -1)
                                {
                                    try
                                    {
                                        SqlCommand consultaAlta = new SqlCommand(string.Format("INSERT INTO Receta(Folio,Fecha,Hora,Temperatura_Corporal,Medico_Cedula,Paciente_Expediente,Medicamento_Clave)" +
                       "values('" + mtbFOLIO.Text + "','" + mtbFECHA.Text + "','" + mtbHORA.Text + "'," + nudTEMPERATURA.Value + ",'" + cbDoctor.SelectedValue.ToString() + "','" + cbPaciente.SelectedValue.ToString() + "','" + cbMedicamento.SelectedValue.ToString() + "')"), receta);

                                        if (consultaAlta.ExecuteNonQuery() > 0)
                                        {

                                            MessageBox.Show("Receta agregada");
                                            mtbFOLIO.Clear();
                                            mtbFECHA.Clear();
                                            mtbHORA.Clear();
                                            cbDoctor.SelectedIndex = -1;
                                            cbPaciente.SelectedIndex = -1;
                                            cbMedicamento.SelectedIndex = -1;
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se registro la receta");

                                        }
                                        this.recetaTableAdapter1.Fill(this.clinicaDataSet1.Receta);
                                        receta.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("EL FOLIO YA ES EXISTENTE" + ex);
                                        mtbFOLIO.Clear();

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ELIJA UN MEDICAMENTO");
                                }
                            }
                            else
                            {
                                MessageBox.Show("EL EXPEDIENTE NO ES CORRECTO O NO ESTA COMPLETO");
                            }
                        }
                        else
                        {
                            MessageBox.Show("LA CEDULA PROFESIONAL NO ES CORRECTA O NO ESTA COMPLETA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("LA HORA NO ES CORRECTA O NO ESTA COMPLETA");
                    }
                }
                else
                {
                    MessageBox.Show("LA FECHA NO ES CORRECTA O NO ESTA COMPLETA");
                }
            }
            else
            {
                MessageBox.Show("EL FOLIO NO ES CORRECTO O NO ESTA COMPLETO");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Tabla_Receta.SelectedRows.Count > 0)
            {
                try
                {
                    String Folio = Tabla_Receta.SelectedRows[0].Cells[0].Value.ToString();
                    String Consulta = "DELETE FROM Receta WHERE Folio = '" + Folio + "'";
                    SqlConnection Receta = conectaBDReceta();
                    SqlCommand EliminarMedicamento = new SqlCommand(Consulta, Receta);

                    if (EliminarMedicamento.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Receta Borrada");
                        this.recetaTableAdapter1.Fill(this.clinicaDataSet1.Receta);
                    }
                    else
                    {
                        MessageBox.Show("La receta no se ha borrado");
                    }
                    Receta.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La receta no se ha borrado");
                }


            }
            else
            {
                MessageBox.Show("No hay registros por borrar");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            try
            {
                //Boton para actualizar un registro//
                String Consulta = "UPDATE Receta SET Folio = @Folio, Fecha = @Fecha, Hora = @Hora, Temperatura_Corporal = @Temperatura_Corporal, Medico_Cedula = @Medico_Cedula, Paciente_Expediente = @Paciente_Expediente, Medicamento_Clave = @Clave  WHERE Folio = '" + Tabla_Receta.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand CambiarReceta = new SqlCommand(Consulta, conectaBDReceta());

                CambiarReceta.Parameters.Add(new SqlParameter("@Folio", mtbFOLIO.Text));
                CambiarReceta.Parameters.Add(new SqlParameter("@Fecha", mtbFECHA.Text));
                CambiarReceta.Parameters.Add(new SqlParameter("@Hora", mtbHORA.Text));
                CambiarReceta.Parameters.Add(new SqlParameter("@Temperatura_Corporal", nudTEMPERATURA.Text));
                CambiarReceta.Parameters.Add(new SqlParameter("@Medico_Cedula", SqlDbType.Text));
                CambiarReceta.Parameters.Add(new SqlParameter("@Paciente_Expediente", SqlDbType.Text));
                CambiarReceta.Parameters.Add(new SqlParameter("@Clave", SqlDbType.Text));


                CambiarReceta.Parameters["@Medico_Cedula"].Value = cbDoctor.SelectedValue.ToString();
                CambiarReceta.Parameters["@Paciente_Expediente"].Value = cbPaciente.SelectedValue.ToString();
                CambiarReceta.Parameters["@Clave"].Value = cbMedicamento.SelectedValue.ToString();

                CambiarReceta.ExecuteNonQuery();

                MessageBox.Show("La receta seleccionada se ha actualizado");

                cbPaciente.SelectedIndex = -1;
                cbDoctor.SelectedIndex = -1;
                mtbFOLIO.Clear();
                mtbFECHA.Clear();
                mtbHORA.Clear();
                nudTEMPERATURA.ResetText();

                this.recetaTableAdapter1.Fill(this.clinicaDataSet1.Receta);

                btnañadir.Enabled = true;
                btneliminar.Enabled = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡Error! No se ha completado el cambio" + ex);
            }
        }

        private void Tabla_Receta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnañadir.Enabled = false;
            btneliminar.Enabled = false;
            if (Tabla_Receta.CurrentRow.Index != 1)
            {
                mtbFOLIO.Text = Tabla_Receta.CurrentRow.Cells[0].Value.ToString();
                mtbFECHA.Text = Tabla_Receta.CurrentRow.Cells[1].Value.ToString();
                mtbHORA.Text = Tabla_Receta.CurrentRow.Cells[2].Value.ToString();
                nudTEMPERATURA.Value = Convert.ToDecimal(Tabla_Receta.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Consulta VentanaConsulta = new Consulta();
            VentanaConsulta.Show();
            this.Close();
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            InformeReceta VentanaInformeReceta = new InformeReceta();
            VentanaInformeReceta.Show();
            this.Hide();
        }
    }
}
