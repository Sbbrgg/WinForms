using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Week
	{
		static readonly string[] NAMES = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
		byte days;
		public byte DaysMask
		{
			get { return days; }
			set { days = value; }
		}
		public Week(byte days)
		{
			this.days = days;
			DaysMask = days;
		}
		public override string ToString()
		{
			string days = "";
			for(byte i = 0; i < 7; i ++)
			{
				//byte day = Convert.ToByte(1 << i);
				byte day = (byte)(1 << i);
				if ((this.days & day) != 0) days += $"{NAMES[i]},";
			}
			return days;
		}
		public static Week Parse(string s)
		{
			byte mask = 0;
			string[] parts = s.Split(',');
			foreach(string part in parts)
			{
				string partWithoutSpaces = part.Trim(); //убирает пробелы
				int index = -1;
				switch(partWithoutSpaces)
				{
					case "Пн": index = 0; break;
					case "Вт": index = 1; break;
					case "Ср": index = 2; break;
					case "Чт": index = 3; break;
					case "Пт": index = 4; break;
					case "Сб": index = 5; break;
					case "Вс": index = 6; break;
				}
				if (index >= 0) mask |= (byte)(1 << index);
			}
			return new Week(mask);
		}
	}
}
