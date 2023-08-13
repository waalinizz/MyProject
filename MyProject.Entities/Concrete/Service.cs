using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities.Concrete
{
    public class Service : IEntity
    {
        public int ServiceId { get; set; }
        public string SoftwareArea { get; set; }
        public string Address { get; set; }
    }
}
