using System.ComponentModel.DataAnnotations;

namespace CurriculumVitae.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Institution { get; set; }
        public string Degree { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
