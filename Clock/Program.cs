using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Directory.CreateDirectory($"{Application.UserAppDataPath}\\..\\..\\..\\..\\LocalLow\\PV_521\\Clock\\Settings");
			Application.Run(new MainForm());
		}
	}
}
