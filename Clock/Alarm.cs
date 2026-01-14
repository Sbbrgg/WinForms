using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	internal class Alarm
	{
		public DateTime Date { get; set; }
		public DateTime Time { get; set; }
		public byte WeeakDays { get; set; }
		public string Filename { get; set; }
	}
}
