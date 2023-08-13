
using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service service)
        {
            _serviceDal.Add(service);
        }

        public void Delete(int id)
        {
          _serviceDal.Delete(GetById(id));
        }

        public Service GetById(int id)
        {
            return _serviceDal.Get(s => s.ServiceId == id);
        }

        public List<Service> Getlist()
        {
            return _serviceDal.GetAll();
        }

        public void Update(Service service)
        {
            _serviceDal.Update(service);
        }
    }
}
