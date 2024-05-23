using Core.Results;
using LavisAcademy.Entities;
using LavisAcademy.Entities;
using LavisAcademy.Repositories;
using LavisAcademy.Repositories.Interfaces;
using LavisAcademy.Service.Interfaces;
using System.ComponentModel.Design;
using IResult = Core.Results.IResult;

namespace LavisAcademy.Service
{
    public class EducationService : IEducationService
    {
        IEducationRepository _educationRepository;

        public EducationService(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }

        public IResult Add(Education education)
        {
            _educationRepository.Add(education);
            return new SuccessResult("Eğitim Eklendi");
        }

        public IResult Delete(Education education)
        {
            _educationRepository.Delete(education);
            return new SuccessResult("Eğitim Silindi");
        }

        public IDataResult<List<Education>> GetAll()
        {
            return new SuccessDataResult<List<Education>>(_educationRepository.GetAll());
        }
        public IDataResult<Education> GetById(int educationId)
        {
            return new SuccessDataResult<Education>(_educationRepository.Get(e => e.Id == educationId));
        }

        public IResult Update(Education education)
        {
            _educationRepository.Update(education);
            return new SuccessResult("Eğitim Güncellendi");
        }
    }
}
