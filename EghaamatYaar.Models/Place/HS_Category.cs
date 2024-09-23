using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.Models.Place
{
    public class HS_Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String name { get; set; }

    }
}
