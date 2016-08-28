namespace FFXICrafterDesu
{
    partial class settingsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.processViewGrid = new System.Windows.Forms.DataGridView();
            this.processName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processLabel = new System.Windows.Forms.Label();
            this.saveProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.processViewGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processViewGrid
            // 
            this.processViewGrid.AllowUserToDeleteRows = false;
            this.processViewGrid.AllowUserToResizeColumns = false;
            this.processViewGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processViewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.processViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.processViewGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.processViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processViewGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.processViewGrid.Location = new System.Drawing.Point(6, 100);
            this.processViewGrid.MultiSelect = false;
            this.processViewGrid.Name = "processViewGrid";
            this.processViewGrid.ReadOnly = true;
            this.processViewGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processViewGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.processViewGrid.RowTemplate.Height = 50;
            this.processViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processViewGrid.Size = new System.Drawing.Size(223, 287);
            this.processViewGrid.TabIndex = 3;
            // 
            // processName
            // 
            this.processName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processName.DefaultCellStyle = dataGridViewCellStyle2;
            this.processName.HeaderText = "Process Name";
            this.processName.MinimumWidth = 200;
            this.processName.Name = "processName";
            this.processName.ReadOnly = true;
            this.processName.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveProcess);
            this.groupBox1.Controls.Add(this.processLabel);
            this.groupBox1.Controls.Add(this.processViewGrid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 442);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process List";
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(3, 394);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(161, 13);
            this.processLabel.TabIndex = 5;
            this.processLabel.Text = "No Process has been saved yet.";
            // 
            // saveProcess
            // 
            this.saveProcess.Location = new System.Drawing.Point(6, 413);
            this.saveProcess.Name = "saveProcess";
            this.saveProcess.Size = new System.Drawing.Size(223, 23);
            this.saveProcess.TabIndex = 6;
            this.saveProcess.Text = "Save Process";
            this.saveProcess.UseVisualStyleBackColor = true;
            this.saveProcess.Click += new System.EventHandler(this.saveProcess_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 465);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processViewGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView processViewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn processName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveProcess;
        private System.Windows.Forms.Label processLabel;
    }
}