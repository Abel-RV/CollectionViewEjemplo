using CollectionViewEjemplo.Models;
using System.Linq; // Necesario para que funcione el OrderBy

namespace CollectionViewEjemplo.Pages;

public partial class CollectionViewDemo : ContentPage
{
    private List<Persona> listaPersonas;

    public CollectionViewDemo()
    {
        InitializeComponent();

        // 1. Cargar datos en memoria
        listaPersonas = GetCountries();

        // 2. Asignar la lista a la pantalla
        collectionView.ItemsSource = listaPersonas;
    }

    // --- EVENTO: Al hacer CLICK en una persona (Abre la Ficha) ---
    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Verificamos si se ha seleccionado a alguien válido
        if (e.CurrentSelection.FirstOrDefault() is Persona personaSeleccionada)
        {
            // Navegamos a la página de detalle pasando los datos de la persona
            // (Asegúrate de haber creado ya el archivo DetallePersonaPage)
            await Navigation.PushAsync(new DetallePersonaPage(personaSeleccionada));

            // Deseleccionamos el ítem para que no se quede marcado en gris
            ((CollectionView)sender).SelectedItem = null;
        }
    }

    // --- EVENTO: Botón Ordenar A-Z ---
    private void OnOrdenarNombreClicked(object sender, EventArgs e)
    {
        var listaOrdenada = listaPersonas.OrderBy(p => p.PersonaName).ToList();
        collectionView.ItemsSource = listaOrdenada;

        // Cambio visual de los botones (Naranja el activo)
        btnNombre.BackgroundColor = Colors.Orange;
        btnFecha.BackgroundColor = Color.FromArgb("#2B0B98");
    }

    // --- EVENTO: Botón Ordenar por Fecha ---
    private void OnOrdenarFechaClicked(object sender, EventArgs e)
    {
        // Ordenamos convirtiendo el texto a Fecha real
        var listaOrdenada = listaPersonas.OrderBy(p =>
        {
            if (DateTime.TryParse(p.FechaNacimiento, out DateTime fecha))
                return fecha;
            return DateTime.MinValue;
        }).ToList();

        collectionView.ItemsSource = listaOrdenada;

        // Cambio visual de los botones
        btnFecha.BackgroundColor = Colors.Orange;
        btnNombre.BackgroundColor = Color.FromArgb("#512BD4");
    }

    // --- DATOS: Lista de personas con Trabajo y Dirección ---
    private List<Persona> GetCountries()
    {
		return new List<Persona>
		{
			new Persona{PersonaName = "Jose Vicente",PersonaApellidos="Correas Perez",PersonaFoto="https://i.pravatar.cc/150?img=1",FechaNacimiento="12/05/1990", Direccion="Calle Mayor 12, Madrid", Trabajo="Ingeniero", Telefono="+34 600 123 001"},
			new Persona{PersonaName = "Mariana", PersonaApellidos="Ramos Flores", PersonaFoto="https://i.pravatar.cc/150?img=2", FechaNacimiento="23/08/1988", Direccion="Avenida del Sol 5, Sevilla", Trabajo="Diseñadora", Telefono="+34 600 123 002"},
			new Persona{PersonaName = "Juan", PersonaApellidos="Gomez Rosas", PersonaFoto="https://i.pravatar.cc/150?img=3", FechaNacimiento="05/11/1992", Direccion="Calle Luna 8, Valencia", Trabajo="Profesor", Telefono="+34 600 123 003"},
			new Persona{PersonaName = "Marcos", PersonaApellidos="Nueva Correa", PersonaFoto="https://i.pravatar.cc/150?img=4", FechaNacimiento="30/01/1985", Direccion="Plaza Nueva 3, Bilbao", Trabajo="Mecánico", Telefono="+34 600 123 004"},
			new Persona{PersonaName = "Elena", PersonaApellidos="Gomez Casas", PersonaFoto="https://i.pravatar.cc/150?img=5", FechaNacimiento="17/07/1994", Direccion="Calle Olivo 21, Málaga", Trabajo="Enfermera", Telefono="+34 600 123 005"},
			new Persona{PersonaName = "El Johnny", PersonaApellidos="Hitler", PersonaFoto="https://i.pravatar.cc/150?img=6", FechaNacimiento="02/02/1979", Direccion="Calle Roble 7, Zaragoza", Trabajo="Comerciante", Telefono="+34 600 123 006"},
			new Persona{PersonaName = "Luis", PersonaApellidos="Ramiro Ramos", PersonaFoto="https://i.pravatar.cc/150?img=7", FechaNacimiento="09/09/1991", Direccion="Avenida Libertad 10, Murcia", Trabajo="Desarrollador", Telefono="+34 600 123 007"},
			new Persona{PersonaName = "Dontalo", PersonaApellidos="Filemon", PersonaFoto="https://i.pravatar.cc/150?img=8", FechaNacimiento="14/04/1987", Direccion="Calle Cedro 2, Salamanca", Trabajo="Carpintero", Telefono="+34 600 123 008"},
			new Persona{PersonaName = "Mikasa", PersonaApellidos="Amane", PersonaFoto="https://i.pravatar.cc/150?img=9", FechaNacimiento="21/12/1996", Direccion="Paseo del Parque 14, Granada", Trabajo="Estudiante", Telefono="+34 600 123 009"},
			new Persona{PersonaName = "Tiffanny", PersonaApellidos="Thompsson", PersonaFoto="https://i.pravatar.cc/150?img=10", FechaNacimiento="06/06/1990", Direccion="Calle Azahar 19, Córdoba", Trabajo="Fotógrafa", Telefono="+34 600 123 010"},
			new Persona{PersonaName = "Ana", PersonaApellidos="Martínez López", PersonaFoto="https://i.pravatar.cc/150?img=11", FechaNacimiento="11/03/1993", Direccion="Camino Real 6, Alicante", Trabajo="Abogada", Telefono="+34 600 123 011"},
			new Persona{PersonaName = "Carlos", PersonaApellidos="Sánchez Ruiz", PersonaFoto="https://i.pravatar.cc/150?img=12", FechaNacimiento="04/10/1982", Direccion="Calle Fuente 4, Pamplona", Trabajo="Contable", Telefono="+34 600 123 012"},
			new Persona{PersonaName = "Laura", PersonaApellidos="Pérez Gómez", PersonaFoto="https://i.pravatar.cc/150?img=13", FechaNacimiento="29/02/1996", Direccion="Plaza del Carmen 1, Valladolid", Trabajo="Periodista", Telefono="+34 600 123 013"},
			new Persona{PersonaName = "Diego", PersonaApellidos="Ortiz Salas", PersonaFoto="https://i.pravatar.cc/150?img=14", FechaNacimiento="15/08/1989", Direccion="Calle Rio 11, León", Trabajo="Chef", Telefono="+34 600 123 014"},
			new Persona{PersonaName = "Sofía", PersonaApellidos="Vega Castillo", PersonaFoto="https://i.pravatar.cc/150?img=15", FechaNacimiento="07/01/1995", Direccion="Avenida Mar 22, Santander", Trabajo="Psicóloga", Telefono="+34 600 123 015"},
			new Persona{PersonaName = "Miguel", PersonaApellidos="Herrera Navarro", PersonaFoto="https://i.pravatar.cc/150?img=16", FechaNacimiento="22/11/1987", Direccion="Calle Pino 9, Lugo", Trabajo="Médico", Telefono="+34 600 123 016"},
			new Persona{PersonaName = "Isabel", PersonaApellidos="Rubio Morales", PersonaFoto="https://i.pravatar.cc/150?img=17", FechaNacimiento="03/05/1990", Direccion="Calle Serrano 15, Madrid", Trabajo="Arquitecta", Telefono="+34 600 123 017"},
			new Persona{PersonaName = "Pablo", PersonaApellidos="Soto Ibáñez", PersonaFoto="https://i.pravatar.cc/150?img=18", FechaNacimiento="19/09/1992", Direccion="Avenida Norte 20, Bilbao", Trabajo="Periodista", Telefono="+34 600 123 018"},
			new Persona{PersonaName = "Natalia", PersonaApellidos="Cruz Molina", PersonaFoto="https://i.pravatar.cc/150?img=19", FechaNacimiento="26/12/1994", Direccion="Calle Lirio 13, Cádiz", Trabajo="Farmacéutica", Telefono="+34 600 123 019"},
			new Persona{PersonaName = "Óscar", PersonaApellidos="Beltrán Ruiz", PersonaFoto="https://i.pravatar.cc/150?img=20", FechaNacimiento="08/06/1983", Direccion="Plaza Real 17, Logroño", Trabajo="Consultor", Telefono="+34 600 123 020"},
		};

	}
}