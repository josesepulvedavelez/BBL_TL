using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class TipoEquipo
    {
        public Guid TipoEquipoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
    }
}
