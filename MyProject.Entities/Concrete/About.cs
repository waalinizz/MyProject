using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete
{
    public class About : IEntity
    {
        public int AboutId { get; set; }
        public string FirstName { get; set; } = "Muhammed Ali";
        public string LastName { get; set; } = "KALENDER";
        public string Description { get; set; } = "Yazılım Geliştirici / Backend Developer";
        public int Age { get; set; } = 21;
        public string FirstEmail { get; set; } = "waalinizz@gmail.com";
        public string SecondEmail { get; set; } = "alikalenderj@gmail.com";
        public string Phone { get; set; } = "0(554) 103 36 45";
        public string Address { get; set; } = "OSMANİYE / MERKEZ";
        public string SoftwareArea { get; set; } = ".Net";
    }
}
