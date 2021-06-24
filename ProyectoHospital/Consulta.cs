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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Consulta' Puede moverla o quitarla según sea necesario.
            this.consultaTableAdapter1.Fill(this.clinicaDataSet1.Consulta);
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter1.Fill(this.clinicaDataSet1.Paciente);
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Medico' Puede moverla o quitarla según sea necesario.
            this.medicoTableAdapter1.Fill(this.clinicaDataSet1.Medico);

        }

        public SqlConnection ConectaBDConsulta()
        {
            SqlConnection Consulta = new SqlConnection();
            Consulta.ConnectionString = "Data Source=PEPE-PC;Initial Catalog=Clinica;Integrated Security=True; User ID=sa; Password=jl990510";

            try
            {
                Consulta.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se puede abrir la base de datos \n\n\n" + ex.Message);
            }

            return Consulta;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            if (NumConsulta.Text != "" && NumConsulta.MaskCompleted && cbDoctor.SelectedIndex != -1 && cbPaciente.SelectedIndex != -1
                && Peso.Text != "" && Estatura.Text != "" && Padecimiento.Text != "" && Presión.Text != "")
            {
                try
                {
                    SqlConnection AñadirConsulta = ConectaBDConsulta();
                    String Consulta = "INSERT INTO Consulta (Num_Consulta, Paciente, Medico_Cedula,Padecimiento,Peso, Estatura, Alergias,Presion_Arterial)" +
                        "VALUES (@Num_Consulta,@Paciente,@Medico,@Padecimiento,@Peso,@Estatura,@Alergias,@Presion_Arterial)";
                    SqlCommand InsertarConsulta = new SqlCommand(Consulta, AñadirConsulta);

                    InsertarConsulta.Parameters.Add(new SqlParameter("@Num_Consulta", NumConsulta.Text.ToUpper()));
                    InsertarConsulta.Parameters.Add(new SqlParameter("@Paciente", SqlDbType.Text));
                    InsertarConsulta.Parameters.Add(new SqlParameter("@Medico", SqlDbType.Text));
                    InsertarConsulta.Parameters.Add(new SqlParameter("@Padecimiento", Padecimiento.Text.ToUpper()));
                    InsertarConsulta.Parameters.Add(new SqlParameter("@Peso", SqlDbType.SmallInt));
                    InsertarConsulta.Parameters.Add(new SqlParameter("@Estatura", SqlDbType.TinyInt));
                    InsertarConsulta.Parameters.Add(new SqlParameter("@Alergias", Alergias.Text));
                    InsertarConsulta.Parameters.Add(new SqlParameter("@Presion_Arterial", Presión.Text));

                    InsertarConsulta.Parameters["@Peso"].Value = Convert.ToInt32(Peso.Text);
                    InsertarConsulta.Parameters["@Estatura"].Value = Convert.ToInt32(Estatura.Text);
                    InsertarConsulta.Parameters["@Paciente"].Value = cbPaciente.SelectedValue;
                    InsertarConsulta.Parameters["@Medico"].Value = cbDoctor.SelectedValue;

                    InsertarConsulta.ExecuteNonQuery();

                    MessageBox.Show("Consulta Guardada");
                    cbDoctor.SelectedIndex = -1;
                    cbPaciente.SelectedIndex = -1;
                    NumConsulta.Clear();
                    Padecimiento.Clear();
                    Peso.Clear();
                    Estatura.Clear();
                    Alergias.Clear();
                    Presión.Clear();

                }
                catch (SqlException Ex)
                {
                    MessageBox.Show("Ya existe una consulta con esa clave, elige otra"+ Ex);
                    cbDoctor.SelectedIndex = -1;
                    cbPaciente.SelectedIndex = -1;
                    NumConsulta.Clear();
                    Padecimiento.Clear();
                    Peso.Clear();
                    Estatura.Clear();
                    Alergias.Clear();
                    Presión.Clear();
                }

                this.consultaTableAdapter1.Fill(this.clinicaDataSet1.Consulta);
            }

            else
            {
                MessageBox.Show("Asegurese de llenar todos los campos");
            }
         }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Tabla_Consulta.SelectedRows.Count > 0)
            {
                try
                {
                    String Num_Consulta = Tabla_Consulta.SelectedRows[0].Cells[0].Value.ToString();
                    String Consulta = "DELETE FROM Consulta WHERE Num_Consulta = '" + Num_Consulta + "'";
                    SqlConnection Query = ConectaBDConsulta();
                    SqlCommand EliminarConsulta = new SqlCommand(Consulta, Query);

                    if (EliminarConsulta.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Consulta Borrada");
                        this.consultaTableAdapter1.Fill(this.clinicaDataSet1.Consulta);
                    }
                    else
                    {
                        MessageBox.Show("La consulta no se ha borrado");
                    }
                    Query.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La consulta no se ha borrado");
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
                String Consulta = "UPDATE Consulta SET Num_Consulta = @Consulta, Paciente = @Paciente, Medico_Cedula = @Medico, Padecimiento = @Padecimiento, Peso = @Peso, Estatura = @Estatura, Alergias = @Alergias, Presion_Arterial = @Presion  WHERE Num_Consulta = '" + Tabla_Consulta.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand CambiarConsulta = new SqlCommand(Consulta, ConectaBDConsulta());

                CambiarConsulta.Parameters.Add(new SqlParameter("@Consulta", NumConsulta.Text.ToUpper()));
                CambiarConsulta.Parameters.Add(new SqlParameter("@Paciente", SqlDbType.Text));
                CambiarConsulta.Parameters.Add(new SqlParameter("@Medico", SqlDbType.Text));
                CambiarConsulta.Parameters.Add(new SqlParameter("@Padecimiento", Padecimiento.Text.ToUpper()));
                CambiarConsulta.Parameters.Add(new SqlParameter("@Peso", SqlDbType.SmallInt));
                CambiarConsulta.Parameters.Add(new SqlParameter("@Estatura", SqlDbType.TinyInt));
                CambiarConsulta.Parameters.Add(new SqlParameter("@Alergias", Alergias.Text));
                CambiarConsulta.Parameters.Add(new SqlParameter("@Presion", Presión.Text));

                CambiarConsulta.Parameters["@Peso"].Value = Convert.ToInt32(Peso.Text);
                CambiarConsulta.Parameters["@Estatura"].Value = Convert.ToInt32(Estatura.Text);
                CambiarConsulta.Parameters["@Paciente"].Value = cbPaciente.SelectedValue;
                CambiarConsulta.Parameters["@Medico"].Value = cbDoctor.SelectedValue;
                CambiarConsulta.ExecuteNonQuery();

                MessageBox.Show("Consulta Actualizada");
                cbDoctor.SelectedIndex = -1;
                cbPaciente.SelectedIndex = -1;
                NumConsulta.Clear();
                Padecimiento.Clear();
                Peso.Clear();
                Estatura.Clear();
                Alergias.Clear();
                Presión.Clear();

                this.consultaTableAdapter1.Fill(this.clinicaDataSet1.Consulta);

                btnañadir.Enabled = true;
                btneliminar.Enabled = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡Error! No se ha completado el cambio" + ex);
            }
        }

        private void Tabla_Consulta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnañadir.Enabled = false;
            btneliminar.Enabled = false;

            if (Tabla_Consulta.CurrentRow.Index != -1)
            {
                NumConsulta.Text = Tabla_Consulta.CurrentRow.Cells[0].Value.ToString();
                Padecimiento.Text = Tabla_Consulta.CurrentRow.Cells[3].Value.ToString();
                Peso.Text = Tabla_Consulta.CurrentRow.Cells[4].Value.ToString();
                Estatura.Text = Tabla_Consulta.CurrentRow.Cells[5].Value.ToString();
                Alergias.Text = Tabla_Consulta.CurrentRow.Cells[6].Value.ToString();
                Presión.Text = Tabla_Consulta.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void Tabla_Consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemPaciente_Click(object sender, EventArgs e)
        {
            Paciente VentanaPaciente = new Paciente();
            VentanaPaciente.Show();
            this.Close();
        }

        private void ItemMedico_Click(object sender, EventArgs e)
        {
            Medico VentanaMedico = new Medico();
            VentanaMedico.Show();
            this.Close();
        }

        private void ItemMedicamento_Click(object sender, EventArgs e)
        {
            Medicamento VentanaMedicamento = new Medicamento();
            VentanaMedicamento.Show();
            this.Close();
        }

        private void Menu_Receta_Click(object sender, EventArgs e)
        {
            Receta VentanaReceta = new Receta();
            VentanaReceta.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal VentanaPrincipal = new Principal();
            VentanaPrincipal.Show();
            this.Close();
        }

        private void Informe_Click(object sender, EventArgs e)
        {
            InformeConsulta VentanaInformeConsulta = new InformeConsulta();
            VentanaInformeConsulta.Show();
            this.Hide();
        }
    }
    }
