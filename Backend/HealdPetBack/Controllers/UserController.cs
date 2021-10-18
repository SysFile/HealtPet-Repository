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

            var user = UserDataStore.Current.Users.FirstOrDefault(x => x.email == request.email && x.password == request.password); ;
            var id = 0;

            if (user == null) { 

                return new JsonResult(NotFound());
            }
            else
            {
                id = user.id;
                return new JsonResult("Login Succesfuly");
            }
                
        }
    }
}
