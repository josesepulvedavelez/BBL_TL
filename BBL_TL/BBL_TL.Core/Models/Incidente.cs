
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class Incidente
    {
        [Key]        
        public Guid IncidenteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required]
        public int NivelSeveridad { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaHoraInicio { get; set; }

        public DateTime? FechaHoraFin { get; set; }

        [Required]
        [StringLength(200)]
        public string Ubicacion { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 9)")]
        public decimal Coordenadas { get; set; }

        [Required]
        [ForeignKey("TipoIncidente")]
        public Guid TipoIncidenteId { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public Guid UsuarioId { get; set; }
    }
}
