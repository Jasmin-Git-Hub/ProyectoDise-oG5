using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLuisRebazaNeira.Models
{
    public class SolicitudAcademica
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSolicitud {  get; set; }
        [Required, StringLength(10)]
        public string TipoTramite {  get; set; }
        [Required, StringLength(100)]
        public string Descripcion {  get; set; }
        [Required]
        public DateOnly FechaRegistro {  get; set; }
        [Required]
        public string Estado {  get; set; }
        [Required, StringLength(30)]
        public string Observaciones { get; set; }
        public int IdUsuario {  get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<HistorialSolicitud> HistorialSolicitudes {  get; set; }


    }
}
