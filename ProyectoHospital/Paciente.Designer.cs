namespace ProyectoHospital
{
    partial class Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericEdad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomPac = new System.Windows.Forms.TextBox();
            this.dataGWPaci = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.btninforme = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.clinicaDataSet1 = new ProyectoHospital.ClinicaDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.PacienteTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWPaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxObs
            // 
            this.textBoxObs.BackColor = System.Drawing.Color.White;
            this.textBoxObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxObs.ForeColor = System.Drawing.Color.Black;
            this.textBoxObs.Location = new System.Drawing.Point(31, 236);
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(143, 20);
            this.textBoxObs.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Observaciones";
            // 
            // textBoxPade
            // 
            this.textBoxPade.BackColor = System.Drawing.Color.White;
            this.textBoxPade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPade.ForeColor = System.Drawing.Color.Black;
            this.textBoxPade.Location = new System.Drawing.Point(31, 188);
            this.textBoxPade.Name = "textBoxPade";
            this.textBoxPade.Size = new System.Drawing.Size(143, 20);
            this.textBoxPade.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Padecimiento";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox1.Location = new System.Drawing.Point(31, 40);
            this.maskedTextBox1.Mask = "00000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(62, 20);
            this.maskedTextBox1.TabIndex = 15;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "N° de Expediente";
            // 
            // numericEdad
            // 
            this.numericEdad.BackColor = System.Drawing.Color.White;
            this.numericEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericEdad.ForeColor = System.Drawing.Color.Black;
            this.numericEdad.Location = new System.Drawing.Point(31, 135);
            this.numericEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEdad.Name = "numericEdad";
            this.numericEdad.Size = new System.Drawing.Size(62, 20);
            this.numericEdad.TabIndex = 13;
            this.numericEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre del paciente";
            // 
            // tbNomPac
            // 
            this.tbNomPac.BackColor = System.Drawing.Color.White;
            this.tbNomPac.ForeColor = System.Drawing.Color.Black;
            this.tbNomPac.Location = new System.Drawing.Point(31, 91);
            this.tbNomPac.Name = "tbNomPac";
            this.tbNomPac.Size = new System.Drawing.Size(143, 20);
            this.tbNomPac.TabIndex = 10;
            // 
            // dataGWPaci
            // 
            this.dataGWPaci.AllowUserToAddRows = false;
            this.dataGWPaci.AllowUserToDeleteRows = false;
            this.dataGWPaci.AutoGenerateColumns = false;
            this.dataGWPaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGWPaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGWPaci.DataSource = this.pacienteBindingSource;
            this.dataGWPaci.Location = new System.Drawing.Point(262, 75);
            this.dataGWPaci.Name = "dataGWPaci";
            this.dataGWPaci.ReadOnly = true;
            this.dataGWPaci.Size = new System.Drawing.Size(570, 133);
            this.dataGWPaci.TabIndex = 20;
            this.dataGWPaci.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGWPaci_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Image = global::ProyectoHospital.Properties.Resources.Update1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(538, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 54);
            this.button1.TabIndex = 23;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::ProyectoHospital.Properties.Resources._16__Delete_;
            this.btneliminar.Location = new System.Drawing.Point(414, 232);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(81, 54);
            this.btneliminar.TabIndex = 22;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = global::ProyectoHospital.Properties.Resources._16__Plus_;
            this.btnañadir.Location = new System.Drawing.Point(282, 232);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(81, 54);
            this.btnañadir.TabIndex = 21;
            this.btnañadir.Text = "Añadir ";
            this.btnañadir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btninforme
            // 
            this.btninforme.Image = global::ProyectoHospital.Properties.Resources.Informe;
            this.btninforme.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninforme.Location = new System.Drawing.Point(643, 232);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(75, 52);
            this.btninforme.TabIndex = 44;
            this.btninforme.Text = "Informe";
            this.btninforme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btninforme.UseVisualStyleBackColor = true;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Image = global::ProyectoHospital.Properties.Resources._16__Back_;
            this.btnregresar.Location = new System.Drawing.Point(757, 234);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 50);
            this.btnregresar.TabIndex = 43;
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Pacientes dados de alta";
            // 
            // clinicaDataSet1
            // 
            this.clinicaDataSet1.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Expediente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Expediente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Padecimiento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Padecimiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Observaciones";
            this.dataGridViewTextBoxColumn5.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 309);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btninforme);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.dataGWPaci);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomPac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWPaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomPac;
        private System.Windows.Forms.DataGridView dataGWPaci;
        private ClinicaDataSet clinicaDataSet;
        private ClinicaDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expedienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padecimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btninforme;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label label9;
        private ClinicaDataSet clinicaDataSet1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ClinicaDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}