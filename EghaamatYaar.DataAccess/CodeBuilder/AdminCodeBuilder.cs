using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.DataAccess.CodeBuilder
{
    public class AdminCodeBuilder
    {

        public static String build()
        {

            String alphabet = "mnopqrst";
            String numbers = "0123456789";

            String code = "";
            int tempNum;
            int tempAorN;
            Random rnd = new Random();


            for (int i = 0; i < 7; i++)
            {
                tempAorN = rnd.Next(0, 3);

                if (tempAorN == 0)
                {
                    tempNum = rnd.Next(0, 8);

                    code += alphabet[tempNum];
                }

                else
                {
                    tempNum = rnd.Next(0, 10);

                    code += numbers[tempNum];
                }

            }

            return code;
        }
    }
}
