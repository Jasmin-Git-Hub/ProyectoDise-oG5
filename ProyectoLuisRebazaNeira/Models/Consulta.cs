using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLuisRebazaNeira.Models
{
    public class Consulta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdConsulta { get; set; }
        [Required, StringLength(50)]

        public string NombreConsulta { get; set; }
        [Required, StringLength(100)]
        public string DescripcionConsulta {  get; set; }
        [Required, StringLength(20)]
        public string DatoContacto { get; set; }
        [Required]
        public DateOnly FechaRegistro {  get; set; }
        [Required]
        public string Estado {  get; set; }
        
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<RespuestaConsulta> RespuestaConsultas { get; set; }

    }
}
