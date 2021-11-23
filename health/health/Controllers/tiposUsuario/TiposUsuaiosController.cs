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

namespace health.Controllers.tiposUsuario
{
    [ApiController]
    public class TiposUsuaiosController : ControllerBase
    {
        private readonly AppDbContext context;
        public TiposUsuaiosController(AppDbContext context)
        {
            this.context = context;

        }
        [HttpGet]
        [Route("api/getTiposUsuario")]
        public Object Get()
        {
            return context.TiposUsuario.ToList();
        }
    }
}
