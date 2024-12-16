using BBL_TL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Interfaces
{
    public interface IIncidenteRepo
    {
        Task<IEnumerable<Incidente>> GetAllIncidentes();
    }
}
