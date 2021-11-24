using health.context;
using health.models;
using health.models.citas;
using health.models.resp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace health.Controllers.citas
{

    [ApiController]
    [Authorize]
    public class CitasController : ControllerBase
    {
        private readonly AppDbContext context;
        public CitasController(AppDbContext context)
        {
            this.context = context;
        }
        // post
        [HttpPost]
        [Route("api/postCita")]
        public Object Porst([FromBody] Citas cita)
        {
            Resp r = new Resp();
            try
            {
                context.Citas.Add(cita);
                context.SaveChanges();
                r.Ok = true;
                r.mensaje = "La cita a sido registrada";
                return Ok(r);
            }
            catch
            {
                r.Ok = false;
                r.mensaje = "La cita no a sido registra";
                return BadRequest(r);
            }
        }


        // put 
        [HttpPut]
        [Route("api/putCita/{id}")]
        public Object Put([FromBody] Citas cita, int id)
        {
            Resp r = new Resp();
            if (id == cita.idCita)
            {
                context.Entry(cita).State = EntityState.Modified;
                context.SaveChanges();
                r.Ok = true;
                r.data = cita;
                r.mensaje = "La cita ha sido editada";
                return Ok(r);
            }
            else
            {
                r.Ok = false;
                r.mensaje = "La cita no ha sido editada";
                return BadRequest(r);
            }
        }



        // delete
        [HttpDelete]
        [Route("api/deleteCita/{id}")]
        public Object Delete(int id)
        {
            Resp r = new Resp();
            var cita = context.Citas.FirstOrDefault(x => x.idCita == id);


            if (cita != null)
            {
                context.Citas.Remove(cita);
                context.SaveChanges();
                r.Ok = true;
                r.mensaje = "La cita ha sido eliminada";
                return Ok(r);
            }
            else
            {
                r.Ok = false;
                r.mensaje = "La cita no ha sido eliminada";
                return BadRequest(r);
            }
        }


        [HttpGet]
        [Route("api/getCitas")]
        public Object Get()
        {
            return context.Citas.ToList();
        }
    }
}
