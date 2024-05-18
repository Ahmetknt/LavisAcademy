using LavisAcademy.Core;
using LavisAcademy.DataAccess;
using LavisAcademy.Models;
using LavisAcademy.Repositories.Interfaces;

namespace LavisAcademy.Repositories
{
    public class AboutRepository : EfEntityRepositoryBase<AboutUs, LavisContext>, IAboutRepository
    {
    }
}
