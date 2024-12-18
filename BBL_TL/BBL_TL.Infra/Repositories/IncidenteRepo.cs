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

        public async Task<int> InsertIncidente(Incidente incidente)
        {
            await _context.Incidente.AddAsync(incidente);
            var result = await _context.SaveChangesAsync();

            return result;
        }

        public async Task<int> UpdateIncidente(Guid incidenteId, Incidente incidente)
        {
            var existeIncidente = await  _context.Incidente.FirstOrDefaultAsync(x => x.IncidenteId == incidenteId);

            existeIncidente.Titulo = incidente.Titulo;
            existeIncidente.Descripcion = incidente.Descripcion;
            existeIncidente.NivelSeveridad = incidente.NivelSeveridad;
            existeIncidente.Estado = incidente.Estado;
            existeIncidente.FechaHoraInicio = incidente.FechaHoraInicio;
            existeIncidente.FechaHoraFin = incidente.FechaHoraFin;
            existeIncidente.Ubicacion = incidente.Ubicacion;
            existeIncidente.Coordenadas = incidente.Coordenadas;
            existeIncidente.TipoIncidenteId = incidente.TipoIncidenteId;
            existeIncidente.UsuarioId = incidente.UsuarioId;

            var update = await _context.SaveChangesAsync();

            return update;
        }

    }
}
