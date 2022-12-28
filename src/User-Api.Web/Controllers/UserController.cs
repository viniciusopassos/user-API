using Microsoft.AspNetCore.Mvc;
using User_Api.Web.Models;
using User_Api.Web.Repository;

namespace User_Api.Web.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _repository;
        public UserController(UserRepository repository)
        {
            _repository = repository;
        }

        /// <summary> This function return all users </summary>
        /// <returns> A list of user </returns>
        [HttpGet(Name = "GetUsers")]
        public IActionResult Get()
        {
            IEnumerable<User> user = _repository.GetUsers();            
            return Ok(user);
        }

        /// <summary> This function return specific user </summary>
        /// <returns> The user according to the id </returns>
        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult Get(int id)
        {
            User user = _repository.GetUser(id);

            if (user == null) return NotFound();

            return Ok(user);
        }

        /// <summary> This function create a user </summary>
        /// <returns> A created user </returns>
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            _repository.AddUser(user);
            return CreatedAtRoute("GetUsers", user);
        }

        /// <summary> This function update a user </summary>
        /// <returns> A updated user </returns>
        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            _repository.UpdateUser(user);
            return Ok(user);
        }
        
        /// <summary> This function remove a user </summary>
        /// <returns> A removed user </returns>
        [HttpDelete("{id}")]
        public IActionResult RemoveUser(int id, User user)
        {
            var userById = _repository.GetUser(id);
            _repository.RemoveUser(id);
            return Ok(userById);
        }
    }
}