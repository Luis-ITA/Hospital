namespace ProyectoHospital
{
    partial class InformeMedico
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeMedico));
            this.MedicoPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaDataSet = new ProyectoHospital.ClinicaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MedicoPacienteTableAdapter = new ProyectoHospital.ClinicaDataSetTableAdapters.MedicoPacienteTableAdapter();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MedicoPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicoPacienteBindingSource
            // 
            this.MedicoPacienteBindingSource.DataMember = "MedicoPaciente";
            this.MedicoPacienteBindingSource.DataSource = this.ClinicaDataSet;
            // 
            // ClinicaDataSet
            // 
            this.ClinicaDataSet.DataSetName = "ClinicaDataSet";
            this.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MedicoPacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoHospital.InformeMedicoPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(717, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // MedicoPacienteTableAdapter
            // 
            this.MedicoPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnregresar
            // 
            this.btnregresar.Image = global::ProyectoHospital.Properties.Resources._16__Back_;
            this.btnregresar.Location = new System.Drawing.Point(732, 39);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 54);
            this.btnregresar.TabIndex = 44;
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // InformeMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InformeMedico";
            this.Text = "InformeMedico";
            this.Load += new System.EventHandler(this.InformeMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicoPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MedicoPacienteBindingSource;
        private ClinicaDataSet ClinicaDataSet;
        private ClinicaDataSetTableAdapters.MedicoPacienteTableAdapter MedicoPacienteTableAdapter;
        private System.Windows.Forms.Button btnregresar;
    }
}