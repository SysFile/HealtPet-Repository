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

namespace health.Controllers.raza
{
    [ApiController]
    public class RazaController : ControllerBase
    {
        private readonly AppDbContext context;
        public RazaController(AppDbContext context)
        {
            this.context = context;

        }

        [HttpGet]
        [Route("api/getUsuarios")]
        public Object Get()
        {
            return context.Raza.ToList();
        }
    }
}
