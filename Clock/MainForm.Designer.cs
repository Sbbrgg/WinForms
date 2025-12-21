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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.CBShowDate = new System.Windows.Forms.CheckBox();
			this.CBShowWeekDay = new System.Windows.Forms.CheckBox();
			this.btnHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.CMSMainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CMSNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.labelTime.Font = new System.Drawing.Font("Engravers MT", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTime.Location = new System.Drawing.Point(91, 21);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(458, 50);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "CurrentTime\r\n";
			this.labelTime.MouseHover += new System.EventHandler(this.labelTime_MouseHover);
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
			this.CBShowDate.Location = new System.Drawing.Point(100, 190);
			this.CBShowDate.Name = "CBShowDate";
			this.CBShowDate.Size = new System.Drawing.Size(176, 29);
			this.CBShowDate.TabIndex = 1;
			this.CBShowDate.Text = "Показать дату";
			this.CBShowDate.UseVisualStyleBackColor = true;
			// 
			// CBShowWeekDay
			// 
			this.CBShowWeekDay.AutoSize = true;
			this.CBShowWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CBShowWeekDay.Location = new System.Drawing.Point(100, 225);
			this.CBShowWeekDay.Name = "CBShowWeekDay";
			this.CBShowWeekDay.Size = new System.Drawing.Size(256, 29);
			this.CBShowWeekDay.TabIndex = 2;
			this.CBShowWeekDay.Text = "Показать день недели";
			this.CBShowWeekDay.UseVisualStyleBackColor = true;
			// 
			// btnHideControls
			// 
			this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHideControls.Location = new System.Drawing.Point(100, 260);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(339, 111);
			this.btnHideControls.TabIndex = 3;
			this.btnHideControls.Text = "Hide controls";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.CMSNotifyIcon;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "System tray";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// CMSMainForm
			// 
			this.CMSMainForm.Name = "CMSMainForm";
			this.CMSMainForm.Size = new System.Drawing.Size(61, 4);
			// 
			// CMSNotifyIcon
			// 
			this.CMSNotifyIcon.Name = "CMSNotifyIcon";
			this.CMSNotifyIcon.Size = new System.Drawing.Size(61, 4);
			this.CMSNotifyIcon.Opening += new System.ComponentModel.CancelEventHandler(this.CMSNotifyIcon_Opening);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 383);
			this.ContextMenuStrip = this.CMSMainForm;
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.CBShowWeekDay);
			this.Controls.Add(this.CBShowDate);
			this.Controls.Add(this.labelTime);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clock PV_521";
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
		private System.Windows.Forms.ContextMenuStrip CMSNotifyIcon;
		private System.Windows.Forms.ContextMenuStrip CMSMainForm;
	}
}

