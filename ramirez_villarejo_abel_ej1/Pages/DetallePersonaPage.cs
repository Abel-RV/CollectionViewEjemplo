using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo.Pages;

public partial class DetallePersonaPage : ContentPage
{
    internal DetallePersonaPage(Persona persona)
    {
        InitializeComponent();
        BindingContext = persona;
    }
}