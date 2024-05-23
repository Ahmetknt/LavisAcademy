using LavisAcademy.Entities.Interface;

namespace LavisAcademy.Entities
{
    public class Education : IEntity
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string Content { get; set; }
        public string PurchaseLink { get; set; }

    }
}
