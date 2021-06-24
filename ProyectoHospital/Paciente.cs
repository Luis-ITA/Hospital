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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter1.Fill(this.clinicaDataSet1.Paciente);
        }

        public SqlConnection conectaBDPaciente()
        {
            SqlConnection receta = new SqlConnection();
            receta.ConnectionString = "Data Source=PEPE-PC;Initial Catalog=Clinica;User ID=sa;Password=jl990510";
            try
            {
                receta.Open();
            }
            catch (SqlException ex)
            {

                Console.Write("No se pudo abrir la base de datos " + ex.Message);
            }
            return receta;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" && maskedTextBox1.MaskCompleted)
            {
                if (tbNomPac.Text != "")
                {
                    if (numericEdad.Value != 0)
                    {
                        if (textBoxPade.Text != "")
                        {
                            if (textBoxObs.Text != "")
                            {
                                SqlConnection paciente = conectaBDPaciente();
                                String consulta = "INSERT INTO Paciente(Expediente,Nombre,Edad,Padecimiento,Observaciones)" +
                                    "values('" + maskedTextBox1.Text + "','" + tbNomPac.Text + "'," + Convert.ToInt32(numericEdad.Value) + ",'" + textBoxPade.Text + "','" + textBoxObs.Text + "')";
                                SqlCommand consultaAlta = new SqlCommand(consulta, paciente);

                                if (consultaAlta.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Paciente agregado");
                                    numericEdad.ResetText();
                                    maskedTextBox1.Clear();
                                    tbNomPac.Clear();
                                    textBoxPade.Clear();
                                    textBoxObs.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("No se almaceno el paciente");
                                    numericEdad.ResetText();
                                    maskedTextBox1.Clear();
                                    tbNomPac.Clear();
                                    textBoxPade.Clear();
                                    textBoxObs.Clear();

                                }
                                this.pacienteTableAdapter1.Fill(this.clinicaDataSet1.Paciente);
                                paciente.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ingrese las observaciones");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese padecimiento");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la edad del paciente");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre del paciente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese N° de Expediente");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGWPaci.SelectedRows.Count > 0)
            {
                try
                {
                    String Expediente = dataGWPaci.SelectedRows[0].Cells[0].Value.ToString();
                    String Consulta = "DELETE FROM Paciente WHERE Expediente= '" + Expediente + "' ";
                    SqlConnection paciente = conectaBDPaciente();
                    SqlCommand consultaBaja = new SqlCommand(Consulta, paciente);
                    if (consultaBaja.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Paciente borrado");
                        this.pacienteTableAdapter1.Fill(this.clinicaDataSet1.Paciente);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar al paciente");
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("No se pudo eleiminar al paciente" + ex);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos para borrar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Boton para actualizar un registro//
                String Consulta = "UPDATE Paciente SET Expediente = @Expediente, Nombre = @Nombre, Edad = @Edad, Padecimiento = @Padecimiento, Observaciones = @Observaciones  WHERE Expediente = '" + dataGWPaci.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand CambiarPaciente = new SqlCommand(Consulta, conectaBDPaciente());

                CambiarPaciente.Parameters.Add(new SqlParameter("@Expediente", maskedTextBox1.Text));
                CambiarPaciente.Parameters.Add(new SqlParameter("@Nombre", tbNomPac.Text));
                CambiarPaciente.Parameters.Add(new SqlParameter("@Edad", numericEdad.Text));
                CambiarPaciente.Parameters.Add(new SqlParameter("@Padecimiento", textBoxPade.Text));
                CambiarPaciente.Parameters.Add(new SqlParameter("@Observaciones", textBoxObs.Text));

                CambiarPaciente.ExecuteNonQuery();

                MessageBox.Show("El paciente seleccionado se ha actualizado");

                numericEdad.ResetText();
                maskedTextBox1.Clear();
                tbNomPac.Clear();
                textBoxPade.Clear();
                textBoxObs.Clear();

                this.pacienteTableAdapter1.Fill(this.clinicaDataSet1.Paciente);

                btnañadir.Enabled = true;
                btneliminar.Enabled = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡Error! No se ha completado el cambio" + ex);
            }
        }

        private void dataGWPaci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnañadir.Enabled = false;
            btneliminar.Enabled = false;
            if (dataGWPaci.CurrentRow.Index != -1)
            {
                maskedTextBox1.Text = dataGWPaci.CurrentRow.Cells[0].Value.ToString();
                tbNomPac.Text = dataGWPaci.CurrentRow.Cells[1].Value.ToString();
                numericEdad.Value = Convert.ToDecimal(dataGWPaci.CurrentRow.Cells[2].Value.ToString());
                textBoxPade.Text = dataGWPaci.CurrentRow.Cells[3].Value.ToString();
                textBoxObs.Text = dataGWPaci.CurrentRow.Cells[4].Value.ToString();
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
            InformePaciente VentanaInformePaciente = new InformePaciente();
            VentanaInformePaciente.Show();
            this.Hide();
        }
    }
}
