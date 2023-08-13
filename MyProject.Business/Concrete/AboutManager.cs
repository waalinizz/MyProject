
using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
            _aboutDal.Add(about);
        }

        public void Delete(int id)
        {
            _aboutDal.Delete(GetById(id));
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(a => a.AboutId == id);
        }

        public List<About> Getlist()
        {
            return _aboutDal.GetAll();
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
