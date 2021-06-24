namespace ProyectoHospital
{
    partial class InformePaciente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VistaPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaDataSet = new ProyectoHospital.ClinicaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VistaPacienteTableAdapter = new ProyectoHospital.ClinicaDataSetTableAdapters.VistaPacienteTableAdapter();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VistaPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaPacienteBindingSource
            // 
            this.VistaPacienteBindingSource.DataMember = "VistaPaciente";
            this.VistaPacienteBindingSource.DataSource = this.ClinicaDataSet;
            // 
            // ClinicaDataSet
            // 
            this.ClinicaDataSet.DataSetName = "ClinicaDataSet";
            this.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.VistaPacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoHospital.InformePaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(703, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // VistaPacienteTableAdapter
            // 
            this.VistaPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnregresar
            // 
            this.btnregresar.Image = global::ProyectoHospital.Properties.Resources._16__Back_;
            this.btnregresar.Location = new System.Drawing.Point(713, 49);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 54);
            this.btnregresar.TabIndex = 44;
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // InformePaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "InformePaciente";
            this.Text = "InformePaciente";
            this.Load += new System.EventHandler(this.InformePaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VistaPacienteBindingSource;
        private ClinicaDataSet ClinicaDataSet;
        private ClinicaDataSetTableAdapters.VistaPacienteTableAdapter VistaPacienteTableAdapter;
        private System.Windows.Forms.Button btnregresar;
    }
}