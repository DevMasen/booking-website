﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EghaamatYaar.Models.Place;

namespace EghaamatYaar.Models.Users
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("شناسه ادمین")]
        public String? adminCode {  get; set; }

        [Required(ErrorMessage = "نام یک فیلد اجباریست")]
        [DisplayName("نام")]
        public String firstName { get; set; }

        [Required(ErrorMessage = "نام خانوادگی یک فیلد اجباریست")]
        [DisplayName("نام خانوادگی")]
        public String lastName { get; set; }

        [Required(ErrorMessage = "نام کاربری یک فیلد اجباریست")]
        [DisplayName("نام کاربری")]
        public String userName { get; set; }

        [Required(ErrorMessage = "رمز عبور یک فیلد اجباریست")]
        [DisplayName("رمز عبور")]
        public String password { get; set; }

        [Required(ErrorMessage = "کد ملی یک فیلد اجباریست")]
        [DisplayName("کد ملی")]
        public long nationalCode { get; set; }

        [Required(ErrorMessage = "تلفن همراه یک فیلد اجباریست")]
        [DisplayName("تلفن همراه")]
        public long phoeneNumber { get; set; }

        public DateTime creatDateTime { get; set; } = DateTime.Now;
        public DateTime lastUpdateTime { get; set; } = DateTime.Now;

        IEnumerable<HomeStay> places { get; set; }
    }
}
