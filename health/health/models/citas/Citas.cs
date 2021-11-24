using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.citas
{
    public class Citas
    {
        [Key]
        public int idCita { get; set; }
        public int idVeterinaria { get; set; }
        public int idUsuario { get; set; }
        public int idMascotas { get; set; }
        public DateTime fechaCita { get; set; }
    }
}
