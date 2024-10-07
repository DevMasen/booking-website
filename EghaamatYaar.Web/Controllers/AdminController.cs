using EghaamatYaar.Models.Users;
using Microsoft.AspNetCore.Mvc;
using EghaamatYaar.DataAccess.Data;
using EghaamatYaar.DataAccess.CodeBuilder;

namespace EghaamatYaar.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _Context;

        public AdminController (AppDbContext context)
        {
            _Context = context;
        }
        public IActionResult signUp()
        {
            return View();
        }

        public IActionResult AddAdmin(Admin newAdmin)
        {
            if (newAdmin != null)
            {
                String code = AdminCodeBuilder.build();
                newAdmin.adminCode = code;

                _Context.Admins.Add(newAdmin);
                _Context.SaveChanges();

                return RedirectToAction("success" , newAdmin);
            }

            return View();
        }

        public IActionResult success(Admin admin)
        {
            return View(admin);
        }
    }
}
