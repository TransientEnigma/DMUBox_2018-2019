namespace DMUBox
{
    partial class frmHallStudentsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHallStudentsReport));
            this.sproc_HallStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sproc_HallStudentsTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.sproc_HallStudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_HallStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sproc_HallStudentsBindingSource
            // 
            this.sproc_HallStudentsBindingSource.DataMember = "sproc_HallStudents";
            this.sproc_HallStudentsBindingSource.DataSource = this.DMUBoxDataSet;
            // 
            // DMUBoxDataSet
            // 
            this.DMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.DMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HallStudentDataSet";
            reportDataSource1.Value = this.sproc_HallStudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DMUBox.rptHallStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(621, 550);
            this.reportViewer1.TabIndex = 1;
            // 
            // sproc_HallStudentsTableAdapter
            // 
            this.sproc_HallStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmHallStudentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(710, 605);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmHallStudentsReport";
            this.Text = "frmHallStudentsReport";
            this.Load += new System.EventHandler(this.frmHallStudentsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sproc_HallStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sproc_HallStudentsBindingSource;
        private DMUBoxDataSet DMUBoxDataSet;
        private DMUBoxDataSetTableAdapters.sproc_HallStudentsTableAdapter sproc_HallStudentsTableAdapter;
    }
}