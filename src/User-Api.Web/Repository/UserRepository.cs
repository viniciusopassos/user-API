


namespace User_Api.Web.Repository
{
    public class UserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
    }
}