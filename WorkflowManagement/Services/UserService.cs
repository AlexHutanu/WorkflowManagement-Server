using WorkflowManagement.Interfaces;
using WorkflowManagement.Repositories;

namespace WorkflowManagement.Services
{
    public class UserService: IService<User>
    {
        private UserRepository _userRepository;

        public UserService()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

            _userRepository = new UserRepository(new ApplicationDbContext(contextOptions));
        }

        public User Create(User data)
        {
            return _userRepository.Create(data);
        }

        public User Find(string username)
        {
            return _userRepository.FindOneByName(username);
        }
    }
}
