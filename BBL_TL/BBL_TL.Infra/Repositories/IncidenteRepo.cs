using BBL_TL.Core.Interfaces;
using BBL_TL.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Infra.Repositories
{
    public class IncidenteRepo: IIncidenteRepo
    {
        private readonly BblContext _context;

        public IncidenteRepo(BblContext bblContext) 
        { 
            _context = bblContext;
        }

        public async Task<IEnumerable<Incidente>> GetAllIncidentes()
        {
            var incidentes = await _context.Incidente.ToListAsync();

            return incidentes;
        }

    }
}
