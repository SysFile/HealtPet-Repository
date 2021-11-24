using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.Pets
{
    public class PetView
    {
        [Key]
        public int idMascota { get; set; }
        public string nombreMascota { get; set; }
        public string edad { get; set; }
        public string raza { get; set; }
        public int idUsuario { get; set; }
    }
}
