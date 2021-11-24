using health.context;
using health.models;
using health.models.login;
using health.models.resp;
using health.models.settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace health.Controllers.login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly AppDbContext context;
        private readonly AppSettings _appSettings;
        public LoginController(AppDbContext context, IOptions<AppSettings> appSettings)
        {
            this.context = context;
            _appSettings = appSettings.Value;
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        public Resp Auth([FromBody] Login login)
        {
            Resp r = new Resp();
            r.Ok = false;
            try
            {
                User lst = context.Usuarios.SingleOrDefault(u => u.correo == login.usuario && u.contraseña == login.password);

                if (lst != null)
                {
                    var token = GenerateToken(lst.correo);
                    r.Ok = true;
                    r.mensaje = lst.correo;
                    Dictionary<string, string> tokenData = new Dictionary<string, string>
                    {
                        { "token", token }
                    };
                    r.data = tokenData;
                }
                else
                {
                    r.mensaje = "Datos incorrectos";
                }
            }
            catch (Exception ex)
            {
                r.mensaje = "Ocurrio un error en el servidor";
            }

            return r;
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public String GenerateToken(String usuario)
        {
            var detalleUsuario = context.Usuarios.SingleOrDefault(x => x.correo == usuario);

            if (detalleUsuario == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                NotBefore = DateTime.Now,
                Expires = DateTime.Now.AddMinutes(_appSettings.ExpiracionJWT),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var creacionToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(creacionToken);
            return token.ToString();
        }
    }
}
