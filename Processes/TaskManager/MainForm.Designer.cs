﻿
namespace TaskManager
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
			this.components = new System.ComponentModel.Container();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuFileRun = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewHide = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenuViewColumns = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenuViewRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRateHigh = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRateNormal = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRateLow = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripName = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelProcessCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabControlProcesses = new System.Windows.Forms.TabPage();
			this.listViewProcesses = new System.Windows.Forms.ListView();
			this.columnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuProcList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemOpenFileLocation = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tollStripMenuItemDestroy = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPagePerformance = new System.Windows.Forms.TabPage();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.MainMenu.SuspendLayout();
			this.statusStripName.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabControlProcesses.SuspendLayout();
			this.contextMenuProcList.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(800, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFileRun,
            this.toolStripSeparator1,
            this.mainMenuFileExit});
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.runToolStripMenuItem.Text = "File";
			// 
			// mainMenuFileRun
			// 
			this.mainMenuFileRun.Name = "mainMenuFileRun";
			this.mainMenuFileRun.Size = new System.Drawing.Size(95, 22);
			this.mainMenuFileRun.Text = "Run";
			this.mainMenuFileRun.Click += new System.EventHandler(this.mainMenuFileRun_Click_1);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(92, 6);
			// 
			// mainMenuFileExit
			// 
			this.mainMenuFileExit.Name = "mainMenuFileExit";
			this.mainMenuFileExit.Size = new System.Drawing.Size(95, 22);
			this.mainMenuFileExit.Text = "Exit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuViewTopmost,
            this.mainMenuViewHide,
            this.toolStripSeparator2,
            this.mainMenuViewColumns,
            this.toolStripSeparator3,
            this.mainMenuViewRefresh,
            this.mainMenuViewRefreshRate});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// mainMenuViewTopmost
			// 
			this.mainMenuViewTopmost.CheckOnClick = true;
			this.mainMenuViewTopmost.Name = "mainMenuViewTopmost";
			this.mainMenuViewTopmost.Size = new System.Drawing.Size(190, 22);
			this.mainMenuViewTopmost.Text = "Topmost";
			// 
			// mainMenuViewHide
			// 
			this.mainMenuViewHide.CheckOnClick = true;
			this.mainMenuViewHide.Name = "mainMenuViewHide";
			this.mainMenuViewHide.Size = new System.Drawing.Size(190, 22);
			this.mainMenuViewHide.Text = "Hide when minimized";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
			// 
			// mainMenuViewColumns
			// 
			this.mainMenuViewColumns.Name = "mainMenuViewColumns";
			this.mainMenuViewColumns.Size = new System.Drawing.Size(190, 22);
			this.mainMenuViewColumns.Text = "Select columns";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
			// 
			// mainMenuViewRefresh
			// 
			this.mainMenuViewRefresh.Name = "mainMenuViewRefresh";
			this.mainMenuViewRefresh.Size = new System.Drawing.Size(190, 22);
			this.mainMenuViewRefresh.Text = "Refresh";
			// 
			// mainMenuViewRefreshRate
			// 
			this.mainMenuViewRefreshRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuViewRateHigh,
            this.mainMenuViewRateNormal,
            this.mainMenuViewRateLow});
			this.mainMenuViewRefreshRate.Name = "mainMenuViewRefreshRate";
			this.mainMenuViewRefreshRate.Size = new System.Drawing.Size(190, 22);
			this.mainMenuViewRefreshRate.Text = "Refresh rate";
			// 
			// mainMenuViewRateHigh
			// 
			this.mainMenuViewRateHigh.Name = "mainMenuViewRateHigh";
			this.mainMenuViewRateHigh.Size = new System.Drawing.Size(114, 22);
			this.mainMenuViewRateHigh.Text = "High";
			// 
			// mainMenuViewRateNormal
			// 
			this.mainMenuViewRateNormal.Name = "mainMenuViewRateNormal";
			this.mainMenuViewRateNormal.Size = new System.Drawing.Size(114, 22);
			this.mainMenuViewRateNormal.Text = "Normal";
			// 
			// mainMenuViewRateLow
			// 
			this.mainMenuViewRateLow.Name = "mainMenuViewRateLow";
			this.mainMenuViewRateLow.Size = new System.Drawing.Size(114, 22);
			this.mainMenuViewRateLow.Text = "Low";
			// 
			// statusStripName
			// 
			this.statusStripName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelProcessCount});
			this.statusStripName.Location = new System.Drawing.Point(0, 428);
			this.statusStripName.Name = "statusStripName";
			this.statusStripName.Size = new System.Drawing.Size(800, 22);
			this.statusStripName.TabIndex = 1;
			this.statusStripName.Text = "statusStrip1";
			// 
			// toolStripStatusLabelProcessCount
			// 
			this.toolStripStatusLabelProcessCount.Name = "toolStripStatusLabelProcessCount";
			this.toolStripStatusLabelProcessCount.Size = new System.Drawing.Size(185, 17);
			this.toolStripStatusLabelProcessCount.Text = "toolStripStatusLabelProcessCount";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabControlProcesses);
			this.tabControl.Controls.Add(this.tabPagePerformance);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 404);
			this.tabControl.TabIndex = 2;
			// 
			// tabControlProcesses
			// 
			this.tabControlProcesses.Controls.Add(this.listViewProcesses);
			this.tabControlProcesses.Location = new System.Drawing.Point(4, 22);
			this.tabControlProcesses.Name = "tabControlProcesses";
			this.tabControlProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabControlProcesses.Size = new System.Drawing.Size(792, 378);
			this.tabControlProcesses.TabIndex = 0;
			this.tabControlProcesses.Text = "Processes";
			this.tabControlProcesses.UseVisualStyleBackColor = true;
			// 
			// listViewProcesses
			// 
			this.listViewProcesses.AllowColumnReorder = true;
			this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProcessName,
            this.columnPID});
			this.listViewProcesses.ContextMenuStrip = this.contextMenuProcList;
			this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewProcesses.FullRowSelect = true;
			this.listViewProcesses.HideSelection = false;
			this.listViewProcesses.Location = new System.Drawing.Point(3, 3);
			this.listViewProcesses.MultiSelect = false;
			this.listViewProcesses.Name = "listViewProcesses";
			this.listViewProcesses.Size = new System.Drawing.Size(786, 372);
			this.listViewProcesses.TabIndex = 0;
			this.listViewProcesses.UseCompatibleStateImageBehavior = false;
			this.listViewProcesses.View = System.Windows.Forms.View.Details;
			this.listViewProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProcesses_ColumnClick);
			// 
			// columnPID
			// 
			this.columnPID.Text = "PID";
			// 
			// columnProcessName
			// 
			this.columnProcessName.Text = "Name";
			// 
			// contextMenuProcList
			// 
			this.contextMenuProcList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenFileLocation,
            this.toolStripSeparator4,
            this.tollStripMenuItemDestroy});
			this.contextMenuProcList.Name = "contextMenuProcList";
			this.contextMenuProcList.Size = new System.Drawing.Size(174, 54);
			this.contextMenuProcList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuProcList_Opening);
			// 
			// toolStripMenuItemOpenFileLocation
			// 
			this.toolStripMenuItemOpenFileLocation.Name = "toolStripMenuItemOpenFileLocation";
			this.toolStripMenuItemOpenFileLocation.Size = new System.Drawing.Size(173, 22);
			this.toolStripMenuItemOpenFileLocation.Text = "Open File Location";
			this.toolStripMenuItemOpenFileLocation.Click += new System.EventHandler(this.toolStripMenuItemOpenFileLocation_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
			// 
			// tollStripMenuItemDestroy
			// 
			this.tollStripMenuItemDestroy.Name = "tollStripMenuItemDestroy";
			this.tollStripMenuItemDestroy.Size = new System.Drawing.Size(173, 22);
			this.tollStripMenuItemDestroy.Text = "Destroy ";
			this.tollStripMenuItemDestroy.Click += new System.EventHandler(this.destroyToolStripMenuItem_Click);
			// 
			// tabPagePerformance
			// 
			this.tabPagePerformance.Location = new System.Drawing.Point(4, 22);
			this.tabPagePerformance.Name = "tabPagePerformance";
			this.tabPagePerformance.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePerformance.Size = new System.Drawing.Size(792, 378);
			this.tabPagePerformance.TabIndex = 1;
			this.tabPagePerformance.Text = "Preformance";
			this.tabPagePerformance.UseVisualStyleBackColor = true;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStripName);
			this.Controls.Add(this.MainMenu);
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.Text = "TaskManagerPD_311";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.statusStripName.ResumeLayout(false);
			this.statusStripName.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabControlProcesses.ResumeLayout(false);
			this.contextMenuProcList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mainMenuFileRun;
		private System.Windows.Forms.ToolStripMenuItem mainMenuFileExit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewTopmost;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewHide;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewColumns;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRefresh;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRefreshRate;
		private System.Windows.Forms.StatusStrip statusStripName;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRateHigh;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRateNormal;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRateLow;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProcessCount;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabControlProcesses;
		private System.Windows.Forms.TabPage tabPagePerformance;
		private System.Windows.Forms.ListView listViewProcesses;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ColumnHeader columnProcessName;
		private System.Windows.Forms.ColumnHeader columnPID;
		private System.Windows.Forms.ContextMenuStrip contextMenuProcList;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFileLocation;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem tollStripMenuItemDestroy;
	}
}

