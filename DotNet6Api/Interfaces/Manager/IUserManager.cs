using DotNet6Api.Models;
using EF.Core.Repository.Interface.Manager;

namespace DotNet6Api.Interfaces.Manager
{
    public interface IUserManager : ICommonManager<User>
    {
        User GetById(int id);
    }
}
