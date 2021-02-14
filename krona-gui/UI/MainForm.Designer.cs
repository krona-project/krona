﻿namespace Krona.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up all resources in use.
        /// </summary>
        /// <param name="disposing"> If managed resources should be released，for true；otherwise false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Code generated by the form designer

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.walletWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createwalletdatabaseNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openwalletdatabaseOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildwalletdatabaseRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.signatureSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electionEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewhelpVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutKronaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createnewAddressNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportPrivateKeyIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWatchOnlyAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSmartContractSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MultisignatureMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.viewPrivateKeyVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToClipboardCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_height = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_count_node = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walletWToolStripMenuItem,
            this.transactionTToolStripMenuItem,
            this.advancedAToolStripMenuItem,
            this.helpHToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // walletWToolStripMenuItem
            // 
            this.walletWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createwalletdatabaseNToolStripMenuItem,
            this.openwalletdatabaseOToolStripMenuItem,
            this.toolStripSeparator1,
            this.changePasswordCToolStripMenuItem,
            this.rebuildwalletdatabaseRToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitXToolStripMenuItem});
            this.walletWToolStripMenuItem.Name = "walletWToolStripMenuItem";
            resources.ApplyResources(this.walletWToolStripMenuItem, "walletWToolStripMenuItem");
            // 
            // createwalletdatabaseNToolStripMenuItem
            // 
            this.createwalletdatabaseNToolStripMenuItem.Name = "createwalletdatabaseNToolStripMenuItem";
            resources.ApplyResources(this.createwalletdatabaseNToolStripMenuItem, "createwalletdatabaseNToolStripMenuItem");
            this.createwalletdatabaseNToolStripMenuItem.Click += new System.EventHandler(this.createwalletdatabaseNToolStripMenuItem_Click);
            // 
            // openwalletdatabaseOToolStripMenuItem
            // 
            this.openwalletdatabaseOToolStripMenuItem.Name = "openwalletdatabaseOToolStripMenuItem";
            resources.ApplyResources(this.openwalletdatabaseOToolStripMenuItem, "openwalletdatabaseOToolStripMenuItem");
            this.openwalletdatabaseOToolStripMenuItem.Click += new System.EventHandler(this.openwalletdatabaseOToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // changePasswordCToolStripMenuItem
            // 
            resources.ApplyResources(this.changePasswordCToolStripMenuItem, "changePasswordCToolStripMenuItem");
            this.changePasswordCToolStripMenuItem.Name = "changePasswordCToolStripMenuItem";
            this.changePasswordCToolStripMenuItem.Click += new System.EventHandler(this.changePasswordCToolStripMenuItem_Click);
            // 
            // rebuildwalletdatabaseRToolStripMenuItem
            // 
            this.rebuildwalletdatabaseRToolStripMenuItem.Name = "rebuildwalletdatabaseRToolStripMenuItem";
            resources.ApplyResources(this.rebuildwalletdatabaseRToolStripMenuItem, "rebuildwalletdatabaseRToolStripMenuItem");
            this.rebuildwalletdatabaseRToolStripMenuItem.Click += new System.EventHandler(this.rebuildwalletdatabaseRToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // quitXToolStripMenuItem
            // 
            this.quitXToolStripMenuItem.Name = "quitXToolStripMenuItem";
            resources.ApplyResources(this.quitXToolStripMenuItem, "quitXToolStripMenuItem");
            this.quitXToolStripMenuItem.Click += new System.EventHandler(this.quitXToolStripMenuItem_Click);
            // 
            // transactionTToolStripMenuItem
            // 
            this.transactionTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferTToolStripMenuItem,
            this.toolStripSeparator5,
            this.signatureSToolStripMenuItem});
            resources.ApplyResources(this.transactionTToolStripMenuItem, "transactionTToolStripMenuItem");
            this.transactionTToolStripMenuItem.Name = "transactionTToolStripMenuItem";
            // 
            // transferTToolStripMenuItem
            // 
            this.transferTToolStripMenuItem.Name = "transferTToolStripMenuItem";
            resources.ApplyResources(this.transferTToolStripMenuItem, "transferTToolStripMenuItem");
            this.transferTToolStripMenuItem.Click += new System.EventHandler(this.transferTToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // signatureSToolStripMenuItem
            // 
            this.signatureSToolStripMenuItem.Name = "signatureSToolStripMenuItem";
            resources.ApplyResources(this.signatureSToolStripMenuItem, "signatureSToolStripMenuItem");
            this.signatureSToolStripMenuItem.Click += new System.EventHandler(this.signatureSToolStripMenuItem_Click);
            // 
            // advancedAToolStripMenuItem
            // 
            this.advancedAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.electionEToolStripMenuItem,
            this.signDataToolStripMenuItem});
            this.advancedAToolStripMenuItem.Name = "advancedAToolStripMenuItem";
            resources.ApplyResources(this.advancedAToolStripMenuItem, "advancedAToolStripMenuItem");
            // 
            // electionEToolStripMenuItem
            // 
            resources.ApplyResources(this.electionEToolStripMenuItem, "electionEToolStripMenuItem");
            this.electionEToolStripMenuItem.Name = "electionEToolStripMenuItem";
            this.electionEToolStripMenuItem.Click += new System.EventHandler(this.electionEToolStripMenuItem_Click);
            // 
            // signDataToolStripMenuItem
            // 
            resources.ApplyResources(this.signDataToolStripMenuItem, "signDataToolStripMenuItem");
            this.signDataToolStripMenuItem.Name = "signDataToolStripMenuItem";
            this.signDataToolStripMenuItem.Click += new System.EventHandler(this.signDataToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewhelpVToolStripMenuItem,
            this.websiteWToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutKronaToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            resources.ApplyResources(this.helpHToolStripMenuItem, "helpHToolStripMenuItem");
            // 
            // viewhelpVToolStripMenuItem
            // 
            this.viewhelpVToolStripMenuItem.Name = "viewhelpVToolStripMenuItem";
            resources.ApplyResources(this.viewhelpVToolStripMenuItem, "viewhelpVToolStripMenuItem");
            // 
            // websiteWToolStripMenuItem
            // 
            this.websiteWToolStripMenuItem.Name = "websiteWToolStripMenuItem";
            resources.ApplyResources(this.websiteWToolStripMenuItem, "websiteWToolStripMenuItem");
            this.websiteWToolStripMenuItem.Click += new System.EventHandler(this.websiteWToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // aboutKronaToolStripMenuItem
            // 
            this.aboutKronaToolStripMenuItem.Name = "aboutKronaToolStripMenuItem";
            resources.ApplyResources(this.aboutKronaToolStripMenuItem, "aboutKronaToolStripMenuItem");
            this.aboutKronaToolStripMenuItem.Click += new System.EventHandler(this.aboutKronaToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listView1.Groups"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listView1.Groups1"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listView1.Groups2")))});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createnewAddressNToolStripMenuItem,
            this.ImportPrivateKeyIToolStripMenuItem,
            this.createSmartContractSToolStripMenuItem,
            this.toolStripSeparator6,
            this.viewPrivateKeyVToolStripMenuItem,
            this.viewContractToolStripMenuItem,
            this.voteToolStripMenuItem,
            this.CopyToClipboardCToolStripMenuItem,
            this.DeleteDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // createnewAddressNToolStripMenuItem
            // 
            resources.ApplyResources(this.createnewAddressNToolStripMenuItem, "createnewAddressNToolStripMenuItem");
            this.createnewAddressNToolStripMenuItem.Name = "createnewAddressNToolStripMenuItem";
            this.createnewAddressNToolStripMenuItem.Click += new System.EventHandler(this.createnewAddressNToolStripMenuItem_Click);
            // 
            // ImportPrivateKeyIToolStripMenuItem
            // 
            this.ImportPrivateKeyIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importWIFToolStripMenuItem,
            this.importWatchOnlyAddressToolStripMenuItem});
            resources.ApplyResources(this.ImportPrivateKeyIToolStripMenuItem, "ImportPrivateKeyIToolStripMenuItem");
            this.ImportPrivateKeyIToolStripMenuItem.Name = "ImportPrivateKeyIToolStripMenuItem";
            // 
            // importWIFToolStripMenuItem
            // 
            this.importWIFToolStripMenuItem.Name = "importWIFToolStripMenuItem";
            resources.ApplyResources(this.importWIFToolStripMenuItem, "importWIFToolStripMenuItem");
            this.importWIFToolStripMenuItem.Click += new System.EventHandler(this.importWIFToolStripMenuItem_Click);
            // 
            // importWatchOnlyAddressToolStripMenuItem
            // 
            this.importWatchOnlyAddressToolStripMenuItem.Name = "importWatchOnlyAddressToolStripMenuItem";
            resources.ApplyResources(this.importWatchOnlyAddressToolStripMenuItem, "importWatchOnlyAddressToolStripMenuItem");
            this.importWatchOnlyAddressToolStripMenuItem.Click += new System.EventHandler(this.importWatchOnlyAddressToolStripMenuItem_Click);
            // 
            // createSmartContractSToolStripMenuItem
            // 
            this.createSmartContractSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MultisignatureMToolStripMenuItem,
            this.lockToolStripMenuItem});
            resources.ApplyResources(this.createSmartContractSToolStripMenuItem, "createSmartContractSToolStripMenuItem");
            this.createSmartContractSToolStripMenuItem.Name = "createSmartContractSToolStripMenuItem";
            // 
            // MultisignatureMToolStripMenuItem
            // 
            this.MultisignatureMToolStripMenuItem.Name = "MultisignatureMToolStripMenuItem";
            resources.ApplyResources(this.MultisignatureMToolStripMenuItem, "MultisignatureMToolStripMenuItem");
            this.MultisignatureMToolStripMenuItem.Click += new System.EventHandler(this.MultisignatureMToolStripMenuItem_Click);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            resources.ApplyResources(this.lockToolStripMenuItem, "lockToolStripMenuItem");
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // viewPrivateKeyVToolStripMenuItem
            // 
            resources.ApplyResources(this.viewPrivateKeyVToolStripMenuItem, "viewPrivateKeyVToolStripMenuItem");
            this.viewPrivateKeyVToolStripMenuItem.Name = "viewPrivateKeyVToolStripMenuItem";
            this.viewPrivateKeyVToolStripMenuItem.Click += new System.EventHandler(this.viewPrivateKeyVToolStripMenuItem_Click);
            // 
            // viewContractToolStripMenuItem
            // 
            resources.ApplyResources(this.viewContractToolStripMenuItem, "viewContractToolStripMenuItem");
            this.viewContractToolStripMenuItem.Name = "viewContractToolStripMenuItem";
            this.viewContractToolStripMenuItem.Click += new System.EventHandler(this.viewContractToolStripMenuItem_Click);
            // 
            // voteToolStripMenuItem
            // 
            resources.ApplyResources(this.voteToolStripMenuItem, "voteToolStripMenuItem");
            this.voteToolStripMenuItem.Name = "voteToolStripMenuItem";
            this.voteToolStripMenuItem.Click += new System.EventHandler(this.voteToolStripMenuItem_Click);
            // 
            // CopyToClipboardCToolStripMenuItem
            // 
            resources.ApplyResources(this.CopyToClipboardCToolStripMenuItem, "CopyToClipboardCToolStripMenuItem");
            this.CopyToClipboardCToolStripMenuItem.Name = "CopyToClipboardCToolStripMenuItem";
            this.CopyToClipboardCToolStripMenuItem.Click += new System.EventHandler(this.CopyToClipboardCToolStripMenuItem_Click);
            // 
            // DeleteDToolStripMenuItem
            // 
            resources.ApplyResources(this.DeleteDToolStripMenuItem, "DeleteDToolStripMenuItem");
            this.DeleteDToolStripMenuItem.Name = "DeleteDToolStripMenuItem";
            this.DeleteDToolStripMenuItem.Click += new System.EventHandler(this.DeleteDToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_height,
            this.toolStripStatusLabel4,
            this.lbl_count_node,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // lbl_height
            // 
            this.lbl_height.Name = "lbl_height";
            resources.ApplyResources(this.lbl_height, "lbl_height");
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            // 
            // lbl_count_node
            // 
            this.lbl_count_node.Name = "lbl_count_node";
            resources.ApplyResources(this.lbl_count_node, "lbl_count_node");
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Maximum = 15;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView3);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader10,
            this.columnHeader9});
            this.listView3.ContextMenuStrip = this.contextMenuStrip3;
            resources.ApplyResources(this.listView3, "listView3");
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView3.HideSelection = false;
            this.listView3.Name = "listView3";
            this.listView3.ShowGroups = false;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.DoubleClick += new System.EventHandler(this.listView3_DoubleClick);
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            resources.ApplyResources(this.contextMenuStrip3, "contextMenuStrip3");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem walletWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createwalletdatabaseNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openwalletdatabaseOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordCToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewhelpVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteWToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem aboutKronaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signatureSToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createnewAddressNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportPrivateKeyIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem viewPrivateKeyVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToClipboardCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_height;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbl_count_node;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem transferTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSmartContractSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MultisignatureMToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem importWIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electionEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildwalletdatabaseRToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem viewContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWatchOnlyAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signDataToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

