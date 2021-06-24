namespace ProyectoHospital
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.NumConsulta = new System.Windows.Forms.MaskedTextBox();
            this.Peso = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Estatura = new System.Windows.Forms.MaskedTextBox();
            this.Padecimiento = new System.Windows.Forms.TextBox();
            this.Alergias = new System.Windows.Forms.TextBox();
            this.Presión = new System.Windows.Forms.MaskedTextBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.Tabla_Consulta = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Catalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMedicamento = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Receta = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Informe = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.clinicaDataSet1 = new ProyectoHospital.ClinicaDataSet();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.MedicoTableAdapter();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.PacienteTableAdapter();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.ConsultaTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NumConsulta
            // 
            this.NumConsulta.Location = new System.Drawing.Point(43, 50);
            this.NumConsulta.Mask = "000";
            this.NumConsulta.Name = "NumConsulta";
            this.NumConsulta.Size = new System.Drawing.Size(62, 20);
            this.NumConsulta.TabIndex = 0;
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(394, 34);
            this.Peso.Mask = "000";
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(108, 20);
            this.Peso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Núm. Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Peso (KG)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estatura (CM)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Padecimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Alergias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Presion Arterial (000/000)";
            // 
            // Estatura
            // 
            this.Estatura.Location = new System.Drawing.Point(619, 34);
            this.Estatura.Mask = "000";
            this.Estatura.Name = "Estatura";
            this.Estatura.Size = new System.Drawing.Size(108, 20);
            this.Estatura.TabIndex = 10;
            // 
            // Padecimiento
            // 
            this.Padecimiento.Location = new System.Drawing.Point(43, 149);
            this.Padecimiento.Name = "Padecimiento";
            this.Padecimiento.Size = new System.Drawing.Size(156, 20);
            this.Padecimiento.TabIndex = 11;
            // 
            // Alergias
            // 
            this.Alergias.Location = new System.Drawing.Point(252, 149);
            this.Alergias.Name = "Alergias";
            this.Alergias.Size = new System.Drawing.Size(139, 20);
            this.Alergias.TabIndex = 12;
            // 
            // Presión
            // 
            this.Presión.Location = new System.Drawing.Point(423, 112);
            this.Presión.Mask = "000/000";
            this.Presión.Name = "Presión";
            this.Presión.Size = new System.Drawing.Size(108, 20);
            this.Presión.TabIndex = 13;
            // 
            // cbDoctor
            // 
            this.cbDoctor.DataSource = this.medicoBindingSource;
            this.cbDoctor.DisplayMember = "Nombre";
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(152, 49);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(150, 21);
            this.cbDoctor.TabIndex = 14;
            this.cbDoctor.ValueMember = "Cedula_Profesional";
            // 
            // cbPaciente
            // 
            this.cbPaciente.DataSource = this.pacienteBindingSource;
            this.cbPaciente.DisplayMember = "Nombre";
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(151, 90);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(151, 21);
            this.cbPaciente.TabIndex = 15;
            this.cbPaciente.ValueMember = "Nombre";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = global::ProyectoHospital.Properties.Resources.Update1;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.Location = new System.Drawing.Point(744, 159);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(96, 37);
            this.btnactualizar.TabIndex = 18;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::ProyectoHospital.Properties.Resources._16__Delete_;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(661, 160);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(66, 36);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = global::ProyectoHospital.Properties.Resources._16__Plus_;
            this.btnañadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnañadir.Location = new System.Drawing.Point(585, 160);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(64, 36);
            this.btnañadir.TabIndex = 16;
            this.btnañadir.Text = "Añadir ";
            this.btnañadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // Tabla_Consulta
            // 
            this.Tabla_Consulta.AllowUserToAddRows = false;
            this.Tabla_Consulta.AllowUserToDeleteRows = false;
            this.Tabla_Consulta.AutoGenerateColumns = false;
            this.Tabla_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.medicoCedulaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.Tabla_Consulta.DataSource = this.consultaBindingSource;
            this.Tabla_Consulta.Location = new System.Drawing.Point(12, 253);
            this.Tabla_Consulta.Name = "Tabla_Consulta";
            this.Tabla_Consulta.ReadOnly = true;
            this.Tabla_Consulta.Size = new System.Drawing.Size(847, 175);
            this.Tabla_Consulta.TabIndex = 19;
            this.Tabla_Consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_Consulta_CellContentClick);
            this.Tabla_Consulta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tabla_Consulta_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoHospital.Properties.Resources.Hospital;
            this.pictureBox1.Location = new System.Drawing.Point(741, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 114);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Catalogo,
            this.Menu_Receta,
            this.salirToolStripMenuItem,
            this.Informe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Catalogo
            // 
            this.Menu_Catalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemPaciente,
            this.ItemMedico,
            this.ItemMedicamento});
            this.Menu_Catalogo.Image = global::ProyectoHospital.Properties.Resources.catalogo;
            this.Menu_Catalogo.Name = "Menu_Catalogo";
            this.Menu_Catalogo.Size = new System.Drawing.Size(88, 20);
            this.Menu_Catalogo.Text = "Catálogos";
            // 
            // ItemPaciente
            // 
            this.ItemPaciente.Image = global::ProyectoHospital.Properties.Resources.Paciente;
            this.ItemPaciente.Name = "ItemPaciente";
            this.ItemPaciente.Size = new System.Drawing.Size(148, 22);
            this.ItemPaciente.Text = "Paciente";
            this.ItemPaciente.Click += new System.EventHandler(this.ItemPaciente_Click);
            // 
            // ItemMedico
            // 
            this.ItemMedico.Image = global::ProyectoHospital.Properties.Resources.Doctor;
            this.ItemMedico.Name = "ItemMedico";
            this.ItemMedico.Size = new System.Drawing.Size(148, 22);
            this.ItemMedico.Text = "Medico";
            this.ItemMedico.Click += new System.EventHandler(this.ItemMedico_Click);
            // 
            // ItemMedicamento
            // 
            this.ItemMedicamento.Image = global::ProyectoHospital.Properties.Resources.pastillas;
            this.ItemMedicamento.Name = "ItemMedicamento";
            this.ItemMedicamento.Size = new System.Drawing.Size(148, 22);
            this.ItemMedicamento.Text = "Medicamento";
            this.ItemMedicamento.Click += new System.EventHandler(this.ItemMedicamento_Click);
            // 
            // Menu_Receta
            // 
            this.Menu_Receta.Image = global::ProyectoHospital.Properties.Resources.Receta;
            this.Menu_Receta.Name = "Menu_Receta";
            this.Menu_Receta.Size = new System.Drawing.Size(70, 20);
            this.Menu_Receta.Text = "Receta";
            this.Menu_Receta.Click += new System.EventHandler(this.Menu_Receta_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ProyectoHospital.Properties.Resources._16__Exit_;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Informe
            // 
            this.Informe.Image = global::ProyectoHospital.Properties.Resources.Informe;
            this.Informe.Name = "Informe";
            this.Informe.Size = new System.Drawing.Size(77, 20);
            this.Informe.Text = "Informe";
            this.Informe.Click += new System.EventHandler(this.Informe_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Historial de Consultas";
            // 
            // clinicaDataSet1
            // 
            this.clinicaDataSet1.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "Consulta";
            this.consultaBindingSource.DataSource = this.clinicaDataSet1;
            // 
            // consultaTableAdapter1
            // 
            this.consultaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Num_Consulta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Num_Consulta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Paciente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Paciente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // medicoCedulaDataGridViewTextBoxColumn
            // 
            this.medicoCedulaDataGridViewTextBoxColumn.DataPropertyName = "Medico_Cedula";
            this.medicoCedulaDataGridViewTextBoxColumn.HeaderText = "Medico_Cedula";
            this.medicoCedulaDataGridViewTextBoxColumn.Name = "medicoCedulaDataGridViewTextBoxColumn";
            this.medicoCedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Padecimiento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Padecimiento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Peso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estatura";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estatura";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Alergias";
            this.dataGridViewTextBoxColumn6.HeaderText = "Alergias";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Presion_Arterial";
            this.dataGridViewTextBoxColumn7.HeaderText = "Presion_Arterial";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(879, 441);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tabla_Consulta);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.Presión);
            this.Controls.Add(this.Alergias);
            this.Controls.Add(this.Padecimiento);
            this.Controls.Add(this.Estatura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.NumConsulta);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox NumConsulta;
        private System.Windows.Forms.MaskedTextBox Peso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox Estatura;
        private System.Windows.Forms.TextBox Padecimiento;
        private System.Windows.Forms.TextBox Alergias;
        private System.Windows.Forms.MaskedTextBox Presión;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbPaciente;
        private ClinicaDataSet clinicaDataSet;
        private ClinicaDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private ClinicaDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.DataGridView Tabla_Consulta;
        private ClinicaDataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padecimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presionArterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Catalogo;
        private System.Windows.Forms.ToolStripMenuItem ItemPaciente;
        private System.Windows.Forms.ToolStripMenuItem ItemMedico;
        private System.Windows.Forms.ToolStripMenuItem ItemMedicamento;
        private System.Windows.Forms.ToolStripMenuItem Menu_Receta;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Informe;
        private System.Windows.Forms.Label label9;
        private ClinicaDataSet clinicaDataSet1;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ClinicaDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ClinicaDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter1;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private ClinicaDataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}