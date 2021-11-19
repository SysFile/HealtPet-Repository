using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.menu
{
    public class Menu
    {
        [Key]
        public int idMenu { get; set; }
        public string name { get; set; }
        public string link { get; set;  }
    }
}
