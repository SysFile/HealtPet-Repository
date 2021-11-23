using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.tipoDocumento
{
    public class TipoDocumento
    {
        [Key]
        public int idTipoDocumento { get; set; }
        public string tipoDocumento { get; set; }
    }
}
