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
	public partial class AlarmsForm : Form
	{
		//AlarmDialog alarm;
		public ListBox List { get => listBoxAlarms; }
		public AlarmsForm()
		{
			InitializeComponent();
			//alarm = new AlarmDialog();
			this.StartPosition = FormStartPosition.Manual;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AlarmDialog alarm = new AlarmDialog();
			alarm.StartPosition = FormStartPosition.CenterParent;
			alarm.Location = new Point(this.Location.X + (this.Width - alarm.Width) / 2, this.Location.Y + (this.Height - alarm.Height) / 2);
			if(alarm.ShowDialog() == DialogResult.OK)
			{
				listBoxAlarms.Items.Add(new Alarm(alarm.Alarm));
			}
		}
		private void listBoxAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listBoxAlarms.Items.Count > 0 && listBoxAlarms.SelectedItem != null)
			{
				AlarmDialog alarm = new AlarmDialog(listBoxAlarms.SelectedItem as Alarm);
				alarm.StartPosition = FormStartPosition.CenterParent;
				//alarm.Location = new Point(this.Location.X + (this.Width - alarm.Width) / 2, this.Location.Y + (this.Height - alarm.Height) / 2);
				alarm.ShowDialog();
				//listBoxAlarms.Refresh();
				listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = new Alarm(alarm.Alarm);
			}
			else
			{
				buttonAdd_Click(sender, e);
			}
		}
	}
}
