using System;
using SQLite;

namespace Znamky
{
	public class Znamka
	{


		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Predmet { get; set; }
		public int Vaha { get; set; }
		public int Hodnoceni { get; set; }
		public double PravaZnamka() {
			return Vaha * Hodnoceni;
		}

		public override string ToString()
		{
			return Vaha + " " + Hodnoceni + " " + Predmet;
		}
	}
}
