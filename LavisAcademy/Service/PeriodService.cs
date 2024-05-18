using Core.Results;
using LavisAcademy.Models;
using LavisAcademy.Repositories;
using LavisAcademy.Repositories.Interfaces;
using LavisAcademy.Service.Interfaces;
using System.ComponentModel.Design;
using IResult = Core.Results.IResult;

namespace LavisAcademy.Service
{
    public class PeriodService : IPeriodService
    {
        IPeriodRepository _periodRepository;

        public PeriodService(IPeriodRepository periodRepository)
        {
            _periodRepository = periodRepository;
        }

        public IResult Add(Period period)
        {
            _periodRepository.Add(period);
            return new SuccessResult("Süreç Eklendi");
        }

        public IResult Delete(Period period)
        {
            _periodRepository.Delete(period);
            return new SuccessResult("Süreç Silindi");
        }

        public IDataResult<List<Period>> GetAll()
        {
            return new SuccessDataResult<List<Period>>(_periodRepository.GetAll());
        }
        public IDataResult<Period> GetById(int periodId)
        {
            return new SuccessDataResult<Period>(_periodRepository.Get(p => p.Id == periodId));
        }

        public IResult Update(Period period)
        {
            _periodRepository.Update(period);
            return new SuccessResult("Süreç Güncellendi");
        }
    }
}
