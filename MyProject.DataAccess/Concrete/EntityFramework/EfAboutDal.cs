
using MyProject.Core.DataAccess.EntityFramework;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.Context;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EfAboutDal : EfEntityRepositoryBase<About, MyProjectContext> , IAboutDal
    {

    }
}
