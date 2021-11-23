using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.raza
{
    public class Raza
    {
        [Key]
        public int idRaza { get; set; }
        public string raza { get; set; }
    }
}
