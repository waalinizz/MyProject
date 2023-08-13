using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.Entities.Concrete;
using MyProject.WebUI.Areas.Admin.Models.ExperienceTwoModel;

namespace MyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceTwosController : Controller
    {
        private IExperienceTwoService _experienceTwoService;

        public ExperienceTwosController(IExperienceTwoService experienceTwoService)
        {
            _experienceTwoService = experienceTwoService;
        }

        public IActionResult Index()
        {
            var model = new ExperienceTwoListViewModel()
            {
                ExperienceTwos = _experienceTwoService.Getlist()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new ExperienceTwoAddViewModel()
            {
                ExperienceTwo = new ExperienceTwo()
            };

            return View(model);
        }

        public IActionResult Add(ExperienceTwo experienceTwo)
        {
            _experienceTwoService.Add(experienceTwo);
            return RedirectToAction("Index", "ExperienceTwos");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var experienceTwoModel = _experienceTwoService.GetById(id);
            _experienceTwoService.Delete(id);
            return RedirectToAction("Index", "ExperienceTwos");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var experienceGetbyIdModel = _experienceTwoService.GetById(id);
            if (experienceGetbyIdModel != null)
            {
                var model = new ExperienceTwoUpdateViewModel
                {
                    ExperienceTwo = new ExperienceTwo()
                    {
                        ExperienceTwoId = experienceGetbyIdModel.ExperienceTwoId,
                        Title = experienceGetbyIdModel.Title,
                        Subtitle = experienceGetbyIdModel.Subtitle,
                        Date = experienceGetbyIdModel.Date,
                        Description = experienceGetbyIdModel.Description
                    }

                };
                return View(model);
            };
            return View();
        }

        public IActionResult Update(ExperienceTwo experienceTwo)
        {
            _experienceTwoService.Update(experienceTwo);
            return RedirectToAction("Index", "ExperienceTwos", new { Areas = "Admin"});
        }

    }
}
