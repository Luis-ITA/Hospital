namespace ProyectoHospital
{
    partial class Receta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receta));
            this.mtbFECHA = new System.Windows.Forms.MaskedTextBox();
            this.mtbHORA = new System.Windows.Forms.MaskedTextBox();
            this.lbHORA = new System.Windows.Forms.Label();
            this.lbTEMPERATURA = new System.Windows.Forms.Label();
            this.nudTEMPERATURA = new System.Windows.Forms.NumericUpDown();
            this.lbFECHA = new System.Windows.Forms.Label();
            this.mtbFOLIO = new System.Windows.Forms.MaskedTextBox();
            this.lbFOLIO = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabla_Receta = new System.Windows.Forms.DataGridView();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btninforme = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMedicamento = new System.Windows.Forms.ComboBox();
            this.clinicaDataSet1 = new ProyectoHospital.ClinicaDataSet();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetaTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.RecetaTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.MedicoTableAdapter();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.PacienteTableAdapter();
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentoTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.MedicamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nudTEMPERATURA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Receta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbFECHA
            // 
            this.mtbFECHA.Location = new System.Drawing.Point(27, 96);
            this.mtbFECHA.Mask = "00/00/0000";
            this.mtbFECHA.Name = "mtbFECHA";
            this.mtbFECHA.Size = new System.Drawing.Size(64, 20);
            this.mtbFECHA.TabIndex = 32;
            this.mtbFECHA.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHORA
            // 
            this.mtbHORA.Location = new System.Drawing.Point(27, 148);
            this.mtbHORA.Mask = "00:00:00";
            this.mtbHORA.Name = "mtbHORA";
            this.mtbHORA.Size = new System.Drawing.Size(64, 20);
            this.mtbHORA.TabIndex = 31;
            this.mtbHORA.ValidatingType = typeof(System.DateTime);
            // 
            // lbHORA
            // 
            this.lbHORA.AutoSize = true;
            this.lbHORA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHORA.Location = new System.Drawing.Point(24, 129);
            this.lbHORA.Name = "lbHORA";
            this.lbHORA.Size = new System.Drawing.Size(42, 16);
            this.lbHORA.TabIndex = 30;
            this.lbHORA.Text = "Hora";
            // 
            // lbTEMPERATURA
            // 
            this.lbTEMPERATURA.AutoSize = true;
            this.lbTEMPERATURA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTEMPERATURA.Location = new System.Drawing.Point(24, 171);
            this.lbTEMPERATURA.Name = "lbTEMPERATURA";
            this.lbTEMPERATURA.Size = new System.Drawing.Size(97, 16);
            this.lbTEMPERATURA.TabIndex = 29;
            this.lbTEMPERATURA.Text = "Temperatura";
            // 
            // nudTEMPERATURA
            // 
            this.nudTEMPERATURA.Location = new System.Drawing.Point(27, 190);
            this.nudTEMPERATURA.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nudTEMPERATURA.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudTEMPERATURA.Name = "nudTEMPERATURA";
            this.nudTEMPERATURA.Size = new System.Drawing.Size(120, 20);
            this.nudTEMPERATURA.TabIndex = 28;
            this.nudTEMPERATURA.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // lbFECHA
            // 
            this.lbFECHA.AutoSize = true;
            this.lbFECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFECHA.Location = new System.Drawing.Point(24, 77);
            this.lbFECHA.Name = "lbFECHA";
            this.lbFECHA.Size = new System.Drawing.Size(51, 16);
            this.lbFECHA.TabIndex = 27;
            this.lbFECHA.Text = "Fecha";
            // 
            // mtbFOLIO
            // 
            this.mtbFOLIO.Location = new System.Drawing.Point(27, 49);
            this.mtbFOLIO.Mask = "?0000";
            this.mtbFOLIO.Name = "mtbFOLIO";
            this.mtbFOLIO.Size = new System.Drawing.Size(80, 20);
            this.mtbFOLIO.TabIndex = 26;
            // 
            // lbFOLIO
            // 
            this.lbFOLIO.AutoSize = true;
            this.lbFOLIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFOLIO.Location = new System.Drawing.Point(24, 30);
            this.lbFOLIO.Name = "lbFOLIO";
            this.lbFOLIO.Size = new System.Drawing.Size(130, 16);
            this.lbFOLIO.TabIndex = 25;
            this.lbFOLIO.Text = "Folio de la receta";
            // 
            // cbDoctor
            // 
            this.cbDoctor.DataSource = this.medicoBindingSource;
            this.cbDoctor.DisplayMember = "Nombre";
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(26, 243);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cbDoctor.TabIndex = 33;
            this.cbDoctor.ValueMember = "Cedula_Profesional";
            // 
            // cbPaciente
            // 
            this.cbPaciente.DataSource = this.pacienteBindingSource;
            this.cbPaciente.DisplayMember = "Nombre";
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(26, 300);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(121, 21);
            this.cbPaciente.TabIndex = 34;
            this.cbPaciente.ValueMember = "Expediente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre del doctor que atendio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre del paciente:";
            // 
            // Tabla_Receta
            // 
            this.Tabla_Receta.AllowUserToAddRows = false;
            this.Tabla_Receta.AllowUserToDeleteRows = false;
            this.Tabla_Receta.AutoGenerateColumns = false;
            this.Tabla_Receta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Receta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.Tabla_Receta.DataSource = this.recetaBindingSource;
            this.Tabla_Receta.Location = new System.Drawing.Point(274, 72);
            this.Tabla_Receta.Name = "Tabla_Receta";
            this.Tabla_Receta.ReadOnly = true;
            this.Tabla_Receta.Size = new System.Drawing.Size(677, 192);
            this.Tabla_Receta.TabIndex = 37;
            this.Tabla_Receta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tabla_Receta_MouseDoubleClick);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = global::ProyectoHospital.Properties.Resources.Update1;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnactualizar.Location = new System.Drawing.Point(530, 279);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(81, 54);
            this.btnactualizar.TabIndex = 40;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::ProyectoHospital.Properties.Resources._16__Delete_;
            this.btneliminar.Location = new System.Drawing.Point(406, 279);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(81, 54);
            this.btneliminar.TabIndex = 39;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = global::ProyectoHospital.Properties.Resources._16__Plus_;
            this.btnañadir.Location = new System.Drawing.Point(274, 279);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(81, 54);
            this.btnañadir.TabIndex = 38;
            this.btnañadir.Text = "Añadir ";
            this.btnañadir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Image = global::ProyectoHospital.Properties.Resources._16__Back_;
            this.btnregresar.Location = new System.Drawing.Point(769, 281);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 50);
            this.btnregresar.TabIndex = 41;
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btninforme
            // 
            this.btninforme.Image = global::ProyectoHospital.Properties.Resources.Informe;
            this.btninforme.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninforme.Location = new System.Drawing.Point(655, 279);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(75, 52);
            this.btninforme.TabIndex = 42;
            this.btninforme.Text = "Informe";
            this.btninforme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btninforme.UseVisualStyleBackColor = true;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(275, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Historial de Recetas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Medicamento Recetado";
            // 
            // cbMedicamento
            // 
            this.cbMedicamento.DataSource = this.medicamentoBindingSource;
            this.cbMedicamento.DisplayMember = "Nombre";
            this.cbMedicamento.FormattingEnabled = true;
            this.cbMedicamento.Location = new System.Drawing.Point(26, 365);
            this.cbMedicamento.Name = "cbMedicamento";
            this.cbMedicamento.Size = new System.Drawing.Size(121, 21);
            this.cbMedicamento.TabIndex = 45;
            this.cbMedicamento.ValueMember = "Clave_Medicamento";
            // 
            // clinicaDataSet1
            // 
            this.clinicaDataSet1.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetaBindingSource
            // 
            this.recetaBindingSource.DataMember = "Receta";
            this.recetaBindingSource.DataSource = this.clinicaDataSet1;
            // 
            // recetaTableAdapter1
            // 
            this.recetaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Folio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Folio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Temperatura_Corporal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Temperatura_Corporal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medico_Cedula";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medico_Cedula";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Paciente_Expediente";
            this.dataGridViewTextBoxColumn6.HeaderText = "Paciente_Expediente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Medicamento_Clave";
            this.dataGridViewTextBoxColumn7.HeaderText = "Medicamento_Clave";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.clinicaDataSet1;
            // 
            // medicoTableAdapter1
            // 
            this.medicoTableAdapter1.ClearBeforeFill = true;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.clinicaDataSet1;
            // 
            // pacienteTableAdapter1
            // 
            this.pacienteTableAdapter1.ClearBeforeFill = true;
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataMember = "Medicamento";
            this.medicamentoBindingSource.DataSource = this.clinicaDataSet1;
            // 
            // medicamentoTableAdapter1
            // 
            this.medicamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 413);
            this.Controls.Add(this.cbMedicamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btninforme);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.Tabla_Receta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.mtbFECHA);
            this.Controls.Add(this.mtbHORA);
            this.Controls.Add(this.lbHORA);
            this.Controls.Add(this.lbTEMPERATURA);
            this.Controls.Add(this.nudTEMPERATURA);
            this.Controls.Add(this.lbFECHA);
            this.Controls.Add(this.mtbFOLIO);
            this.Controls.Add(this.lbFOLIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Receta";
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.Receta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTEMPERATURA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Receta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbFECHA;
        private System.Windows.Forms.MaskedTextBox mtbHORA;
        private System.Windows.Forms.Label lbHORA;
        private System.Windows.Forms.Label lbTEMPERATURA;
        private System.Windows.Forms.NumericUpDown nudTEMPERATURA;
        private System.Windows.Forms.Label lbFECHA;
        private System.Windows.Forms.MaskedTextBox mtbFOLIO;
        private System.Windows.Forms.Label lbFOLIO;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Tabla_Receta;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btninforme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private ClinicaDataSet clinicaDataSet;
        private ClinicaDataSetTableAdapters.RecetaTableAdapter recetaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaCorporalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteExpedienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentoClaveDataGridViewTextBoxColumn;
        private ClinicaDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private ClinicaDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private ClinicaDataSetTableAdapters.MedicamentoTableAdapter medicamentoTableAdapter;
        private System.Windows.Forms.ComboBox cbMedicamento;
        private ClinicaDataSet clinicaDataSet1;
        private System.Windows.Forms.BindingSource recetaBindingSource;
        private ClinicaDataSetTableAdapters.RecetaTableAdapter recetaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ClinicaDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ClinicaDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter1;
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private ClinicaDataSetTableAdapters.MedicamentoTableAdapter medicamentoTableAdapter1;
    }
}