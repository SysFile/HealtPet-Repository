using health.context;
using health.models.Pets;
using health.models.resp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace health.Controllers.pets
{
    
    [ApiController]
    [Authorize]
    public class PetController : ControllerBase
    {

        private readonly AppDbContext context;

        public PetController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("api/getListaMascotas")]
        public Object GetListaMascotas()
        {
            return context.Mascotas.ToList();
        }

        [HttpGet]
        [Route("api/getMascotas/{id}")]
        public Object GetMascotas(int id)
        {
            return context.PetsDetails.Where(u => u.idUsuario == id);
        }

        [HttpPost]
        [Route("api/registerMascota")]
        public Object RegisterMascota([FromBody] Pets pets)
        {
            Resp res = new Resp();

            res.Ok = false;

            try
            {

                if (pets != null)
                {
                    context.Mascotas.Add(pets);
                    context.SaveChanges();
                    res.Ok = true;
                    res.data = pets;
                    res.mensaje = "Registrado Exitosamente";
                }
                else
                {
                    res.mensaje = "Error Al Registrar";
                }
            }
            catch (Exception e)
            {
                res.mensaje = "Error El Servidor";
            }
            return res;
        }

        [HttpPut]
        [Route("api/updateMascota/{id}")]
        public object UpdateMascota([FromBody] Pets pets, int id)
        {
            Resp res = new Resp();
            res.Ok = false;
            try
            {
                if (id == pets.idMascota)
                {
                    context.Entry(pets).State = EntityState.Modified;
                    context.SaveChanges();
                    res.Ok = true;
                    res.data = pets;
                    res.mensaje = "Actualizado con exito";
                }
                else
                {
                    res.mensaje = "Error al actualizar";
                }
            }
            catch (Exception)
            {
                res.mensaje = "Error en el servidor";
            }
            return res;
        }

        [HttpDelete]
        [Route("api/deleteMascota/{id}")]
        public object DeleteMascota(int id)
        {
            Resp res = new Resp();
            res.Ok = false;
            try
            {

                var lst = context.Mascotas.SingleOrDefault(u => u.idMascota == id);

                if (lst != null)
                {
                    context.Mascotas.Remove(lst);
                    context.SaveChanges();
                    res.Ok = true;
                    res.data = lst;
                    res.mensaje = "Eliminado Con Exito";
                }
                else
                {
                    res.mensaje = "Error al Eliminar";
                }
            }
            catch (Exception)
            {
                res.mensaje = "Error en el servidor";
            }
            return res;
        }






    }
}
