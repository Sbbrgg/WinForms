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
		public AlarmsForm()
		{
			InitializeComponent();
			//alarm = new AlarmDialog();
			this.StartPosition = FormStartPosition.Manual;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			//alarm.StartPosition = FormStartPosition.CenterParent;
			AlarmDialog alarm = new AlarmDialog();
			alarm.Location = new Point(this.Location.X + (this.Width - alarm.Width) / 2, this.Location.Y + (this.Height - alarm.Height) / 2);
			if (alarm.ShowDialog() == DialogResult.OK)
			{
				listBoxAlarms.Items.Add(alarm.Alarm);
			}
		}

		private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
		{
			Alarm selectedAlarm = (Alarm)listBoxAlarms.SelectedItem;
			int selectedIndex = listBoxAlarms.SelectedIndex;

			Alarm editingAlarm = new Alarm();
			editingAlarm.Date = selectedAlarm.Date;
			editingAlarm.Time = selectedAlarm.Time;
			editingAlarm.Days = selectedAlarm.Days != null? new Week(selectedAlarm.Days.DaysMask) : new Week(0);
			editingAlarm.Filename = selectedAlarm.Filename;


			AlarmDialog editAlarm = new AlarmDialog();
			editAlarm.Location = new Point(this.Location.X + (this.Width - editAlarm.Width) / 2, this.Location.Y + (this.Height - editAlarm.Height) / 2);

			editAlarm.LoadAlarmSettings(editingAlarm);
			if(editAlarm.ShowDialog() == DialogResult.OK)
			{
				listBoxAlarms.Items[selectedIndex] = editAlarm.Alarm;
				listBoxAlarms.Refresh();
			}

			//Alarm selectedAlarm = listBoxAlarms.SelectedItem as Alarm;
		}
	}
}
