using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities.Concrete
{
    public class ExperienceTwo : IEntity
    {
        public int ExperienceTwoId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Date { get; set; }
        public string Description { get; set; } 
    }
}
