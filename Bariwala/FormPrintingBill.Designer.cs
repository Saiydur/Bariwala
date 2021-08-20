namespace Bariwala
{
    partial class FormPrintingBill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelReportViewControl = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetForInvoice = new Bariwala.DataSetForInvoice();
            this.TransactionHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TransactionHistoryTableAdapter = new Bariwala.DataSetForInvoiceTableAdapters.TransactionHistoryTableAdapter();
            this.panelReportViewControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReportViewControl
            // 
            this.panelReportViewControl.BackColor = System.Drawing.Color.White;
            this.panelReportViewControl.Controls.Add(this.reportViewer1);
            this.panelReportViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportViewControl.Location = new System.Drawing.Point(3, 64);
            this.panelReportViewControl.Name = "panelReportViewControl";
            this.panelReportViewControl.Size = new System.Drawing.Size(974, 583);
            this.panelReportViewControl.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.TransactionHistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bariwala.PrintInvoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(974, 583);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetForInvoice
            // 
            this.DataSetForInvoice.DataSetName = "DataSetForInvoice";
            this.DataSetForInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TransactionHistoryBindingSource
            // 
            this.TransactionHistoryBindingSource.DataMember = "TransactionHistory";
            this.TransactionHistoryBindingSource.DataSource = this.DataSetForInvoice;
            // 
            // TransactionHistoryTableAdapter
            // 
            this.TransactionHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrintingBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.panelReportViewControl);
            this.Name = "FormPrintingBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form-Printing Bill";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrintingBill_FormClosed);
            this.Load += new System.EventHandler(this.FormPrintingBill_Load);
            this.panelReportViewControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelReportViewControl;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TransactionHistoryBindingSource;
        private DataSetForInvoice DataSetForInvoice;
        private DataSetForInvoiceTableAdapters.TransactionHistoryTableAdapter TransactionHistoryTableAdapter;
    }
}