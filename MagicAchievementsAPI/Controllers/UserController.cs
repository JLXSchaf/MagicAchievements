using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicAchievementsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;

        public UserController(IWebHostEnvironment env)
        {
            _env = env;
        }

        // GET: api/<UserController>
        [HttpGet]
        public string Get()
        {
            // C:\Users\janni\source\repos\MagicAchievements\MagicAchievementsAPI
            var path = Path.Combine(_env.WebRootPath, "data.txt");
            Debug.WriteLine(path.GetType());
            var a = path.GetType();
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.WriteAllText(path, "Testuser,1.1.1,");
            }
            return System.IO.File.ReadAllText(path);
        }

        // GET api/<UserController>/id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
