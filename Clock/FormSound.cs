using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class FormSound : Form
	{
		public FormSound()
		{
			InitializeComponent();
			LoadSound();
		}
		void LoadSound()
		{
			string currentDir = Application.ExecutablePath;
			Directory.SetCurrentDirectory($"{currentDir}\\..\\..\\..\\MUSIC");
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.mp3");
			for (int i = 0; i < files.Length; i++)
			{
				comboBoxSound.Items.Add(files[i].Split('\\').Last().Split('.').First());
			}
		}
	}
}
