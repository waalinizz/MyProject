using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Concrete
{
    public class ExperienceTwoManager : IExperienceTwoService
    {
        IExperienceTwoDal _experienceTwoDal;
        public ExperienceTwoManager(IExperienceTwoDal experienceTwoDal)
        {
            _experienceTwoDal = experienceTwoDal;
        }
    public void Add(ExperienceTwo experienceTwo)
        {
        _experienceTwoDal.Add(experienceTwo);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ExperienceTwo GetById(int id)
        {
            return _experienceTwoDal.Get(e => e.ExperienceTwoId == id);
        }

        public List<ExperienceTwo> Getlist()
        {
            return _experienceTwoDal.GetAll();
        }

        public void Update(ExperienceTwo experienceTwo)
        {
            _experienceTwoDal.Update(experienceTwo);
        }
    }
}
