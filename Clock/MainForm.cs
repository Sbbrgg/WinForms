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
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			CBShowDate.Visible = false;
			CBShowWeekDay.Visible = false;
			btnHideControls.Visible = false;
			this.ShowInTaskbar = false;
		}
	}
}
