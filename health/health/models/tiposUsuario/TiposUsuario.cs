using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.TiposUsuario
{
    public class TiposUsuario
    {
        [Key]
        public int idTipoUsuario { get; set; }
        public string tipoUsuario { get; set; }
    }
}
