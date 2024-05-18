using LavisAcademy.Core;
using LavisAcademy.DataAccess;
using LavisAcademy.Models;
using LavisAcademy.Repositories.Interfaces;

namespace LavisAcademy.Repositories
{
    public class EducationCoachRepository : EfEntityRepositoryBase<EducationCoach, LavisContext>, IEducationCoachRepository
    {
    }
}
