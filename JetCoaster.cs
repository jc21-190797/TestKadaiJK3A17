using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class JetCoaster
        {
            public static int ride
                (int k, int[] g, int r)
            {
                int[] aaa = g;
                int[] newaaa = new int[g.Length];
                int boa = 0;

                int ret = 0;

                for (int a = 0; a < r; a++)
                {
                    int count = 0;
                    for (int b = 0; b < aaa.Length; b++)
                    {
                        int boac = boa;
                        boa += aaa[b];
                        count++;
                        if (boa > k)
                        {
                            boa = boac;
                            count--;
                            break;
                        }
                    }
                    for (int c = 0; c < count; c++)
                    {
                        int bff = aaa[0];
                        Array.Copy(aaa, 1, newaaa, 0, aaa.Length - 1);
                        newaaa[newaaa.Length - 1] = bff;

                        aaa = newaaa;
                    }
                    ret += boa;
                    boa = 0;
                }
                return ret;
            }
    }
}
