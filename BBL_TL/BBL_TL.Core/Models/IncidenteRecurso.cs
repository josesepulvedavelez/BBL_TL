using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class IncidenteRecurso
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Recurso")]
        public Guid RecursoId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Incidente")]
        public Guid IncidenteId { get; set; }
    }
}
