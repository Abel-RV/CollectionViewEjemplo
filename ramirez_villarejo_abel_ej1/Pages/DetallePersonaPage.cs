using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo.Pages;

public partial class DetallePersonaPage : ContentPage
{
    private bool esModoEdicion = false;

    internal DetallePersonaPage(Persona persona)
    {
        InitializeComponent();
        BindingContext = persona;
    }

    private void OnEditarClicked(object sender, EventArgs e)
    {
        // Invertimos el estado de edición
        esModoEdicion = !esModoEdicion;
        txtNombre.IsReadOnly = !esModoEdicion;
        txtApellidos.IsReadOnly = !esModoEdicion;
        txtTrabajo.IsReadOnly = !esModoEdicion;
        txtDireccion.IsReadOnly = !esModoEdicion;
        txtFecha.IsReadOnly = !esModoEdicion;

        if (esModoEdicion)
        {
            btnEditar.Text = "Guardar Cambios";
            btnEditar.BackgroundColor = Colors.Orange;
            
            txtNombre.Focus();
        }
        else
        {
            btnEditar.Text = "Editar Datos";
            btnEditar.BackgroundColor = Color.FromArgb("#512BD4");
            DisplayAlert("Guardado", "Los datos han sido actualizados", "OK");
        }
    }
}