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

namespace health.Controllers.paises
{
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly AppDbContext context;
        public PaisesController(AppDbContext context)
        {
            this.context = context;

        }
        [HttpGet]
        [Route("api/getPaises")]
        public Object Get()
        {
            return context.TiposUsuario.ToList();
        }
    }
}
