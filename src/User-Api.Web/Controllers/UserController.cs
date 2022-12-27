using Microsoft.AspNetCore.Mvc;
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
    }
}