using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo.Pages;


public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();
		collectionView.ItemsSource = GetCountries();
	}
	private List<Persona> GetCountries()
	{
		return new List<Persona>
		{
			new Persona{PersonaName = "Jose Vicente",PersonaApellidos="Correas Perez",PersonaFoto="https://i.pravatar.cc/150?img=1",fechaNacimiento="12/05/1990"},
			new Persona{PersonaName = "Mariana", PersonaApellidos="Ramos Flores", PersonaFoto="https://i.pravatar.cc/150?img=2", fechaNacimiento="23/08/1988"},
			new Persona{PersonaName = "Juan", PersonaApellidos="Gomez Rosas", PersonaFoto="https://i.pravatar.cc/150?img=3", fechaNacimiento="05/11/1992"},
			new Persona{PersonaName = "Marcos", PersonaApellidos="Nueva Correa", PersonaFoto="https://i.pravatar.cc/150?img=4", fechaNacimiento="30/01/1985"},
			new Persona{PersonaName = "Elena", PersonaApellidos="Gomez Casas", PersonaFoto="https://i.pravatar.cc/150?img=5", fechaNacimiento="17/07/1994"},
			new Persona{PersonaName = "El Johnny", PersonaApellidos="Hitler", PersonaFoto="https://i.pravatar.cc/150?img=6", fechaNacimiento="02/02/1979"},
			new Persona{PersonaName = "Luis", PersonaApellidos="Ramiro Ramos", PersonaFoto="https://i.pravatar.cc/150?img=7", fechaNacimiento="09/09/1991"},
			new Persona{PersonaName = "Dontalo", PersonaApellidos="Filemon", PersonaFoto="https://i.pravatar.cc/150?img=8", fechaNacimiento="14/04/1987"},
			new Persona{PersonaName = "Mikasa", PersonaApellidos="Amane", PersonaFoto="https://i.pravatar.cc/150?img=9", fechaNacimiento="21/12/1996"},
			new Persona{PersonaName = "Tiffanny", PersonaApellidos="Thompsson", PersonaFoto="https://i.pravatar.cc/150?img=10", fechaNacimiento="06/06/1990"}
		};

	}
}