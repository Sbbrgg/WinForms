using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - this.Width, Screen.PrimaryScreen.WorkingArea.Top);

			//InitializeContextMenu();
		}

		//private void InitializeContextMenu()
		//{
		//	CMSMainForm = new ContextMenuStrip
		//	{
		//		Items =
		//		{
		//			new ToolStripMenuItem("Открыть", null, (s, e) => SetVisibility(true)),
		//			new ToolStripMenuItem("Скрыть", null, (s, e) => SetVisibility(false)),
		//			new ToolStripMenuItem("Поверх всех окон", null,
		//				(s, e) => {
		//					this.TopMost = this.TopMost;
		//					((ToolStripMenuItem)s).Checked = this.TopMost;
		//				}) { CheckOnClick = true },
		//			new ToolStripSeparator(),
		//			new ToolStripMenuItem("Выход", null, (s, e) => Application.Exit())
		//		}
		//	};
		//	notifyIcon.ContextMenuStrip = CMSMainForm;
		//}

		void SetVisibility(bool visible)
		{
			CBShowDate.Visible = visible;
			CBShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString
				(
				//"H:mm:ss"
				//"HH:mm:ss"
				"T"
				//System.Globalization.CultureInfo.InvariantCulture	//чтобы писалось AM PM
				);
			if (CBShowDate.Checked)
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy:MM:dd")}";
			if (CBShowWeekDay.Checked)
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text = labelTime.Text;
		}

		private void btnHideControls_Click(object sender, EventArgs e) => SetVisibility(false);
		private void labelTime_MouseHover(object sender, EventArgs e) => SetVisibility(true);
		private void notifyIcon_MouseDoubleClick(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.TopMost = false;
		}

		//создаётся каждый раз при нажатии 
		//private void CMSNotifyIcon_Opening(object sender, CancelEventArgs e)
		//{

		//	CMSMainForm = new ContextMenuStrip();
		//	ToolStripMenuItem openItem = new ToolStripMenuItem("Открыть");
		//	//openItem.Click += (s, args) => SetVisibility(true);
		//	openItem.Click += new EventHandler(openItem_Click);
		//	ToolStripMenuItem hideItem = new ToolStripMenuItem("Скрыть");
		//	hideItem.Click += (s, args) => SetVisibility(false);

		//	ToolStripMenuItem alwaysOnTop = new ToolStripMenuItem("Показать");
		//	alwaysOnTop.Click += (s, args) => this.TopMost = this.TopMost;

		//	ToolStripMenuItem exitItem = new ToolStripMenuItem("Выход");
		//	exitItem.Click += (s, args) => Application.Exit();

		//	CMSMainForm.Items.AddRange
		//		(
		//			new ToolStripItem[] { openItem, hideItem, alwaysOnTop, exitItem }
		//		);
		//	CMSMainForm.Show(Cursor.Position);
		//}
		//private void openItem_Click(object sender, EventArgs e)
		//{
		//	SetVisibility(true);
		//}
		void cms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Control c = CMSMainForm.SourceControl as Control;
			ToolStripDropDownItem tsi = CMSMainForm.OwnerItem as ToolStripDropDownItem;

			CMSMainForm.Items.Clear();

			if (c != null)
			{
				CMSMainForm.Items.Add("Source: " + tsi.GetType().ToString());
			}

			CMSMainForm.Items.Add("Открыть");
			CMSMainForm.Items.Add("Закрыть");

			e.Cancel = false;
		}
	}
}