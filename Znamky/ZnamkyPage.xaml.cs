using System;
using Xamarin.Forms;

namespace Znamky
{
	public partial class ZnamkyPage : ContentPage
	{
		public ZnamkyPage()
		{
			InitializeComponent();
			fill();
		}

		/// <summary>
		/// Provede se při navratu sem
		/// </summary>
		protected override void OnAppearing()
		{
			base.OnAppearing();
			fill();

		}
		/// <summary>
		/// Naplní ListView
		/// </summary>
		public void fill()
		{
			var dbConnection = App.Database;
			Database personDatabase = App.Database;
			ListViewFormatted.ItemsSource = App.Database.GetItemsAsync().Result;

		}

		/// <summary>
		/// Funkce pro rychlé zadaní známek a zobrazení pruměru
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void rychloPocet(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new rychloPocet());
		}

		/// <summary>
		/// Otevření stránky s detailem po kliknutí
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public async void SelectedItemMethod(object sender, ItemTappedEventArgs e)
		{
			//////vytvoření Item s přijatímy daty
			//Item item = e.Item as Item;
			////přičte k množstí 1
			//item.Quantity = item.Quantity + 1;
			////vytvoření spojení s db
			//var dbConnection = App.Database;
			////db uživatelu
			//Database userDatabase = App.Database;
			////zapis(update) dat do db
			//await App.Database.SaveItemAsync(item);
			////počkej pro stabilitu
			//await Task.Delay(1);
			//fill();
		}
	}
}
