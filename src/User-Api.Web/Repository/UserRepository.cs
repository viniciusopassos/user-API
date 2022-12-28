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
        public User GetUser(int id)
        {
            return _context.Users.Find(id);
        }
        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }
        public User UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();

            return user;
        }
        public User RemoveUser(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();

            return user;
        }
    }
}