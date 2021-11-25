using health.context;
using health.models;
using health.models.resp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        // post
        [HttpPost]
        [Route("api/postUsuarios")]
        public Object Porst([FromBody] User user)
        {
            Resp r = new Resp();
            try
            {
                context.Usuarios.Add(user);
                context.SaveChanges();
                r.Ok = true;
                r.mensaje = "El Usuario a sido registrado";
                return Ok(r);
            }
            catch
            {
                r.Ok = false;
                r.mensaje = "El Usuario no a sido registrado";
                return BadRequest(r);
            }
        }


        // put 
        [HttpPut]
        [Route("api/putUsuarios/{id}")]
        public Object Put([FromBody] User user, int id)
        {
            Resp r = new Resp();
            if (id == user.idUsuario)
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                r.Ok = true;
                r.data = user;
                r.mensaje = "El Usuario ha sido editado";
                return Ok(r);
            }
            else
            {
                r.Ok = false;
                r.mensaje = "El Usuario no ha sido editado";
                return BadRequest(r);
            }
        }



        // delete
        [HttpDelete]
        [Route("api/deleteUsuarios/{id}")]
        public Object Delete(int id)
        {
            Resp r = new Resp();
            var us = context.Usuarios.FirstOrDefault(x => x.idUsuario == id);


            if (us != null)
            {
                context.Usuarios.Remove(us);
                context.SaveChanges();
                r.Ok = true;
                r.mensaje = "El Usuario ha sido eliminado";
                return Ok(r);
            }
            else
            {
                r.Ok = false;
                r.mensaje = "El Usuario no ha sido eliminado";
                return BadRequest(r);
            }
        }


        [HttpGet]
        [Route("api/getUsuarios")]
        public Object Get()
        {
            return context.Usuarios.ToList();
        }



        [HttpGet]
        [Route("api/getUsuarios/{id}")]
        public Object GetUser(int id)
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
