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

namespace health.Controllers.Usua
{

    [ApiController]
    [Authorize]
    public class ApiUsuController : ControllerBase
    {
        private readonly AppDbContext context;
        public ApiUsuController(AppDbContext context)
        {
            this.context = context;

        }

        [HttpGet]
        [Route("api/getUsuarios")]
        public Object Get()
        {
            return context.Usuarios.ToList();
        }

        [HttpGet]
        [Route("api/getUsuarios/{id}")]
        public Object Get(int id)
        {
            Resp r = new Resp();

            try
            {
                User lst = context.Usuarios.SingleOrDefault(u => u.idUsuario == id);
                r.Ok = true;
                if (lst != null)
                {
                    r.mensaje = "Usuario retornado cone éxito";
                    r.data = lst;
                }
                else
                {
                    r.mensaje = "Usuario no existe";
                }
                return Ok(r);
            }
            catch (Exception ex)
            {
                r.Ok = false;
                r.mensaje = "Ocurrio un error en el servidor";
                return BadRequest(r);
            }
        }
    }
}
