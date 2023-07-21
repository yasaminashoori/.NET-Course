using System;
using Microsoft.AspNetCore.Mvc;

namespace migrate_to_asp_net.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello From Get";
        }
        public string Get1()
        {
            return "Hello From Get1";
        }
    }
}
