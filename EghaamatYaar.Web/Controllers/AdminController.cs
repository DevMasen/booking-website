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
                //bool isValid = false;
                //String code;
                //ValidationCode validation = new ValidationCode(_Context);
                //do
                //{
                //    code = AdminCodeBuilder.build();
                //    isValid = validation.isValid(code , 0);

                //} while (isValid);

                string code = AdminCodeBuilder.build();
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

        public IActionResult signIn ()
        {
            return View();
        }

        public IActionResult Panel(AdminLoginBag bag)
        {
            Admin? admin = _Context.Admins.FirstOrDefault(u => u.adminCode == bag.adminCode);

            if (admin != null)
            {
                if (admin.userName.Equals(bag.userName) && admin.password.Equals(bag.password))
                {
                    return View(admin);
                }        
            }

            return RedirectToAction("_NotFound");
        }

        public IActionResult _NotFound () { return View("~/Views/Shared/_NotFound.cshtml"); }

        public IActionResult test()
        {
            return View("success");
        }


    }
}
