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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        private void Medico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet3.Medico' Puede moverla o quitarla según sea necesario.
            this.medicoTableAdapter3.Fill(this.clinicaDataSet3.Medico);

        }

        public SqlConnection conectaBDMedico()
        {
            SqlConnection Medico = new SqlConnection();
            Medico.ConnectionString = "Data Source = PEPE-PC;Initial Catalog = Clinica; Integrated Security = True";
            try
            {
                Medico.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo abrir la base de datos " + ex.Message);
            }
            return Medico;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            SqlConnection Medico = conectaBDMedico();

            if (maskedTextBoxCP.Text != "" && maskedTextBoxCP.MaskFull)
            {
                if (textBoxNom.Text != "")
                {
                    if (textBoxEsp.Text != "")
                    {
                        if (maskedTextBoxTel.Text != "")
                        {
                            if (maskedTextBoxSueldo.Text != "")
                            {
                                try
                                {
                                    String Consulta = "INSERT INTO Medico (Cedula_Profesional, Nombre, Especialidad, Telefono, Sueldo)" +
                                        "VALUES (@Cedula_Profesional,@Nombre,@Especialidad,@Telefono,@Sueldo)";
                                    SqlCommand InsertarMedico = new SqlCommand(Consulta, Medico);

                                    InsertarMedico.Parameters.Add(new SqlParameter("@Cedula_Profesional", maskedTextBoxCP.Text));
                                    InsertarMedico.Parameters.Add(new SqlParameter("@Nombre", textBoxNom.Text));
                                    InsertarMedico.Parameters.Add(new SqlParameter("@Especialidad", textBoxEsp.Text));
                                    InsertarMedico.Parameters.Add(new SqlParameter("@Telefono", maskedTextBoxTel.Text));
                                    InsertarMedico.Parameters.Add(new SqlParameter("@Sueldo", maskedTextBoxSueldo.Text));

                                    InsertarMedico.ExecuteNonQuery();

                                    MessageBox.Show("Nuevo Médico agregado con éxito");
                                    maskedTextBoxCP.Clear();
                                    textBoxNom.Clear();
                                    textBoxEsp.Clear();
                                    maskedTextBoxTel.Clear();
                                    maskedTextBoxSueldo.Clear();

                                    this.medicoTableAdapter3.Fill(this.clinicaDataSet3.Medico);
                                    Medico.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Cedula profesional repetida, Ingrese otra");
                                    maskedTextBoxCP.Clear();
                                }
                            }
                            else
                                MessageBox.Show("Ingrese su sueldo");
                        }
                        else
                            MessageBox.Show("Ingrese su número de telefono");
                    }
                    else
                        MessageBox.Show("Ingrese la especialidad que ejerce");
                }
                else
                    MessageBox.Show("Ingrese su Nombre");
            }
            else
                MessageBox.Show("Cedula profesional incompleta");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            SqlConnection Medico = conectaBDMedico();
            if (Tabla_Medico.SelectedRows.Count > 0)
            {
                try
                {
                    String Cedula_Profesional = Tabla_Medico.SelectedRows[0].Cells[0].Value.ToString();
                    String Consulta = "DELETE FROM Medico WHERE Cedula_Profesional = '" + Cedula_Profesional + "'";
                    SqlCommand EliminarMedico = new SqlCommand(Consulta, Medico);

                    if (EliminarMedico.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Medico eliminado correctamente");
                        this.medicoTableAdapter3.Fill(this.clinicaDataSet3.Medico);
                        Medico.Close();
                    }
                    else
                        MessageBox.Show("No se pudo eliminar correctamente");
                    Medico.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("El médico no se ha podido eliminar");
                }

            }
            else
                MessageBox.Show("No hay registros por borrar");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            SqlConnection Medico = conectaBDMedico();
            try
            {
                String Consulta = "UPDATE Medico SET Cedula_Profesional = @Cedula_Profesional, Nombre = @Nombre, Especialidad = @Especialidad, Telefono = @Telefono, Sueldo = @Sueldo  WHERE Cedula_Profesional = '" + Tabla_Medico.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand ModificarMedico = new SqlCommand(Consulta, conectaBDMedico());

                ModificarMedico.Parameters.Add(new SqlParameter("@Cedula_Profesional", maskedTextBoxCP.Text));
                ModificarMedico.Parameters.Add(new SqlParameter("@Nombre", textBoxNom.Text));
                ModificarMedico.Parameters.Add(new SqlParameter("@Especialidad", textBoxEsp.Text));
                ModificarMedico.Parameters.Add(new SqlParameter("@Telefono", maskedTextBoxTel.Text));
                ModificarMedico.Parameters.Add(new SqlParameter("@Sueldo", maskedTextBoxSueldo.Text));

                ModificarMedico.ExecuteNonQuery();

                MessageBox.Show("El médico seleccionado ha sido actualizado correctamente");

                maskedTextBoxCP.Clear();
                textBoxNom.Clear();
                textBoxEsp.Clear();
                maskedTextBoxTel.Clear();
                maskedTextBoxSueldo.Clear();

                this.medicoTableAdapter3.Fill(this.clinicaDataSet3.Medico);
                Medico.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡Error! No se ha completado el cambio" + ex);
            }
        }

        private void Tabla_Medico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Tabla_Medico.CurrentRow.Index != -1)
            {
                maskedTextBoxCP.Text = Tabla_Medico.CurrentRow.Cells[0].Value.ToString();
                textBoxNom.Text = Tabla_Medico.CurrentRow.Cells[1].Value.ToString();
                textBoxEsp.Text = Tabla_Medico.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxTel.Text = Tabla_Medico.CurrentRow.Cells[3].Value.ToString();
                maskedTextBoxSueldo.Text = Tabla_Medico.CurrentRow.Cells[4].Value.ToString();
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
            InformeMedico VentanaInforme = new InformeMedico();
            VentanaInforme.Show();
        }
    }
}
