using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.Models.Users
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "نام یک فیلد اجباریست")]
        [DisplayName("نام")]
        protected String firstName { get; set; }

        [Required(ErrorMessage = "نام خانوادگی یک فیلد اجباریست")]
        [DisplayName("نام خانوادگی")]
        protected String lastName { get; set; }

        [Required(ErrorMessage = "نام کاربری یک فیلد اجباریست")]
        [DisplayName("نام کاربری")]
        protected String userName { get; set; }

        [Required(ErrorMessage = "رمز عبور یک فیلد اجباریست")]
        [DisplayName("رمز عبور")]
        protected String password { get; set; }

        [Required(ErrorMessage = "کد ملی یک فیلد اجباریست")]
        [DisplayName("کد ملی")]
        protected long nationalCode { get; set; }

        [Required(ErrorMessage = "تلفن همراه یک فیلد اجباریست")]
        [DisplayName("تلفن همراه")]
        protected long phoeneNumber { get; set; }

        protected DateTime creatDateTime { get; set; } = DateTime.Now;
        protected DateTime lastUpdateTime { get; set; } = DateTime.Now;
        public String ownerCoed {  get; set; }

        IEnumerable<Admin> admins { get; set; }
    }
}
