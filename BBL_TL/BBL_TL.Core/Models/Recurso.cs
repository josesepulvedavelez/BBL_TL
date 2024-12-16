using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class Recurso
    {
        public Guid RecursoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int CantidadDisponible { get; set; }
        public string? Ubicacion { get; set; }
        public Guid? IncidenteIdAsignado { get; set; }
        public Incidente? IncidenteAsignado { get; set; }
    }
}
