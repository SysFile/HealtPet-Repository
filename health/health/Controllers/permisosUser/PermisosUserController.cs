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

namespace health.Controllers.permisosUser
{
    [ApiController]
    public class PermisosUserController : ControllerBase
    {
        private readonly AppDbContext context;
        public PermisosUserController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [Route("api/getPermisUsuarios")]
        public Object Get()
        {
            return context.PermisosUsuario.ToList();
        }
    }
}
