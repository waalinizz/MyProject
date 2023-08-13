
using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Add(Experience experience)
        {
            _experienceDal.Add(experience);
        }

        public void Delete(int id)
        {
            _experienceDal.Delete(GetById(id));
        }

        public Experience GetById(int id)
        {
            return _experienceDal.Get(e => e.ExperienceId == id);
        }

        public List<Experience> Getlist()
        {
            return _experienceDal.GetAll();
        }

        public void Update(Experience experience)
        {
            _experienceDal.Update(experience);
        }
    }
}
