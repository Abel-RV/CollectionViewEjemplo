using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo.Pages;

public partial class DetallePersonaPage : ContentPage
{
    // El constructor recibe la persona seleccionada
    internal DetallePersonaPage(Persona persona)
    {
        InitializeComponent();
        BindingContext = persona;
    }
}