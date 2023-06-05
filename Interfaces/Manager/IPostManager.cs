using EF.Core.Repository.Interface.Manager;
using FirstWebAPI.Models;

namespace FirstWebAPI.Interfaces.Manager
{
    public interface IPostManager : ICommonManager<PostModel>
    {
        PostModel GetById(int id);

    }
}
