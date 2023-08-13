using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.Entities.Concrete;
using MyProject.WebUI.Areas.Admin.Models.PortfolioModel;

namespace MyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfoliosController : Controller
    {
        private IPortfolioService _portfolioService;
        public PortfoliosController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            var model = new PortfolioListViewModel()
            {
                Portfolios = _portfolioService.Getlist()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new PortfolioAddViewModel()
            {
                Portfolio = new Portfolio()
            };
            return View(model);
        }
        public IActionResult Add(Portfolio portfolio)
        {
            _portfolioService.Add(portfolio);
            return RedirectToAction("Index", "Portfolios");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var portfolioModel = _portfolioService.GetById(id);
            _portfolioService.Delete(portfolioModel.PortfolioId);
            return RedirectToAction("Index", "Portfolios");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var portfolioGetByIdModel= _portfolioService.GetById(id);
            if (portfolioGetByIdModel!=null)
            {
                var model = new PortfolioUpdateViewModel()
                {
                    Portfolio = new Portfolio
                    {
                        PortfolioId = portfolioGetByIdModel.PortfolioId,
                        PortfolioName = portfolioGetByIdModel.PortfolioName,
                        PortfolioLink = portfolioGetByIdModel.PortfolioLink
                    }
                };
                return View(model);
            }
            return View();
        }
        public IActionResult Update(Portfolio portfolio)
        {
            _portfolioService.Update(portfolio);
            return RedirectToAction("Index", "Portfolios", new { Area = "Admin" });
        }
    }
}
