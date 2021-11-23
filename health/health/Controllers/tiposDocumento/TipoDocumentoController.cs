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

namespace health.Controllers.tipoDocumento
{
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly AppDbContext context;
        public TipoDocumentoController(AppDbContext context)
        {
            this.context = context;

        }

        [HttpGet]
        [Route("api/getTpDocumentos")]
        public Object Get()
        {
            return context.TiposDocumento.ToList();
        }
    }
}
