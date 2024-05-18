using Core.Results;
using LavisAcademy.Models;
using LavisAcademy.Repositories;
using LavisAcademy.Repositories.Interfaces;
using LavisAcademy.Service.Interfaces;
using IResult = Core.Results.IResult;
namespace LavisAcademy.Service
{
    public class AboutUsService : IAboutUsService
    {
        IAboutRepository _aboutRepository;

        public AboutUsService(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public IResult Add(AboutUs aboutUs)
        {
            _aboutRepository.Add(aboutUs);
            return new SuccessResult("Hakkımda Eklendi");
        }

        public IResult Delete(AboutUs aboutUs)
        {
            _aboutRepository.Delete(aboutUs);
            return new SuccessResult("Hakkımda Silindi");
        }

        public IDataResult<List<AboutUs>> GetAll()
        {
            return new SuccessDataResult<List<AboutUs>>(_aboutRepository.GetAll());
        }

        public IResult Update(AboutUs aboutUs)
        {
            _aboutRepository.Update(aboutUs);
            return new SuccessResult("Hakkımda Güncellendi");
        }
    }
}
