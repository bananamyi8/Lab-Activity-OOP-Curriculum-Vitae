using System.ComponentModel.DataAnnotations;

namespace CurriculumVitae.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public string Description { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
