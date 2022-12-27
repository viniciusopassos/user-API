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
        public IActionResult GetUsers()
        {
            IEnumerable<User> user = _repository.GetUsers();            
            return Ok(user);
        }
    }
}