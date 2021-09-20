using Backend.DataStotore;
using Backend.models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HealdPetBack.Controllers
{

    [ApiController]
    [Route("app/users")]
    public class UserController : ControllerBase
    {
        [HttpGet("")]
        public JsonResult GetUsers()
        {
            return new JsonResult(UserDataStore.Current.Users);
        }


        [HttpPost("login")]
        public JsonResult LoginUser([FromBody] userDto request)
        {
            return new JsonResult(UserDataStore.Current.Users.FirstOrDefault(x => x.id == request.id));
        }
    }
}
