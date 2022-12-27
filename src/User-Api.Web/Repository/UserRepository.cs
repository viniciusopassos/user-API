using User_Api.Web.Models;

namespace User_Api.Web.Repository
{
    public class UserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users;
        }
    }
}