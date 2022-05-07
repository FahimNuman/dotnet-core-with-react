using DotNet6Api.Context;
using DotNet6Api.Interfaces.Manager;
using DotNet6Api.Models;
using DotNet6Api.Repository;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace DotNet6Api.Manager
{
    public class PostManager : CommonManager<Post>, IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {
        }

        public Post GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
