using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.Models.Users
{
    public class Owner : User
    {
        public String ownerCoed {  get; set; }

        IEnumerable<Admin> admins { get; set; }
    }
}
