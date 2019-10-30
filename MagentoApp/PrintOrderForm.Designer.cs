namespace MagentoApp
{
    partial class PrintOrderForm
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
            this.panelInvoice = new System.Windows.Forms.Panel();
            this.crystalReportViewerInvoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInvoice
            // 
            this.panelInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInvoice.BackColor = System.Drawing.SystemColors.Window;
            this.panelInvoice.Controls.Add(this.crystalReportViewerInvoice);
            this.panelInvoice.Location = new System.Drawing.Point(12, 12);
            this.panelInvoice.Name = "panelInvoice";
            this.panelInvoice.Size = new System.Drawing.Size(1136, 821);
            this.panelInvoice.TabIndex = 0;
            // 
            // crystalReportViewerInvoice
            // 
            this.crystalReportViewerInvoice.ActiveViewIndex = -1;
            this.crystalReportViewerInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerInvoice.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerInvoice.Name = "crystalReportViewerInvoice";
            this.crystalReportViewerInvoice.Size = new System.Drawing.Size(1136, 821);
            this.crystalReportViewerInvoice.TabIndex = 0;
            // 
            // PrintOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 845);
            this.Controls.Add(this.panelInvoice);
            this.Name = "PrintOrderForm";
            this.Text = "PrintOrderForm";
            this.Load += new System.EventHandler(this.PrintOrderForm_Load);
            this.panelInvoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInvoice;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerInvoice;
    }
}