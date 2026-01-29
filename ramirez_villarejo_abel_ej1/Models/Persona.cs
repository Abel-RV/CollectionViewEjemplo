using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using SQLite;

namespace CollectionViewEjemplo.Models
{
    
    [SQLite.Table("Personas")]
    public class Persona : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        [SQLite.Column("Id")]
        public int Id { get; set; }

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

        [SQLite.Column("PersonaName")]
        public string PersonaName
        {
            get => _personaName;
            set { if (_personaName != value) { _personaName = value; OnPropertyChanged(); } }
        }

        [SQLite.Column("PersonaApellidos")]
        public string PersonaApellidos
        {
            get => _personaApellidos;
            set { if (_personaApellidos != value) { _personaApellidos = value; OnPropertyChanged(); } }
        }

        [SQLite.Column("Trabajo")]
        public string Trabajo
        {
            get => _trabajo;
            set { if (_trabajo != value) { _trabajo = value; OnPropertyChanged(); } }
        }

        [SQLite.Column("Direccion")]
        public string Direccion
        {
            get => _direccion;
            set { if (_direccion != value) { _direccion = value; OnPropertyChanged(); } }
        }

        [SQLite.Column("Telefono")]
        public string Telefono
        {
            get => _telefono;
            set { if (_telefono != value) { _telefono = value; OnPropertyChanged(); } }
        }

        [SQLite.Column("FechaNacimiento")]
        public string FechaNacimiento
        {
            get => _fechaNacimiento;
            set { if (_fechaNacimiento != value) { _fechaNacimiento = value; OnPropertyChanged(); } }
        }

        [SQLite.Column("PersonaFoto")]
        public string PersonaFoto
        {
            get => _personaFoto;
            set { if (_personaFoto != value) { _personaFoto = value; OnPropertyChanged(); } }
        }
    }
}