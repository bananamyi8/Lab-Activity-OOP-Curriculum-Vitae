using System.ComponentModel.DataAnnotations;

namespace CurriculumVitae.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Summary { get; set; }

        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public ICollection<Education> Educations { get; set; } = new List<Education>();
        public string Skills { get; set; }
    }
}
