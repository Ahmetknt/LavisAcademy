using LavisAcademy.Models.Interface;

namespace LavisAcademy.Models
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CommentContent { get; set; }
    }
}
