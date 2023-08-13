
using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill skill)
        {
            _skillDal.Add(skill);
        }

        public void Delete(int id)
        {
            _skillDal.Delete(GetById(id));
        }

        public Skill GetById(int id)
        {
            return _skillDal.Get(s => s.SkillId == id);
        }

        public List<Skill> Getlist()
        {
            return _skillDal.GetAll();
        }

        public void Update(Skill skill)
        {
            _skillDal.Update(skill);
        }
    }
}
