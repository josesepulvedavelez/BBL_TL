using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? NumeroTelefono { get; set; }
        public string Rol { get; set; } = null!; // Consider using an enum
        public Guid? EquipoId { get; set; }
        public Equipo? Equipo { get; set; }
        public string Credenciales { get; set; } = null!;
        public ICollection<Incidente> IncidentesReportados { get; set; } = new List<Incidente>();
    }
}
