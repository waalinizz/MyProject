
using MyProject.Core.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Abstract
{
    public interface IExperienceDal : IEntityRepository<Experience>
    {
    }
}
