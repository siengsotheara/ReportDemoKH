namespace ReportDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.axCrystalActiveXReportViewer1 = new AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.cboConnectionType = new System.Windows.Forms.ComboBox();
            this.cboPowerType = new System.Windows.Forms.ComboBox();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalActiveXReportViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboCurrency);
            this.panel1.Controls.Add(this.cboPowerType);
            this.panel1.Controls.Add(this.cboConnectionType);
            this.panel1.Controls.Add(this.cboCustomerType);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 57);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "ខែ MM ឆ្នាំ yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "មើល";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axCrystalActiveXReportViewer1
            // 
            this.axCrystalActiveXReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axCrystalActiveXReportViewer1.Enabled = true;
            this.axCrystalActiveXReportViewer1.Location = new System.Drawing.Point(0, 57);
            this.axCrystalActiveXReportViewer1.Name = "axCrystalActiveXReportViewer1";
            this.axCrystalActiveXReportViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCrystalActiveXReportViewer1.OcxState")));
            this.axCrystalActiveXReportViewer1.Size = new System.Drawing.Size(1296, 463);
            this.axCrystalActiveXReportViewer1.TabIndex = 1;
            // 
            // cboCustomerType
            // 
            this.cboCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerType.FormattingEnabled = true;
            this.cboCustomerType.Items.AddRange(new object[] {
            "គ្រប់អតិថិជន",
            "លក់អោយអ្នកកាន់អាជ្ញាប័ណ្ឌ",
            "លក់អោយអតិថិជន MV (ឧស្សាហ៏កម្ម ពាណិជកម្ម)",
            "លក់លើតង់ស្យុងទាប (អតិថិជនទូទៅ)"});
            this.cboCustomerType.Location = new System.Drawing.Point(136, 12);
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.Size = new System.Drawing.Size(165, 27);
            this.cboCustomerType.TabIndex = 2;
            // 
            // cboConnectionType
            // 
            this.cboConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConnectionType.FormattingEnabled = true;
            this.cboConnectionType.Items.AddRange(new object[] {
            "គ្រប់ប្រភេទភ្ជាប់ចរន្ត",
            "អតិថិជនធម្មតា",
            "ទិញពី MV ត្រង់ស្វូអ្នកលក់",
            "ទិញពី MV ត្រង់ស្វូអ្នកទិញ",
            "ទិញ MV"});
            this.cboConnectionType.Location = new System.Drawing.Point(307, 12);
            this.cboConnectionType.Name = "cboConnectionType";
            this.cboConnectionType.Size = new System.Drawing.Size(143, 27);
            this.cboConnectionType.TabIndex = 3;
            // 
            // cboPowerType
            // 
            this.cboPowerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPowerType.FormattingEnabled = true;
            this.cboPowerType.Items.AddRange(new object[] {
            "គ្រប់ប្រភេទថាមពល",
            "0 Kwh",
            "1 - 10 Kwh",
            ">10 Kwh"});
            this.cboPowerType.Location = new System.Drawing.Point(456, 12);
            this.cboPowerType.Name = "cboPowerType";
            this.cboPowerType.Size = new System.Drawing.Size(162, 27);
            this.cboPowerType.TabIndex = 4;
            // 
            // cboCurrency
            // 
            this.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Items.AddRange(new object[] {
            "គ្រប់រូបិយប័ណ្ឌ",
            "រៀល",
            "ដូល្លា"});
            this.cboCurrency.Location = new System.Drawing.Point(624, 12);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(143, 27);
            this.cboCurrency.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 520);
            this.Controls.Add(this.axCrystalActiveXReportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS System", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalActiveXReportViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer axCrystalActiveXReportViewer1;
        private System.Windows.Forms.ComboBox cboCustomerType;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.ComboBox cboPowerType;
        private System.Windows.Forms.ComboBox cboConnectionType;
    }
}

