
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class Incidente
    {
        public Guid IncidenteId { get; set; }
        public string Titulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public Guid TipoIncidenteId { get; set; }
        public TipoIncidente TipoIncidente { get; set; } = null!;
        public string NivelSeveridad { get; set; } = null!; // Consider using an enum
        public string Estado { get; set; } = null!; // Consider using an enum
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public string? Ubicacion { get; set; }
        public decimal? CoordenadasLatitude { get; set; }
        public decimal? CoordenadasLongitude { get; set; }
        public Guid ReportadoPorUsuarioId { get; set; }
        public Usuario ReportadoPorUsuario { get; set; } = null!;
        public ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
        public ICollection<Recurso> Recursos { get; set; } = new List<Recurso>();
    }
}
