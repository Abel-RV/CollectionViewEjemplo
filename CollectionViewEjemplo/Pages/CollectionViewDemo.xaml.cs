using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo.Pages;


public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();
		collectionView.ItemsSource = GetCountries();
	}
	private List<Country> GetCountries()
	{
		return new List<Country>
		{
			new Country{CountryName = "United States",IsoCode="USA",FlagUrl="https://flagcdn.com/w40/us.png"},
			new Country{CountryName = "Canada", IsoCode="CAN", FlagUrl="https://flagcdn.com/w40/ca.png"},
			new Country{CountryName = "Mexico", IsoCode="MEX", FlagUrl="https://flagcdn.com/w40/mx.png"},
			new Country{CountryName = "Spain", IsoCode="ESP", FlagUrl="https://flagcdn.com/w40/es.png"},
			new Country{CountryName = "France", IsoCode="FRA", FlagUrl="https://flagcdn.com/w40/fr.png"},
			new Country{CountryName = "Germany", IsoCode="DEU", FlagUrl="https://flagcdn.com/w40/de.png"},
			new Country{CountryName = "Argentina", IsoCode="ARG", FlagUrl="https://flagcdn.com/w40/ar.png"},
			new Country{CountryName = "Brazil", IsoCode="BRA", FlagUrl="https://flagcdn.com/w40/br.png"},
			new Country{CountryName = "Japan", IsoCode="JPN", FlagUrl="https://flagcdn.com/w40/jp.png"},
			new Country{CountryName = "Australia", IsoCode="AUS", FlagUrl="https://flagcdn.com/w40/au.png"}


        };

	}
}