using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.Pets
{
    public class Pets
    {

        [Key]
        public int idMascota { get; set; }
        public string nombreMascota { get; set; }
        public int idUsuario { get; set; }
        public string edad { get; set; }
        public int idRaza { get; set; }



    }
}
