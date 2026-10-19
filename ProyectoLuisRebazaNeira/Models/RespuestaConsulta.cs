using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLuisRebazaNeira.Models
{
    public class RespuestaConsulta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRespuest{ get; set; }
        [Required, StringLength(200)]
        public string Mensaje {  get; set; }
        [Required]
        public DateOnly FechaRespuesta {  get; set; }
        public int IdConsulta { get; set; }
        public Consulta Consulta { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }



    }
}
