namespace Sagssystem
{
    partial class HomeBase
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
            this.SøgTextBox = new System.Windows.Forms.TextBox();
            this.søgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.rapNrLbl = new System.Windows.Forms.Label();
            this.parrentLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.parentTextBox = new System.Windows.Forms.TextBox();
            this.testerTextBox = new System.Windows.Forms.TextBox();
            this.kortBeskrivTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.afventerLbl = new System.Windows.Forms.Label();
            this.regDatoLbl = new System.Windows.Forms.Label();
            this.AnsvarligTextBox = new System.Windows.Forms.TextBox();
            this.kontaktTextBox = new System.Windows.Forms.TextBox();
            this.ressourceTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.langBeskrivTextBox = new System.Windows.Forms.TextBox();
            this.gemBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nytProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nySagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyOBSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.åbnSagssystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemSagssystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rydAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilTekstfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fraTekstfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niveauComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.subTaskLbl = new System.Windows.Forms.Label();
            this.subTaskListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kortBeskriv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registreretTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SøgTextBox
            // 
            this.SøgTextBox.Location = new System.Drawing.Point(203, 55);
            this.SøgTextBox.Name = "SøgTextBox";
            this.SøgTextBox.Size = new System.Drawing.Size(155, 22);
            this.SøgTextBox.TabIndex = 0;
            // 
            // søgBtn
            // 
            this.søgBtn.Location = new System.Drawing.Point(370, 49);
            this.søgBtn.Name = "søgBtn";
            this.søgBtn.Size = new System.Drawing.Size(65, 30);
            this.søgBtn.TabIndex = 2;
            this.søgBtn.Text = "Søg";
            this.søgBtn.UseVisualStyleBackColor = true;
            this.søgBtn.Click += new System.EventHandler(this.søgBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Regisreret af:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(61, 115);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(81, 17);
            this.typeLbl.TabIndex = 5;
            this.typeLbl.Text = "Projekt nr. :";
            // 
            // rapNrLbl
            // 
            this.rapNrLbl.AutoSize = true;
            this.rapNrLbl.Location = new System.Drawing.Point(177, 111);
            this.rapNrLbl.Name = "rapNrLbl";
            this.rapNrLbl.Size = new System.Drawing.Size(16, 17);
            this.rapNrLbl.TabIndex = 6;
            this.rapNrLbl.Text = "0";
            // 
            // parrentLbl
            // 
            this.parrentLbl.AutoSize = true;
            this.parrentLbl.Location = new System.Drawing.Point(58, 187);
            this.parrentLbl.Name = "parrentLbl";
            this.parrentLbl.Size = new System.Drawing.Size(88, 17);
            this.parrentLbl.TabIndex = 7;
            this.parrentLbl.Text = "Tilhører sag:";
            this.parrentLbl.Click += new System.EventHandler(this.parrentLbl_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tester:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Beskrivelse kort:";
            // 
            // parentTextBox
            // 
            this.parentTextBox.Location = new System.Drawing.Point(182, 187);
            this.parentTextBox.Name = "parentTextBox";
            this.parentTextBox.Size = new System.Drawing.Size(155, 22);
            this.parentTextBox.TabIndex = 11;
            // 
            // testerTextBox
            // 
            this.testerTextBox.Location = new System.Drawing.Point(536, 253);
            this.testerTextBox.Name = "testerTextBox";
            this.testerTextBox.Size = new System.Drawing.Size(155, 22);
            this.testerTextBox.TabIndex = 13;
            this.testerTextBox.TextChanged += new System.EventHandler(this.OpdaterAfventerLbl);
            // 
            // kortBeskrivTextBox
            // 
            this.kortBeskrivTextBox.Location = new System.Drawing.Point(180, 284);
            this.kortBeskrivTextBox.Name = "kortBeskrivTextBox";
            this.kortBeskrivTextBox.Size = new System.Drawing.Size(511, 22);
            this.kortBeskrivTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Afventer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Registreret:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rapport ansvarlig:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kontakt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ressource:";
            // 
            // afventerLbl
            // 
            this.afventerLbl.AutoSize = true;
            this.afventerLbl.Location = new System.Drawing.Point(533, 115);
            this.afventerLbl.Name = "afventerLbl";
            this.afventerLbl.Size = new System.Drawing.Size(0, 17);
            this.afventerLbl.TabIndex = 20;
            // 
            // regDatoLbl
            // 
            this.regDatoLbl.AutoSize = true;
            this.regDatoLbl.Location = new System.Drawing.Point(533, 150);
            this.regDatoLbl.Name = "regDatoLbl";
            this.regDatoLbl.Size = new System.Drawing.Size(146, 17);
            this.regDatoLbl.TabIndex = 21;
            this.regDatoLbl.Text = "01-01-2000  12.00.00";
            // 
            // AnsvarligTextBox
            // 
            this.AnsvarligTextBox.Location = new System.Drawing.Point(180, 253);
            this.AnsvarligTextBox.Name = "AnsvarligTextBox";
            this.AnsvarligTextBox.Size = new System.Drawing.Size(155, 22);
            this.AnsvarligTextBox.TabIndex = 22;
            this.AnsvarligTextBox.TextChanged += new System.EventHandler(this.OpdaterAfventerLbl);
            // 
            // kontaktTextBox
            // 
            this.kontaktTextBox.Location = new System.Drawing.Point(536, 218);
            this.kontaktTextBox.Name = "kontaktTextBox";
            this.kontaktTextBox.Size = new System.Drawing.Size(155, 22);
            this.kontaktTextBox.TabIndex = 23;
            this.kontaktTextBox.TextChanged += new System.EventHandler(this.OpdaterAfventerLbl);
            // 
            // ressourceTextBox
            // 
            this.ressourceTextBox.Location = new System.Drawing.Point(536, 187);
            this.ressourceTextBox.Name = "ressourceTextBox";
            this.ressourceTextBox.Size = new System.Drawing.Size(155, 22);
            this.ressourceTextBox.TabIndex = 24;
            this.ressourceTextBox.TextChanged += new System.EventHandler(this.OpdaterAfventerLbl);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Beskrivelse:";
            // 
            // langBeskrivTextBox
            // 
            this.langBeskrivTextBox.AcceptsReturn = true;
            this.langBeskrivTextBox.AcceptsTab = true;
            this.langBeskrivTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.langBeskrivTextBox.Location = new System.Drawing.Point(49, 354);
            this.langBeskrivTextBox.Multiline = true;
            this.langBeskrivTextBox.Name = "langBeskrivTextBox";
            this.langBeskrivTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.langBeskrivTextBox.Size = new System.Drawing.Size(665, 248);
            this.langBeskrivTextBox.TabIndex = 26;
            // 
            // gemBtn
            // 
            this.gemBtn.Location = new System.Drawing.Point(614, 51);
            this.gemBtn.Name = "gemBtn";
            this.gemBtn.Size = new System.Drawing.Size(65, 30);
            this.gemBtn.TabIndex = 27;
            this.gemBtn.Text = "Gem";
            this.gemBtn.UseVisualStyleBackColor = true;
            this.gemBtn.Click += new System.EventHandler(this.gemBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nytProjektToolStripMenuItem,
            this.nySagToolStripMenuItem,
            this.nyOBSToolStripMenuItem,
            this.åbnSagssystemToolStripMenuItem,
            this.gemSagssystemToolStripMenuItem,
            this.gemSomToolStripMenuItem,
            this.rydAltToolStripMenuItem,
            this.tilTekstfilToolStripMenuItem,
            this.fraTekstfilToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nytProjektToolStripMenuItem
            // 
            this.nytProjektToolStripMenuItem.Name = "nytProjektToolStripMenuItem";
            this.nytProjektToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.nytProjektToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.nytProjektToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.nytProjektToolStripMenuItem.Text = "Nyt Projekt";
            this.nytProjektToolStripMenuItem.Click += new System.EventHandler(this.nytProjektMenuItem_Click);
            // 
            // nySagToolStripMenuItem
            // 
            this.nySagToolStripMenuItem.Name = "nySagToolStripMenuItem";
            this.nySagToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.nySagToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.nySagToolStripMenuItem.Text = "Ny Sag";
            this.nySagToolStripMenuItem.Click += new System.EventHandler(this.nySagMenuItem_Click);
            // 
            // nyOBSToolStripMenuItem
            // 
            this.nyOBSToolStripMenuItem.Name = "nyOBSToolStripMenuItem";
            this.nyOBSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.nyOBSToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.nyOBSToolStripMenuItem.Text = "Ny OBS";
            this.nyOBSToolStripMenuItem.Click += new System.EventHandler(this.nyOBSMenuItem_Click);
            // 
            // åbnSagssystemToolStripMenuItem
            // 
            this.åbnSagssystemToolStripMenuItem.Name = "åbnSagssystemToolStripMenuItem";
            this.åbnSagssystemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.åbnSagssystemToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.åbnSagssystemToolStripMenuItem.Text = "Åbn";
            this.åbnSagssystemToolStripMenuItem.Click += new System.EventHandler(this.åbnSagssystemMenuItem_Click);
            // 
            // gemSagssystemToolStripMenuItem
            // 
            this.gemSagssystemToolStripMenuItem.Name = "gemSagssystemToolStripMenuItem";
            this.gemSagssystemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.gemSagssystemToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.gemSagssystemToolStripMenuItem.Text = "Gem";
            this.gemSagssystemToolStripMenuItem.Click += new System.EventHandler(this.GemMenuItem_Click);
            // 
            // gemSomToolStripMenuItem
            // 
            this.gemSomToolStripMenuItem.Name = "gemSomToolStripMenuItem";
            this.gemSomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.gemSomToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.gemSomToolStripMenuItem.Text = "Gem Som";
            this.gemSomToolStripMenuItem.Click += new System.EventHandler(this.gemSomMenuItem_Click);
            // 
            // rydAltToolStripMenuItem
            // 
            this.rydAltToolStripMenuItem.Name = "rydAltToolStripMenuItem";
            this.rydAltToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rydAltToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.rydAltToolStripMenuItem.Text = "Ryd Alt";
            this.rydAltToolStripMenuItem.Click += new System.EventHandler(this.rydAltToolStripMenuItem_Click);
            // 
            // tilTekstfilToolStripMenuItem
            // 
            this.tilTekstfilToolStripMenuItem.Name = "tilTekstfilToolStripMenuItem";
            this.tilTekstfilToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.tilTekstfilToolStripMenuItem.Text = "til tekstfil";
            this.tilTekstfilToolStripMenuItem.Click += new System.EventHandler(this.tilTekstfilToolStripMenuItem_Click);
            // 
            // fraTekstfilToolStripMenuItem
            // 
            this.fraTekstfilToolStripMenuItem.Name = "fraTekstfilToolStripMenuItem";
            this.fraTekstfilToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.fraTekstfilToolStripMenuItem.Text = "fra tekstfil";
            this.fraTekstfilToolStripMenuItem.Click += new System.EventHandler(this.fraTekstfilToolStripMenuItem_Click);
            // 
            // niveauComboBox
            // 
            this.niveauComboBox.AllowDrop = true;
            this.niveauComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.niveauComboBox.FormattingEnabled = true;
            this.niveauComboBox.Location = new System.Drawing.Point(58, 51);
            this.niveauComboBox.Name = "niveauComboBox";
            this.niveauComboBox.Size = new System.Drawing.Size(121, 24);
            this.niveauComboBox.TabIndex = 29;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(180, 218);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(155, 24);
            this.statusComboBox.TabIndex = 30;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.OpdaterAfventerLbl);
            // 
            // subTaskLbl
            // 
            this.subTaskLbl.AutoSize = true;
            this.subTaskLbl.Location = new System.Drawing.Point(55, 620);
            this.subTaskLbl.Name = "subTaskLbl";
            this.subTaskLbl.Size = new System.Drawing.Size(166, 17);
            this.subTaskLbl.TabIndex = 31;
            this.subTaskLbl.Text = "OBSer under denne sag:";
            // 
            // subTaskListView
            // 
            this.subTaskListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subTaskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.kortBeskriv,
            this.statusColumn});
            this.subTaskListView.FullRowSelect = true;
            this.subTaskListView.GridLines = true;
            this.subTaskListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.subTaskListView.Location = new System.Drawing.Point(49, 640);
            this.subTaskListView.MultiSelect = false;
            this.subTaskListView.Name = "subTaskListView";
            this.subTaskListView.Size = new System.Drawing.Size(665, 149);
            this.subTaskListView.TabIndex = 32;
            this.subTaskListView.UseCompatibleStateImageBehavior = false;
            this.subTaskListView.View = System.Windows.Forms.View.Details;
            this.subTaskListView.DoubleClick += new System.EventHandler(this.subTaskListView_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // kortBeskriv
            // 
            this.kortBeskriv.Text = "Beskrivelse";
            this.kortBeskriv.Width = 495;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            // 
            // registreretTextBox
            // 
            this.registreretTextBox.Location = new System.Drawing.Point(180, 150);
            this.registreretTextBox.Name = "registreretTextBox";
            this.registreretTextBox.Size = new System.Drawing.Size(155, 22);
            this.registreretTextBox.TabIndex = 33;
            // 
            // HomeBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(650, 700);
            this.ClientSize = new System.Drawing.Size(893, 829);
            this.Controls.Add(this.registreretTextBox);
            this.Controls.Add(this.subTaskListView);
            this.Controls.Add(this.subTaskLbl);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.niveauComboBox);
            this.Controls.Add(this.gemBtn);
            this.Controls.Add(this.langBeskrivTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ressourceTextBox);
            this.Controls.Add(this.kontaktTextBox);
            this.Controls.Add(this.AnsvarligTextBox);
            this.Controls.Add(this.regDatoLbl);
            this.Controls.Add(this.afventerLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kortBeskrivTextBox);
            this.Controls.Add(this.testerTextBox);
            this.Controls.Add(this.parentTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parrentLbl);
            this.Controls.Add(this.rapNrLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.søgBtn);
            this.Controls.Add(this.SøgTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeBase";
            this.ShowIcon = false;
            this.Text = "Sagssystem";
            this.Load += new System.EventHandler(this.HomeBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SøgTextBox;
        private System.Windows.Forms.Button søgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label rapNrLbl;
        private System.Windows.Forms.Label parrentLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox parentTextBox;
        private System.Windows.Forms.TextBox testerTextBox;
        private System.Windows.Forms.TextBox kortBeskrivTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label afventerLbl;
        private System.Windows.Forms.Label regDatoLbl;
        private System.Windows.Forms.TextBox AnsvarligTextBox;
        private System.Windows.Forms.TextBox kontaktTextBox;
        private System.Windows.Forms.TextBox ressourceTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox langBeskrivTextBox;
        private System.Windows.Forms.Button gemBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nytProjektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nySagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyOBSToolStripMenuItem;
        private System.Windows.Forms.ComboBox niveauComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ToolStripMenuItem åbnSagssystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemSagssystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rydAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilTekstfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fraTekstfilToolStripMenuItem;
        private System.Windows.Forms.Label subTaskLbl;
        private System.Windows.Forms.ListView subTaskListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader kortBeskriv;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.TextBox registreretTextBox;
    }
}

