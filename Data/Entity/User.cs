using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Data.Entity
{
    public class User:IdentityUser
    {
        public String Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }
 
        public string Gender { get; set; }
    }
}
