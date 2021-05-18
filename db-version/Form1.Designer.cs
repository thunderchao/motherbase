namespace db_version
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pCentral = new System.Windows.Forms.PictureBox();
            this.pDock = new System.Windows.Forms.PictureBox();
            this.pAerial = new System.Windows.Forms.PictureBox();
            this.pServer = new System.Windows.Forms.PictureBox();
            this.pNaval = new System.Windows.Forms.PictureBox();
            this.pStorage = new System.Windows.Forms.PictureBox();
            this.pObservatory = new System.Windows.Forms.PictureBox();
            this.tabTroops = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.lboTroops = new System.Windows.Forms.ListBox();
            this.btnNewTroop = new System.Windows.Forms.Button();
            this.btnDeleteTroop = new System.Windows.Forms.Button();
            this.lblSNresult = new System.Windows.Forms.Label();
            this.lblVE = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSA = new System.Windows.Forms.Label();
            this.lblCQresult = new System.Windows.Forms.Label();
            this.lblLA = new System.Windows.Forms.Label();
            this.lblVEresult = new System.Windows.Forms.Label();
            this.lblCQ = new System.Windows.Forms.Label();
            this.lblLAresult = new System.Windows.Forms.Label();
            this.lblXPresult = new System.Windows.Forms.Label();
            this.lblSAresult = new System.Windows.Forms.Label();
            this.lblLevelresult = new System.Windows.Forms.Label();
            this.tabMissions = new System.Windows.Forms.TabPage();
            this.btnAbortMission = new System.Windows.Forms.Button();
            this.lblTimeRem = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pbActiveMission = new System.Windows.Forms.ProgressBar();
            this.btnMissionStart = new System.Windows.Forms.Button();
            this.lblMissionXPR = new System.Windows.Forms.Label();
            this.lblRewardsR = new System.Windows.Forms.Label();
            this.lblTimeR = new System.Windows.Forms.Label();
            this.lblMainStatR = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.lblMissionXP = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDanger = new System.Windows.Forms.Label();
            this.lblMainStat = new System.Windows.Forms.Label();
            this.lblAvailableMissions = new System.Windows.Forms.Label();
            this.lboAvailableMissions = new System.Windows.Forms.ListBox();
            this.tmrMission = new System.Windows.Forms.Timer(this.components);
            this.lboActiveSquad = new System.Windows.Forms.ListBox();
            this.btnAddToSquad = new System.Windows.Forms.Button();
            this.btnRemoveFromSquad = new System.Windows.Forms.Button();
            this.lblAvgSneak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAverages = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvgCQC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAvgVehicles = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAvgLarge = new System.Windows.Forms.Label();
            this.lblAvgSmall = new System.Windows.Forms.Label();
            this.lblAvgLevel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCentral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNaval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pObservatory)).BeginInit();
            this.tabTroops.SuspendLayout();
            this.tabMissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBase);
            this.tabControl1.Controls.Add(this.tabTroops);
            this.tabControl1.Controls.Add(this.tabMissions);
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.tableLayoutPanel1);
            this.tabBase.Location = new System.Drawing.Point(4, 22);
            this.tabBase.Name = "tabBase";
            this.tabBase.Size = new System.Drawing.Size(705, 526);
            this.tabBase.TabIndex = 2;
            this.tabBase.Text = "Base";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.pCentral, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pDock, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pAerial, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pServer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pNaval, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pStorage, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pObservatory, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pCentral
            // 
            this.pCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCentral.Image = global::db_version.Properties.Resources.central_platform;
            this.pCentral.Location = new System.Drawing.Point(133, 133);
            this.pCentral.Margin = new System.Windows.Forms.Padding(0);
            this.pCentral.Name = "pCentral";
            this.pCentral.Size = new System.Drawing.Size(133, 133);
            this.pCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCentral.TabIndex = 0;
            this.pCentral.TabStop = false;
            // 
            // pDock
            // 
            this.pDock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pDock.Image = global::db_version.Properties.Resources.floating_dock;
            this.pDock.Location = new System.Drawing.Point(18, 18);
            this.pDock.Margin = new System.Windows.Forms.Padding(18, 18, 0, 18);
            this.pDock.Name = "pDock";
            this.tableLayoutPanel1.SetRowSpan(this.pDock, 3);
            this.pDock.Size = new System.Drawing.Size(115, 364);
            this.pDock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pDock.TabIndex = 1;
            this.pDock.TabStop = false;
            // 
            // pAerial
            // 
            this.pAerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAerial.Image = global::db_version.Properties.Resources.aerial;
            this.pAerial.Location = new System.Drawing.Point(133, 5);
            this.pAerial.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pAerial.Name = "pAerial";
            this.pAerial.Size = new System.Drawing.Size(133, 128);
            this.pAerial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAerial.TabIndex = 2;
            this.pAerial.TabStop = false;
            // 
            // pServer
            // 
            this.pServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pServer.Image = global::db_version.Properties.Resources.server_farm;
            this.pServer.Location = new System.Drawing.Point(133, 266);
            this.pServer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 19);
            this.pServer.Name = "pServer";
            this.pServer.Size = new System.Drawing.Size(133, 115);
            this.pServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pServer.TabIndex = 3;
            this.pServer.TabStop = false;
            // 
            // pNaval
            // 
            this.pNaval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNaval.Image = global::db_version.Properties.Resources.naval;
            this.pNaval.Location = new System.Drawing.Point(266, 18);
            this.pNaval.Margin = new System.Windows.Forms.Padding(0, 18, 18, 0);
            this.pNaval.Name = "pNaval";
            this.pNaval.Size = new System.Drawing.Size(116, 115);
            this.pNaval.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pNaval.TabIndex = 4;
            this.pNaval.TabStop = false;
            // 
            // pStorage
            // 
            this.pStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStorage.Image = global::db_version.Properties.Resources.storage_and_mnfg;
            this.pStorage.Location = new System.Drawing.Point(266, 133);
            this.pStorage.Margin = new System.Windows.Forms.Padding(0, 0, 36, 0);
            this.pStorage.Name = "pStorage";
            this.pStorage.Size = new System.Drawing.Size(98, 133);
            this.pStorage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pStorage.TabIndex = 5;
            this.pStorage.TabStop = false;
            // 
            // pObservatory
            // 
            this.pObservatory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pObservatory.Image = global::db_version.Properties.Resources.observatory;
            this.pObservatory.Location = new System.Drawing.Point(266, 266);
            this.pObservatory.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pObservatory.Name = "pObservatory";
            this.pObservatory.Size = new System.Drawing.Size(129, 129);
            this.pObservatory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pObservatory.TabIndex = 6;
            this.pObservatory.TabStop = false;
            // 
            // tabTroops
            // 
            this.tabTroops.Controls.Add(this.lblAvgSneak);
            this.tabTroops.Controls.Add(this.label2);
            this.tabTroops.Controls.Add(this.label3);
            this.tabTroops.Controls.Add(this.lblAverages);
            this.tabTroops.Controls.Add(this.label5);
            this.tabTroops.Controls.Add(this.label6);
            this.tabTroops.Controls.Add(this.lblAvgCQC);
            this.tabTroops.Controls.Add(this.label8);
            this.tabTroops.Controls.Add(this.lblAvgVehicles);
            this.tabTroops.Controls.Add(this.label10);
            this.tabTroops.Controls.Add(this.lblAvgLarge);
            this.tabTroops.Controls.Add(this.lblAvgSmall);
            this.tabTroops.Controls.Add(this.lblAvgLevel);
            this.tabTroops.Controls.Add(this.btnRemoveFromSquad);
            this.tabTroops.Controls.Add(this.btnAddToSquad);
            this.tabTroops.Controls.Add(this.lboActiveSquad);
            this.tabTroops.Controls.Add(this.btnSave);
            this.tabTroops.Controls.Add(this.lboTroops);
            this.tabTroops.Controls.Add(this.btnNewTroop);
            this.tabTroops.Controls.Add(this.btnDeleteTroop);
            this.tabTroops.Controls.Add(this.lblSNresult);
            this.tabTroops.Controls.Add(this.lblVE);
            this.tabTroops.Controls.Add(this.lblSN);
            this.tabTroops.Controls.Add(this.lblXP);
            this.tabTroops.Controls.Add(this.lblLevel);
            this.tabTroops.Controls.Add(this.lblSA);
            this.tabTroops.Controls.Add(this.lblCQresult);
            this.tabTroops.Controls.Add(this.lblLA);
            this.tabTroops.Controls.Add(this.lblVEresult);
            this.tabTroops.Controls.Add(this.lblCQ);
            this.tabTroops.Controls.Add(this.lblLAresult);
            this.tabTroops.Controls.Add(this.lblXPresult);
            this.tabTroops.Controls.Add(this.lblSAresult);
            this.tabTroops.Controls.Add(this.lblLevelresult);
            this.tabTroops.Location = new System.Drawing.Point(4, 22);
            this.tabTroops.Name = "tabTroops";
            this.tabTroops.Padding = new System.Windows.Forms.Padding(3);
            this.tabTroops.Size = new System.Drawing.Size(705, 526);
            this.tabTroops.TabIndex = 0;
            this.tabTroops.Text = "Troops";
            this.tabTroops.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(203, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Troops";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lboTroops
            // 
            this.lboTroops.FormattingEnabled = true;
            this.lboTroops.Location = new System.Drawing.Point(4, 46);
            this.lboTroops.Name = "lboTroops";
            this.lboTroops.Size = new System.Drawing.Size(193, 212);
            this.lboTroops.TabIndex = 17;
            this.lboTroops.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNewTroop
            // 
            this.btnNewTroop.Location = new System.Drawing.Point(203, 75);
            this.btnNewTroop.Name = "btnNewTroop";
            this.btnNewTroop.Size = new System.Drawing.Size(98, 23);
            this.btnNewTroop.TabIndex = 1;
            this.btnNewTroop.Text = "New Troop";
            this.btnNewTroop.UseVisualStyleBackColor = true;
            this.btnNewTroop.Click += new System.EventHandler(this.btnNewTroop_Click);
            // 
            // btnDeleteTroop
            // 
            this.btnDeleteTroop.Location = new System.Drawing.Point(203, 46);
            this.btnDeleteTroop.Name = "btnDeleteTroop";
            this.btnDeleteTroop.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteTroop.TabIndex = 3;
            this.btnDeleteTroop.Text = "Delete Troop";
            this.btnDeleteTroop.UseVisualStyleBackColor = true;
            this.btnDeleteTroop.Click += new System.EventHandler(this.btnDeleteTroop_Click);
            // 
            // lblSNresult
            // 
            this.lblSNresult.AutoSize = true;
            this.lblSNresult.Location = new System.Drawing.Point(75, 341);
            this.lblSNresult.Name = "lblSNresult";
            this.lblSNresult.Size = new System.Drawing.Size(0, 13);
            this.lblSNresult.TabIndex = 19;
            // 
            // lblVE
            // 
            this.lblVE.AutoSize = true;
            this.lblVE.Location = new System.Drawing.Point(3, 325);
            this.lblVE.Name = "lblVE";
            this.lblVE.Size = new System.Drawing.Size(47, 13);
            this.lblVE.TabIndex = 8;
            this.lblVE.Text = "Vehicles";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(3, 341);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(38, 13);
            this.lblSN.TabIndex = 18;
            this.lblSN.Text = "Sneak";
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(3, 261);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(21, 13);
            this.lblXP.TabIndex = 4;
            this.lblXP.Text = "XP";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(3, 277);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level";
            // 
            // lblSA
            // 
            this.lblSA.AutoSize = true;
            this.lblSA.Location = new System.Drawing.Point(3, 293);
            this.lblSA.Name = "lblSA";
            this.lblSA.Size = new System.Drawing.Size(58, 13);
            this.lblSA.TabIndex = 6;
            this.lblSA.Text = "Small Arms";
            // 
            // lblCQresult
            // 
            this.lblCQresult.AutoSize = true;
            this.lblCQresult.Location = new System.Drawing.Point(75, 357);
            this.lblCQresult.Name = "lblCQresult";
            this.lblCQresult.Size = new System.Drawing.Size(0, 13);
            this.lblCQresult.TabIndex = 15;
            // 
            // lblLA
            // 
            this.lblLA.AutoSize = true;
            this.lblLA.Location = new System.Drawing.Point(3, 309);
            this.lblLA.Name = "lblLA";
            this.lblLA.Size = new System.Drawing.Size(60, 13);
            this.lblLA.TabIndex = 7;
            this.lblLA.Text = "Large Arms";
            // 
            // lblVEresult
            // 
            this.lblVEresult.AutoSize = true;
            this.lblVEresult.Location = new System.Drawing.Point(75, 325);
            this.lblVEresult.Name = "lblVEresult";
            this.lblVEresult.Size = new System.Drawing.Size(0, 13);
            this.lblVEresult.TabIndex = 14;
            // 
            // lblCQ
            // 
            this.lblCQ.AutoSize = true;
            this.lblCQ.Location = new System.Drawing.Point(3, 357);
            this.lblCQ.Name = "lblCQ";
            this.lblCQ.Size = new System.Drawing.Size(29, 13);
            this.lblCQ.TabIndex = 9;
            this.lblCQ.Text = "CQC";
            // 
            // lblLAresult
            // 
            this.lblLAresult.AutoSize = true;
            this.lblLAresult.Location = new System.Drawing.Point(75, 309);
            this.lblLAresult.Name = "lblLAresult";
            this.lblLAresult.Size = new System.Drawing.Size(0, 13);
            this.lblLAresult.TabIndex = 13;
            // 
            // lblXPresult
            // 
            this.lblXPresult.AutoSize = true;
            this.lblXPresult.Location = new System.Drawing.Point(75, 261);
            this.lblXPresult.Name = "lblXPresult";
            this.lblXPresult.Size = new System.Drawing.Size(0, 13);
            this.lblXPresult.TabIndex = 10;
            // 
            // lblSAresult
            // 
            this.lblSAresult.AutoSize = true;
            this.lblSAresult.Location = new System.Drawing.Point(75, 293);
            this.lblSAresult.Name = "lblSAresult";
            this.lblSAresult.Size = new System.Drawing.Size(0, 13);
            this.lblSAresult.TabIndex = 12;
            // 
            // lblLevelresult
            // 
            this.lblLevelresult.AutoSize = true;
            this.lblLevelresult.Location = new System.Drawing.Point(75, 277);
            this.lblLevelresult.Name = "lblLevelresult";
            this.lblLevelresult.Size = new System.Drawing.Size(0, 13);
            this.lblLevelresult.TabIndex = 11;
            // 
            // tabMissions
            // 
            this.tabMissions.Controls.Add(this.btnAbortMission);
            this.tabMissions.Controls.Add(this.lblTimeRem);
            this.tabMissions.Controls.Add(this.lblProg);
            this.tabMissions.Controls.Add(this.lblSpeed);
            this.tabMissions.Controls.Add(this.pbActiveMission);
            this.tabMissions.Controls.Add(this.btnMissionStart);
            this.tabMissions.Controls.Add(this.lblMissionXPR);
            this.tabMissions.Controls.Add(this.lblRewardsR);
            this.tabMissions.Controls.Add(this.lblTimeR);
            this.tabMissions.Controls.Add(this.lblMainStatR);
            this.tabMissions.Controls.Add(this.lblReward);
            this.tabMissions.Controls.Add(this.lblMissionXP);
            this.tabMissions.Controls.Add(this.lblTime);
            this.tabMissions.Controls.Add(this.lblDanger);
            this.tabMissions.Controls.Add(this.lblMainStat);
            this.tabMissions.Controls.Add(this.lblAvailableMissions);
            this.tabMissions.Controls.Add(this.lboAvailableMissions);
            this.tabMissions.Location = new System.Drawing.Point(4, 22);
            this.tabMissions.Name = "tabMissions";
            this.tabMissions.Padding = new System.Windows.Forms.Padding(3);
            this.tabMissions.Size = new System.Drawing.Size(705, 526);
            this.tabMissions.TabIndex = 1;
            this.tabMissions.Text = "Missions";
            this.tabMissions.UseVisualStyleBackColor = true;
            // 
            // btnAbortMission
            // 
            this.btnAbortMission.Location = new System.Drawing.Point(286, 172);
            this.btnAbortMission.Name = "btnAbortMission";
            this.btnAbortMission.Size = new System.Drawing.Size(144, 23);
            this.btnAbortMission.TabIndex = 16;
            this.btnAbortMission.Text = "Abort Mission";
            this.btnAbortMission.UseVisualStyleBackColor = true;
            this.btnAbortMission.Click += new System.EventHandler(this.btnAbortMission_Click);
            // 
            // lblTimeRem
            // 
            this.lblTimeRem.AutoSize = true;
            this.lblTimeRem.Location = new System.Drawing.Point(286, 348);
            this.lblTimeRem.Name = "lblTimeRem";
            this.lblTimeRem.Size = new System.Drawing.Size(83, 13);
            this.lblTimeRem.TabIndex = 15;
            this.lblTimeRem.Text = "Time Remaining";
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.Location = new System.Drawing.Point(286, 331);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(48, 13);
            this.lblProg.TabIndex = 14;
            this.lblProg.Text = "Progress";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(286, 314);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 13;
            this.lblSpeed.Text = "Speed";
            // 
            // pbActiveMission
            // 
            this.pbActiveMission.Location = new System.Drawing.Point(286, 284);
            this.pbActiveMission.Name = "pbActiveMission";
            this.pbActiveMission.Size = new System.Drawing.Size(413, 23);
            this.pbActiveMission.TabIndex = 12;
            // 
            // btnMissionStart
            // 
            this.btnMissionStart.Location = new System.Drawing.Point(286, 142);
            this.btnMissionStart.Name = "btnMissionStart";
            this.btnMissionStart.Size = new System.Drawing.Size(144, 23);
            this.btnMissionStart.TabIndex = 11;
            this.btnMissionStart.Text = "Begin Mission";
            this.btnMissionStart.UseVisualStyleBackColor = true;
            this.btnMissionStart.Click += new System.EventHandler(this.btnMissionStart_Click);
            // 
            // lblMissionXPR
            // 
            this.lblMissionXPR.AutoSize = true;
            this.lblMissionXPR.Location = new System.Drawing.Point(349, 101);
            this.lblMissionXPR.Name = "lblMissionXPR";
            this.lblMissionXPR.Size = new System.Drawing.Size(35, 13);
            this.lblMissionXPR.TabIndex = 10;
            this.lblMissionXPR.Text = "label1";
            // 
            // lblRewardsR
            // 
            this.lblRewardsR.AutoSize = true;
            this.lblRewardsR.Location = new System.Drawing.Point(349, 73);
            this.lblRewardsR.Name = "lblRewardsR";
            this.lblRewardsR.Size = new System.Drawing.Size(35, 13);
            this.lblRewardsR.TabIndex = 9;
            this.lblRewardsR.Text = "label1";
            // 
            // lblTimeR
            // 
            this.lblTimeR.AutoSize = true;
            this.lblTimeR.Location = new System.Drawing.Point(517, 46);
            this.lblTimeR.Name = "lblTimeR";
            this.lblTimeR.Size = new System.Drawing.Size(35, 13);
            this.lblTimeR.TabIndex = 8;
            this.lblTimeR.Text = "label1";
            // 
            // lblMainStatR
            // 
            this.lblMainStatR.AutoSize = true;
            this.lblMainStatR.Location = new System.Drawing.Point(349, 46);
            this.lblMainStatR.Name = "lblMainStatR";
            this.lblMainStatR.Size = new System.Drawing.Size(35, 13);
            this.lblMainStatR.TabIndex = 7;
            this.lblMainStatR.Text = "label1";
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Location = new System.Drawing.Point(285, 73);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(52, 13);
            this.lblReward.TabIndex = 6;
            this.lblReward.Text = "Rewards:";
            // 
            // lblMissionXP
            // 
            this.lblMissionXP.AutoSize = true;
            this.lblMissionXP.Location = new System.Drawing.Point(286, 101);
            this.lblMissionXP.Name = "lblMissionXP";
            this.lblMissionXP.Size = new System.Drawing.Size(24, 13);
            this.lblMissionXP.TabIndex = 5;
            this.lblMissionXP.Text = "XP:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(477, 46);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // lblDanger
            // 
            this.lblDanger.AutoSize = true;
            this.lblDanger.Location = new System.Drawing.Point(455, 46);
            this.lblDanger.Name = "lblDanger";
            this.lblDanger.Size = new System.Drawing.Size(16, 13);
            this.lblDanger.TabIndex = 3;
            this.lblDanger.Text = "⬤";
            // 
            // lblMainStat
            // 
            this.lblMainStat.AutoSize = true;
            this.lblMainStat.Location = new System.Drawing.Point(286, 46);
            this.lblMainStat.Name = "lblMainStat";
            this.lblMainStat.Size = new System.Drawing.Size(58, 13);
            this.lblMainStat.TabIndex = 2;
            this.lblMainStat.Text = "Main Stat: ";
            // 
            // lblAvailableMissions
            // 
            this.lblAvailableMissions.AutoSize = true;
            this.lblAvailableMissions.Location = new System.Drawing.Point(4, 4);
            this.lblAvailableMissions.Name = "lblAvailableMissions";
            this.lblAvailableMissions.Size = new System.Drawing.Size(93, 13);
            this.lblAvailableMissions.TabIndex = 1;
            this.lblAvailableMissions.Text = "Available Missions";
            // 
            // lboAvailableMissions
            // 
            this.lboAvailableMissions.FormattingEnabled = true;
            this.lboAvailableMissions.Location = new System.Drawing.Point(4, 46);
            this.lboAvailableMissions.Name = "lboAvailableMissions";
            this.lboAvailableMissions.Size = new System.Drawing.Size(275, 472);
            this.lboAvailableMissions.TabIndex = 0;
            this.lboAvailableMissions.SelectedIndexChanged += new System.EventHandler(this.lboAvailableMissions_SelectedIndexChanged);
            // 
            // tmrMission
            // 
            this.tmrMission.Tick += new System.EventHandler(this.tmrMission_Tick);
            // 
            // lboActiveSquad
            // 
            this.lboActiveSquad.FormattingEnabled = true;
            this.lboActiveSquad.Location = new System.Drawing.Point(396, 46);
            this.lboActiveSquad.Name = "lboActiveSquad";
            this.lboActiveSquad.Size = new System.Drawing.Size(194, 56);
            this.lboActiveSquad.TabIndex = 20;
            this.lboActiveSquad.SelectedIndexChanged += new System.EventHandler(this.lboActiveSquad_SelectedIndexChanged);
            // 
            // btnAddToSquad
            // 
            this.btnAddToSquad.Enabled = false;
            this.btnAddToSquad.Location = new System.Drawing.Point(349, 46);
            this.btnAddToSquad.Name = "btnAddToSquad";
            this.btnAddToSquad.Size = new System.Drawing.Size(28, 23);
            this.btnAddToSquad.TabIndex = 21;
            this.btnAddToSquad.Text = ">";
            this.btnAddToSquad.UseVisualStyleBackColor = true;
            this.btnAddToSquad.Click += new System.EventHandler(this.btnAddToSquad_Click);
            // 
            // btnRemoveFromSquad
            // 
            this.btnRemoveFromSquad.Enabled = false;
            this.btnRemoveFromSquad.Location = new System.Drawing.Point(349, 76);
            this.btnRemoveFromSquad.Name = "btnRemoveFromSquad";
            this.btnRemoveFromSquad.Size = new System.Drawing.Size(28, 23);
            this.btnRemoveFromSquad.TabIndex = 22;
            this.btnRemoveFromSquad.Text = "<";
            this.btnRemoveFromSquad.UseVisualStyleBackColor = true;
            this.btnRemoveFromSquad.Click += new System.EventHandler(this.btnRemoveFromSquad_Click);
            // 
            // lblAvgSneak
            // 
            this.lblAvgSneak.AutoSize = true;
            this.lblAvgSneak.Location = new System.Drawing.Point(471, 188);
            this.lblAvgSneak.Name = "lblAvgSneak";
            this.lblAvgSneak.Size = new System.Drawing.Size(0, 13);
            this.lblAvgSneak.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Vehicles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Sneak";
            // 
            // lblAverages
            // 
            this.lblAverages.AutoSize = true;
            this.lblAverages.Location = new System.Drawing.Point(399, 108);
            this.lblAverages.Name = "lblAverages";
            this.lblAverages.Size = new System.Drawing.Size(119, 13);
            this.lblAverages.TabIndex = 23;
            this.lblAverages.Text = "Active Squad Averages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Small Arms";
            // 
            // lblAvgCQC
            // 
            this.lblAvgCQC.AutoSize = true;
            this.lblAvgCQC.Location = new System.Drawing.Point(471, 204);
            this.lblAvgCQC.Name = "lblAvgCQC";
            this.lblAvgCQC.Size = new System.Drawing.Size(0, 13);
            this.lblAvgCQC.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Large Arms";
            // 
            // lblAvgVehicles
            // 
            this.lblAvgVehicles.AutoSize = true;
            this.lblAvgVehicles.Location = new System.Drawing.Point(471, 172);
            this.lblAvgVehicles.Name = "lblAvgVehicles";
            this.lblAvgVehicles.Size = new System.Drawing.Size(0, 13);
            this.lblAvgVehicles.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "CQC";
            // 
            // lblAvgLarge
            // 
            this.lblAvgLarge.AutoSize = true;
            this.lblAvgLarge.Location = new System.Drawing.Point(471, 156);
            this.lblAvgLarge.Name = "lblAvgLarge";
            this.lblAvgLarge.Size = new System.Drawing.Size(0, 13);
            this.lblAvgLarge.TabIndex = 32;
            // 
            // lblAvgSmall
            // 
            this.lblAvgSmall.AutoSize = true;
            this.lblAvgSmall.Location = new System.Drawing.Point(471, 140);
            this.lblAvgSmall.Name = "lblAvgSmall";
            this.lblAvgSmall.Size = new System.Drawing.Size(0, 13);
            this.lblAvgSmall.TabIndex = 31;
            // 
            // lblAvgLevel
            // 
            this.lblAvgLevel.AutoSize = true;
            this.lblAvgLevel.Location = new System.Drawing.Point(471, 124);
            this.lblAvgLevel.Name = "lblAvgLevel";
            this.lblAvgLevel.Size = new System.Drawing.Size(0, 13);
            this.lblAvgLevel.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCentral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNaval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pObservatory)).EndInit();
            this.tabTroops.ResumeLayout(false);
            this.tabTroops.PerformLayout();
            this.tabMissions.ResumeLayout(false);
            this.tabMissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTroops;
        private System.Windows.Forms.TabPage tabMissions;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.Button btnNewTroop;
        private System.Windows.Forms.Button btnDeleteTroop;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSA;
        private System.Windows.Forms.Label lblLA;
        private System.Windows.Forms.Label lblVE;
        private System.Windows.Forms.Label lblCQ;
        private System.Windows.Forms.Label lblCQresult;
        private System.Windows.Forms.Label lblVEresult;
        private System.Windows.Forms.Label lblLAresult;
        private System.Windows.Forms.Label lblSAresult;
        private System.Windows.Forms.Label lblLevelresult;
        private System.Windows.Forms.Label lblXPresult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lboTroops;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblSNresult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pCentral;
        private System.Windows.Forms.PictureBox pDock;
        private System.Windows.Forms.PictureBox pAerial;
        private System.Windows.Forms.PictureBox pServer;
        private System.Windows.Forms.PictureBox pNaval;
        private System.Windows.Forms.PictureBox pStorage;
        private System.Windows.Forms.PictureBox pObservatory;
        private System.Windows.Forms.Label lblAvailableMissions;
        private System.Windows.Forms.ListBox lboAvailableMissions;
        private System.Windows.Forms.Label lblMainStatR;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Label lblMissionXP;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDanger;
        private System.Windows.Forms.Label lblMainStat;
        private System.Windows.Forms.Button btnMissionStart;
        private System.Windows.Forms.Label lblMissionXPR;
        private System.Windows.Forms.Label lblRewardsR;
        private System.Windows.Forms.Label lblTimeR;
        private System.Windows.Forms.ProgressBar pbActiveMission;
        private System.Windows.Forms.Timer tmrMission;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTimeRem;
        private System.Windows.Forms.Button btnAbortMission;
        private System.Windows.Forms.Button btnRemoveFromSquad;
        private System.Windows.Forms.Button btnAddToSquad;
        private System.Windows.Forms.ListBox lboActiveSquad;
        private System.Windows.Forms.Label lblAvgSneak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAverages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAvgCQC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAvgVehicles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAvgLarge;
        private System.Windows.Forms.Label lblAvgSmall;
        private System.Windows.Forms.Label lblAvgLevel;
    }
}

