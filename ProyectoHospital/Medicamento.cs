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
    public partial class Medicamento : Form
    {
        public Medicamento()
        {
            InitializeComponent();

        }

        private void Medicamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet1.Medicamento' Puede moverla o quitarla según sea necesario.
            this.medicamentoTableAdapter1.Fill(this.clinicaDataSet1.Medicamento);

        }

        public SqlConnection ConectaBDMedicamento()
        {
            SqlConnection Medicamento = new SqlConnection();
            Medicamento.ConnectionString = "Data Source=PEPE-PC;Initial Catalog=Clinica;Integrated Security=True; User ID=sa; Password=jl990510";

            try
            {
                Medicamento.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se puede abrir la base de datos \n\n\n" +ex.Message);
            }

            return Medicamento;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {

            if (Clave.Text != "" && Clave.MaskCompleted)
            {
                if (Nombre.Text != "")
                {
                    if (Caducidad.Value != null)
                    {
                        if (Precio.Text != "")
                        {
                            if (Administracion.SelectedIndex != -1)
                            {
                                try
                                {
                                    SqlConnection AñadirMedicamento = ConectaBDMedicamento();
                                    String Consulta = "INSERT INTO Medicamento (Clave_Medicamento, Nombre, Fecha_Caducidad,Precio,Via_Administracion)" +
                                        "VALUES (@Clave_Medicamento,@Nombre,@Fecha_Caducidad,@Precio,@Via_Administracion)";
                                    SqlCommand InsertarMedicamento = new SqlCommand(Consulta, AñadirMedicamento);

                                    InsertarMedicamento.Parameters.Add(new SqlParameter("@Clave_Medicamento", Clave.Text.ToUpper()));
                                    InsertarMedicamento.Parameters.Add(new SqlParameter("@Nombre", Nombre.Text.ToUpper()));
                                    InsertarMedicamento.Parameters.Add(new SqlParameter("@Fecha_Caducidad", SqlDbType.DateTime2));
                                    InsertarMedicamento.Parameters.Add(new SqlParameter("@Precio", Precio.Text.ToUpper()));
                                    InsertarMedicamento.Parameters.Add(new SqlParameter("@Via_Administracion", SqlDbType.Text));

                                    InsertarMedicamento.Parameters["@Via_Administracion"].Value = Administracion.SelectedItem.ToString();
                                    InsertarMedicamento.Parameters["@Fecha_Caducidad"].Value = Caducidad.Value;
                                    InsertarMedicamento.ExecuteNonQuery();

                                    MessageBox.Show("Medicamento Guardado");
                                    Administracion.SelectedIndex = -1;
                                    Clave.Clear();
                                    Nombre.Clear();
                                    Precio.Clear();
                                    Caducidad.Value = DateTime.Now;
                                }
                                catch (SqlException Ex)
                                {
                                    MessageBox.Show("Ya existe un medicamento con esa clave, elige otra");
                                    Administracion.SelectedIndex = -1;
                                    Clave.Clear();
                                    Nombre.Clear();
                                    Precio.Clear();
                                    Caducidad.Value = DateTime.Now;
                                }
                               
                                this.medicamentoTableAdapter1.Fill(this.clinicaDataSet1.Medicamento);
                            }
                            else
                            {
                                MessageBox.Show("Elija la via de adminisración del medicamento");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el precio del medicamento");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Elija la fecha de caducidad del medicamento");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre del medicamento");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una clave de medicamento válida");
            }

        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Tabla_Medicamento.SelectedRows.Count > 0)
            {
                try
                {
                    String Clave_Medicamento = Tabla_Medicamento.SelectedRows[0].Cells[0].Value.ToString();
                    String Consulta = "DELETE FROM Medicamento WHERE Clave_Medicamento = '" + Clave_Medicamento + "'";
                    SqlConnection Medicamento = ConectaBDMedicamento();
                    SqlCommand EliminarMedicamento = new SqlCommand(Consulta, Medicamento);

                    if (EliminarMedicamento.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Medicamento Borrado");
                        this.medicamentoTableAdapter1.Fill(this.clinicaDataSet1.Medicamento);
                    }
                    else
                    {
                        MessageBox.Show("El medicamento no se ha borrado");
                    }
                    Medicamento.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("El medicamento no se ha borrado");
                }

            }
            else
            {
                MessageBox.Show("No hay registros por borrar");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Boton para actualizar un registro//
                String Consulta = "UPDATE Medicamento SET Clave_Medicamento = @Clave_Medicamento,Nombre = @Nombre, Fecha_Caducidad = @Fecha_Caducidad, Precio = @Precio, Via_Administracion = @Via_Administracion  WHERE Clave_Medicamento = '" +Tabla_Medicamento.CurrentRow.Cells[0].Value.ToString()+"'" ;
                SqlCommand CambiarMedicamento = new SqlCommand(Consulta, ConectaBDMedicamento());

                CambiarMedicamento.Parameters.Add(new SqlParameter("@Clave_Medicamento", Clave.Text));
                CambiarMedicamento.Parameters.Add(new SqlParameter("@Nombre", Nombre.Text));
                CambiarMedicamento.Parameters.Add(new SqlParameter("@Fecha_Caducidad", SqlDbType.DateTime2));
                CambiarMedicamento.Parameters.Add(new SqlParameter("@Precio", Precio.Text));
                CambiarMedicamento.Parameters.Add(new SqlParameter("@Via_Administracion", SqlDbType.Text));

                CambiarMedicamento.Parameters["@Via_Administracion"].Value = Administracion.SelectedItem.ToString();
                CambiarMedicamento.Parameters["@Fecha_Caducidad"].Value = Caducidad.Value;

                CambiarMedicamento.ExecuteNonQuery();

                MessageBox.Show("El medicamento seleccionado se ha actualizado");

                Administracion.SelectedIndex = -1;
                Clave.Clear();
                Nombre.Clear();
                Precio.Clear();
                Caducidad.Value = DateTime.Now;

                this.medicamentoTableAdapter1.Fill(this.clinicaDataSet1.Medicamento);

                btnañadir.Enabled = true;
                btneliminar.Enabled = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡Error! No se ha completado el cambio" +ex);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tabla_Medicamento_DoubleClick(object sender, EventArgs e)
        {
            btnañadir.Enabled = false;
            btneliminar.Enabled = false;

            if (Tabla_Medicamento.CurrentRow.Index != -1)
            {
                Clave.Text = Tabla_Medicamento.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = Tabla_Medicamento.CurrentRow.Cells[1].Value.ToString();
                Caducidad.Text = Tabla_Medicamento.CurrentRow.Cells[2].Value.ToString();
                Precio.Text = Tabla_Medicamento.CurrentRow.Cells[3].Value.ToString();
                Administracion.Text = Tabla_Medicamento.CurrentRow.Cells[4].Value.ToString();
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
            InformeMedicamento VentanaInformeMed = new InformeMedicamento();
            VentanaInformeMed.Show();
            this.Hide();
        }
    }
}
