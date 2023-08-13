
using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Add(SocialMedia socialMedia)
        {
            _socialMediaDal.Add(socialMedia);
        }

        public void Delete(int id)
        {
            _socialMediaDal.Delete(GetById(id));
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.Get(s => s.SocialMediaId == id);
        }

        public List<SocialMedia> Getlist()
        {
           return _socialMediaDal.GetAll();
        }

        public void Update(SocialMedia socialMedia)
        {
            _socialMediaDal.Update(socialMedia);
        }
    }
}
