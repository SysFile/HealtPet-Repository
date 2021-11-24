using health.context;
using health.models.Pets;
using health.models.resp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public Object GetMascotas()
        {
            return context.PetsDetails.ToList();
        }

        [HttpGet]
        [Route("api/getMascotas/{id}")]
        public Object GetMascotasUsuario(int id)
        {
            return context.PetsDetails.Where(u => u.idUsuario == id); 

        }

        [HttpPost]
        [Route("api/registerMascotas")]
        public void registerMascotas([FromBody] Pets pets)
        {

            context.Mascotas.Add(pets);

        }



    }
}
