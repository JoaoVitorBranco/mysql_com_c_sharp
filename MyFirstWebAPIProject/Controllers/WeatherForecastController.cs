using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from your API!");
        }


        [HttpGet("user/{id}")]
        public IActionResult GetUser(int id)
        {
            RepoMock repo = new RepoMock();
            return Ok($"User ID: {repo.returnItem(id)}");
        }
    }
}