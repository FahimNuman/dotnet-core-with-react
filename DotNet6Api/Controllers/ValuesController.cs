using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       // [Route("action")]
        [HttpGet]
        public string GetName()
        {
            return "test";
        }
        //[Route("action")]
        [HttpGet]
        public string GetFullName()
        {
            return "test case";
        }
    }
}
