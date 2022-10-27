using BasicAPI.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        List<User> users = new List<User>
        {
            new User(1, "Luan", "luan@ndd.com", "luan123"),
            new User(2, "Carlos", "carlos@ndd.com", "carlos123"),
            new User(3, "Lucas", "lucas@ndd.com", "lucas123")
        };

        // GET: api/user
        [HttpGet]
        public IActionResult Get()
        {
            var result = new OkObjectResult(new { message = "200 OK", currentDate = DateTime.Now });
            return result;
        }

        // GET api/user/2
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            User user = users.Find(u => u.ID == id);
            return user;
        }

        // POST api/user
        [HttpPost]
        public List<User> Post([FromBody] User user)
        {
            users.Add(user);
            return users;
        }

        // PUT api/user/3
        [HttpPut("{id}")]
        public List<User> Put(int id, [FromBody] User user)
        {
            User userToUpdate = users.Find(u => u.ID == id);
            int index = users.IndexOf(userToUpdate);

            users[index].Name = user.Name;
            users[index].Email = user.Email;
            users[index].Password = user.Password;

            return users;
        }

        // DELETE api/user/2
        [HttpDelete("{id}")]
        public List<User> Delete(int id)
        {
            User user = users.Find(u => u.ID == id);
            users.Remove(user);
            return users;
        }
    }
}
