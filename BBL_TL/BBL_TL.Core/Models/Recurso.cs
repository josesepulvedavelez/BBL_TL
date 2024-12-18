using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class Recurso
    {
        [Key]        
        public Guid RecursoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Required]
        public int CantidadDisponible { get; set; }

        [Required]
        [StringLength(200)]
        public string Ubicacion { get; set; }

        [ForeignKey("Incidente")]
        public Guid? IncidenteId { get; set; }        
    }
}
