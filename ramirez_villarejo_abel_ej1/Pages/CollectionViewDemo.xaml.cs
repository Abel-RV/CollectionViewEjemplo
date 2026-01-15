using CollectionViewEjemplo.Models;
using System.Linq; // Necesario para ordenar

namespace CollectionViewEjemplo.Pages;

public partial class CollectionViewDemo : ContentPage
{
    private List<Persona> listaPersonas;

    public CollectionViewDemo()
    {
        InitializeComponent();
        listaPersonas = GetCountries(); // Carga los datos en memoria
        collectionView.ItemsSource = listaPersonas; // Los muestra
    }

    // Se ejecuta al pulsar "Ordenar A-Z"
    private void OnOrdenarNombreClicked(object sender, EventArgs e)
    {
        // 1. Ordenar la lista
        var listaOrdenada = listaPersonas.OrderBy(p => p.PersonaName).ToList();
        collectionView.ItemsSource = listaOrdenada;

        // 2. Cambiar colores para saber que este está activo
        btnNombre.BackgroundColor = Colors.Orange; // Activo
        btnFecha.BackgroundColor = Color.FromArgb("#2B0B98"); // Inactivo
    }

    // Se ejecuta al pulsar "Ordenar por Fecha"
    private void OnOrdenarFechaClicked(object sender, EventArgs e)
    {
        // 1. Ordenar por fecha (convirtiendo el texto a fecha real)
        var listaOrdenada = listaPersonas.OrderBy(p => 
        {
            if (DateTime.TryParse(p.FechaNacimiento, out DateTime fecha))
                return fecha;
            return DateTime.MinValue;
        }).ToList();

        collectionView.ItemsSource = listaOrdenada;

        // 2. Cambiar colores para saber que este está activo
        btnFecha.BackgroundColor = Colors.Orange; // Activo
        btnNombre.BackgroundColor = Color.FromArgb("#512BD4"); // Inactivo
    }

    private List<Persona> GetCountries()
    {
		return new List<Persona>
		{
			new Persona{PersonaName = "Jose Vicente",PersonaApellidos="Correas Perez",PersonaFoto="https://i.pravatar.cc/150?img=1",FechaNacimiento="12/05/1990"},
			new Persona{PersonaName = "Mariana", PersonaApellidos="Ramos Flores", PersonaFoto="https://i.pravatar.cc/150?img=2", FechaNacimiento="23/08/1988"},
			new Persona{PersonaName = "Juan", PersonaApellidos="Gomez Rosas", PersonaFoto="https://i.pravatar.cc/150?img=3", FechaNacimiento="05/11/1992"},
			new Persona{PersonaName = "Marcos", PersonaApellidos="Nueva Correa", PersonaFoto="https://i.pravatar.cc/150?img=4", FechaNacimiento="30/01/1985"},
			new Persona{PersonaName = "Elena", PersonaApellidos="Gomez Casas", PersonaFoto="https://i.pravatar.cc/150?img=5", FechaNacimiento="17/07/1994"},
			new Persona{PersonaName = "El Johnny", PersonaApellidos="Hitler", PersonaFoto="https://i.pravatar.cc/150?img=6", FechaNacimiento="02/02/1979"},
			new Persona{PersonaName = "Luis", PersonaApellidos="Ramiro Ramos", PersonaFoto="https://i.pravatar.cc/150?img=7", FechaNacimiento="09/09/1991"},
			new Persona{PersonaName = "Dontalo", PersonaApellidos="Filemon", PersonaFoto="https://i.pravatar.cc/150?img=8", FechaNacimiento="14/04/1987"},
			new Persona{PersonaName = "Mikasa", PersonaApellidos="Amane", PersonaFoto="https://i.pravatar.cc/150?img=9", FechaNacimiento="21/12/1996"},
			new Persona{PersonaName = "Tiffanny", PersonaApellidos="Thompsson", PersonaFoto="https://i.pravatar.cc/150?img=10", FechaNacimiento="06/06/1990"},
			new Persona{PersonaName = "Ana", PersonaApellidos="Martínez López", PersonaFoto="https://i.pravatar.cc/150?img=11", FechaNacimiento="11/03/1993"},
			new Persona{PersonaName = "Carlos", PersonaApellidos="Sánchez Ruiz", PersonaFoto="https://i.pravatar.cc/150?img=12", FechaNacimiento="04/10/1982"},
			new Persona{PersonaName = "Laura", PersonaApellidos="Pérez Gómez", PersonaFoto="https://i.pravatar.cc/150?img=13", FechaNacimiento="29/02/1996"},
			new Persona{PersonaName = "Diego", PersonaApellidos="Ortiz Salas", PersonaFoto="https://i.pravatar.cc/150?img=14", FechaNacimiento="15/08/1989"},
			new Persona{PersonaName = "Sofía", PersonaApellidos="Vega Castillo", PersonaFoto="https://i.pravatar.cc/150?img=15", FechaNacimiento="07/01/1995"},
			new Persona{PersonaName = "Miguel", PersonaApellidos="Herrera Navarro", PersonaFoto="https://i.pravatar.cc/150?img=16", FechaNacimiento="22/11/1987"},
			new Persona{PersonaName = "Isabel", PersonaApellidos="Rubio Morales", PersonaFoto="https://i.pravatar.cc/150?img=17", FechaNacimiento="03/05/1990"},
			new Persona{PersonaName = "Pablo", PersonaApellidos="Soto Ibáñez", PersonaFoto="https://i.pravatar.cc/150?img=18", FechaNacimiento="19/09/1992"},
			new Persona{PersonaName = "Natalia", PersonaApellidos="Cruz Molina", PersonaFoto="https://i.pravatar.cc/150?img=19", FechaNacimiento="26/12/1994"},
			new Persona{PersonaName = "Óscar", PersonaApellidos="Beltrán Ruiz", PersonaFoto="https://i.pravatar.cc/150?img=20", FechaNacimiento="08/06/1983"},
		};

	}
}