﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class TipoIncidente
    {
        [Key]        
        public Guid TipoIncidenteId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
