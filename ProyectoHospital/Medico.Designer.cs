namespace ProyectoHospital
{
    partial class Medico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medico));
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCP = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEsp = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.maskedTextBoxSueldo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabla_Medico = new System.Windows.Forms.DataGridView();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.btninforme = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.clinicaDataSet3 = new ProyectoHospital.ClinicaDataSet();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter3 = new ProyectoHospital.ClinicaDataSetTableAdapters.MedicoTableAdapter();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Medico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula Profesional";
            // 
            // maskedTextBoxCP
            // 
            this.maskedTextBoxCP.Location = new System.Drawing.Point(29, 54);
            this.maskedTextBoxCP.Mask = "9999999";
            this.maskedTextBoxCP.Name = "maskedTextBoxCP";
            this.maskedTextBoxCP.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxCP.TabIndex = 4;
            this.maskedTextBoxCP.ValidatingType = typeof(int);
            // 
            // textBoxEsp
            // 
            this.textBoxEsp.Location = new System.Drawing.Point(30, 168);
            this.textBoxEsp.Name = "textBoxEsp";
            this.textBoxEsp.Size = new System.Drawing.Size(193, 20);
            this.textBoxEsp.TabIndex = 21;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(30, 110);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(193, 20);
            this.textBoxNom.TabIndex = 20;
            // 
            // maskedTextBoxSueldo
            // 
            this.maskedTextBoxSueldo.Location = new System.Drawing.Point(30, 283);
            this.maskedTextBoxSueldo.Mask = "999999";
            this.maskedTextBoxSueldo.Name = "maskedTextBoxSueldo";
            this.maskedTextBoxSueldo.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBoxSueldo.TabIndex = 19;
            this.maskedTextBoxSueldo.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sueldo";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(30, 226);
            this.maskedTextBoxTel.Mask = "000-000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxTel.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // Tabla_Medico
            // 
            this.Tabla_Medico.AllowUserToAddRows = false;
            this.Tabla_Medico.AllowUserToDeleteRows = false;
            this.Tabla_Medico.AutoGenerateColumns = false;
            this.Tabla_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Medico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.Tabla_Medico.DataSource = this.medicoBindingSource;
            this.Tabla_Medico.Location = new System.Drawing.Point(270, 65);
            this.Tabla_Medico.Name = "Tabla_Medico";
            this.Tabla_Medico.ReadOnly = true;
            this.Tabla_Medico.Size = new System.Drawing.Size(545, 169);
            this.Tabla_Medico.TabIndex = 22;
            this.Tabla_Medico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tabla_Medico_MouseDoubleClick);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = global::ProyectoHospital.Properties.Resources.Update1;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnactualizar.Location = new System.Drawing.Point(526, 249);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(81, 54);
            this.btnactualizar.TabIndex = 25;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::ProyectoHospital.Properties.Resources._16__Delete_;
            this.btneliminar.Location = new System.Drawing.Point(402, 249);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(81, 54);
            this.btneliminar.TabIndex = 24;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = global::ProyectoHospital.Properties.Resources._16__Plus_;
            this.btnañadir.Location = new System.Drawing.Point(270, 249);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(81, 54);
            this.btnañadir.TabIndex = 23;
            this.btnañadir.Text = "Añadir ";
            this.btnañadir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btninforme
            // 
            this.btninforme.Image = global::ProyectoHospital.Properties.Resources.Informe;
            this.btninforme.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninforme.Location = new System.Drawing.Point(636, 249);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(75, 54);
            this.btninforme.TabIndex = 44;
            this.btninforme.Text = "Informe";
            this.btninforme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btninforme.UseVisualStyleBackColor = true;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Image = global::ProyectoHospital.Properties.Resources._16__Back_;
            this.btnregresar.Location = new System.Drawing.Point(750, 249);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 54);
            this.btnregresar.TabIndex = 43;
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(316, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Medicos registrados en la clínica";
            // 
            // clinicaDataSet3
            // 
            this.clinicaDataSet3.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.clinicaDataSet3;
            // 
            // medicoTableAdapter3
            // 
            this.medicoTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cedula_Profesional";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cedula_Profesional";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Especialidad";
            this.dataGridViewTextBoxColumn13.HeaderText = "Especialidad";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn14.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Sueldo";
            this.dataGridViewTextBoxColumn15.HeaderText = "Sueldo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 332);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btninforme);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.Tabla_Medico);
            this.Controls.Add(this.textBoxEsp);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.maskedTextBoxSueldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxCP);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Medico";
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.Medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Medico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCP;
        private System.Windows.Forms.TextBox textBoxEsp;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Tabla_Medico;
        private ClinicaDataSet clinicaDataSet;
        private ClinicaDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaProfesionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btninforme;
        private System.Windows.Forms.Button btnregresar;
        private ClinicaDataSet clinicaDataSet1;
        private ClinicaDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label9;
        private ClinicaDataSet clinicaDataSet2;
        private ClinicaDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private ClinicaDataSet clinicaDataSet3;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ClinicaDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}