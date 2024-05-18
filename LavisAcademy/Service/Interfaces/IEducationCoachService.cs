using Core.Results;
using LavisAcademy.Models;
using IResult = Core.Results.IResult;

namespace LavisAcademy.Service.Interfaces
{
    public interface IEducationCoachService
    {
        IDataResult<List<EducationCoach>> GetAll();
        IDataResult<EducationCoach> GetById(int educationCoachId);
        IResult Add(EducationCoach educationCoach);
        IResult Update(EducationCoach educationCoach);
        IResult Delete(EducationCoach educationCoach);
    }
}
