using health.context;
using health.models;
using health.models.cambioContraseña;
using health.models.resp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace health.Controllers.cambioContraseña
{
    [ApiController]
    public class CcontraseñaController : ControllerBase
    {
        private readonly AppDbContext context;

        public CcontraseñaController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPut]
        [Route("api/cambioContrasea")]
        public Object Get([FromBody] cambio user)
        {
            Resp r = new Resp();
            try
            {
                User us = context.Usuarios.SingleOrDefault(u => u.idUsuario==user.id);
                r.Ok = true;
                if (us != null)
                {
                    us.contraseña = user.password;
                    context.SaveChanges();
                    r.mensaje = "Contraseña cambiada con éxito";
                }
                else
                {
                    r.mensaje = "Datos incorrectos";
                }
                

                return Ok(r);
            }
            catch (Exception e)
            {
                r.Ok = false;
                r.mensaje = "Error al retornar el menú";
                return BadRequest(r);
            }

        }
    }
}
