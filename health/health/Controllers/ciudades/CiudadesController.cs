using health.context;
using health.models;
using health.models.resp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace health.Controllers.ciudades
{
    [ApiController]
    public class CiudadesController : ControllerBase
    {
        private readonly AppDbContext context;
        public CiudadesController(AppDbContext context)
        {
            this.context = context;

        }
        [HttpGet]
        [Route("api/getCiudades")]
        public Object Get()
        {
            return context.Ciudades.ToList();
        }
    }
}
