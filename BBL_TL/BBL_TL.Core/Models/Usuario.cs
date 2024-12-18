using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL_TL.Core.Models
{
    public class Usuario
    {
        [Key]        
        public Guid UsuarioId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string NumeroTelefono { get; set; }

        [Required]
        public int Rol { get; set; }

        [Required]
        [StringLength(10)]
        public string Credenciales { get; set; }

        [Required]
        [ForeignKey("EquipoId")]
        public Guid EquipoId { get; set; }
    }
}
