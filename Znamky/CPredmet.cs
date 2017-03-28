using System;
namespace Znamky
{
	public class CPredmet
	{
		public string Predmet { get; set; }
		public double Prumer { get; set; }
		public int Znamek { get; set; }
		public int Absence { get; set; }

		public override string ToString()
		{
			return Predmet;
		}
	}
}
