using System.Collections.Generic;
using System.Threading.Tasks;
using XamSkillsForms.Models;

namespace XamSkillsForms.Services
{
    public class UserService : IUserService
    {
        private static readonly IEnumerable<User> Users = new[]
        {
            new User { FirstName = "John", LastName = "Doe" },
            new User { FirstName = "Mary", LastName = "McGuire" },
            new User { FirstName = "Dolores", LastName = "Vernon" },
        };

        public async Task<IEnumerable<User>> GetUsers()
        {
            await Task.Delay(1000);

            return await Task.FromResult(Users);
        }
    }

    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
    }
}