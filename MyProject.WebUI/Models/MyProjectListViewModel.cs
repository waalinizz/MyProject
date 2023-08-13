using MyProject.Entities.Concrete;
using System.Collections.Generic;

namespace MyProject.WebUI.Models
{
    public class MyProjectListViewModel
    {
        public List<About> Abouts { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<ExperienceTwo> ExperienceTwos { get; set; }
        public List<Service> Services { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
        public List<Skill> Skills { get; set; }
        public List<SkillTwo> SkillTwos { get; set; }
    }
}
