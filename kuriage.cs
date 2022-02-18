using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
     public class kuriage
    {
        public static int kuriage10(int i)
        {
            int a = i;
            int min = 1;
            int aaa;



            if (a < 0)
            {
                a = System.Math.Abs(a);
                min = -1;
            }



            int b = a % 10;
            int c = (a / 10) % 10;



            if (b == 0)
            {
                aaa = a * min;
                return aaa;
            }



            c = c + 1;
            aaa = c * 10;
            aaa = aaa * min;



            return aaa;
        }
    }
}