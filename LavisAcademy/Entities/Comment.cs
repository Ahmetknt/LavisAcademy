using LavisAcademy.Entities.Interface;

namespace LavisAcademy.Entities
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CommentContent { get; set; }
    }
}
