using Microsoft.AspNetCore.Mvc;

namespace ActionsAPI.Controllers
{
    //[ApiController]
    //[RoutePrefix("api/")]
    public class MainController : ControllerBase
    {


        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("date")]
        public string GetDate()
        {
            return "It be : " + DateTime.Now;
        }

        [HttpGet]
        [Route("test")]
        public string Get()
        {
            return "It is : " + DateTime.Today;
        }

    }
}