using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionViewEjemplo.Models
{
    // Implementamos la interfaz para notificar cambios
    internal class Persona : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _personaName;
        private string _personaApellidos;
        private string _trabajo;
        private string _direccion;
        private string _telefono;
        private string _fechaNacimiento;
        private string _personaFoto;

        public string PersonaName
        {
            get => _personaName;
            set { if (_personaName != value) { _personaName = value; OnPropertyChanged(); } }
        }

        public string PersonaApellidos
        {
            get => _personaApellidos;
            set { if (_personaApellidos != value) { _personaApellidos = value; OnPropertyChanged(); } }
        }

        public string Trabajo
        {
            get => _trabajo;
            set { if (_trabajo != value) { _trabajo = value; OnPropertyChanged(); } }
        }

        public string Direccion
        {
            get => _direccion;
            set { if (_direccion != value) { _direccion = value; OnPropertyChanged(); } }
        }

        public string Telefono
        {
            get => _telefono;
            set { if (_telefono != value) { _telefono = value; OnPropertyChanged(); } }
        }
        
        public string FechaNacimiento
        {
            get => _fechaNacimiento;
            set { if (_fechaNacimiento != value) { _fechaNacimiento = value; OnPropertyChanged(); } }
        }

        public string PersonaFoto
        {
            get => _personaFoto;
            set { if (_personaFoto != value) { _personaFoto = value; OnPropertyChanged(); } }
        }
    }
}