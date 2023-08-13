using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities.Concrete
{
    public class SocialMedia : IEntity
    {
        public int SocialMediaId { get; set; }
        public string SocialMediaName { get; set; }
        public string Address { get; set; }
        public string Icon { get; set; }
    }
}
