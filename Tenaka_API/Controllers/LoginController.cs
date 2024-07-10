using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using Tenaka_API.DBContext;
using Tenaka_API.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tenaka_API.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IConfiguration Configuration;
        private readonly ILogger<LoginController> _logger;
        private ApplicationDbContext Context { get; set; }

        public LoginController(IConfiguration configuration, ApplicationDbContext applicationDbContext, ILogger<LoginController> logger)
        {
            Configuration = configuration;
            Context = applicationDbContext;
            _logger = logger;
        }

        [Route("login")]
        [HttpPost]
        public Task<ActionResult> Login([FromBody] LoginModel login)
        {
            _logger.LogInformation("Login() called from: " + HttpContext.Connection.RemoteIpAddress.ToString());

            var received = new { Username = string.Empty, Password = string.Empty };

            //received = JsonConvert.DeserializeAnonymousType(login.ToString(Newtonsoft.Json.Formatting.None), received);

            return Task.FromResult<ActionResult>(new JsonResult(new
            {
                username = login.Username,
                description ="Successful",
                responsecode = Common.ResponseCodes.Successful,
                status = true
            })) ;
        }

           // GET: api/<LoginController>
           [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
