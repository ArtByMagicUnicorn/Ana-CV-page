namespace Ana_CV_page.Models
{
    public class CvData
    {
        public Profile Profile { get; set; } = new();

        public List<Experience> Experiences { get; set; } = [];
        public List<Education> Education { get; set; } = [];
        public List<Skill> Skills { get; set; } = [];
        public List<Language> Languages { get; set; } = [];
        public List<Certification> Certifications { get; set; } = [];
        public BeyondTheNumbersData BeyondTheNumbers { get; set; } = new();
    }
}
