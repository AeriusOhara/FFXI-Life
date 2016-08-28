using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

using System.Drawing;
using System.ComponentModel;


namespace FFXICrafterDesu
{
    public partial class mainForm : Form
    {
        BackgroundWorker taskWorker;
        const int MAX_HUNTS = 28;
        const int CRAFT_SECONDS = 20;
        enum RANKS:byte{F, E, D, C, B, A, S }
        int taskSecondsSoFar = 0;
        int tasksCompletedSoFar = 0;
        string commandToWindower = String.Empty;

        // Temporary fix, remove once multiline-tasks are implemented
        RadioButton lastSelectedTask;

        bool doingTask = false;
        bool registeringHunts = false;
        bool showingHunts = false;

        /* * * * * * * * * * * * * * * * * * * * * * *
         * W I N D O W E R   A P I
         * * * * * * * * * * * * * * * * * * * * * * */
        [DllImport("WindowerHelper.dll")]
        public static extern int CreateKeyboardHelper(string name);

        [DllImport("WindowerHelper.dll")]
        public static extern void CKHSendString(int helper, string data);

        public void SendString(String text)
        {
            int _keyboardHelper;

            //Process[] localByName = Process.GetProcessesByName("po2");
            Process[] localByName = Process.GetProcessesByName(FFXILife.Properties.Settings.Default.processName);
            _keyboardHelper = CreateKeyboardHelper("WindowerMMFKeyboardHandler_" + localByName[0].Id);
            CKHSendString(_keyboardHelper, text);
        }

        /* * * * * * * * * * * * * * * * * * * * * * *
         * F O R M
         * * * * * * * * * * * * * * * * * * * * * * */
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateHuntsTable();

            checkButtons();

            // Temporary fix, remove once multiline-tasks are implemented
            lastSelectedTask = radioButtonCrafting;
        }

        private void checkFirstRun(object sender, EventArgs e)
        {
            if(FFXILife.Properties.Settings.Default.firstRun)
            {
                string msg = "Ohey! Thanks for downloading my app. In order\n" +
                            "to make use of FFXI Life you need to select the\n" +
                            "Windower process.\n\n" +
                            "You can do that by pressing the \"Settings\" button\n" +
                            "at the bottom of this window. After that you will\n" +
                            "be good to go. Good luck and have fun!";
                MessageBox.Show(msg, "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FFXILife.Properties.Settings.Default.firstRun = false;
            FFXILife.Properties.Settings.Default.Save();
        }

        private void checkButtons()
        {
            craftCount.Enabled = false;
            craftButton.Enabled = false;
            cancelCraftingButton.Enabled = false;
            activateAllHuntsButton.Enabled = false;
            helpButton1.Enabled = false;
            taskListBox.Enabled = false;
            loadScriptButton.Enabled = false;
            saveScriptButton.Enabled = false;
            openSettingsButton.Enabled = false;

            if (doingTask)
            {
                cancelCraftingButton.Enabled = true;
            }
            else if (registeringHunts)
            {
                craftCount.Enabled = true;
            }
            else if(FFXILife.Properties.Settings.Default.processName == string.Empty)
            {
                openSettingsButton.Enabled = true;
            }
            else
            {
                craftCount.Enabled = true;
                craftButton.Enabled = true;
                cancelCraftingButton.Enabled = false;
                activateAllHuntsButton.Enabled = true;
                helpButton1.Enabled = true;
                taskListBox.Enabled = true;
                openSettingsButton.Enabled = true;
            }
        }

        /* * * * * * * * * * * * * * * * * * * * * * *
         * C R A F T S
         * * * * * * * * * * * * * * * * * * * * * * */
        private void craftButton_Click(object sender, EventArgs e)
        {
            // First check if we have a process name to work with
            if (FFXILife.Properties.Settings.Default.processName == string.Empty)
            {
                string msg = "You have not entered a Process Name.\n" +
                            "Please press the \"Settings\" button\n" +
                            "at the bottom of this application to\n" +
                            "set it up properly.";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Which command will we be sending to Windower?
            commandToWindower = "/lastsynth";
            if (radioButtonOther.Checked)
            {
                if(commandToWindower == String.Empty)
                {
                    MessageBox.Show("The Custom Command box cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                commandToWindower = otherCommandTextBox.Text;
            }
            else if (radioButtonDigging.Checked)
            {
                commandToWindower = "/dig";
            }

            doingTask = true;
            checkButtons();

            taskWorker = new BackgroundWorker();
            taskWorker.DoWork += new DoWorkEventHandler(craftWorker_DoWork);
            taskWorker.ProgressChanged += new ProgressChangedEventHandler(craftWorker_ProgressChanged);
            taskWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(craftWorker_RunWorkerCompleted);
            taskWorker.WorkerSupportsCancellation = true;
            taskWorker.WorkerReportsProgress = true;

            taskOverallProgressBar.Value = 0;
            taskOverallProgressBar.Maximum = (int)craftCount.Value;

            taskProgressBar.Value = 0;
            taskProgressBar.Maximum = CRAFT_SECONDS;

            tasksCompletedSoFar = 0;

            taskSecondsSoFar = 0;

            taskWorker.RunWorkerAsync();
        }

        private void cancelCraftingButton_Click(object sender, EventArgs e)
        {
            taskWorker.CancelAsync();
        }

        private void craftWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker cWorker = sender as BackgroundWorker;

            while(!cWorker.CancellationPending)
            {
                int craftprogress = 0;

                System.Threading.Thread.Sleep(1000);
                cWorker.ReportProgress(craftprogress);
            }

            e.Cancel = true;
        }

        private void craftWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(taskSecondsSoFar == 0)
            {
                SendString(commandToWindower);
                taskProgressBar.Value = 0;
                taskSecondsSoFar++;
            }
            else
            {
                if (taskSecondsSoFar <= CRAFT_SECONDS)
                {
                    taskProgressBar.Value++;
                    taskSecondsSoFar++;
                }
                else
                {
                    tasksCompletedSoFar++;
                    if (tasksCompletedSoFar >= craftCount.Value)
                    {
                        taskWorker.CancelAsync();
                    }
                    else
                    {
                        taskOverallProgressBar.Value++;
                        taskProgressBar.Value = 0;
                        taskSecondsSoFar = 0;
                    }
                }
            }
        }

        private void craftWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                doingTask = false;

                taskOverallProgressBar.Value = 0;
                taskProgressBar.Value = 0;

                checkButtons();
            }

            else if (!(e.Error == null))
            {
                MessageBox.Show("ERROR: " + e.Error.Message);

                checkButtons();
            }

            else
            {
                checkButtons();
            }
        }

        /* * * * * * * * * * * * * * * * * * * * * * *
         * H U N T S
         * * * * * * * * * * * * * * * * * * * * * * */
        private void showHunts_Click(object sender, EventArgs e)
        {
            if (!showingHunts)
            {
                showingHunts = true;
                this.Size = new Size(660, this.Size.Height);
            }
            else
            {
                showingHunts = false;
                this.Size = new Size(295, this.Size.Height);
            }
        }

        private void helpButton1_Click(object sender, EventArgs e)
        {
            string msg = "Step 1: Do the craft once in the game.\n" +
                            "Step 2: Set the times you want to repeat that same craft again in\n" +
                            "the number box and then click on the \"Start Crafting\" button.\n\n" +
                            "You can cancel any time with the \"Cancel Crafting\" button.";
            MessageBox.Show(msg, "Crafting and (You)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioBoxChanged(object sender, EventArgs e)
        {
            // Temporary, will remove once multi-line tasks are implemented
            if (radioButtonOther.Checked)
            {
                MessageBox.Show("This feature has not been implemented. Coming soon!", "Featureis a WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lastSelectedTask.Checked = true;
                checkButtons();
            }
            else 
            {
                if (radioButtonCrafting.Checked) { lastSelectedTask = radioButtonCrafting; }
                if (radioButtonDigging.Checked) { lastSelectedTask = radioButtonDigging; }
            }
            // /Temporary fix end

            otherCommandTextBox.Enabled = radioButtonOther.Checked;
            loadScriptButton.Enabled = radioButtonOther.Checked;
            saveScriptButton.Enabled = radioButtonOther.Checked;
            customSeconds.Enabled = radioButtonDigging.Checked | radioButtonOther.Checked;
        }

        private void alternatingRowColors(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.Gainsboro, e.CellBounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
        }

        private void populateHuntsTable()
        {
            HuntEntry FRANK0 = new HuntEntry(1, 10, "Wild Sheep", "West Ronfaure", 1500);
            HuntEntry FRANK1 = new HuntEntry(2, 10, "Goblin Weaver", "East Ronfaure", 1500);
            HuntEntry FRANK2 = new HuntEntry(3, 10, "Vulture", "North Gustaburg", 1500);
            HuntEntry FRANK3 = new HuntEntry(4, 10, "Rock Lizard", "North Gustaburg", 1500);
            HuntEntry FRANK4 = new HuntEntry(5, 10, "Yagudo", "West Sarutabaruta", 1500);
            HuntEntry FRANK5 = new HuntEntry(6, 10, "Crawlers", "East Sarutabaruta", 1500);
            HuntEntry FRANK6 = new HuntEntry(7, 10, "Leaping Lizzy", "South Gustaburg", 3000);
            HuntEntry FRANK7 = new HuntEntry(8, 10, "Bubbly Bernie", "South Gustaburg", 3000);
            HuntEntry FRANK8 = new HuntEntry(9, 10, "Tom Tit Tat", "West Sarutabaruta", 3000);

            HuntEntry ERANK0 = new HuntEntry(10, 12, "Hill Lizard", "Valkurm Dunes", 2500);
            HuntEntry ERANK1 = new HuntEntry(11, 12, "Snipper", "Valkurm Dunes", 2500);
            HuntEntry ERANK2 = new HuntEntry(12, 12, "Goblin Gambler", "Valkurm Dunes", 2500);
            HuntEntry ERANK3 = new HuntEntry(13, 12, "Land Worm", "Korroloka Tunnel", 2500);
            HuntEntry ERANK4 = new HuntEntry(14, 12, "Spook", "King Ranperres Tomb", 4000);
            HuntEntry ERANK5 = new HuntEntry(15, 12, "Orcish Panzer", "Fort Ghelsba", 4000);
            HuntEntry ERANK6 = new HuntEntry(16, 12, "Zhuu Buxu the Silent", "Giddeus", 4000);
            HuntEntry ERANK7 = new HuntEntry(17, 12, "Sharp-Eared Ropipi", "East Sarutabaruta", 4000);
            HuntEntry ERANK8 = new HuntEntry(18, 12, "Lumbering Lambert", "La Theine Plateau", 4000);
            HuntEntry ERANK9 = new HuntEntry(19, 12, "Rampaging Ram", "Konschtat Highlands", 4000);

            HuntEntry DRANK0 = new HuntEntry(20, 12, "Clippers", "Qufim Island", 3500);
            HuntEntry DRANK1 = new HuntEntry(21, 12, "Land Worms", "Qufim Island", 3500);
            HuntEntry DRANK2 = new HuntEntry(22, 12, "Mandragoras", "Yuhtunga Jungle", 3500);
            HuntEntry DRANK3 = new HuntEntry(23, 12, "Garuda", "Daily BCNM #2", 5000);
            HuntEntry DRANK4 = new HuntEntry(24, 12, "Golden Bat", "Valkurm Dunes", 5000);
            HuntEntry DRANK5 = new HuntEntry(25, 12, "Epialtes", "Lower Delkfutt Tower", 5000);
            HuntEntry DRANK6 = new HuntEntry(26, 12, "Jolly Green", "Pashhow Marshlands", 5000);
            HuntEntry DRANK7 = new HuntEntry(27, 12, "Morion Worm", "Korroloka Tunnel", 5000);
            HuntEntry DRANK8 = new HuntEntry(28, 12, "Tyrant", "Lower Delkfutt Tower", 5000);

            HuntRank rankF = new HuntRank();
            rankF.rank = (int)RANKS.F;
            rankF.huntList.Add(FRANK0); rankF.huntList.Add(FRANK1); rankF.huntList.Add(FRANK2); rankF.huntList.Add(FRANK3);
            rankF.huntList.Add(FRANK4); rankF.huntList.Add(FRANK5); rankF.huntList.Add(FRANK6); rankF.huntList.Add(FRANK7);
            rankF.huntList.Add(FRANK8);

            HuntRank rankE = new HuntRank();
            rankE.rank = (int)RANKS.E;
            rankE.huntList.Add(ERANK0); rankE.huntList.Add(ERANK1); rankE.huntList.Add(ERANK2); rankE.huntList.Add(ERANK3);
            rankE.huntList.Add(ERANK4); rankE.huntList.Add(ERANK5); rankE.huntList.Add(ERANK6); rankE.huntList.Add(ERANK7);
            rankE.huntList.Add(ERANK8); rankE.huntList.Add(ERANK9);

            HuntRank rankD = new HuntRank();
            rankD.rank = (int)RANKS.D;
            rankD.huntList.Add(DRANK0); rankD.huntList.Add(DRANK1); rankD.huntList.Add(DRANK2); rankD.huntList.Add(DRANK3);
            rankD.huntList.Add(DRANK4); rankD.huntList.Add(DRANK5); rankD.huntList.Add(DRANK6); rankD.huntList.Add(DRANK7);
            rankD.huntList.Add(DRANK8);

            Hunt hunt = new Hunt();
            hunt.HuntPages.Add(rankF);
            hunt.HuntPages.Add(rankE);
            hunt.HuntPages.Add(rankD);

            populateTable(hunt, (int)RANKS.F, fHuntsTable);
            populateTable(hunt, (int)RANKS.E, eHuntsTable);
            populateTable(hunt, (int)RANKS.D, dHuntsTable);
        }

        private void populateTable(Hunt hunt, int rank, TableLayoutPanel table)
        {
            for (int i = 0; i < hunt.HuntPages[rank].huntList.Count; i++)
            {
                if (i != 0)
                {
                    // Create a new row
                    table.RowCount++;
                }
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    switch (j)
                    {
                        case 0: // Button
                            Button tmpButton = new Button()
                            {
                                Text = "Accept" + hunt.HuntPages[rank].huntList[i].huntNo,
                                Anchor = AnchorStyles.Left,
                                AutoSize = true,
                                Tag = hunt.HuntPages[rank].huntList[i].huntNo
                            };
                            tmpButton.Click += registerHunt;
                            table.Controls.Add(tmpButton, j, i);
                            break;
                        case 1: // Mob amount + name
                            table.Controls.Add(new Label()
                            {
                                Text = hunt.HuntPages[rank].huntList[i].mobCount + "x " + hunt.HuntPages[rank].huntList[i].mobName,
                                Anchor = AnchorStyles.Left,
                                AutoSize = true,
                                Tag = hunt.HuntPages[rank].huntList[i].huntNo
                            }, j, i);
                            break;
                        case 2: // Area Name
                            table.Controls.Add(new Label()
                            {
                                Text = hunt.HuntPages[rank].huntList[i].areaName,
                                Anchor = AnchorStyles.Left,
                                AutoSize = true,
                                Tag = hunt.HuntPages[rank].huntList[i].huntNo
                            }, j, i);
                            break;
                        default:
                            MessageBox.Show("WAT + " + j.ToString());
                            break;
                    }
                }
            }
        }

        private void registerHunt(object sender, EventArgs e)
        {
            SendString("@hunt " + ((Button)sender).Tag);
        }

        private void openSettingsButton_Click(object sender, EventArgs e)
        {
            Form settingsForm = new settingsForm();
            settingsForm.ShowDialog(this);

            checkButtons();
        }
    }
}

class HuntEntry
{
    public int huntNo { get; set; }
    public int mobCount { get; set; }
    public string mobName { get; set; }
    public string areaName { get; set; }
    public int rewardAmount { get; set; }
    public HuntEntry(int _huntNo, int _mobCount, string _mobName, string _areaName, int _rewardAmount)
    {
        huntNo = _huntNo;
        mobCount = _mobCount;
        mobName = _mobName;
        areaName = _areaName;
        rewardAmount = _rewardAmount;
    }
};

class HuntRank
{
    public int rank;
    public List<HuntEntry> huntList = new List<HuntEntry>();
};

class Hunt
{
    public List<HuntRank> HuntPages = new List<HuntRank>();
}
