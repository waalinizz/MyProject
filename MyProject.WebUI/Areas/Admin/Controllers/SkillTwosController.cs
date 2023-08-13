using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.Entities.Concrete;
using MyProject.WebUI.Areas.Admin.Models.SkillTwoModel;

namespace MyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillTwosController : Controller
    {
        private ISkillTwoService _skillTwoService;

        public SkillTwosController(ISkillTwoService skillTwoService)
        {
            _skillTwoService = skillTwoService;
        }

        public IActionResult Index()
        {
            var model = new SkillTwoListViewModel()
            {
                SkillTwos = _skillTwoService.Getlist()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new SkillTwoAddViewModel()
            {
                SkillTwo = new SkillTwo()
            };

            return View(model);
        }

        public IActionResult Add(SkillTwo skillTwo)
        {
            _skillTwoService.Add(skillTwo);
            return RedirectToAction("Index", "SkillTwos");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var skillTwoModel = _skillTwoService.GetById(id);
            _skillTwoService.Delete(skillTwoModel.SkillTwoId);

            return RedirectToAction("Index", "SkillTwos");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var skillTwoGetByIdModel = _skillTwoService.GetById(id);
            if (skillTwoGetByIdModel != null)
            {
                var model = new SkillTwoUpdateViewModel()
                {
                    SkillTwo = new SkillTwo
                    {
                        SkillTwoId = skillTwoGetByIdModel.SkillTwoId,
                        SkillItem = skillTwoGetByIdModel.SkillItem,
                        SkillItemPercent = skillTwoGetByIdModel.SkillItemPercent
                    }
                };
                return View(model);
            }
            return View();
        }
        public IActionResult Update(SkillTwo skillTwo)
        {
            _skillTwoService.Update(skillTwo);
            return RedirectToAction("Index", "SkillTwos", new { Area = "Admin" });
        }

    }
}
