using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.Entities.Concrete;
using MyProject.WebUI.Areas.Admin.Models.AboutModel;

namespace MyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutsController : Controller
    {
        
        IAboutService _aboutService;
        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IActionResult Index()
        {
            var model = new AboutListViewModel()
            {
                Abouts = _aboutService.Getlist()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var modelGetByIdAbout = _aboutService.GetById(id);
            if (modelGetByIdAbout != null)
            {
                var model = new AboutUpdateViewModel
                {
                    About = new About
                    {
                        AboutId = modelGetByIdAbout.AboutId,
                        FirstEmail = modelGetByIdAbout.FirstEmail,
                        FirstName = modelGetByIdAbout.FirstName,
                        LastName = modelGetByIdAbout.LastName,
                        Description = modelGetByIdAbout.Description,
                        Age = modelGetByIdAbout.Age,
                        SecondEmail = modelGetByIdAbout.SecondEmail,
                        Address = modelGetByIdAbout.Address,
                        Phone = modelGetByIdAbout.Phone,
                        SoftwareArea = modelGetByIdAbout.SoftwareArea
                    }
                };
                return View(model);
            }
            return View();
        }
        public IActionResult Update(About about)
        {
            _aboutService.Update(about);
            return RedirectToAction("Index", "Abouts", new { Areas = "Admin" });
        }
    }
}
