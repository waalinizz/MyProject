
using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Concrete
{
    public  class SkillTwoManager : ISkillTwoService
    {
        private ISkillTwoDal _skillTwoDal;
        public SkillTwoManager(ISkillTwoDal SkillTwoDal)
        {
            _skillTwoDal = SkillTwoDal;
        }

        public void Add(SkillTwo SkillTwo)
        {
            _skillTwoDal.Add(SkillTwo);
        }

        public void Delete(int id)
        {
            _skillTwoDal.Delete(GetById(id));
        }

        public SkillTwo GetById(int id)
        {
            return _skillTwoDal.Get(a => a.SkillTwoId == id);
        }

        public List<SkillTwo> Getlist()
        {
            return _skillTwoDal.GetAll();
        }

        public void Update(SkillTwo SkillTwo)
        {
            _skillTwoDal.Update(SkillTwo);
        }
    }
}
