namespace ProyectoHospital
{
    partial class InformeReceta
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClinicaDataSet = new ProyectoHospital.ClinicaDataSet();
            this.VistaRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VistaRecetaTableAdapter = new ProyectoHospital.ClinicaDataSetTableAdapters.VistaRecetaTableAdapter();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaRecetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.VistaRecetaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoHospital.InformeReceta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(741, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClinicaDataSet
            // 
            this.ClinicaDataSet.DataSetName = "ClinicaDataSet";
            this.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VistaRecetaBindingSource
            // 
            this.VistaRecetaBindingSource.DataMember = "VistaReceta";
            this.VistaRecetaBindingSource.DataSource = this.ClinicaDataSet;
            // 
            // VistaRecetaTableAdapter
            // 
            this.VistaRecetaTableAdapter.ClearBeforeFill = true;
            // 
            // btnregresar
            // 
            this.btnregresar.Image = global::ProyectoHospital.Properties.Resources._16__Back_;
            this.btnregresar.Location = new System.Drawing.Point(759, 31);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 54);
            this.btnregresar.TabIndex = 44;
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // InformeReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "InformeReceta";
            this.Text = "InformeReceta";
            this.Load += new System.EventHandler(this.InformeReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaRecetaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VistaRecetaBindingSource;
        private ClinicaDataSet ClinicaDataSet;
        private ClinicaDataSetTableAdapters.VistaRecetaTableAdapter VistaRecetaTableAdapter;
        private System.Windows.Forms.Button btnregresar;
    }
}