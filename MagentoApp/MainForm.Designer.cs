namespace MagentoApp
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGetOrderByDate = new System.Windows.Forms.Button();
            this.panelByDate = new System.Windows.Forms.Panel();
            this.gbByDate = new System.Windows.Forms.GroupBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCondetion = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.panelByOrder = new System.Windows.Forms.Panel();
            this.gbByOrder = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFromTo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbFTStatus = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.cbFTStatus = new System.Windows.Forms.ComboBox();
            this.btnGetOrderByFromToDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelCommandButton = new System.Windows.Forms.Panel();
            this.gbCommandButton = new System.Windows.Forms.GroupBox();
            this.btnSaveToDb = new System.Windows.Forms.Button();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelByDate.SuspendLayout();
            this.gbByDate.SuspendLayout();
            this.panelByOrder.SuspendLayout();
            this.gbByOrder.SuspendLayout();
            this.panelFromTo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelCommandButton.SuspendLayout();
            this.gbCommandButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(210, 75);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(85, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(12, 330);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1421, 411);
            this.dgv.TabIndex = 2;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_CellMouseClick);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellValueChanged);
            this.dgv.CurrentCellDirtyStateChanged += new System.EventHandler(this.Dgv_CurrentCellDirtyStateChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(21, 14);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 32);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnGetOrderByDate
            // 
            this.btnGetOrderByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetOrderByDate.Location = new System.Drawing.Point(278, 168);
            this.btnGetOrderByDate.Name = "btnGetOrderByDate";
            this.btnGetOrderByDate.Size = new System.Drawing.Size(75, 26);
            this.btnGetOrderByDate.TabIndex = 4;
            this.btnGetOrderByDate.Text = "Submit";
            this.btnGetOrderByDate.UseVisualStyleBackColor = true;
            this.btnGetOrderByDate.Click += new System.EventHandler(this.BtnGetOrderByDate_Click);
            // 
            // panelByDate
            // 
            this.panelByDate.Controls.Add(this.gbByDate);
            this.panelByDate.Location = new System.Drawing.Point(12, 12);
            this.panelByDate.Name = "panelByDate";
            this.panelByDate.Size = new System.Drawing.Size(410, 253);
            this.panelByDate.TabIndex = 6;
            // 
            // gbByDate
            // 
            this.gbByDate.Controls.Add(this.dtpOrderDate);
            this.gbByDate.Controls.Add(this.label1);
            this.gbByDate.Controls.Add(this.cbCondetion);
            this.gbByDate.Controls.Add(this.lbStatus);
            this.gbByDate.Controls.Add(this.lbDate);
            this.gbByDate.Controls.Add(this.cbStatus);
            this.gbByDate.Controls.Add(this.btnGetOrderByDate);
            this.gbByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbByDate.Location = new System.Drawing.Point(0, 17);
            this.gbByDate.Name = "gbByDate";
            this.gbByDate.Size = new System.Drawing.Size(395, 217);
            this.gbByDate.TabIndex = 0;
            this.gbByDate.TabStop = false;
            this.gbByDate.Text = "By Date";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(79, 33);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(274, 23);
            this.dtpOrderDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Condetion";
            // 
            // cbCondetion
            // 
            this.cbCondetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondetion.FormattingEnabled = true;
            this.cbCondetion.Items.AddRange(new object[] {
            "gteq",
            "gt",
            "eq"});
            this.cbCondetion.Location = new System.Drawing.Point(79, 120);
            this.cbCondetion.Name = "cbCondetion";
            this.cbCondetion.Size = new System.Drawing.Size(274, 24);
            this.cbCondetion.TabIndex = 8;
            this.cbCondetion.Text = "gteq";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(6, 81);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(48, 17);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Status";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(6, 36);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 17);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "Date";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Processing",
            "Pending",
            "Canceled"});
            this.cbStatus.Location = new System.Drawing.Point(79, 80);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(274, 24);
            this.cbStatus.TabIndex = 0;
            this.cbStatus.Text = "Processing";
            // 
            // panelByOrder
            // 
            this.panelByOrder.Controls.Add(this.gbByOrder);
            this.panelByOrder.Location = new System.Drawing.Point(875, 12);
            this.panelByOrder.Name = "panelByOrder";
            this.panelByOrder.Size = new System.Drawing.Size(369, 253);
            this.panelByOrder.TabIndex = 7;
            // 
            // gbByOrder
            // 
            this.gbByOrder.Controls.Add(this.label2);
            this.gbByOrder.Controls.Add(this.txtId);
            this.gbByOrder.Controls.Add(this.btnSubmit);
            this.gbByOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbByOrder.Location = new System.Drawing.Point(3, 17);
            this.gbByOrder.Name = "gbByOrder";
            this.gbByOrder.Size = new System.Drawing.Size(346, 217);
            this.gbByOrder.TabIndex = 0;
            this.gbByOrder.TabStop = false;
            this.gbByOrder.Text = "By Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Order Id";
            // 
            // panelFromTo
            // 
            this.panelFromTo.Controls.Add(this.groupBox1);
            this.panelFromTo.Location = new System.Drawing.Point(439, 12);
            this.panelFromTo.Name = "panelFromTo";
            this.panelFromTo.Size = new System.Drawing.Size(419, 253);
            this.panelFromTo.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.lbToDate);
            this.groupBox1.Controls.Add(this.lbFTStatus);
            this.groupBox1.Controls.Add(this.lbFromDate);
            this.groupBox1.Controls.Add(this.cbFTStatus);
            this.groupBox1.Controls.Add(this.btnGetOrderByFromToDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From To Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(84, 82);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(282, 23);
            this.dtpToDate.TabIndex = 15;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(84, 33);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(282, 23);
            this.dtpFromDate.TabIndex = 14;
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToDate.Location = new System.Drawing.Point(6, 87);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(59, 17);
            this.lbToDate.TabIndex = 12;
            this.lbToDate.Text = "To Date";
            // 
            // lbFTStatus
            // 
            this.lbFTStatus.AutoSize = true;
            this.lbFTStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFTStatus.Location = new System.Drawing.Point(6, 124);
            this.lbFTStatus.Name = "lbFTStatus";
            this.lbFTStatus.Size = new System.Drawing.Size(48, 17);
            this.lbFTStatus.TabIndex = 7;
            this.lbFTStatus.Text = "Status";
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromDate.Location = new System.Drawing.Point(6, 36);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(74, 17);
            this.lbFromDate.TabIndex = 6;
            this.lbFromDate.Text = "From Date";
            // 
            // cbFTStatus
            // 
            this.cbFTStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFTStatus.FormattingEnabled = true;
            this.cbFTStatus.Items.AddRange(new object[] {
            "Processing",
            "Pending",
            "Canceled",
            "All"});
            this.cbFTStatus.Location = new System.Drawing.Point(84, 123);
            this.cbFTStatus.Name = "cbFTStatus";
            this.cbFTStatus.Size = new System.Drawing.Size(282, 24);
            this.cbFTStatus.TabIndex = 0;
            this.cbFTStatus.Text = "Processing";
            // 
            // btnGetOrderByFromToDate
            // 
            this.btnGetOrderByFromToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetOrderByFromToDate.Location = new System.Drawing.Point(291, 168);
            this.btnGetOrderByFromToDate.Name = "btnGetOrderByFromToDate";
            this.btnGetOrderByFromToDate.Size = new System.Drawing.Size(75, 26);
            this.btnGetOrderByFromToDate.TabIndex = 4;
            this.btnGetOrderByFromToDate.Text = "Submit";
            this.btnGetOrderByFromToDate.UseVisualStyleBackColor = true;
            this.btnGetOrderByFromToDate.Click += new System.EventHandler(this.BtnGetOrderByFromToDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(21, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panelCommandButton
            // 
            this.panelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCommandButton.Controls.Add(this.gbCommandButton);
            this.panelCommandButton.Location = new System.Drawing.Point(1305, 12);
            this.panelCommandButton.Name = "panelCommandButton";
            this.panelCommandButton.Size = new System.Drawing.Size(128, 253);
            this.panelCommandButton.TabIndex = 9;
            // 
            // gbCommandButton
            // 
            this.gbCommandButton.Controls.Add(this.btnSaveToDb);
            this.gbCommandButton.Controls.Add(this.btnGeneratePDF);
            this.gbCommandButton.Controls.Add(this.btnExport);
            this.gbCommandButton.Controls.Add(this.btnClear);
            this.gbCommandButton.Location = new System.Drawing.Point(3, 3);
            this.gbCommandButton.Name = "gbCommandButton";
            this.gbCommandButton.Size = new System.Drawing.Size(122, 231);
            this.gbCommandButton.TabIndex = 0;
            this.gbCommandButton.TabStop = false;
            // 
            // btnSaveToDb
            // 
            this.btnSaveToDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDb.Location = new System.Drawing.Point(21, 127);
            this.btnSaveToDb.Name = "btnSaveToDb";
            this.btnSaveToDb.Size = new System.Drawing.Size(85, 32);
            this.btnSaveToDb.TabIndex = 10;
            this.btnSaveToDb.Text = "Save";
            this.btnSaveToDb.UseVisualStyleBackColor = true;
            this.btnSaveToDb.Click += new System.EventHandler(this.BtnSaveToDb_Click);
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePDF.Location = new System.Drawing.Point(21, 52);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(85, 32);
            this.btnGeneratePDF.TabIndex = 9;
            this.btnGeneratePDF.Text = "Print";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.BtnGeneratePDF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 767);
            this.Controls.Add(this.panelCommandButton);
            this.Controls.Add(this.panelFromTo);
            this.Controls.Add(this.panelByOrder);
            this.Controls.Add(this.panelByDate);
            this.Controls.Add(this.dgv);
            this.Name = "MainForm";
            this.Text = " Magento API Connect (By Richard Dewan)";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelByDate.ResumeLayout(false);
            this.gbByDate.ResumeLayout(false);
            this.gbByDate.PerformLayout();
            this.panelByOrder.ResumeLayout(false);
            this.gbByOrder.ResumeLayout(false);
            this.gbByOrder.PerformLayout();
            this.panelFromTo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCommandButton.ResumeLayout(false);
            this.gbCommandButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGetOrderByDate;
        private System.Windows.Forms.Panel panelByDate;
        private System.Windows.Forms.GroupBox gbByDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCondetion;
        private System.Windows.Forms.Panel panelByOrder;
        private System.Windows.Forms.GroupBox gbByOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFromTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbFTStatus;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.ComboBox cbFTStatus;
        private System.Windows.Forms.Button btnGetOrderByFromToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelCommandButton;
        private System.Windows.Forms.GroupBox gbCommandButton;
        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.Button btnSaveToDb;
    }
}

