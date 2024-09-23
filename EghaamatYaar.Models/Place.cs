using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("استان")]
        public String county {  get; set; }

        [Required(ErrorMessage = "لطفا شهر را وارد کنید")]
        [DisplayName("شهر")]
        public String city { get; set; }

        [Required(ErrorMessage = "لطفا ادرس اقامتگاه را وارد کنید")]
        [DisplayName("ادرس اقامتگاه")]
        public String address { get; set; }

        [Required(ErrorMessage = "لطفا شماره پلاک اقامتگاه را وارد کنید")]
        [DisplayName("پلاک اقامتگاه")]
        public int houseNumber { get; set; }

        [Required(ErrorMessage = "لطفا قیمت روزانه اقامتگاه را وارد کنید")]
        [DisplayName("قیمت روزانه اقامتگاه")]
        public int price { get; set; }

        
    }
}
