using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicAchievementsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicAchievementsController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;

        public MagicAchievementsController(IWebHostEnvironment env)
        {
            _env = env;
        }

        // GET: api/<MagicAchievementsController>
        [HttpGet]
        public string Get()
        {
            // C:\Users\janni\source\repos\MagicAchievements\MagicAchievementsAPI
            var path = Path.Combine(_env.WebRootPath, "data.txt");
            Console.WriteLine("Test", path);
            if (!System.IO.File.Exists(path)) {
                return "Datei nicht gefunden";
            }
            return System.IO.File.ReadAllText(path);
        }


        // GET api/<MagicAchievementsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MagicAchievementsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }


        // DELETE api/<MagicAchievementsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
