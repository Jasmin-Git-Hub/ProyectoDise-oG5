using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLuisRebazaNeira.Models
{
    public class Carrera
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCarrera  { get; set; }
        [Required, StringLength(50)]
        public string NombreCarrera { get; set; }
        [Required, StringLength(100)]
        public string DescipcionCarrea {  get; set; }
        [Required]
        public bool estado {  get; set; }

    }
}
