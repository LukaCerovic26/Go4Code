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
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [Authorize(Roles.User)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentsGetDetailsResponse>>> Get([FromQuery] string search)
        {
            var result = await _commentService.GetAsync();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public ActionResult<Comment> GetCommentById(int id)
        {
            var comment = _commentService.GetDetailsAsync(id);
            if(comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }

        [Authorize(Roles = Roles.User)]
        [HttpGet("Details/{id}")]
        public async Task<ActionResult<CommentsGetDetailsResponse>> GetDetails(int id)
        {
            var result = await _commentService.GetDetailsAsync(id);

            return result is null ? NotFound() : Ok(result);
        }

        [Authorize(Roles = Roles.User)]
        [HttpPost]
        public async Task<ActionResult<CommentsGetDetailsResponse>> Post(CommentsCreateRequest comment)
        {
            var result = await _commentService.CreateAsync(comment);
            return CreatedAtAction(nameof(GetDetails), new { id = result.Id }, result);
        }

        [Authorize(Roles = Roles.User)]
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _commentService.DeleteAsync(id);
            return result == false ? NotFound() : NoContent();
        }
    }
}
