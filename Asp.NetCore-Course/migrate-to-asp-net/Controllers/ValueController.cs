using System;
using Microsoft.AspNetCore.Mvc;

namespace migrate_to_asp_net.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        [Route("get-all-books")]
        public string GetAll(int list, string listname)
        {
            return "Hello All Books: " + list + "name :" + listname;
        }
        [Route("get-book/{id}")]
        public string GetSingle(int id)
        {
            return "Hello single book" + id;
        }
    }
}
