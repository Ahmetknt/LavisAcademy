using Core.Results;
using LavisAcademy.Entities;
using IResult = Core.Results.IResult;
namespace LavisAcademy.Service.Interfaces
{
    public interface ICommentService
    {
        IDataResult<List<Comment>> GetAll();
        IDataResult<Comment> GetById(int commentId);
        IResult Add(Comment comment);
        IResult Update(Comment comment);
        IResult Delete(Comment comment);
    }
}
