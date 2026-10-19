using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLuisRebazaNeira.Models
{
    public class Rol
    {
        [Key,DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int IdRol { get; set; }
        [Required,StringLength (50)]
        public string NombreRol { get; set; }
        [Required, StringLength(100)] 
        public string Descripcion {  get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
