using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLuisRebazaNeira.Models
{
    public class Usuario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; }
        [Required, StringLength(50)]
        public string Apellido  { get;set; }
        [Required, StringLength(30)]
        public string Correo { get; set; }
        [Required, StringLength(10)]
        public string Contraseña { get; set; }
        [Required]
        public bool Activo { get; set; }

        public int IdRol {  get; set; }
        public Rol Rol { get; set; }

        public ICollection<Consulta> consultas { get; set; }
        public ICollection<RespuestaConsulta> respuestaConsultas { get; set; }
        public ICollection<SolicitudAcademica>solicitudAcademicas { get; set; } 
        public ICollection<HistorialSolicitud> historialSolicitudes {  get; set; }


    }
}
