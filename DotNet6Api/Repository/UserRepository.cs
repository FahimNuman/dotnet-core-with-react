using DotNet6Api.Interfaces.Repository;
using DotNet6Api.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotNet6Api.Repository
{
    public class UserRepository : CommonRepository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
