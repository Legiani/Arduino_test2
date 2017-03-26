using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Znamky
{
	public partial class NovaZnamka : ContentPage
	{
		public NovaZnamka()
		{
			InitializeComponent();
		}

		public void ulozit(object sender, EventArgs args)
		{
			//vytvoření spojení s db
			var dbConnection = App.Database;
			//db uživatelu
			Database userDatabase = App.Database;

			//list pro dočasne uložení
			Znamka item = new Znamka();
			item.Hodnoceni = Convert.ToInt16(znamka.Text);
			item.Predmet = predmet.Text;
			item.Vaha = Convert.ToInt16(vaha.Text);

			//zapis dat do db
			App.Database.SaveItemAsync(item);
			//vrat se na domovskou obrazovku
			Navigation.PopModalAsync();
		}
	}
}
