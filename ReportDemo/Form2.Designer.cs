namespace ReportDemo
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LICENSE_GENERATE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCHEDULE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATE_ON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATE_BY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_MODIFIED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_ACTIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LICENSE_GENERATE_ID,
            this.SCHEDULE_ID,
            this.CREATE_ON,
            this.CREATE_BY,
            this.NOTE,
            this.LAST_MODIFIED,
            this.IS_ACTIVE});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(863, 462);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // LICENSE_GENERATE_ID
            // 
            this.LICENSE_GENERATE_ID.DataPropertyName = "LICENSE_GENERATE_ID";
            this.LICENSE_GENERATE_ID.HeaderText = "LICENSE_GENERATE_ID";
            this.LICENSE_GENERATE_ID.Name = "LICENSE_GENERATE_ID";
            this.LICENSE_GENERATE_ID.ReadOnly = true;
            this.LICENSE_GENERATE_ID.Visible = false;
            // 
            // SCHEDULE_ID
            // 
            this.SCHEDULE_ID.DataPropertyName = "SCHEDULE_ID";
            this.SCHEDULE_ID.HeaderText = "SCHEDULE_ID";
            this.SCHEDULE_ID.Name = "SCHEDULE_ID";
            this.SCHEDULE_ID.ReadOnly = true;
            this.SCHEDULE_ID.Visible = false;
            // 
            // CREATE_ON
            // 
            this.CREATE_ON.DataPropertyName = "CREATE_ON";
            this.CREATE_ON.HeaderText = "CREATE_ON";
            this.CREATE_ON.Name = "CREATE_ON";
            this.CREATE_ON.ReadOnly = true;
            // 
            // CREATE_BY
            // 
            this.CREATE_BY.DataPropertyName = "CREATE_BY";
            this.CREATE_BY.HeaderText = "CREATE_BY";
            this.CREATE_BY.Name = "CREATE_BY";
            this.CREATE_BY.ReadOnly = true;
            // 
            // NOTE
            // 
            this.NOTE.DataPropertyName = "NOTE";
            this.NOTE.HeaderText = "សំគាល់";
            this.NOTE.Name = "NOTE";
            // 
            // LAST_MODIFIED
            // 
            this.LAST_MODIFIED.DataPropertyName = "LAST_MODIFIED";
            this.LAST_MODIFIED.HeaderText = "LAST_MODIFIED";
            this.LAST_MODIFIED.Name = "LAST_MODIFIED";
            this.LAST_MODIFIED.ReadOnly = true;
            // 
            // IS_ACTIVE
            // 
            this.IS_ACTIVE.DataPropertyName = "IS_ACTIVE";
            this.IS_ACTIVE.HeaderText = "IS_ACTIVE";
            this.IS_ACTIVE.Name = "IS_ACTIVE";
            this.IS_ACTIVE.ReadOnly = true;
            this.IS_ACTIVE.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 462);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Khmer OS System", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LICENSE_GENERATE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCHEDULE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATE_ON;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATE_BY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_MODIFIED;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_ACTIVE;

    }
}