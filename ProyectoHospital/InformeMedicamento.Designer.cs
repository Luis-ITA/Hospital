namespace ProyectoHospital
{
    partial class InformeMedicamento
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
            this.VistaMedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaDataSet = new ProyectoHospital.ClinicaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VistaMedicamentoTableAdapter = new ProyectoHospital.ClinicaDataSetTableAdapters.VistaMedicamentoTableAdapter();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VistaMedicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaMedicamentoBindingSource
            // 
            this.VistaMedicamentoBindingSource.DataMember = "VistaMedicamento";
            this.VistaMedicamentoBindingSource.DataSource = this.ClinicaDataSet;
            // 
            // ClinicaDataSet
            // 
            this.ClinicaDataSet.DataSetName = "ClinicaDataSet";
            this.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.VistaMedicamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoHospital.InformeMedicamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(711, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // VistaMedicamentoTableAdapter
            // 
            this.VistaMedicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // btnregresar
            // 
            this.btnregresar.Image = global::ProyectoHospital.Properties.Resources._16__Back_;
            this.btnregresar.Location = new System.Drawing.Point(717, 43);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 54);
            this.btnregresar.TabIndex = 44;
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // InformeMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "InformeMedicamento";
            this.Text = "InformeMedicamento";
            this.Load += new System.EventHandler(this.InformeMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaMedicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VistaMedicamentoBindingSource;
        private ClinicaDataSet ClinicaDataSet;
        private ClinicaDataSetTableAdapters.VistaMedicamentoTableAdapter VistaMedicamentoTableAdapter;
        private System.Windows.Forms.Button btnregresar;
    }
}