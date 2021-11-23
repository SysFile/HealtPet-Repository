using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.paises
{
    public class Paises
    {
        [Key]
        public int idPais { get; set; }
        public string pais { get; set; }
    }
}
