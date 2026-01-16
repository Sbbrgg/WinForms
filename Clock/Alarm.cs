using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm
	{
		public DateTime Date { get; set; }
		public DateTime Time { get; set; }
		public Week Days { get; set; }
		public string Filename { get; set; }
		public Alarm() { }
		public Alarm(string line)
		{
			ParseFromString(line);
		}
		public override string ToString()
		{
			//return $"{Date}, {Time}, {Days.ToString()}, {Filename}";
			string info = "";
			info += Date != DateTime.MaxValue ? Date.ToString("yyyy.MM.dd") : "Каждый день";
			info += $"\t{Time.ToString("HH:mm:ss")}";
			info += $"\t{Days}";
			info += $"\t{Filename.Split('\\').Last()}";
			return info;
		}
		public void ParseFromString(string data)
		{
			string[] parts = data.Split('\t');
			Date = parts[0] == "Каждый день" ? DateTime.MaxValue : DateTime.ParseExact(parts[0], "yyyy.MM.dd", null);
			Time = DateTime.ParseExact(parts[1], "HH:mm:ss", null);
			//Days = new Week(Convert.ToByte(parts[2]));
			Days = Week.Parse(parts[2]);
			Filename = parts[3];
		}
	}
}
