using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace UserAPI.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //private readonly IBus _bus;
        private readonly IConfiguration _config;
        public ValuesController( IConfiguration config)
        {
            //_bus = bus;
            _config = config;
        }


        // GET 
        [HttpGet("/api/user")]
        public ActionResult<string> UserApi()
        {
            string data = "[{\"id\":1,\"firstname\":\"John\",\"lastname\":\"smith\",\"address\":\"35 avenue road\",\"contact\":\"1125-4569873\",\"email\":\"john.smith@example.com\"},{\"id\":2,\"firstname\":\"jane\",\"lastname\":\"smdoeith\",\"address\":\"35 avenue road\",\"contact\":\"1125-4569873\",\"email\":\"john.smith@example.com\"},{\"id\":3,\"firstname\":\"John\",\"lastname\":\"smith\",\"address\":\"35 avenue road\",\"contact\":\"1125-4569873\",\"email\":\"john.smith@example.com\"},{\"id\":4,\"firstname\":\"John\",\"lastname\":\"smith\",\"address\":\"35 avenue road\",\"contact\":\"1125-4569873\",\"email\":\"john.smith@example.com\"}]";
            return data;
        }

        // GET
        [HttpGet("/api/auth")]
        [Authorize]
        public ActionResult<string> Auth()
        {
            string data = "Authenticated";
            return data;
        }


    }
}
