using System;
using Aplikacija1.Model;
using Aplikacija1.Service;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("{commentId}")]
        public ActionResult<Comment> GetCommentById(int commentId)
        {
            var comment = _commentService.GetCommentById(commentId);
            if (comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }

        // DODAJ AKCIJE (GetAllComments, AddComment, UpdateComment, DeleteComment)
    }
}

