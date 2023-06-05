using FirstWebAPI.Context;
using FirstWebAPI.Interfaces.Manager;
using FirstWebAPI.Manager;
using FirstWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        //ApplicationDbContext _dbContext;
        private readonly IPostManager _postManager;

        //PostManager  _postManager;
        //public PostController(ApplicationDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //    _postManager = new PostManager(dbContext);
        //}

        public PostController(IPostManager postManager)
        {
            _postManager = postManager;
        }

        [HttpGet]
        public List<PostModel> GetAll()
        {
            //var posts = _dbContext.Posts.ToList();
            var posts = _postManager.GetAll().ToList();
            return posts;
        }

        [HttpGet("id")]
        public PostModel GetById(int id)
        {
            var post = _postManager.GetById(id);
            return post;
        }

        [HttpPost]
        public PostModel Add(PostModel post)
        {
              post.CreatedDate = DateTime.Now;
            bool isSaved = _postManager.Add(post);
            //_dbContext.Posts.Add(post);
            //bool isSaved = _dbContext.SaveChanges() > 0;
            if(isSaved)
            {
                return post;
            }
            return post;
        }

        [HttpPut]

        public PostModel Edit(PostModel post)
        {
            if (post.Id == 0)
            {
                return null;
            }

            bool isUpdate = _postManager.Update(post);
            if (isUpdate)
            {
                return post;
            }
            return post;
        }

        [HttpDelete("id")]
        public string Delete(int id)
        {
            var post = _postManager.GetById(id);
            if(post == null)
            {
                return "Not Found";
            }
            bool isDelete = _postManager.Delete(post);
            if(isDelete)
            {
                return "Post Has been delete ";
            }

            return "Post Is not deleted";

        }
       
    }
}
