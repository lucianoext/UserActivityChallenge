using System.ComponentModel.DataAnnotations;

namespace UsersActivity.API
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; } = string.Empty;
        public DateTime FechaDeNacimiento { get; set; }
        public int Telefono { get; set; } 
        public string PaisDeResidencia { get; set; } = string.Empty;
        public bool DeseaRecibirInformacion { get; set; }
        public bool Activo { get; set; } = true;
    }
}