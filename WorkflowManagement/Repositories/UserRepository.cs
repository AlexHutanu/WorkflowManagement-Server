using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Repositories
{
    public class UserRepository : IRepository<User>
    {

        private ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) 
        {
            _context= context;
        }
        public User Create(User userData)
        {
            User user = new()
            {
                Name = userData.Name,
                Email = userData.Email,
                Password = userData.Password,
            };

            _context.User.Add(user);
            _context.SaveChanges();

            return user;
        }

        public IEnumerable<User> Find()
        {
            throw new NotImplementedException();
        }

        public User FindOneByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
