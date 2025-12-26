namespace Clock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAutoStart = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.CBShowDate = new System.Windows.Forms.CheckBox();
			this.CBShowWeekDay = new System.Windows.Forms.CheckBox();
			this.btnHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Engravers MT", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTime.Location = new System.Drawing.Point(36, 31);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(458, 50);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "CurrentTime\r\n";
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsmiShowControls,
            this.toolStripSeparator1,
            this.tsmiShowDate,
            this.tsmiShowWeekday,
            this.toolStripSeparator2,
            this.tsmiShowConsole,
            this.toolStripSeparator3,
            this.tsmiFont,
            this.tsmiColor,
            this.toolStripSeparator4,
            this.tsmiAlarms,
            this.toolStripSeparator5,
            this.tsmiAutoStart,
            this.toolStripSeparator6,
            this.tsmiQuit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(181, 282);
			// 
			// tsmiTopmost
			// 
			this.tsmiTopmost.CheckOnClick = true;
			this.tsmiTopmost.Name = "tsmiTopmost";
			this.tsmiTopmost.Size = new System.Drawing.Size(180, 22);
			this.tsmiTopmost.Text = "Topmost";
			this.tsmiTopmost.Click += new System.EventHandler(this.tsmiTopmost_Click);
			// 
			// tsmiShowControls
			// 
			this.tsmiShowControls.CheckOnClick = true;
			this.tsmiShowControls.Name = "tsmiShowControls";
			this.tsmiShowControls.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowControls.Text = "Show controls";
			this.tsmiShowControls.CheckedChanged += new System.EventHandler(this.tsmiShowControls_CheckedChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiShowDate
			// 
			this.tsmiShowDate.CheckOnClick = true;
			this.tsmiShowDate.Name = "tsmiShowDate";
			this.tsmiShowDate.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowDate.Text = "Show date";
			this.tsmiShowDate.CheckedChanged += new System.EventHandler(this.tsmiShowDate_CheckedChanged);
			// 
			// tsmiShowWeekday
			// 
			this.tsmiShowWeekday.CheckOnClick = true;
			this.tsmiShowWeekday.Name = "tsmiShowWeekday";
			this.tsmiShowWeekday.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowWeekday.Text = "Show weekday";
			this.tsmiShowWeekday.CheckedChanged += new System.EventHandler(this.tsmiShowWeekday_CheckedChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiShowConsole
			// 
			this.tsmiShowConsole.CheckOnClick = true;
			this.tsmiShowConsole.Name = "tsmiShowConsole";
			this.tsmiShowConsole.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowConsole.Text = "Show console";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiFont
			// 
			this.tsmiFont.Name = "tsmiFont";
			this.tsmiFont.Size = new System.Drawing.Size(180, 22);
			this.tsmiFont.Text = "Font";
			this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
			// 
			// tsmiColor
			// 
			this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundColor,
            this.tsmiBackgroundColor});
			this.tsmiColor.Name = "tsmiColor";
			this.tsmiColor.Size = new System.Drawing.Size(180, 22);
			this.tsmiColor.Text = "Color";
			// 
			// tsmiForegroundColor
			// 
			this.tsmiForegroundColor.Name = "tsmiForegroundColor";
			this.tsmiForegroundColor.Size = new System.Drawing.Size(168, 22);
			this.tsmiForegroundColor.Text = "Foreground color";
			this.tsmiForegroundColor.Click += new System.EventHandler(this.tsmiForegroundColor_Click);
			// 
			// tsmiBackgroundColor
			// 
			this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
			this.tsmiBackgroundColor.Size = new System.Drawing.Size(168, 22);
			this.tsmiBackgroundColor.Text = "Background color";
			this.tsmiBackgroundColor.Click += new System.EventHandler(this.tsmiBackgroundColor_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiAlarms
			// 
			this.tsmiAlarms.Name = "tsmiAlarms";
			this.tsmiAlarms.Size = new System.Drawing.Size(180, 22);
			this.tsmiAlarms.Text = "Alarms";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiAutoStart
			// 
			this.tsmiAutoStart.CheckOnClick = true;
			this.tsmiAutoStart.Name = "tsmiAutoStart";
			this.tsmiAutoStart.Size = new System.Drawing.Size(180, 22);
			this.tsmiAutoStart.Text = "Auto start";
			this.tsmiAutoStart.CheckedChanged += new System.EventHandler(this.tsmiAutoStart_CheckedChanged);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiQuit
			// 
			this.tsmiQuit.Name = "tsmiQuit";
			this.tsmiQuit.Size = new System.Drawing.Size(180, 22);
			this.tsmiQuit.Text = "Quit";
			this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// CBShowDate
			// 
			this.CBShowDate.AutoSize = true;
			this.CBShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CBShowDate.Location = new System.Drawing.Point(22, 190);
			this.CBShowDate.Name = "CBShowDate";
			this.CBShowDate.Size = new System.Drawing.Size(176, 29);
			this.CBShowDate.TabIndex = 1;
			this.CBShowDate.Text = "Показать дату";
			this.CBShowDate.UseVisualStyleBackColor = true;
			this.CBShowDate.CheckedChanged += new System.EventHandler(this.CBShowDate_CheckedChanged);
			// 
			// CBShowWeekDay
			// 
			this.CBShowWeekDay.AutoSize = true;
			this.CBShowWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CBShowWeekDay.Location = new System.Drawing.Point(22, 225);
			this.CBShowWeekDay.Name = "CBShowWeekDay";
			this.CBShowWeekDay.Size = new System.Drawing.Size(256, 29);
			this.CBShowWeekDay.TabIndex = 2;
			this.CBShowWeekDay.Text = "Показать день недели";
			this.CBShowWeekDay.UseVisualStyleBackColor = true;
			this.CBShowWeekDay.CheckedChanged += new System.EventHandler(this.CBShowWeekDay_CheckedChanged);
			// 
			// btnHideControls
			// 
			this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHideControls.Location = new System.Drawing.Point(12, 260);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(339, 111);
			this.btnHideControls.TabIndex = 3;
			this.btnHideControls.Text = "Hide controls";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "System tray";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 383);
			this.ContextMenuStrip = this.contextMenuStrip;
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.CBShowWeekDay);
			this.Controls.Add(this.CBShowDate);
			this.Controls.Add(this.labelTime);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Clock PV_521";
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox CBShowDate;
		private System.Windows.Forms.CheckBox CBShowWeekDay;
		private System.Windows.Forms.Button btnHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowConsole;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem tsmiFont;
		private System.Windows.Forms.ToolStripMenuItem tsmiColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem tsmiAlarms;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem tsmiAutoStart;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
	}
}

