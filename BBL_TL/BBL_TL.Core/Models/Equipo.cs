using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class Equipo
    {
        public Guid EquipoId { get; set; }
        public string Nombre { get; set; } = null!;
        public Guid TipoEquipoId { get; set; }
        public TipoEquipo TipoEquipo { get; set; } = null!;
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public ICollection<Incidente> Incidentes { get; set; } = new List<Incidente>();
    }
}
