using DotNet6Api.Context;
using DotNet6Api.Interfaces.Manager;
using DotNet6Api.Models;
using DotNet6Api.Repository;
using EF.Core.Repository.Manager;

namespace DotNet6Api.Manager
{
    public class UserManager : CommonManager<User>, IUserManager
    {
        public UserManager(ApplicationDbContext _dbContext) : base(new UserRepository(_dbContext))
        {
        }

        public User GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
