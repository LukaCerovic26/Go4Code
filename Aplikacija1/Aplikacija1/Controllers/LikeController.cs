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
        public class LikeController : ControllerBase
        {
            private readonly ILikeService _likeService;

            public LikeController(ILikeService likeService)
            {
                _likeService = likeService;
            }


            [HttpGet("{id}")]
            public ActionResult<Like> GetlikeById(int id)
            {
                var like = _likeService.GetLikeById(id);
                if (like == null)
                {
                    return NotFound();
                }
                return Ok(like);
            }

            [Authorize(Roles = Roles.User)]
            [HttpGet("LikesByUser/{id}")]
            public async Task<ActionResult<IEnumerable<Like>>> GetLikesByUser(int id)
            {
                var result = await _likeService.GetLikesByUser(id);

                return result is null ? NotFound() : Ok(result);
            }

            
            [HttpGet("LikesForPost/{id}")]
            public async Task<ActionResult<IEnumerable<Like>>> GetLikesForPost(int id)
            {
                var result = await _likeService.GetLikesForPost(id);

                return result is null ? NotFound() : Ok(result);
            }

            [Authorize(Roles = Roles.User)]
            [HttpPost]
            public async Task<ActionResult<Like>> Post(LikesCreateRequest like)
            {
                var result = await _likeService.CreateLike(like);
            return result;
            }

            [Authorize(Roles = Roles.User)]
            [HttpDelete]
            public async Task<ActionResult> Delete(LikesDeleteRequest request)
            {
                var result = await _likeService.DeleteLike(request);
                return result == false ? NotFound() : NoContent();
            }
        }
    }
