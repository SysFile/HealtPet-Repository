﻿using health.context;
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
    [Route("api/[controller]")]
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
        public Object Get()
        {

            return context.Mascotas.ToList();

        }

    }
}