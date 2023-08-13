using MyProject.Entities.Concrete;
using System.Collections.Generic;
using System.Security.Permissions;

namespace MyProject.WebUI.Areas.Admin.Models.ServiceModel
{
    public class ServiceListViewModel
    {
        public List<Service> Services{ get; set; }//hepsini
        public Service Service{ get; set; } //1002
    }
}
