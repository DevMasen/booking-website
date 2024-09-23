using EghaamatYaar.Models.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.DataAccess.CodeBuilder
{
    public class OffCodeBuilder
    {
        public static String build()
        {
            String alphabet = "abcdefghijkl";
            String numbers = "0123456789";

            String code = "";
            int tempNum;
            int tempAorN;
            Random rnd = new Random();
            int codeSize = rnd.Next(10, 16);

            for (int i = 0; i < codeSize; i++)
            {
                tempAorN = rnd.Next(0, 2);

                if (tempAorN == 0)
                {
                    tempNum = rnd.Next(0, 12);

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
