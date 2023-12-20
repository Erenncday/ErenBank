using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenBankMVC.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; } //İl
        public string District { get; set; } //İlçe
        public string ImageUrl { get; set; }
    }
}
