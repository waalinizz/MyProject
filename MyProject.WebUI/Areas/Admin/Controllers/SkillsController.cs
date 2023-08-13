using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.Entities.Concrete;
using MyProject.WebUI.Areas.Admin.Models.SkillModel;
using Newtonsoft.Json.Schema;

namespace MyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillsController : Controller
    {
        private ISkillService _skillService;

        public SkillsController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var model = new SkillListViewModel()
            {
                Skills = _skillService.Getlist()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new SkillAddViewModel()
            {
                Skill = new Skill()
            };

            return View(model);
        }

        public IActionResult Add(Skill skill)
        {
            _skillService.Add(skill);
            return RedirectToAction("Index", "Skills");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var skillModel = _skillService.GetById(id);
            _skillService.Delete(skillModel.SkillId);

            return RedirectToAction("Index", "Skills");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var skillGetByIdModel = _skillService.GetById(id);
            if (skillGetByIdModel!=null)
            {
                var model = new SkillUpdateViewModel
                {
                    Skill = new Skill()
                    {
                        SkillId = skillGetByIdModel.SkillId,
                        SkillItem = skillGetByIdModel.SkillItem,
                        SkillItemPercent = skillGetByIdModel.SkillItemPercent
                    }
                };
                return View(model);
            }
            return View();
        }
        public IActionResult Update(Skill skill)
        {
            _skillService.Update(skill);
            return RedirectToAction("Index", "Skills", new { Areas = "Admin" });
        }
    }
}
