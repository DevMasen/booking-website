using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.Models.Other
{
    public class OffCode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String code { get; set; }

        [Required]
        public int OffPer {  get; set; }
    }
}
