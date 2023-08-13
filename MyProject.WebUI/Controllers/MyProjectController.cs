using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.WebUI.Models;

namespace MyProject.WebUI.Controllers
{
    public class MyProjectController : Controller
    {
        private IAboutService _aboutService;
        private IContactService _contactService;
        private IPortfolioService _portfolioService;
        private IExperienceService _experienceService;
        private IServiceService _serviceservice;
        private ISkillService _skillService;
        private ISkillTwoService _skillTwoService;
        private ISocialMediaService _socialMediaService;
        private IExperienceTwoService _experienceTwoService;

        public MyProjectController(IAboutService aboutService, IContactService contactService, IPortfolioService portfolioService, IExperienceService experienceService, IServiceService serviceservice, ISkillService skillService, ISocialMediaService socialMediaService, ISkillTwoService skillTwoService, IExperienceTwoService experienceTwoService)
        {
            _aboutService = aboutService;
            _contactService = contactService;
            _portfolioService = portfolioService;
            _experienceService = experienceService;
            _serviceservice = serviceservice;
            _skillService = skillService;
            _socialMediaService = socialMediaService;
            _skillTwoService = skillTwoService;
            _experienceTwoService = experienceTwoService;
        }

        public IActionResult Index()
        {
            var model = new MyProjectListViewModel
            {
                Abouts = _aboutService.Getlist(),
                Contacts = _contactService.Getlist(),
                Portfolios = _portfolioService.Getlist(),
                Experiences = _experienceService.Getlist(),
                ExperienceTwos = _experienceTwoService.Getlist(),
                Services = _serviceservice.Getlist(),
                Skills = _skillService.Getlist(),
                SocialMedias = _socialMediaService.Getlist(),
                SkillTwos = _skillTwoService.Getlist()

            };
            return View(model);
        }
    }
}
