using System;
using Aplikacija1.Model;
using Aplikacija1.Service;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("{postId}")]
        public ActionResult<Post> GetPostById(int postId)
        {
            var post = _postService.GetPostById(postId);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        // OSTALE AKCIJE (GetAllPosts, AddPost, UpdatePost, DeletePost)
    }
}

