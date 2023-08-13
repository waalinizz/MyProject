
using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;
        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Add(Portfolio portfolio)
        {
            _portfolioDal.Add(portfolio);
        }

        public void Delete(int id)
        {
            _portfolioDal.Delete(GetById(id));
        }

        public Portfolio GetById(int id)
        {
            return _portfolioDal.Get(p => p.PortfolioId == id);
        }

        public List<Portfolio> Getlist()
        {
            return _portfolioDal.GetAll();
        }

        public void Update(Portfolio portfolio)
        {
            _portfolioDal.Update(portfolio);
        }
    }
}
