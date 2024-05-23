using Core.Results;
using LavisAcademy.Entities;
using LavisAcademy.Repositories.Interfaces;
using LavisAcademy.Service.Interfaces;
using IResult = Core.Results.IResult;

namespace LavisAcademy.Service
{
    public class CommentService : ICommentService
    {
        ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IResult Add(Comment comment)
        {
            _commentRepository.Add(comment);
            return new SuccessResult("Yorum Eklendi");
        }

        public IResult Delete(Comment comment)
        {
            _commentRepository.Delete(comment);
            return new SuccessResult("Yorum Silindi");
        }

        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(_commentRepository.GetAll());
        }

        public IDataResult<Comment> GetById(int commentId)
        {
            return new SuccessDataResult<Comment>(_commentRepository.Get(c=>c.Id == commentId));
        }

        public IResult Update(Comment comment)
        {
            _commentRepository.Update(comment);
            return new SuccessResult("Yorum Güncellendi");
        }
    }
}
