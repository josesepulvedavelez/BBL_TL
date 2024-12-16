using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class TipoIncidente
    {
        public Guid TipoIncidenteId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public ICollection<Incidente> Incidentes { get; set; } = new List<Incidente>();
    }
}
