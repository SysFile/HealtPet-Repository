using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.PermisosUser
{
    public class PermisosUsuario
    {

        [Key]
        public int IdPermiso { get; set; }
        public string permiso { get; set; }
    }
}
