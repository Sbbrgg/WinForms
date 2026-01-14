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
	public partial class AlarmDialog : Form
	{
		OpenFileDialog fileDialog;
		public AlarmDialog()
		{
			InitializeComponent();
			dtpDate.Enabled = checkBoxUseDate.Checked;
			fileDialog = new OpenFileDialog();
			fileDialog.Filter =
				"All sound files (*.mp3; *.flac; *.flacc; *.wav;*.wave; *.ogg; *.aiff; *.aac; *.alac; *.mqa; *.ape)|*.mp3;*.flac;*.flacc;*.wav;*.wave;*.ogg;*.aiff;*.aac;*.alac;*.mqa;*.ape" +
				"|Mp3 files (*.mp3)|*.mp3" +
				"|Flac files (*.flac)|*.flac;*.flacc" +
				"|Wav files (*.wav;*.wave)|*.wav;*.wave" +
				"|Ogg files (*.ogg)|*.ogg" +
				"|Aiff files (*.aiff)|*.aiff" +
				"|Aac files (*.aac)|*.aac" +
				"|Alac files (*.alac)|*.alac" +
				"|Mqa files (*.mqa)|*.mqa" +
				"|Ape files (*.ape)|*.ape";
			this.StartPosition = FormStartPosition.Manual;
		}

		private void checkBoxUseDate_CheckedChanged(object sender, EventArgs e)
		{
			dtpDate.Enabled = (sender as CheckBox).Checked;
			clbWeekDays.Enabled = !dtpDate.Enabled;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				labelFilename.Text = fileDialog.FileName;
			}
		}

		private void clbWeekDays_SelectedIndexChanged(object sender, EventArgs e)
		{
			Console.WriteLine("clbWeekDays_SelectedIndexChanged");
			for (int i = 0; i < clbWeekDays.CheckedItems.Count; i++)
				Console.Write($"{clbWeekDays.CheckedItems[i]}\t");
			Console.WriteLine();
			byte days = 0;
			for (int i = 0; i < clbWeekDays.CheckedIndices.Count; i++)
			{
				days |= (byte)(1<<clbWeekDays.CheckedIndices[i]);
				Console.Write($"{clbWeekDays.CheckedIndices[i]}\t");
			}
			Console.WriteLine($"days mask {days}");
			Console.WriteLine("\n-------------------------------------------\n");
		}
		byte GetDaysMask()
		{
			byte days = 0;
			for (int i = 0; i < clbWeekDays.CheckedIndices.Count; i++)
				days |= (byte)(1 << clbWeekDays.CheckedIndices[i]);
			return days;
		}
	}
}
