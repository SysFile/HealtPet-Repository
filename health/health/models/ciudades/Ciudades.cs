using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace health.models.ciudades
{
    public class Ciudades
    {
        [Key]
        public int idCiudad { get; set; }
        public string ciudad { get; set; }
        public int idPais { get; set; }
    }
}
