using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.Models.Users
{
    public class Admin : User
    {
        public String adminCode {  get; set; }

        IEnumerable<Place> places { get; set; }
    }
}
