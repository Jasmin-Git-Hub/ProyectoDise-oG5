using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLuisRebazaNeira.Models
{
    public class HistorialSolicitud
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistorial {  get; set; }
        [Required]
        public string EstadoAnterior {  get; set; }
        [Required]
        public string EstadoNuevo {  get; set; }
        [Required, StringLength(20)]
        public string Observaciones { get; set; }
        [Required]
        public DateOnly FechaCambio {  get; set; }

        public int IdSolicitud {  get; set; }
        public SolicitudAcademica solicitudAcademica { get; set; }
        public int IdUsuario {  get; set; }
        public Usuario Usuario { get; set; }
    }

}
