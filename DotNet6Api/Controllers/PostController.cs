using DotNet6Api.Context;
using DotNet6Api.Interfaces.Manager;
using DotNet6Api.Manager;
using DotNet6Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        //ApplicationDbContext _dbContext;
        IPostManager _postManager;
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
        public IActionResult GetAll()
        {
            try
            {
                var posts = _postManager.GetAll().ToList();
                return Ok(posts);
            }
            //var posts= _dbContext.Posts.ToList();
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("id")]
        public IActionResult GetById(int id)
        {
            try
            {
                var post = _postManager.GetById(id);
                if (post == null)
                {
                    return NotFound();
                }
                return Ok(post);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

        }

        [HttpPost]
        public IActionResult Add(Post post)
        {
            //post.CreateDate = DateTime.Now;
            //_dbContext.Posts.Add(post);
            //bool isSaved = _dbContext.SaveChanges() > 0;
            try
            {
                bool isSaved = _postManager.Add(post);
                if (isSaved)
                {
                    return Created("", post);
                }
                return BadRequest("Post saved Faield");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        public IActionResult Edit(Post post)
        {
            try
            {
                if (post.Id == 0)
                {
                    return BadRequest("Data does not found");
                }
                bool isUpdate = _postManager.Update(post);
                if (isUpdate)
                {
                    return Ok(post);
                }
                return BadRequest("Post Updated Faield");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            try
            {
                var post = _postManager.GetById(id);
                if (post == null)
                {
                    return NotFound();
                }
                bool isDelete = _postManager.Delete(post);
                if (isDelete)
                {
                    return Ok("Post has been deleted");
                }
                return BadRequest("deletef failed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        

    }
}
