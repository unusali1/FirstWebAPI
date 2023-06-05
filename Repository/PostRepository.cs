using EF.Core.Repository.Repository;
using FirstWebAPI.Context;
using FirstWebAPI.Interfaces.Repository;
using FirstWebAPI.Models;

namespace FirstWebAPI.Repository
{
    public class PostRepository : CommonRepository<PostModel>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext) 
        {
            
        }


    }
}
