using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;
using Aplikacija1.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [Authorize(Roles = Roles.User)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostsGetDetailsResponse>>> Get([FromQuery] string search)
        {
            var result = await _postService.GetAsync();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public ActionResult<Post> GetPostById(int id)
        {
            var post = _postService.GetDetailsAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [Authorize(Roles = Roles.User)]
        [HttpGet("Details/{id}")]
        public async Task<ActionResult<PostsGetDetailsResponse>> GetDetails(int id)
        {
            var result = await _postService.GetDetailsAsync(id);

            return result is null ? NotFound() : Ok(result);
        }

        [Authorize(Roles = Roles.User)]
        [HttpPost]
        public async Task<ActionResult<PostsGetDetailsResponse>> Post(PostsCreateRequest post)
        {
            var result = await _postService.CreateAsync(post);

            return CreatedAtAction(nameof(GetDetails), new { id = result.Id }, result);
        }

        [Authorize(Roles = Roles.User)]
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _postService.DeleteAsync(id);

            return result == false ? NotFound() : NoContent();
        }
    }
}

