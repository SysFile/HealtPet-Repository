using health.context;
using health.models;
using health.models.resp;
using health.models.veterinaria;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace health.Controllers.veterinarias
{
    [ApiController]
    [Authorize]
    public class VeterinariasController : ControllerBase
    {
        private readonly AppDbContext context;
        public VeterinariasController(AppDbContext context)
        {
            this.context = context;

        }
        [HttpPost]
        [Route("api/postVeterinarias")]
        public Object Porst([FromBody] Veterinarias vete)
        {
            Resp r = new Resp();
            try
            {
                context.Veterinarias.Add(vete);
                context.SaveChanges();
                r.Ok = true;
                r.mensaje = "La veterinaria a sido registrado";
                return Ok(r);
            }
            catch
            {
                r.Ok = false;
                r.mensaje = "La veterinaria no a sido registrada";
                return BadRequest(r);
            }
        }


        // put 
        [HttpPut]
        [Route("api/putVeterinarias/{id}")]
        public Object Put([FromBody] Veterinarias vete, int id)
        {
            Resp r = new Resp();
            if (id == vete.idVeterinaria)
            {
                context.Entry(vete).State = EntityState.Modified;
                context.SaveChanges();
                r.Ok = true;
                r.data = vete;
                r.mensaje = "La veterinaria a sido editado";
                return Ok(r);
            }
            else
            {
                r.Ok = false;
                r.mensaje = "La veterinaria no a sido editado";
                return BadRequest(r);
            }
        }



        // delete
        [HttpDelete]
        [Route("api/deleteVeterinarias/{id}")]
        public Object Delete(int id)
        {
            Resp r = new Resp();
            var vete = context.Veterinarias.FirstOrDefault(x => x.idVeterinaria == id);


            if (vete != null)
            {
                context.Veterinarias.Remove(vete);
                context.SaveChanges();
                r.Ok = true;
                r.mensaje = "La veterinaria a sido eliminado";
                return Ok(r);
            }
            else
            {
                r.Ok = false;
                r.mensaje = "La veterinaria no a sido eliminado";
                return BadRequest(r);
            }
        }

        [HttpGet]
        [Route("api/getVeterinarias")]
        public Object Get()
        {
            return context.Veterinarias.ToList();
        }
    }
}
