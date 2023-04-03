using System.ComponentModel.DataAnnotations;

namespace UsersActivity.API
{
    public class Activity
    {
        [Key]
        public int Id_actividad { get; set; } 
        public DateTime Create_date { get; set; }
        public int Id_usuario { get; set; }
        public string Actividad { get; set; } = string.Empty;
    }
}