using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.Models.Users
{
    public class Member : User
    {
        
        [Required]
        protected DateTime birthDay { get; set; }

        IEnumerable<Place> reserves { get; set; }


    }
}
