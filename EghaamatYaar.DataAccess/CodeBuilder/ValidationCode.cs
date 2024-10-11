using EghaamatYaar.DataAccess.Data;
using EghaamatYaar.Models.Other;
using EghaamatYaar.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.DataAccess.CodeBuilder
{
    public class ValidationCode
    {
        private readonly AppDbContext _db;

        public ValidationCode(AppDbContext db)
        {
            _db = db;
        }



        public bool isValid (String code , int category)
        {
            bool result = true;

            if (category == 0) //Admin code
            {
                IEnumerable<Admin> admins = _db.Admins;

                foreach (Admin admin in admins)
                {
                    if(admin.adminCode.Equals(code))
                    {
                        result = false;
                        break;
                    }
                }

            }

            else if (category == 1) //off code
            {
                IEnumerable<OffCode> offCodes = _db.offCodes;

                foreach (OffCode offCode in offCodes)
                {
                    if (offCode.code.Equals(code))
                    {
                        result = false;
                        break;
                    }
                }

            }

            return result;
        }
    }
}
