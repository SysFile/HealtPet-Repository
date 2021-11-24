using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.veterinaria
{
    public class Veterinarias
    {
        [Key]
        public int idVeterinaria { get; set; }
        public string nombreVeterinaria { get; set; }
        public int idCiudad { get; set; }
        public string direccion { get; set; }
        public string certificado { get; set; }

    }
}

