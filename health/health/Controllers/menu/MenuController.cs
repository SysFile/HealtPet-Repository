using health.context;
using health.models.menu;
using health.models.resp;
using health.models.settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace health.Controllers.menu
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuController : ControllerBase
    {
        private readonly AppDbContext context;

        public MenuController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public Object Get()
        {
            Resp r = new Resp();
            try
            {
                r.Ok = true;
                r.mensaje = "Menú retornado con éxito";
                r.data = context.Menu.ToList();

                return Ok(r); 
            }
            catch(Exception e)
            {
                r.Ok = false;
                r.mensaje = "Error al retornar el menú";
                return BadRequest(r);
            }
            
        }
    }
}
