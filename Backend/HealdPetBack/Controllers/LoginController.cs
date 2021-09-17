using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HealdPetBack.Controllers
{

    [ApiController]
    [Route("app")]
    public class LoginController : ControllerBase
    {
        [HttpGet("login")]
        public JsonResult Login()
        {
            return new JsonResult(
                new List<object>(){
                new {id=1,Name="uno"},
                new {id=2,Name="dos"}
                }
            );
        }
    }
}
