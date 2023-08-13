using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.Entities.Concrete;
using MyProject.WebUI.Areas.Admin.Models.ServiceModel;

namespace MyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var model = new ServiceListViewModel
            {
                Services = _serviceService.Getlist()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new ServiceAddViewModel
            {
                Service = new Service()
            };
            return View(model);
        }

        public IActionResult Add(Service service)
        {
            _serviceService.Add(service);
            return RedirectToAction("Index","Services"); // Services controlurun index metoduna git demek
        }

        public IActionResult Delete(int id)
        {
            var servisModel =_serviceService.GetById(id);
            _serviceService.Delete(servisModel.ServiceId);
            return RedirectToAction("Index", "Services");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var serviceGetByIdModel = _serviceService.GetById(id);
            if (serviceGetByIdModel!=null)
            {
                var model = new ServiceUpdateViewModel()
                {
                    Service = new Service
                    {
                        ServiceId = serviceGetByIdModel.ServiceId,
                        SoftwareArea = serviceGetByIdModel.SoftwareArea,
                        Address = serviceGetByIdModel.Address
                    }
                };
                return View(model);
            }
            return View();
        }
        public IActionResult Update(Service service)
        {
            _serviceService.Update(service);
            return RedirectToAction("Index", "Services", new { Area = "Admin" });
        }
    }
}
