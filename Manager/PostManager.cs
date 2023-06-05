using EF.Core.Repository.Manager;
using FirstWebAPI.Context;
using FirstWebAPI.Interfaces.Manager;
using FirstWebAPI.Models;
using FirstWebAPI.Repository;

namespace FirstWebAPI.Manager
{
    public class PostManager : CommonManager<PostModel>, IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {
            
        }

        public PostModel GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
