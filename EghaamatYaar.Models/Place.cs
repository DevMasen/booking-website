using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.Models
{
    public class Place
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "لطفا استان را وارد کنید")]
        public String area {  get; set; }

        public String city { get; set; }

        public String address { get; set; }

        public int houseNumber { get; set; }

        public int price { get; set; }

        
    }
}
