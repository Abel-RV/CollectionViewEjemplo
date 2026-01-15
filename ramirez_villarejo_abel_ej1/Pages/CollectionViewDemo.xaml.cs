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
			new Country{PersonaName = "United States",IsoCode="USA",FlagUrl="https://flagcdn.com/w40/us.png"},
			new Country{PersonaName = "Canada", IsoCode="CAN", FlagUrl="https://flagcdn.com/w40/ca.png"},
			new Country{PersonaName = "Mexico", IsoCode="MEX", FlagUrl="https://flagcdn.com/w40/mx.png"},
			new Country{PersonaName = "Spain", IsoCode="ESP", FlagUrl="https://flagcdn.com/w40/es.png"},
			new Country{PersonaName = "France", IsoCode="FRA", FlagUrl="https://flagcdn.com/w40/fr.png"},
			new Country{PersonaName = "Germany", IsoCode="DEU", FlagUrl="https://flagcdn.com/w40/de.png"},
			new Country{PersonaName = "Argentina", IsoCode="ARG", FlagUrl="https://flagcdn.com/w40/ar.png"},
			new Country{PersonaName = "Brazil", IsoCode="BRA", FlagUrl="https://flagcdn.com/w40/br.png"},
			new Country{PersonaName = "Japan", IsoCode="JPN", FlagUrl="https://flagcdn.com/w40/jp.png"},
			new Country{PersonaName = "Australia", IsoCode="AUS", FlagUrl="https://flagcdn.com/w40/au.png"}


        };

	}
}