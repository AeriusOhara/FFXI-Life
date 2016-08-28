namespace FFXICrafterDesu
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.activateAllHuntsButton = new System.Windows.Forms.Button();
            this.craftCount = new System.Windows.Forms.NumericUpDown();
            this.cancelCraftingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.craftButton = new System.Windows.Forms.Button();
            this.taskProgressBar = new System.Windows.Forms.ProgressBar();
            this.taskOverallProgressBar = new System.Windows.Forms.ProgressBar();
            this.helpButton1 = new System.Windows.Forms.Button();
            this.radioButtonCrafting = new System.Windows.Forms.RadioButton();
            this.radioButtonDigging = new System.Windows.Forms.RadioButton();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.taskListBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.otherCommandTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customSeconds = new System.Windows.Forms.NumericUpDown();
            this.loadScriptButton = new System.Windows.Forms.Button();
            this.saveScriptButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.huntsTabControl = new System.Windows.Forms.TabControl();
            this.fRank = new System.Windows.Forms.TabPage();
            this.fHuntsTable = new System.Windows.Forms.TableLayoutPanel();
            this.eRank = new System.Windows.Forms.TabPage();
            this.eHuntsTable = new System.Windows.Forms.TableLayoutPanel();
            this.dRank = new System.Windows.Forms.TabPage();
            this.dHuntsTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openSettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.craftCount)).BeginInit();
            this.taskListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.huntsTabControl.SuspendLayout();
            this.fRank.SuspendLayout();
            this.eRank.SuspendLayout();
            this.dRank.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // activateAllHuntsButton
            // 
            this.activateAllHuntsButton.Enabled = false;
            this.activateAllHuntsButton.Location = new System.Drawing.Point(24, 28);
            this.activateAllHuntsButton.Name = "activateAllHuntsButton";
            this.activateAllHuntsButton.Size = new System.Drawing.Size(209, 25);
            this.activateAllHuntsButton.TabIndex = 0;
            this.activateAllHuntsButton.Text = "Show/Hide Available Hunts";
            this.activateAllHuntsButton.UseVisualStyleBackColor = true;
            this.activateAllHuntsButton.Click += new System.EventHandler(this.showHunts_Click);
            // 
            // craftCount
            // 
            this.craftCount.Location = new System.Drawing.Point(104, 14);
            this.craftCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.craftCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.craftCount.Name = "craftCount";
            this.craftCount.Size = new System.Drawing.Size(95, 20);
            this.craftCount.TabIndex = 9;
            this.craftCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cancelCraftingButton
            // 
            this.cancelCraftingButton.Enabled = false;
            this.cancelCraftingButton.Location = new System.Drawing.Point(24, 104);
            this.cancelCraftingButton.Name = "cancelCraftingButton";
            this.cancelCraftingButton.Size = new System.Drawing.Size(95, 25);
            this.cancelCraftingButton.TabIndex = 8;
            this.cancelCraftingButton.Text = "Cancel Task";
            this.cancelCraftingButton.UseVisualStyleBackColor = true;
            this.cancelCraftingButton.Click += new System.EventHandler(this.cancelCraftingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Times to repeat:";
            // 
            // craftButton
            // 
            this.craftButton.Enabled = false;
            this.craftButton.Location = new System.Drawing.Point(24, 46);
            this.craftButton.Name = "craftButton";
            this.craftButton.Size = new System.Drawing.Size(95, 50);
            this.craftButton.TabIndex = 5;
            this.craftButton.Text = "Do Task";
            this.craftButton.UseVisualStyleBackColor = true;
            this.craftButton.Click += new System.EventHandler(this.craftButton_Click);
            // 
            // taskProgressBar
            // 
            this.taskProgressBar.Location = new System.Drawing.Point(0, 281);
            this.taskProgressBar.Name = "taskProgressBar";
            this.taskProgressBar.Size = new System.Drawing.Size(264, 10);
            this.taskProgressBar.TabIndex = 6;
            // 
            // taskOverallProgressBar
            // 
            this.taskOverallProgressBar.Location = new System.Drawing.Point(0, 272);
            this.taskOverallProgressBar.Name = "taskOverallProgressBar";
            this.taskOverallProgressBar.Size = new System.Drawing.Size(264, 10);
            this.taskOverallProgressBar.TabIndex = 30;
            // 
            // helpButton1
            // 
            this.helpButton1.Image = global::FFXILife.Properties.Resources.helpIcon;
            this.helpButton1.Location = new System.Drawing.Point(208, 12);
            this.helpButton1.Name = "helpButton1";
            this.helpButton1.Size = new System.Drawing.Size(25, 25);
            this.helpButton1.TabIndex = 31;
            this.helpButton1.UseVisualStyleBackColor = true;
            this.helpButton1.Click += new System.EventHandler(this.helpButton1_Click);
            // 
            // radioButtonCrafting
            // 
            this.radioButtonCrafting.AutoSize = true;
            this.radioButtonCrafting.Checked = true;
            this.radioButtonCrafting.Location = new System.Drawing.Point(6, 17);
            this.radioButtonCrafting.Name = "radioButtonCrafting";
            this.radioButtonCrafting.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCrafting.TabIndex = 33;
            this.radioButtonCrafting.TabStop = true;
            this.radioButtonCrafting.Text = "Crafting";
            this.radioButtonCrafting.UseVisualStyleBackColor = true;
            this.radioButtonCrafting.Click += new System.EventHandler(this.radioBoxChanged);
            // 
            // radioButtonDigging
            // 
            this.radioButtonDigging.AutoSize = true;
            this.radioButtonDigging.Location = new System.Drawing.Point(6, 40);
            this.radioButtonDigging.Name = "radioButtonDigging";
            this.radioButtonDigging.Size = new System.Drawing.Size(87, 17);
            this.radioButtonDigging.TabIndex = 34;
            this.radioButtonDigging.Text = "Chocobo Dig";
            this.radioButtonDigging.UseVisualStyleBackColor = true;
            this.radioButtonDigging.Click += new System.EventHandler(this.radioBoxChanged);
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(6, 63);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(60, 17);
            this.radioButtonOther.TabIndex = 35;
            this.radioButtonOther.Text = "Other...";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            this.radioButtonOther.Click += new System.EventHandler(this.radioBoxChanged);
            // 
            // taskListBox
            // 
            this.taskListBox.Controls.Add(this.label5);
            this.taskListBox.Controls.Add(this.radioButtonCrafting);
            this.taskListBox.Controls.Add(this.radioButtonOther);
            this.taskListBox.Controls.Add(this.radioButtonDigging);
            this.taskListBox.Location = new System.Drawing.Point(125, 46);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(108, 83);
            this.taskListBox.TabIndex = 36;
            this.taskListBox.TabStop = false;
            this.taskListBox.Text = "Task List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(58, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "(soon)";
            // 
            // otherCommandTextBox
            // 
            this.otherCommandTextBox.Enabled = false;
            this.otherCommandTextBox.Location = new System.Drawing.Point(24, 183);
            this.otherCommandTextBox.Multiline = true;
            this.otherCommandTextBox.Name = "otherCommandTextBox";
            this.otherCommandTextBox.Size = new System.Drawing.Size(209, 53);
            this.otherCommandTextBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Custom Command:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "How many seconds to wait\r\nbefore repeating the task.";
            // 
            // customSeconds
            // 
            this.customSeconds.Enabled = false;
            this.customSeconds.Location = new System.Drawing.Point(49, 140);
            this.customSeconds.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.customSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customSeconds.Name = "customSeconds";
            this.customSeconds.Size = new System.Drawing.Size(49, 20);
            this.customSeconds.TabIndex = 40;
            this.customSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // loadScriptButton
            // 
            this.loadScriptButton.Enabled = false;
            this.loadScriptButton.Location = new System.Drawing.Point(24, 242);
            this.loadScriptButton.Name = "loadScriptButton";
            this.loadScriptButton.Size = new System.Drawing.Size(70, 23);
            this.loadScriptButton.TabIndex = 41;
            this.loadScriptButton.Text = "Load Script";
            this.loadScriptButton.UseVisualStyleBackColor = true;
            // 
            // saveScriptButton
            // 
            this.saveScriptButton.Enabled = false;
            this.saveScriptButton.Location = new System.Drawing.Point(163, 242);
            this.saveScriptButton.Name = "saveScriptButton";
            this.saveScriptButton.Size = new System.Drawing.Size(70, 23);
            this.saveScriptButton.TabIndex = 42;
            this.saveScriptButton.Text = "Save Script";
            this.saveScriptButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::FFXILife.Properties.Resources.clockIcon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.activateAllHuntsButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 60);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hunts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(56, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "(ValhallaXI exclusive feature.)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.craftButton);
            this.groupBox2.Controls.Add(this.taskProgressBar);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.taskOverallProgressBar);
            this.groupBox2.Controls.Add(this.saveScriptButton);
            this.groupBox2.Controls.Add(this.cancelCraftingButton);
            this.groupBox2.Controls.Add(this.loadScriptButton);
            this.groupBox2.Controls.Add(this.craftCount);
            this.groupBox2.Controls.Add(this.customSeconds);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.helpButton1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.taskListBox);
            this.groupBox2.Controls.Add(this.otherCommandTextBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 292);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // huntsTabControl
            // 
            this.huntsTabControl.Controls.Add(this.fRank);
            this.huntsTabControl.Controls.Add(this.eRank);
            this.huntsTabControl.Controls.Add(this.dRank);
            this.huntsTabControl.Location = new System.Drawing.Point(281, 8);
            this.huntsTabControl.Name = "huntsTabControl";
            this.huntsTabControl.SelectedIndex = 0;
            this.huntsTabControl.Size = new System.Drawing.Size(359, 410);
            this.huntsTabControl.TabIndex = 45;
            // 
            // fRank
            // 
            this.fRank.Controls.Add(this.fHuntsTable);
            this.fRank.Location = new System.Drawing.Point(4, 22);
            this.fRank.Name = "fRank";
            this.fRank.Padding = new System.Windows.Forms.Padding(3);
            this.fRank.Size = new System.Drawing.Size(351, 384);
            this.fRank.TabIndex = 0;
            this.fRank.Text = "F Rank";
            this.fRank.UseVisualStyleBackColor = true;
            // 
            // fHuntsTable
            // 
            this.fHuntsTable.AutoSize = true;
            this.fHuntsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.fHuntsTable.ColumnCount = 3;
            this.fHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.fHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fHuntsTable.Location = new System.Drawing.Point(6, 6);
            this.fHuntsTable.Name = "fHuntsTable";
            this.fHuntsTable.RowCount = 1;
            this.fHuntsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.fHuntsTable.Size = new System.Drawing.Size(339, 46);
            this.fHuntsTable.TabIndex = 3;
            this.fHuntsTable.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.alternatingRowColors);
            // 
            // eRank
            // 
            this.eRank.Controls.Add(this.eHuntsTable);
            this.eRank.Location = new System.Drawing.Point(4, 22);
            this.eRank.Name = "eRank";
            this.eRank.Padding = new System.Windows.Forms.Padding(3);
            this.eRank.Size = new System.Drawing.Size(351, 384);
            this.eRank.TabIndex = 1;
            this.eRank.Text = "E Rank";
            this.eRank.UseVisualStyleBackColor = true;
            // 
            // eHuntsTable
            // 
            this.eHuntsTable.AutoSize = true;
            this.eHuntsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.eHuntsTable.ColumnCount = 3;
            this.eHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.eHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.eHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.eHuntsTable.Location = new System.Drawing.Point(6, 6);
            this.eHuntsTable.Name = "eHuntsTable";
            this.eHuntsTable.RowCount = 1;
            this.eHuntsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.eHuntsTable.Size = new System.Drawing.Size(339, 46);
            this.eHuntsTable.TabIndex = 4;
            this.eHuntsTable.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.alternatingRowColors);
            // 
            // dRank
            // 
            this.dRank.Controls.Add(this.dHuntsTable);
            this.dRank.Location = new System.Drawing.Point(4, 22);
            this.dRank.Name = "dRank";
            this.dRank.Size = new System.Drawing.Size(351, 384);
            this.dRank.TabIndex = 2;
            this.dRank.Text = "D Rank";
            this.dRank.UseVisualStyleBackColor = true;
            // 
            // dHuntsTable
            // 
            this.dHuntsTable.AutoSize = true;
            this.dHuntsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.dHuntsTable.ColumnCount = 3;
            this.dHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.dHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dHuntsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dHuntsTable.Location = new System.Drawing.Point(6, 6);
            this.dHuntsTable.Name = "dHuntsTable";
            this.dHuntsTable.RowCount = 1;
            this.dHuntsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.dHuntsTable.Size = new System.Drawing.Size(339, 46);
            this.dHuntsTable.TabIndex = 4;
            this.dHuntsTable.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.alternatingRowColors);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.openSettingsButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 52);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // openSettingsButton
            // 
            this.openSettingsButton.Location = new System.Drawing.Point(24, 19);
            this.openSettingsButton.Name = "openSettingsButton";
            this.openSettingsButton.Size = new System.Drawing.Size(209, 25);
            this.openSettingsButton.TabIndex = 47;
            this.openSettingsButton.Text = "Open Application Settings";
            this.openSettingsButton.UseVisualStyleBackColor = true;
            this.openSettingsButton.Click += new System.EventHandler(this.openSettingsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.huntsTabControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "FFXI Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.checkFirstRun);
            ((System.ComponentModel.ISupportInitialize)(this.craftCount)).EndInit();
            this.taskListBox.ResumeLayout(false);
            this.taskListBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.huntsTabControl.ResumeLayout(false);
            this.fRank.ResumeLayout(false);
            this.fRank.PerformLayout();
            this.eRank.ResumeLayout(false);
            this.eRank.PerformLayout();
            this.dRank.ResumeLayout(false);
            this.dRank.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button activateAllHuntsButton;
        private System.Windows.Forms.NumericUpDown craftCount;
        private System.Windows.Forms.Button cancelCraftingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button craftButton;
        private System.Windows.Forms.ProgressBar taskProgressBar;
        private System.Windows.Forms.ProgressBar taskOverallProgressBar;
        private System.Windows.Forms.Button helpButton1;
        private System.Windows.Forms.RadioButton radioButtonCrafting;
        private System.Windows.Forms.RadioButton radioButtonDigging;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.GroupBox taskListBox;
        private System.Windows.Forms.TextBox otherCommandTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown customSeconds;
        private System.Windows.Forms.Button loadScriptButton;
        private System.Windows.Forms.Button saveScriptButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl huntsTabControl;
        private System.Windows.Forms.TabPage fRank;
        private System.Windows.Forms.TabPage eRank;
        private System.Windows.Forms.TabPage dRank;
        private System.Windows.Forms.TableLayoutPanel fHuntsTable;
        private System.Windows.Forms.TableLayoutPanel eHuntsTable;
        private System.Windows.Forms.TableLayoutPanel dHuntsTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button openSettingsButton;
        private System.Windows.Forms.Label label5;
    }
}

