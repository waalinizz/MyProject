using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities.Concrete
{
    public class Portfolio : IEntity
    {
        public int PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioLink { get; set; }
    }
}
