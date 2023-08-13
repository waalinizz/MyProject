using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Abstract
{
    public interface IGenericService<T>
    {
        List<T> Getlist();
        void Add(T entity);
        void Update(T entity);
        T GetById(int id);
        void Delete(int id);
    }
}
