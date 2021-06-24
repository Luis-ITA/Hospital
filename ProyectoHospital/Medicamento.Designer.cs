namespace ProyectoHospital
{
    partial class Medicamento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.MaskedTextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Caducidad = new System.Windows.Forms.DateTimePicker();
            this.Precio = new System.Windows.Forms.MaskedTextBox();
            this.Administracion = new System.Windows.Forms.ListBox();
            this.Tabla_Medicamento = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.btninforme = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.clinicaDataSet1 = new ProyectoHospital.ClinicaDataSet();
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentoTableAdapter1 = new ProyectoHospital.ClinicaDataSetTableAdapters.MedicamentoTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Medicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Caducidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio (Pesos)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Via de administración ";
            // 
            // Clave
            // 
            this.Clave.Location = new System.Drawing.Point(49, 44);
            this.Clave.Mask = "AAAAAAAA";
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(115, 20);
            this.Clave.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(46, 104);
            this.Nombre.MaxLength = 30;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 6;
            // 
            // Caducidad
            // 
            this.Caducidad.Location = new System.Drawing.Point(46, 165);
            this.Caducidad.MaxDate = new System.DateTime(2034, 1, 1, 0, 0, 0, 0);
            this.Caducidad.MinDate = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.Caducidad.Name = "Caducidad";
            this.Caducidad.Size = new System.Drawing.Size(200, 20);
            this.Caducidad.TabIndex = 7;
            this.Caducidad.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(46, 228);
            this.Precio.Mask = "00000";
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(115, 20);
            this.Precio.TabIndex = 8;
            // 
            // Administracion
            // 
            this.Administracion.FormattingEnabled = true;
            this.Administracion.Items.AddRange(new object[] {
            "Oral",
            "Cutánea",
            "Intravenosa",
            "Intramuscular"});
            this.Administracion.Location = new System.Drawing.Point(41, 302);
            this.Administracion.Name = "Administracion";
            this.Administracion.Size = new System.Drawing.Size(120, 95);
            this.Administracion.TabIndex = 9;
            // 
            // Tabla_Medicamento
            // 
            this.Tabla_Medicamento.AllowUserToAddRows = false;
            this.Tabla_Medicamento.AllowUserToDeleteRows = false;
            this.Tabla_Medicamento.AutoGenerateColumns = false;
            this.Tabla_Medicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Medicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.Tabla_Medicamento.DataSource = this.medicamentoBindingSource;
            this.Tabla_Medicamento.Location = new System.Drawing.Point(296, 64);
            this.Tabla_Medicamento.Name = "Tabla_Medicamento";
            this.Tabla_Medicamento.ReadOnly = true;
            this.Tabla_Medicamento.Size = new System.Drawing.Size(596, 220);
            this.Tabla_Medicamento.TabIndex = 15;
            this.Tabla_Medicamento.DoubleClick += new System.EventHandler(this.Tabla_Medicamento_DoubleClick);
            // 
            // button1
            // 
            this.button1.Image = global::ProyectoHospital.Properties.Resources.Update1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(550, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::ProyectoHospital.Properties.Resources._16__Delete_;
            this.btneliminar.Location = new System.Drawing.Point(426, 314);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(81, 54);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = global::ProyectoHospital.Properties.Resources._16__Plus_;
            this.btnañadir.Location = new System.Drawing.Point(294, 314);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(81, 54);
            this.btnañadir.TabIndex = 12;
            this.btnañadir.Text = "Añadir ";
            this.btnañadir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btninforme
            // 
            this.btninforme.Image = global::ProyectoHospital.Properties.Resources.Informe;
            this.btninforme.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninforme.Location = new System.Drawing.Point(669, 312);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(75, 56);
            this.btninforme.TabIndex = 44;
            this.btninforme.Text = "Informe";
            this.btninforme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btninforme.UseVisualStyleBackColor = true;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Image = global::ProyectoHospital.Properties.Resources._16__Back_;
            this.btnregresar.Location = new System.Drawing.Point(792, 314);
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
            this.label9.Location = new System.Drawing.Point(292, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Medicamentos con existencia en farmacia";
            // 
            // clinicaDataSet1
            // 
            this.clinicaDataSet1.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Clave_Medicamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave_Medicamento";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha_Caducidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha_Caducidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Via_Administracion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Via_Administracion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 410);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btninforme);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.Tabla_Medicamento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.Administracion);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Caducidad);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Medicamento";
            this.Text = "Medicamento";
            this.Load += new System.EventHandler(this.Medicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Medicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Clave;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.DateTimePicker Caducidad;
        private System.Windows.Forms.MaskedTextBox Precio;
        private System.Windows.Forms.ListBox Administracion;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Tabla_Medicamento;
        private ClinicaDataSet clinicaDataSet;
        private ClinicaDataSetTableAdapters.MedicamentoTableAdapter medicamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveMedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaAdministracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btninforme;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label label9;
        private ClinicaDataSet clinicaDataSet1;
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private ClinicaDataSetTableAdapters.MedicamentoTableAdapter medicamentoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

