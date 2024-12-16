using BBL_TL.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Infra
{
    public class BblContext : DbContext
    {
        public BblContext(DbContextOptions<BblContext> options) : base(options)  
        { }

        public DbSet<Incidente> Incidente { get; set; }
    }
}
