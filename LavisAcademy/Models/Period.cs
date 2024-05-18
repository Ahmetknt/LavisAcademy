using LavisAcademy.Models.Interface;

namespace LavisAcademy.Models
{
    public class Period : IEntity
    {
        public int Id { get; set; }
        public string PeriodPhoto { get; set; }
    }
}
