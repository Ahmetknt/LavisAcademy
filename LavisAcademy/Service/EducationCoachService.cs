using Core.Results;
using LavisAcademy.Entities;
using LavisAcademy.Repositories;
using LavisAcademy.Repositories.Interfaces;
using LavisAcademy.Service.Interfaces;
using System.ComponentModel.Design;
using IResult = Core.Results.IResult;
namespace LavisAcademy.Service;

public class EducationCoachService : IEducationCoachService
{

    IEducationCoachRepository _educationCoachRepository;

    public EducationCoachService(IEducationCoachRepository educationCoachRepository)
    {
        _educationCoachRepository = educationCoachRepository;
    }

    public IResult Add(EducationCoach educationCoach)
    {
        _educationCoachRepository.Add(educationCoach);
        return new SuccessResult("Eğitim Koçu Eklendi.");
    }

    public IResult Delete(EducationCoach educationCoach)
    {
        _educationCoachRepository.Delete(educationCoach);
        return new SuccessResult("Eğitim Koçu Silindi.");
    }

    public IDataResult<List<EducationCoach>> GetAll()
    {
        return new SuccessDataResult<List<EducationCoach>>(_educationCoachRepository.GetAll());
    }

    public IDataResult<EducationCoach> GetById(int educationCoachId)
    {
        return new SuccessDataResult<EducationCoach>(_educationCoachRepository.Get(e => e.Id == educationCoachId));
    }

    public IResult Update(EducationCoach educationCoach)
    {
        _educationCoachRepository.Update(educationCoach);
        return new SuccessResult("Eğitim Koçu Güncellendi");
    }
}
