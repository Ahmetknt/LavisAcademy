using Core.Results;
using LavisAcademy.Models;
using IResult = Core.Results.IResult;

namespace LavisAcademy.Service.Interfaces
{
    public interface IPeriodService
    {
        IDataResult<List<Period>> GetAll();
        IDataResult<Period> GetById(int periodId);
        IResult Add(Period period);
        IResult Update(Period period);
        IResult Delete(Period period);
    }
}
