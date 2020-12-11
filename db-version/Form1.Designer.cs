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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pCentral = new System.Windows.Forms.PictureBox();
            this.pDock = new System.Windows.Forms.PictureBox();
            this.pAerial = new System.Windows.Forms.PictureBox();
            this.pServer = new System.Windows.Forms.PictureBox();
            this.pNaval = new System.Windows.Forms.PictureBox();
            this.pStorage = new System.Windows.Forms.PictureBox();
            this.pObservatory = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.tabTroops.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCentral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNaval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pObservatory)).BeginInit();
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
            // tabTroops
            // 
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
            this.btnSave.Location = new System.Drawing.Point(205, 64);
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
            this.lboTroops.Location = new System.Drawing.Point(6, 6);
            this.lboTroops.Name = "lboTroops";
            this.lboTroops.Size = new System.Drawing.Size(193, 95);
            this.lboTroops.TabIndex = 17;
            this.lboTroops.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNewTroop
            // 
            this.btnNewTroop.Location = new System.Drawing.Point(205, 35);
            this.btnNewTroop.Name = "btnNewTroop";
            this.btnNewTroop.Size = new System.Drawing.Size(98, 23);
            this.btnNewTroop.TabIndex = 1;
            this.btnNewTroop.Text = "New Troop";
            this.btnNewTroop.UseVisualStyleBackColor = true;
            this.btnNewTroop.Click += new System.EventHandler(this.btnNewTroop_Click);
            // 
            // btnDeleteTroop
            // 
            this.btnDeleteTroop.Location = new System.Drawing.Point(205, 6);
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
            this.lblSNresult.Location = new System.Drawing.Point(75, 188);
            this.lblSNresult.Name = "lblSNresult";
            this.lblSNresult.Size = new System.Drawing.Size(0, 13);
            this.lblSNresult.TabIndex = 19;
            // 
            // lblVE
            // 
            this.lblVE.AutoSize = true;
            this.lblVE.Location = new System.Drawing.Point(3, 172);
            this.lblVE.Name = "lblVE";
            this.lblVE.Size = new System.Drawing.Size(47, 13);
            this.lblVE.TabIndex = 8;
            this.lblVE.Text = "Vehicles";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(3, 188);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(38, 13);
            this.lblSN.TabIndex = 18;
            this.lblSN.Text = "Sneak";
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(3, 108);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(21, 13);
            this.lblXP.TabIndex = 4;
            this.lblXP.Text = "XP";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(3, 124);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level";
            // 
            // lblSA
            // 
            this.lblSA.AutoSize = true;
            this.lblSA.Location = new System.Drawing.Point(3, 140);
            this.lblSA.Name = "lblSA";
            this.lblSA.Size = new System.Drawing.Size(58, 13);
            this.lblSA.TabIndex = 6;
            this.lblSA.Text = "Small Arms";
            // 
            // lblCQresult
            // 
            this.lblCQresult.AutoSize = true;
            this.lblCQresult.Location = new System.Drawing.Point(75, 204);
            this.lblCQresult.Name = "lblCQresult";
            this.lblCQresult.Size = new System.Drawing.Size(0, 13);
            this.lblCQresult.TabIndex = 15;
            // 
            // lblLA
            // 
            this.lblLA.AutoSize = true;
            this.lblLA.Location = new System.Drawing.Point(3, 156);
            this.lblLA.Name = "lblLA";
            this.lblLA.Size = new System.Drawing.Size(60, 13);
            this.lblLA.TabIndex = 7;
            this.lblLA.Text = "Large Arms";
            // 
            // lblVEresult
            // 
            this.lblVEresult.AutoSize = true;
            this.lblVEresult.Location = new System.Drawing.Point(75, 172);
            this.lblVEresult.Name = "lblVEresult";
            this.lblVEresult.Size = new System.Drawing.Size(0, 13);
            this.lblVEresult.TabIndex = 14;
            // 
            // lblCQ
            // 
            this.lblCQ.AutoSize = true;
            this.lblCQ.Location = new System.Drawing.Point(3, 204);
            this.lblCQ.Name = "lblCQ";
            this.lblCQ.Size = new System.Drawing.Size(29, 13);
            this.lblCQ.TabIndex = 9;
            this.lblCQ.Text = "CQC";
            // 
            // lblLAresult
            // 
            this.lblLAresult.AutoSize = true;
            this.lblLAresult.Location = new System.Drawing.Point(75, 156);
            this.lblLAresult.Name = "lblLAresult";
            this.lblLAresult.Size = new System.Drawing.Size(0, 13);
            this.lblLAresult.TabIndex = 13;
            // 
            // lblXPresult
            // 
            this.lblXPresult.AutoSize = true;
            this.lblXPresult.Location = new System.Drawing.Point(75, 108);
            this.lblXPresult.Name = "lblXPresult";
            this.lblXPresult.Size = new System.Drawing.Size(0, 13);
            this.lblXPresult.TabIndex = 10;
            // 
            // lblSAresult
            // 
            this.lblSAresult.AutoSize = true;
            this.lblSAresult.Location = new System.Drawing.Point(75, 140);
            this.lblSAresult.Name = "lblSAresult";
            this.lblSAresult.Size = new System.Drawing.Size(0, 13);
            this.lblSAresult.TabIndex = 12;
            // 
            // lblLevelresult
            // 
            this.lblLevelresult.AutoSize = true;
            this.lblLevelresult.Location = new System.Drawing.Point(75, 124);
            this.lblLevelresult.Name = "lblLevelresult";
            this.lblLevelresult.Size = new System.Drawing.Size(0, 13);
            this.lblLevelresult.TabIndex = 11;
            // 
            // tabMissions
            // 
            this.tabMissions.Location = new System.Drawing.Point(4, 22);
            this.tabMissions.Name = "tabMissions";
            this.tabMissions.Padding = new System.Windows.Forms.Padding(3);
            this.tabMissions.Size = new System.Drawing.Size(705, 526);
            this.tabMissions.TabIndex = 1;
            this.tabMissions.Text = "Missions";
            this.tabMissions.UseVisualStyleBackColor = true;
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
            this.tabTroops.ResumeLayout(false);
            this.tabTroops.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCentral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNaval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pObservatory)).EndInit();
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
    }
}

