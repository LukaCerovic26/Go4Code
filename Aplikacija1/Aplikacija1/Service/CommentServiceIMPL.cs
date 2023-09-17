using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;
using Aplikacija1.Repository;
using AutoMapper;

namespace Aplikacija1.Service

{
    public class CommentServiceIMPL : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentServiceIMPL(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task<CommentsGetDetailsResponse> CreateAsync(CommentsCreateRequest comment)
        {
            var commentEntity = _mapper.Map<Comment>(comment);
            var result = await _commentRepository.Create(commentEntity);

            return _mapper.Map<CommentsGetDetailsResponse>(result);
            
        }

       public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _commentRepository.Get(id);
            if (exists == null)
            {
                return false;
            }
            await _commentRepository.Delete(exists);
            return true;

        }

        public async Task<IEnumerable<CommentsGetDetailsResponse>> GetAsync()
        {
            var comments = await _commentRepository.GetAll();
            return _mapper.Map<IEnumerable<CommentsGetDetailsResponse>>(comments);
        }

        public async Task<CommentsGetDetailsResponse> GetDetailsAsync(int id)
        {
            var comment = await _commentRepository.Get(id);
            if (comment == null)
                return null;

            return _mapper.Map<CommentsGetDetailsResponse>(comment);

        }
    }
}

