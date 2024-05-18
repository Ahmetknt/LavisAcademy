using LavisAcademy.Models.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace LavisAcademy.Models
{
    public class AboutUs : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PluginHeader { get; set; }
        public string PluginDescription { get; set; }
        public string AboutUsPhoto { get; set; }
    }
}
