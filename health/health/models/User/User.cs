using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models
{
    public class User
    {
        [Key]
        public int idUsuario { get; set; }
        public string nombres { get; set; }
        public int idTipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string correo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public int idPermisos { get; set; }
        public string contraseña { get; set; }
        public int idTipoUsuario { get; set; }
        public Boolean primerIngreso { get; set; }
    }
}
