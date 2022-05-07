using DotNet6Api.Models;
using EF.Core.Repository.Interface.Manager;

namespace DotNet6Api.Interfaces.Manager
{
    public interface IPostManager:ICommonManager<Post>
    {
        Post GetById(int id);
    }
}
