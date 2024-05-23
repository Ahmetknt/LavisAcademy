using Core.Results;
using LavisAcademy.Entities;
using IResult = Core.Results.IResult;

namespace LavisAcademy.Service.Interfaces
{
    public interface IEducationService
    {
        IDataResult<List<Education>> GetAll();
        IDataResult<Education> GetById(int educationId);
        IResult Add(Education education);
        IResult Update(Education education);
        IResult Delete(Education education);
    }
}
