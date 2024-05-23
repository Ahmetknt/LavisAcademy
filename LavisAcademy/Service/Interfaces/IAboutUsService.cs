using Core.Results;
using LavisAcademy.Entities;
using IResult = Core.Results.IResult;

namespace LavisAcademy.Service.Interfaces
{
    public interface IAboutUsService
    {
        IDataResult<List<AboutUs>> GetAll(); 
        IResult Add(AboutUs aboutUs);
        IResult Update(AboutUs aboutUs);
        IResult Delete(AboutUs aboutUs);
    }
}
