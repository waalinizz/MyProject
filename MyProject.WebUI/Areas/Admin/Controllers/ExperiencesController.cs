using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.Entities.Concrete;
using MyProject.WebUI.Areas.Admin.Models.ExperienceModel;

namespace MyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperiencesController : Controller
    {
        private IExperienceService _experienceService;

        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            var model = new ExperienceListViewModel
            {
                Experiences = _experienceService.Getlist()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new ExperienceAddViewModel
            {
                Experience = new Experience()
            };

            return View(model);
        }

        public IActionResult Add(Experience experience)
        {
            _experienceService.Add(experience);
            return RedirectToAction("Index", "Experiences");
        }

        public IActionResult Delete(int id)
        {
            var experienceModel = _experienceService.GetById(id);
            _experienceService.Delete(id);
            return RedirectToAction("Index", "Experiences");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var experienceGetByIdModel = _experienceService.GetById(id);
            if (experienceGetByIdModel != null)
            {
                var model = new ExperienceUpdateViewModel
                {
                    Experience = new Experience()
                    {
                        ExperienceId= experienceGetByIdModel.ExperienceId,
                        Title= experienceGetByIdModel.Title,
                        Subtitle= experienceGetByIdModel.Subtitle,
                        Description= experienceGetByIdModel.Description,
                        Date = experienceGetByIdModel.Date
                    }
                };
                return View(model);
            }
            return View();
        }
        public IActionResult Update(Experience experience)
        {
            _experienceService.Update(experience);
            return RedirectToAction("Index", "Experiences", new { Areas = "Admin" });
        }
    }
}
